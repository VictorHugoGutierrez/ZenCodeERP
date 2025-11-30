using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenCodeERP.Data;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Visao
{
    public partial class formVisaoRelatorioVendas : Form
    {
        private readonly RelatorioVendasRepositorio _repositorio;

        public formVisaoRelatorioVendas()
        {
            InitializeComponent();
            // Ajuste a sua connection string aqui
            _repositorio = new RelatorioVendasRepositorio();

            // Datas padrão: hoje e 30 dias atrás
            dtInicio.Value = DateTime.Today.AddDays(-30);
            dtFim.Value = DateTime.Today;
        }
        private void CarregarRelatorio()
        {
            var dataInicial = dtInicio.Value;
            var dataFinal = dtFim.Value;

            var tabela = _repositorio.ObterRelatorioVendasPorPeriodo(dataInicial, dataFinal);

            dgvRelatorio.AutoGenerateColumns = true;
            dgvRelatorio.DataSource = tabela;

            AjustarColunasGrid();
        }

        private void AjustarColunasGrid()
        {
            if (dgvRelatorio.Columns.Count == 0) return;

            dgvRelatorio.Columns["CODEMPRESA"].HeaderText = "Cód. Empresa";
            dgvRelatorio.Columns["empresa"].HeaderText = "Empresa";
            dgvRelatorio.Columns["CODCLIFOR"].HeaderText = "Cód. Cliente";
            dgvRelatorio.Columns["nome_cliente"].HeaderText = "Cliente";
            dgvRelatorio.Columns["quantidade_pedidos"].HeaderText = "Qtde Pedidos";
            dgvRelatorio.Columns["total_vendas"].HeaderText = "Total Vendas";
            dgvRelatorio.Columns["ticket_medio"].HeaderText = "Ticket Médio";

            dgvRelatorio.Columns["total_vendas"].DefaultCellStyle.Format = "C2";
            dgvRelatorio.Columns["ticket_medio"].DefaultCellStyle.Format = "C2";

            dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRelatorio.ReadOnly = true;
            dgvRelatorio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelatorio.MultiSelect = false;
        }

        private void iBtnGerarRelatorio_Click_1(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }

        private void iBtnNovo_Click(object sender, EventArgs e)
        {
            ExportadorRelatorio.ExportarDataGridViewParaCsv(dgvRelatorio);
        }

        private void iconToolStripButton2_Click(object sender, EventArgs e)
        {
            ExportadorRelatorio.ExportarDataGridViewParaPdf(dgvRelatorio, "Relatório de Vendas por Cliente");

        }
    }

    public class RelatorioVendasRepositorio
    {
        public RelatorioVendasRepositorio()
        {}
       
        public DataTable ObterRelatorioVendasPorPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            const string sql = @"
                            SELECT   
                                E.CODEMPRESA, 
                                E.NOMEFANTASIA AS empresa, 
                                CF.CODCLIFOR, 
                                CF.NOME AS nome_cliente, 
                                COUNT(M.CODMOVIMENTACAO) AS quantidade_pedidos, 
                                SUM(M.VALORTOTAL) AS total_vendas, 
                                AVG(M.VALORTOTAL) AS ticket_medio 
                            FROM MOVIMENTACAO AS M 
                            JOIN CLIENTEFORNECEDOR AS CF 
                                ON CF.CODEMPRESA = M.CODEMPRESA 
                               AND CF.CODCLIFOR  = M.CODCLIFOR 
                            JOIN EMPRESA AS E 
                                ON E.CODEMPRESA = M.CODEMPRESA 
                            WHERE  
                                M.DATA BETWEEN ? AND ? 
                                AND M.TIPOMOVIMENTO = 'VENDA' 
                            GROUP BY  
                                E.CODEMPRESA, 
                                E.NOMEFANTASIA, 
                                CF.CODCLIFOR, 
                                CF.NOME 
                            ORDER BY  
                                total_vendas DESC;";

            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery(sql, dataInicial.Date, dataFinal.Date);
            
            return dataTable;
        }
    }
}
