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
    public partial class FormRelatorioEstoqueProdutos : Form
    {
        private RelatorioEstoqueProdutoRepositorio _repositorio;
        public FormRelatorioEstoqueProdutos()
        {
            InitializeComponent();
            _repositorio = new RelatorioEstoqueProdutoRepositorio();
        }
        private void CarregarRelatorio()
        {
            DataTable tabela = _repositorio.ObterRelatorioEstoqueProdutos();

            dgvEstoqueProdutos.AutoGenerateColumns = true;
            dgvEstoqueProdutos.DataSource = tabela;

            AjustarColunasGrid();
        }

        private void AjustarColunasGrid()
        {
            if (dgvEstoqueProdutos.Columns.Count == 0) return;

            dgvEstoqueProdutos.ReadOnly = true;
            dgvEstoqueProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoqueProdutos.MultiSelect = false;
            dgvEstoqueProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //dgvEstoqueProdutos.Columns["CODPRODUTO"].HeaderText = "Cód. Produto";
            dgvEstoqueProdutos.Columns["CODPRODUTO"].Visible = false;

            dgvEstoqueProdutos.Columns["nome_produto"].HeaderText = "Produto";
            dgvEstoqueProdutos.Columns["quantidade_em_estoque"].HeaderText = "Qtde. Estoque";
            dgvEstoqueProdutos.Columns["quantidade_saldo"].HeaderText = "Qtde. Saldo";
            dgvEstoqueProdutos.Columns["quantidade_reservada"].HeaderText = "Qtde. Reservada";

            dgvEstoqueProdutos.Columns["quantidade_em_estoque"].DefaultCellStyle.Format = "N0";
            dgvEstoqueProdutos.Columns["quantidade_saldo"].DefaultCellStyle.Format = "N0";
            dgvEstoqueProdutos.Columns["quantidade_reservada"].DefaultCellStyle.Format = "N0";

            dgvEstoqueProdutos.Columns["quantidade_em_estoque"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEstoqueProdutos.Columns["quantidade_saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvEstoqueProdutos.Columns["quantidade_reservada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void iBtnBaixarCsv_Click(object sender, EventArgs e)
        {
            ExportadorRelatorio.ExportarDataGridViewParaCsv(dgvEstoqueProdutos);
        }

        private void iBtnBaixarPDF_Click(object sender, EventArgs e)
        {
            ExportadorRelatorio.ExportarDataGridViewParaPdf(dgvEstoqueProdutos, "Relatório Estoque");
        }

        private void iBtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }

        private void iconToolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
            else
                return;
        }
    }
    public class RelatorioEstoqueProdutoRepositorio
    {
        public RelatorioEstoqueProdutoRepositorio()
        {

        }

        public DataTable ObterRelatorioEstoqueProdutos()
        {
            const string sql = @"
                                SELECT
                                    CE.CODPRODUTO,
                                    P.NOME AS nome_produto,
                                    CE.QUANTIDADEATUAL      AS quantidade_em_estoque,
                                    CE.QUANTIDADESALDO      AS quantidade_saldo,
                                    CE.QUANTIDADERESERVADA  AS quantidade_reservada
                                FROM CONTROLEESTOQUE AS CE
                                JOIN PRODUTO AS P
                                    ON P.CODEMPRESA = CE.CODEMPRESA
                                   AND P.CODPRODUTO = CE.CODPRODUTO
                                ORDER BY
                                    P.NOME";

            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery(sql);

            return dataTable;
        }
    }
}
