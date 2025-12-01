using Org.BouncyCastle.Asn1.X509;
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
                tbCusto.Text = "R$ 0,00";
                tbPrecoUnitario.Text = "R$ 0,00";
                tbMargem.Text = "0,00%";
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
            tbCusto.Text = produto.CUSTO.ToString("C2");
            tbMargem.Text = produto.MARGEM.ToString();
            tbCodClassificacao_Leave(null, null);
        }

        private bool Salvar()
        {
            try
            {
                if (!DataBaseConnection.Instance().ExecuteHasRows($"SELECT * FROM PRODUTO WHERE CODEMPRESA = {AppZenCodeContext.CodEmpresa} AND CODPRODUTO = {codProduto}"))
                {
                    string margem = tbMargem.Text.Replace("%", "").Trim();
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
                        CUSTO = decimal.Parse(tbCusto.Text, NumberStyles.Currency),
                        MARGEM = decimal.Parse(margem, NumberStyles.Number)
                    });

                    codProduto = Convert.ToInt32(tbCodProduto.Text);
                }
                else
                {
                    string margem = tbMargem.Text.Replace("%", "").Trim();
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
                        CUSTO = decimal.Parse(tbCusto.Text, NumberStyles.Currency),
                        MARGEM = decimal.Parse(margem, NumberStyles.Number)
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
            tbPrecoUnitario.TextChanged -= tbPrecoUnitario_TextChanged;

            try
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
                tbPrecoUnitario.SelectionStart = tbPrecoUnitario.Text.Length;
            }
            catch
            {
                tbPrecoUnitario.Text = "R$ 0,00";
            }
            finally
            {
                tbPrecoUnitario.TextChanged += tbPrecoUnitario_TextChanged;
            }
        }

        private void tbPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbCusto_TextChanged(object sender, EventArgs e)
        {
            tbCusto.TextChanged -= tbCusto_TextChanged;

            try
            {
                string textoLimpo = System.Text.RegularExpressions.Regex.Replace(tbCusto.Text, "[^0-9]", "");

                if (string.IsNullOrEmpty(textoLimpo))
                {
                    tbCusto.Text = "R$ 0,00";
                }
                else
                {
                    decimal valor = Convert.ToDecimal(textoLimpo) / 100;
                    tbCusto.Text = valor.ToString("C2");

                }
                tbCusto.SelectionStart = tbCusto.Text.Length;
            }
            catch
            {
                tbCusto.Text = "R$ 0,00";
            }
            finally
            {
                tbCusto.TextChanged += tbCusto_TextChanged;
            }
        }

        private void tbCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbMargem_TextChanged(object sender, EventArgs e)
        {
            tbMargem.TextChanged -= tbMargem_TextChanged;

            try
            {
                string textoLimpo = System.Text.RegularExpressions.Regex.Replace(tbMargem.Text, "[^0-9]", "");

                if (string.IsNullOrEmpty(textoLimpo))
                {
                    tbMargem.Text = "0,00%";
                }
                else
                {
                    decimal valor = Convert.ToDecimal(textoLimpo) / 100;

                    tbMargem.Text = valor.ToString("N2") + "%";
                }

                tbMargem.SelectionStart = tbMargem.Text.Length;
            }
            catch
            {
                tbMargem.Text = "0,00%";
            }
            finally
            {
                tbMargem.TextChanged += tbMargem_TextChanged;
            }
        }

        private void tbMargem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void CalcularPrecoVenda()
        {
            string custoLimpo = System.Text.RegularExpressions.Regex.Replace(tbCusto.Text, "[^0-9]", "");
            string margemLimpa = System.Text.RegularExpressions.Regex.Replace(tbMargem.Text, "[^0-9]", "");

            decimal custo = 0;
            decimal margem = 0;

            decimal.TryParse(custoLimpo, out custo);
            decimal.TryParse(margemLimpa, out margem);

            custo = custo / 100;
            margem = margem / 100;

            decimal precoFinal = custo + (custo * (margem / 100));

            tbPrecoUnitario.Text = precoFinal.ToString("C2");
        }

        private void tbCusto_Leave(object sender, EventArgs e)
        {
            CalcularPrecoVenda();
        }

        private void tbMargem_Leave(object sender, EventArgs e)
        {
            CalcularPrecoVenda();
        }
    }
}
