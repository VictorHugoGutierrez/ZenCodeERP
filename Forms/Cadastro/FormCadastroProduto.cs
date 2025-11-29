using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenCodeERP.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Forms.Visao;
using ZenCodeERP.Model;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Cadastro
{
    public partial class FormCadastroProduto : Form
    {
        private ProdutoRepository produtoRepository = new ProdutoRepository();
        public int codProduto;
        public bool edita = false;

        public string codClassificacao;
        public string nomeClassificacao;

        public class OpcaoComboTipoProduto
        {
            public int Id { get; set; }
            public string Tipo { get; set; }
        }

        public FormCadastroProduto()
        {
            InitializeComponent();

            List<OpcaoComboTipoProduto> listaTipoProduto = new List<OpcaoComboTipoProduto>();

            listaTipoProduto.Add(new OpcaoComboTipoProduto { Id = 0, Tipo = "Produto" });
            listaTipoProduto.Add(new OpcaoComboTipoProduto { Id = 1, Tipo = "Serviço" });

            cbTipoProduto.DataSource = listaTipoProduto;

            cbTipoProduto.DisplayMember = "Tipo";
            cbTipoProduto.ValueMember = "Id";
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            if (edita)
                CarregaCampos();
            else
            {
                tbCodProduto.Text = produtoRepository.GetNextCodProduto(AppZenCodeContext.CodEmpresa).ToString();
                tbCodEmpresa.Text = AppZenCodeContext.CodEmpresa.ToString();
                tbPrecoUnitario.Text = "R$ 0,00";
            }
        }

        private void CarregaCampos()
        {
            Produto produto = produtoRepository.GetByCodProduto(AppZenCodeContext.CodEmpresa, codProduto);

            tbCodEmpresa.Text = produto.CODEMPRESA.ToString();
            tbCodProduto.Text = produto.CODPRODUTO.ToString();
            cbTipoProduto.SelectedIndex = produto.TIPO;
            chkAtivo.Checked = produto.ATIVO == 1 ? true :  false;
            tbNome.Text = produto.NOME;
            rtbDescricao.Text = produto.DESCRICAO;
            tbCodClassificacao.Text = produto.CODCLASSIFICACAO.ToString();
            tbPrecoUnitario.Text = produto.PRECOUNITARIO.ToString();
            tbCodClassificacao_Leave(null, null);
        }

        private bool Salvar()
        {
            try
            {
                if (!DataBaseConnection.Instance().ExecuteHasRows($"SELECT * FROM PRODUTO WHERE CODEMPRESA = {AppZenCodeContext.CodEmpresa} AND CODPRODUTO = {codProduto}"))
                {
                    produtoRepository.Add(new Produto
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        CODPRODUTO = Convert.ToInt32(tbCodProduto.Text),
                        TIPO = Convert.ToInt32(cbTipoProduto.SelectedValue),
                        ATIVO = chkAtivo.Checked ? 1 : 0,
                        NOME = tbNome.Text,
                        DESCRICAO = rtbDescricao.Text,
                        PRECOUNITARIO = decimal.Parse(tbPrecoUnitario.Text, NumberStyles.Currency),
                        CODCLASSIFICACAO = Convert.ToInt32(tbCodClassificacao.Text),
                    });

                    codProduto = Convert.ToInt32(tbCodProduto.Text);
                }
                else
                {
                    produtoRepository.Update(new Produto
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        CODPRODUTO = Convert.ToInt32(tbCodProduto.Text),
                        TIPO = Convert.ToInt32(cbTipoProduto.SelectedValue),
                        ATIVO = chkAtivo.Checked ? 1 : 0,
                        NOME = tbNome.Text,
                        DESCRICAO = rtbDescricao.Text,
                        PRECOUNITARIO = decimal.Parse(tbPrecoUnitario.Text, NumberStyles.Currency),
                        CODCLASSIFICACAO = Convert.ToInt32(tbCodClassificacao.Text),
                    });
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Salvar())
                return;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!Salvar())
                return;

            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLookupClassificacao_Click(object sender, EventArgs e)
        {
            FormVisaoClassificacao formVisaoClassificacao = new FormVisaoClassificacao(this);
            formVisaoClassificacao.ShowDialog();

            tbCodClassificacao.Text = string.IsNullOrEmpty(codClassificacao) ? string.Empty : codClassificacao;
            tbNomeClassificacao.Text = string.IsNullOrEmpty(nomeClassificacao) ? string.Empty : nomeClassificacao;
        }

        private void tbCodClassificacao_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCodClassificacao.Text))
                tbNomeClassificacao.Text = DataBaseConnection.Instance().ExecuteGetField("SELECT NOME FROM CLASSIFICACAO  WHERE CODEMPRESA  = ? AND CODCLASSIFICACAO  = ?", new object[] { AppZenCodeContext.CodEmpresa, tbCodClassificacao.Text }).ToString();
            else
                tbNomeClassificacao.Text = string.Empty;
        }

        private void tbPrecoUnitario_TextChanged(object sender, EventArgs e)
        {
            string textoLimpo = System.Text.RegularExpressions.Regex.Replace(tbPrecoUnitario.Text, "[^0-9]", "");

            if (string.IsNullOrEmpty(textoLimpo))
            {
                tbPrecoUnitario.Text = "R$ 0,00";
            }
            else
            {
                decimal valor = Convert.ToDecimal(textoLimpo) / 100;

                tbPrecoUnitario.Text = valor.ToString("C2");
            }
        }

        private void tbPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
