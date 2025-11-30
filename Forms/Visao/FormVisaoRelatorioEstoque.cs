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

    public partial class FormVisaoRelatorioEstoque : Form
    {
        private RelatorioEstoqueRepositorio _repositorio;

        public FormVisaoRelatorioEstoque()
        {
            InitializeComponent();

            _repositorio = new RelatorioEstoqueRepositorio();

        }
        private void CarregarRelatorio()
        {
            DataTable tabela = _repositorio.ObterRelatorioEstoquePorPeriodo();

            dgvEstoqueClassificacao.AutoGenerateColumns = true;
            dgvEstoqueClassificacao.DataSource = tabela;

            AjustarColunasGrid();
        }

        private void AjustarColunasGrid()
        {
            if (dgvEstoqueClassificacao.Columns.Count == 0) return;

            dgvEstoqueClassificacao.ReadOnly = true;
            dgvEstoqueClassificacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoqueClassificacao.MultiSelect = false;
            dgvEstoqueClassificacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvEstoqueClassificacao.Columns["CODEMPRESA"].HeaderText = "Cód. Empresa";
            dgvEstoqueClassificacao.Columns["CODCLASSIFICACAO"].HeaderText = "Cód. Classificação";
            dgvEstoqueClassificacao.Columns["nome_classificacao"].HeaderText = "Classificação";
            dgvEstoqueClassificacao.Columns["quantidade_em_estoque"].HeaderText = "Qtde. em Estoque";

            dgvEstoqueClassificacao.Columns["quantidade_em_estoque"].DefaultCellStyle.Format = "N0";
            dgvEstoqueClassificacao.Columns["quantidade_em_estoque"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void iBtnBaixarCsv_Click(object sender, EventArgs e)
        {
            ExportadorRelatorio.ExportarDataGridViewParaCsv(dgvEstoqueClassificacao);
        }

        private void iBtnBaixarPDF_Click(object sender, EventArgs e)
        {
            ExportadorRelatorio.ExportarDataGridViewParaPdf(dgvEstoqueClassificacao, "Relatório Estoque");
        }

        private void iBtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }
    }

    public class RelatorioEstoqueRepositorio
    {
        public RelatorioEstoqueRepositorio()
        {
      
        }

        public DataTable ObterRelatorioEstoquePorPeriodo()
        {
            const string sql = @"
                                SELECT
                                    C.CODEMPRESA,
                                    C.CODCLASSIFICACAO,
                                    C.NOME AS nome_classificacao,
                                    SUM(CE.QUANTIDADEATUAL) AS quantidade_em_estoque
                                FROM CONTROLEESTOQUE AS CE
                                JOIN PRODUTO AS P
                                    ON P.CODEMPRESA = CE.CODEMPRESA
                                    AND P.CODPRODUTO = CE.CODPRODUTO
                                JOIN CLASSIFICACAO AS C
                                    ON C.CODEMPRESA = P.CODEMPRESA
                                    AND C.CODCLASSIFICACAO = P.CODCLASSIFICACAO
                                GROUP BY
                                    C.CODEMPRESA,
                                    C.CODCLASSIFICACAO,
                                    C.NOME
                                ORDER BY
                                    C.NOME";

            DataTable dataTable = DataBaseConnection.Instance().ExecuteQuery(sql);

            return dataTable;
        }
    }
}
