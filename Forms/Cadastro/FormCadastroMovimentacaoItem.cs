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
    public partial class FormCadastroMovimentacaoItem : Form
    {
        private MovimentacaoItemRepository movimentacaoItemRepository = new MovimentacaoItemRepository();
        public int codMovimentacao;
        public int codMovimentacaoItem;
        public string TipoMovimento;
        public bool edita = false;

        public int status;

        public string codProduto;
        public string nomeProduto;

        public FormCadastroMovimentacaoItem()
        {
            InitializeComponent();
        }

        private void FormCadastroMovimentacaoItem_Load(object sender, EventArgs e)
        {
            if (edita)
            {
                CarregaCampos();
                if(status != 0)
                {
                    btnSalvar.Enabled = false;
                    btnOk.Enabled = false;
                }
            }
            else
            {
                tbCodMovimentacao.Text = codMovimentacao.ToString();
                tbCodMovimentacaoItem.Text = movimentacaoItemRepository.GetNextCodMovimentacaoItem(AppZenCodeContext.CodEmpresa, codMovimentacao).ToString();
                tbCodEmpresa.Text = AppZenCodeContext.CodEmpresa.ToString();
                tbValorTotal.Text = "R$ 0,00";
                tbValorUnitario.Text = "R$ 0,00";
                tbCustoUnitario.Text = "R$ 0,00";
            }
        }

        private void CarregaCampos()
        {
            MovimentacaoItem movimentacaoItem = movimentacaoItemRepository.GetByCodMovimentacaoItem(AppZenCodeContext.CodEmpresa, codMovimentacao, codMovimentacaoItem);

            tbCodEmpresa.Text = movimentacaoItem.CODEMPRESA.ToString();
            tbCodMovimentacao.Text = movimentacaoItem.CODMOVIMENTACAO.ToString();
            tbCodMovimentacaoItem.Text = movimentacaoItem.CODMOVIMENTACAOITEM.ToString();
            tbCodProduto.Text = movimentacaoItem.CODPRODUTO.ToString();
            tbCodProduto_Leave(null, null);
            tbQuantidade.Text = movimentacaoItem.QUANTIDADE.ToString();
            tbValorUnitario.Text = movimentacaoItem.VALORUNITARIO.ToString();
            tbCustoUnitario.Text = movimentacaoItem.CUSTOUNITARIO.ToString();
            tbValorTotal.Text = movimentacaoItem.VALORTOTAL.ToString();
        }

        private bool Salvar()
        {
            try
            {
                if (!DataBaseConnection.Instance().ExecuteHasRows($"SELECT * FROM MOVIMENTACAOITEM WHERE CODEMPRESA = {AppZenCodeContext.CodEmpresa} AND CODMOVIMENTACAO = {codMovimentacao} AND CODMOVIMENTACAOITEM = {codMovimentacaoItem}"))
                {
                    movimentacaoItemRepository.Add(new MovimentacaoItem
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        CODMOVIMENTACAO = Convert.ToInt32(tbCodMovimentacao.Text),
                        CODMOVIMENTACAOITEM = Convert.ToInt32(tbCodMovimentacaoItem.Text),
                        CODPRODUTO = Convert.ToInt32(tbCodProduto.Text),
                        QUANTIDADE = decimal.Parse(tbQuantidade.Text, NumberStyles.Currency),
                        VALORUNITARIO = decimal.Parse(tbValorUnitario.Text, NumberStyles.Currency),
                        VALORTOTAL = decimal.Parse(tbValorTotal.Text, NumberStyles.Currency),
                        CUSTOUNITARIO = decimal.Parse(tbCustoUnitario.Text, NumberStyles.Currency)
                    });

                    codMovimentacaoItem = Convert.ToInt32(tbCodMovimentacaoItem.Text);
                }
                else
                {
                    movimentacaoItemRepository.Update(new MovimentacaoItem
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        CODMOVIMENTACAO = Convert.ToInt32(tbCodMovimentacao.Text),
                        CODMOVIMENTACAOITEM = Convert.ToInt32(tbCodMovimentacaoItem.Text),
                        CODPRODUTO = Convert.ToInt32(tbCodProduto.Text),
                        QUANTIDADE = decimal.Parse(tbQuantidade.Text, NumberStyles.Currency),
                        VALORUNITARIO = decimal.Parse(tbValorUnitario.Text, NumberStyles.Currency),
                        VALORTOTAL = decimal.Parse(tbValorTotal.Text, NumberStyles.Currency),
                        CUSTOUNITARIO = decimal.Parse(tbCustoUnitario.Text, NumberStyles.Currency)
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

        private void btnLookupProduto_Click(object sender, EventArgs e)
        {
            FormVisaoProduto formVisaoProduto = new FormVisaoProduto(this);
            formVisaoProduto.ShowDialog();

            tbCodProduto.Text = string.IsNullOrEmpty(codProduto) ? string.Empty : codProduto;
            tbNomeProduto.Text = string.IsNullOrEmpty(nomeProduto) ? string.Empty : nomeProduto;

            if (!string.IsNullOrEmpty(tbCodProduto.Text))
                CarregarProduto(Convert.ToInt32(tbCodProduto.Text));
        }

        private void tbCodProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCodProduto.Text))
            {
                tbNomeProduto.Text = DataBaseConnection.Instance().ExecuteGetField("SELECT NOME FROM PRODUTO WHERE CODEMPRESA = ? AND CODPRODUTO = ?", new object[] { AppZenCodeContext.CodEmpresa, tbCodProduto.Text }).ToString();
                CarregarProduto(Convert.ToInt32(tbCodProduto.Text));
            }
            else
                tbNomeProduto.Text = string.Empty;
        }

        private void CarregarProduto(int codProduto)
        {
            try
            {
                string sql = "SELECT PRECOUNITARIO, CUSTO FROM PRODUTO WHERE CODPRODUTO = " + codProduto;

                DataTable dt = DataBaseConnection.Instance().ExecuteQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    decimal precoVenda = Convert.ToDecimal(dt.Rows[0]["PRECOUNITARIO"]);
                    decimal custoAtual = dt.Rows[0]["CUSTO"] == DBNull.Value ? 0 : Convert.ToDecimal(dt.Rows[0]["CUSTO"]);

                    tbValorTotal.Enabled = false;

                    if (TipoMovimento == "Saída")
                    {
                        tbValorUnitario.Text = precoVenda.ToString("N2");
                        tbCustoUnitario.Text = custoAtual.ToString("N2");
                    }
                    else
                    {
                        tbValorUnitario.Text = "R$ 0,00";
                        tbCustoUnitario.Text = "R$ 0,00";
                    }

                    tbQuantidade.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message);
            }
        }

        private void tbValorUnitario_TextChanged(object sender, EventArgs e)
        {
            tbValorUnitario.TextChanged -= tbValorUnitario_TextChanged;

            try
            {
                string textoLimpo = System.Text.RegularExpressions.Regex.Replace(tbValorUnitario.Text, "[^0-9]", "");

                if (string.IsNullOrEmpty(textoLimpo))
                {
                    tbValorUnitario.Text = "R$ 0,00";
                }
                else
                {
                    decimal valor = Convert.ToDecimal(textoLimpo) / 100;
                    tbValorUnitario.Text = valor.ToString("C2");
                }
                tbValorUnitario.SelectionStart = tbValorUnitario.Text.Length;
            }
            catch
            {
                tbValorUnitario.Text = "R$ 0,00";
            }
            finally
            {
                tbValorUnitario.TextChanged += tbValorUnitario_TextChanged;
            }
        }

        private void tbValorUnitario_Validated(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void tbQuantidade_Validated(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal qtd = 0;
            decimal valor = 0;

            decimal.TryParse(tbQuantidade.Text, out qtd);

            string valorLimpo = System.Text.RegularExpressions.Regex.Replace(tbValorUnitario.Text, "[^0-9]", "");

            if (!string.IsNullOrEmpty(valorLimpo))
            {
                valor = Convert.ToDecimal(valorLimpo) / 100;
            }
            decimal total = qtd * valor;

            tbValorTotal.Text = total.ToString("C2");
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
