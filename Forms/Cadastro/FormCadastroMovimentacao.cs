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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZenCodeERP.Forms.Cadastro
{
    public partial class FormCadastroMovimentacao : Form
    {
        private MovimentacaoRepository movimentacaoRepository = new MovimentacaoRepository();
        private MovimentacaoItemRepository movimentacaoItemRepository = new MovimentacaoItemRepository();
        public int codMovimentacao;
        public bool edita = false;

        public string codCliFor;
        public string nomeCliFor;

        public string codUsuario;
        public string nomeUsuario;

        private Utilidades utilidades = new Utilidades();

        public class OpcaoComboTipoMovimento
        {
            public int Id { get; set; }
            public string Tipo { get; set; }
        }

        public class OpcaoComboStatus
        {
            public int Id { get; set; }
            public string Status { get; set; }
        }

        public FormCadastroMovimentacao()
        {
            InitializeComponent();

            List<OpcaoComboTipoMovimento> listaTipoMovimento = new List<OpcaoComboTipoMovimento>();

            listaTipoMovimento.Add(new OpcaoComboTipoMovimento { Id = 0, Tipo = "Entrada" });
            listaTipoMovimento.Add(new OpcaoComboTipoMovimento { Id = 1, Tipo = "Saída" });

            cbTipoMovimento.DataSource = listaTipoMovimento;

            cbTipoMovimento.DisplayMember = "Tipo";
            cbTipoMovimento.ValueMember = "Id";

            List<OpcaoComboStatus> listaStatus = new List<OpcaoComboStatus>();

            listaStatus.Add(new OpcaoComboStatus { Id = 0, Status = "Aberto" });
            listaStatus.Add(new OpcaoComboStatus { Id = 1, Status = "Faturado" });
            listaStatus.Add(new OpcaoComboStatus { Id = 2, Status = "Cancelado" });

            cbStatus.DataSource = listaStatus;

            cbStatus.DisplayMember = "Status";
            cbStatus.ValueMember = "Id";
        }

        private void FormCadastroMovimentacao_Load(object sender, EventArgs e)
        {
            if (edita)
            {
                CarregaCampos();
                CarregaGridMovimentacaoItens();
                cbTipoMovimento.Enabled = false;

                if(cbStatus.SelectedIndex != 0)
                {
                    btnSalvar.Enabled = false;
                    btnOk.Enabled = false;
                    iBtnNovo.Enabled = false;
                    iBtnExcluir.Enabled = false;
                }
            }
            else
            {
                tbCodMovimentacao.Text = movimentacaoRepository.GetNextCodMovimentacao(AppZenCodeContext.CodEmpresa).ToString();
                tbCodEmpresa.Text = AppZenCodeContext.CodEmpresa.ToString();
                tbValorTotal.Text = "R$ 0,00";
                dtData.Value = DateTime.Now;
                tabMovimentacaoItem.Enabled = false;
                tbCodUsuario.Text = AppZenCodeContext.CodUsuario.ToString();
                tbCodUsuario_Leave(null, null);
            }
        }

        private void CarregaCampos()
        {
            Movimentacao movimentacao = movimentacaoRepository.GetByCodMovimentacao(AppZenCodeContext.CodEmpresa, codMovimentacao);

            tbCodEmpresa.Text = movimentacao.CODEMPRESA.ToString();
            tbCodMovimentacao.Text = movimentacao.CODMOVIMENTACAO.ToString();
            cbStatus.SelectedIndex = movimentacao.STATUS;
            tbValorTotal.Text = movimentacao.VALORTOTAL.ToString();
            tbCodUsuario.Text = movimentacao.CODUSUARIO.ToString();
            tbCodUsuario_Leave(null, null);
            tbCodCliente.Text = movimentacao.CODCLIFOR.ToString();
            tbCodCliente_Leave(null, null);
            cbTipoMovimento.SelectedIndex = movimentacao.TIPOMOVIMENTO.ToString() == "Entrada" ? 0 : 1; 
            dtData.Value = movimentacao.DATA;
            rtbObservacao.Text = movimentacao.OBSERVACAO.ToString();
        }

        private bool Salvar()
        {
            try
            {
                if (!DataBaseConnection.Instance().ExecuteHasRows($"SELECT * FROM MOVIMENTACAO WHERE CODEMPRESA = {AppZenCodeContext.CodEmpresa} AND CODMOVIMENTACAO = {codMovimentacao}"))
                {
                    movimentacaoRepository.Add(new Movimentacao
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        CODMOVIMENTACAO = Convert.ToInt32(tbCodMovimentacao.Text),
                        STATUS = 0,
                        VALORTOTAL = decimal.Parse(tbValorTotal.Text, NumberStyles.Currency),
                        CODUSUARIO = AppZenCodeContext.CodUsuario,
                        CODCLIFOR = Convert.ToInt32(tbCodCliente.Text),
                        TIPOMOVIMENTO = cbTipoMovimento.Text,
                        DATA = dtData.Value,
                        OBSERVACAO = rtbObservacao.Text
                    });

                    codMovimentacao = Convert.ToInt32(tbCodMovimentacao.Text);
                    cbTipoMovimento.Enabled = false;
                    tabMovimentacaoItem.Enabled = true;
                }
                else
                {
                    movimentacaoRepository.Update(new Movimentacao
                    {
                        CODEMPRESA = Convert.ToInt32(tbCodEmpresa.Text),
                        CODMOVIMENTACAO = Convert.ToInt32(tbCodMovimentacao.Text),
                        STATUS = Convert.ToInt32(cbStatus.SelectedIndex),
                        VALORTOTAL = decimal.Parse(tbValorTotal.Text, NumberStyles.Currency),
                        CODUSUARIO = Convert.ToInt32(tbCodUsuario.Text),
                        CODCLIFOR = Convert.ToInt32(tbCodCliente.Text),
                        TIPOMOVIMENTO = cbTipoMovimento.Text,
                        DATA = dtData.Value,
                        OBSERVACAO = rtbObservacao.Text
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

        private void btnLookupCliente_Click(object sender, EventArgs e)
        {
            FormVisaoClienteFornecedor formVisaoClienteFornecedor = new FormVisaoClienteFornecedor(this);
            formVisaoClienteFornecedor.ShowDialog();

            tbCodCliente.Text = string.IsNullOrEmpty(codCliFor) ? string.Empty : codCliFor;
            tbNomeCliente.Text = string.IsNullOrEmpty(nomeCliFor) ? string.Empty : nomeCliFor;
        }

        private void tbCodCliente_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCodCliente.Text))
                tbNomeCliente.Text = DataBaseConnection.Instance().ExecuteGetField("SELECT NOMEFANTASIA FROM CLIENTEFORNECEDOR  WHERE CODEMPRESA  = ? AND CODCLIFOR  = ?", new object[] { AppZenCodeContext.CodEmpresa, tbCodCliente.Text }).ToString();
            else
                tbNomeCliente.Text = string.Empty;
        }
        
        private void btnLookupUsuario_Click(object sender, EventArgs e)
        {
            FormVisaoUsuarios formVisaoUsuario = new FormVisaoUsuarios(this);
            formVisaoUsuario.ShowDialog();
            tbCodUsuario.Text = string.IsNullOrEmpty(codUsuario) ? string.Empty : codUsuario;
            tbNomeUsuario.Text = string.IsNullOrEmpty(nomeUsuario) ? string.Empty : nomeUsuario;
        }

        private void tbCodUsuario_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCodUsuario.Text))
                tbNomeUsuario.Text = DataBaseConnection.Instance().ExecuteGetField("SELECT NOME FROM USUARIO WHERE CODUSUARIO = ?", new object[] { tbCodUsuario.Text }).ToString();
            else
                tbNomeUsuario.Text = string.Empty;
        }

        private void tbPrecoUnitario_TextChanged(object sender, EventArgs e)
        {
            string textoLimpo = System.Text.RegularExpressions.Regex.Replace(tbValorTotal.Text, "[^0-9]", "");

            if (string.IsNullOrEmpty(textoLimpo))
            {
                tbValorTotal.Text = "R$ 0,00";
            }
            else
            {
                decimal valor = Convert.ToDecimal(textoLimpo) / 100;

                tbValorTotal.Text = valor.ToString("C2");
            }
        }

        private void tbPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #region Movimentação Itens

        private void CarregaGridMovimentacaoItens()
        {
            try
            {
                string coluna = "*";
                string tabela = "MOVIMENTACAOITEM";
                string relacionamento = @"";

                string where = "CODEMPRESA = " + AppZenCodeContext.CodEmpresa + " AND CODMOVIMENTACAO = " + codMovimentacao;

                new Utilidades().GetVisao(gvMovimentacaoItem, coluna, tabela, relacionamento, where);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iBtnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroMovimentacaoItem frm = new FormCadastroMovimentacaoItem();
            frm.codMovimentacao = codMovimentacao;
            frm.TipoMovimento = cbTipoMovimento.Text;
            frm.status = cbStatus.SelectedIndex;
            frm.ShowDialog();
            CarregaGridMovimentacaoItens();
            AtualizaValorTotal();
        }

        private void iBtnEditar_Click(object sender, EventArgs e)
        {
            if (gvMovimentacaoItem.SelectedRows.Count > 0)
            {
                int index = gvMovimentacaoItem.SelectedRows[0].Index;
                DataRow row1 = ((DataRowView)gvMovimentacaoItem.Rows[index].DataBoundItem).Row;
                FormCadastroMovimentacaoItem frm = new FormCadastroMovimentacaoItem();
                frm.edita = true;
                frm.codMovimentacao = Convert.ToInt32(row1["Cód. Movimentação"]);
                frm.codMovimentacaoItem = Convert.ToInt32(row1["Cód. Item Movimentação"]);
                frm.TipoMovimento = cbTipoMovimento.Text;
                frm.status = cbStatus.SelectedIndex;
                frm.ShowDialog();
                CarregaGridMovimentacaoItens();
                AtualizaValorTotal();
            }
        }

        private void iBtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < gvMovimentacaoItem.SelectedRows.Count; i++)
                {
                    int index = gvMovimentacaoItem.SelectedRows[i].Index;
                    DataRow row1 = ((DataRowView)gvMovimentacaoItem.Rows[index].DataBoundItem).Row;

                    int codProduto = Convert.ToInt32(row1["Cód. Produto"]);
                    decimal qtd = Convert.ToDecimal(row1["Quantidade"]);

                    if (cbStatus.SelectedIndex == 0)
                    {
                        if (cbTipoMovimento.Text.ToUpper() == "SAÍDA")
                        {
                            EstornarItemEstoque(AppZenCodeContext.CodEmpresa, codProduto, qtd);
                        }
                    }
                    movimentacaoItemRepository.Delete(AppZenCodeContext.CodEmpresa, Convert.ToInt32(row1["Cód. Movimentação"]), Convert.ToInt32(row1["Cód. Item Movimentação"]));
                }

                CarregaGridMovimentacaoItens();
                AtualizaValorTotal();
            }
        }

        private void gvMovimentacaoItem_DoubleClick(object sender, EventArgs e)
        {
            iBtnEditar_Click(sender, e);
        }

        private void iBtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaGridMovimentacaoItens();
            AtualizaValorTotal();
        }

        private void AtualizaValorTotal()
        {
            if (gvMovimentacaoItem.RowCount > 0)
            {
                decimal valorTotal = Convert.ToDecimal(DataBaseConnection.Instance().ExecuteGetField("SELECT SUM(VALORTOTAL) FROM MOVIMENTACAOITEM WHERE CODEMPRESA = ? AND CODMOVIMENTACAO = ?", AppZenCodeContext.CodEmpresa, tbCodMovimentacao.Text));
                DataBaseConnection.Instance().ExecuteTransaction("UPDATE MOVIMENTACAO SET VALORTOTAL = ? WHERE CODEMPRESA = ? AND CODMOVIMENTACAO = ?", valorTotal, AppZenCodeContext.CodEmpresa, tbCodMovimentacao.Text);
                tbValorTotal.Text = valorTotal.ToString("C2");
            }
        }

        public void EstornarItemEstoque(int codEmpresa, int codProduto, decimal qtdItem)
        {
            utilidades.AtualizarOuCriarEstoque(
                codEmpresa,
                codProduto,
                qtdItem,
                0,
                -qtdItem
            );
        }

        #endregion
    }
}
