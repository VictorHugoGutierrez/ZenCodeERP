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
            _repositorio = new RelatorioVendasRepositorio();

            dtInicio.Value = DateTime.Today.AddDays(-30);
            dtFim.Value = DateTime.Today;
        }
        private void CarregarRelatorio()
        {
            DateTime dataInicial = dtInicio.Value;
            DateTime dataFinal = dtFim.Value;

            DataTable tabela = _repositorio.ObterRelatorioVendasPorPeriodo(dataInicial, dataFinal);

            dgvRelatorio.AutoGenerateColumns = true;
            dgvRelatorio.DataSource = tabela;

            AjustarColunasGrid();
        }

        private void AjustarColunasGrid()
        {
            if (dgvRelatorio.Columns.Count == 0) return;

            //dgvRelatorio.Columns["CODEMPRESA"].HeaderText = "Cód. Empresa";
            dgvRelatorio.Columns["CODEMPRESA"].Visible = false;
            dgvRelatorio.Columns["empresa"].HeaderText = "Empresa";

            //dgvRelatorio.Columns["CODCLIFOR"].HeaderText = "Cód. Cliente";
            dgvRelatorio.Columns["CODCLIFOR"].Visible = false;

            dgvRelatorio.Columns["nome_cliente"].HeaderText = "Cliente";
            dgvRelatorio.Columns["quantidade_pedidos"].HeaderText = "Qtde. Pedidos";
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

        private void iBtnBaixarCsv_Click(object sender, EventArgs e)
        {
            ExportadorRelatorio.ExportarDataGridViewParaCsv(dgvRelatorio);
        }

        private void iBtnBaixarPDF_Click(object sender, EventArgs e)
        {
            ExportadorRelatorio.ExportarDataGridViewParaPdf(dgvRelatorio, "Relatório Ticket médio por cliente e empresa");
        }

        private void iconToolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
            else
                return;
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
                                ROUND(AVG(M.VALORTOTAL), 2) AS ticket_medio 
                            FROM MOVIMENTACAO AS M 
                            JOIN CLIENTEFORNECEDOR AS CF 
                                ON CF.CODEMPRESA = M.CODEMPRESA 
                               AND CF.CODCLIFOR  = M.CODCLIFOR 
                            JOIN EMPRESA AS E 
                                ON E.CODEMPRESA = M.CODEMPRESA 
                            WHERE  
                                M.DATA BETWEEN ? AND ? 
                                AND M.TIPOMOVIMENTO = 'Saída' 
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
