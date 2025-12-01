using System.Data;
using ZenCodeERP.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Forms.Cadastro;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Visao
{
    public partial class FormVisaoMovimentacao : Form
    {
        private MovimentacaoRepository movimentacaoRepository = new MovimentacaoRepository();

        public FormVisaoMovimentacao()
        {
            InitializeComponent();
        }

        private void FormVisaoMovimentacao_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            try
            {
                string coluna = "CODEMPRESA, CODMOVIMENTACAO, STATUS, VALORTOTAL, CODUSUARIO, CODCLIFOR, TIPOMOVIMENTO, DATA, OBSERVACAO";
                string tabela = "MOVIMENTACAO";
                string relacionamento = @"";
                
                string where = "CODEMPRESA = " + AppZenCodeContext.CodEmpresa;

                new Utilidades().GetVisao(gvMovimentacao, coluna, tabela, relacionamento, where);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iBtnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroMovimentacao frm = new FormCadastroMovimentacao();
            frm.ShowDialog();
            CarregaGrid();
        }

        private void iBtnEditar_Click(object sender, EventArgs e)
        {
            if (gvMovimentacao.SelectedRows.Count > 0)
            {
                int index = gvMovimentacao.SelectedRows[0].Index;
                DataRow row1 = ((DataRowView)gvMovimentacao.Rows[index].DataBoundItem).Row;
                FormCadastroMovimentacao frm = new FormCadastroMovimentacao();
                frm.edita = true;
                frm.codMovimentacao = Convert.ToInt32(row1["Cód. Movimentação"]);
                frm.ShowDialog();
                CarregaGrid();
            }
        }

        private void iBtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < gvMovimentacao.SelectedRows.Count; i++)
                {
                    int index = gvMovimentacao.SelectedRows[i].Index;
                    DataRow row1 = ((DataRowView)gvMovimentacao.Rows[index].DataBoundItem).Row;

                    movimentacaoRepository.Delete(AppZenCodeContext.CodEmpresa, Convert.ToInt32(row1["Cód. Movimentação"]));
                }

                CarregaGrid();
            }
        }

        private void iBtnFechar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente fechar?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
            else
                return;
        }

        private void gvMovimentacao_DoubleClick(object sender, EventArgs e)
        {
            iBtnEditar_Click(sender, e);
        }

        private void iBtnFaturar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (gvMovimentacao.SelectedRows.Count > 0)
                {
                    int index = gvMovimentacao.SelectedRows[0].Index;
                    DataRow row1 = ((DataRowView)gvMovimentacao.Rows[index].DataBoundItem).Row;
                    FaturarMovimentacao(AppZenCodeContext.CodEmpresa, Convert.ToInt32(row1["Cód. Movimentação"]));
                    CarregaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FaturarMovimentacao(int codEmpresa, int codMovimentacao)
        {
            try
            {
                string sqlHeader = $"SELECT STATUS, TIPOMOVIMENTO FROM MOVIMENTACAO WHERE CODEMPRESA = {codEmpresa} AND CODMOVIMENTACAO = {codMovimentacao}";
                DataTable dtHeader = DataBaseConnection.Instance().ExecuteQuery(sqlHeader);

                if (dtHeader.Rows.Count == 0) throw new Exception("Movimentação não encontrada.");

                int statusAtual = Convert.ToInt32(dtHeader.Rows[0]["STATUS"]);
                string tipoMovimento = dtHeader.Rows[0]["TIPOMOVIMENTO"].ToString().ToUpper();

                if (statusAtual != 0) throw new Exception("Apenas movimentações 'Abertas' (0) podem ser faturadas.");

                string sqlItens = $"SELECT CODPRODUTO, QUANTIDADE, VALORUNITARIO FROM MOVIMENTACAOITEM WHERE CODEMPRESA = {codEmpresa} AND CODMOVIMENTACAO = {codMovimentacao}";
                DataTable dtItens = DataBaseConnection.Instance().ExecuteQuery(sqlItens);

                foreach (DataRow item in dtItens.Rows)
                {
                    int codProduto = Convert.ToInt32(item["CODPRODUTO"]);
                    decimal qtd = Convert.ToDecimal(item["QUANTIDADE"]);
                    string valorUnitarioSQL = item["VALORUNITARIO"].ToString().Replace(",", ".");

                    if (tipoMovimento == "SAIDA")
                    {
                        AtualizarOuCriarEstoque(codEmpresa, codProduto, -qtd, 0, -qtd);
                    }
                    else if (tipoMovimento == "ENTRADA")
                    {
                        AtualizarOuCriarEstoque(codEmpresa, codProduto, qtd, qtd, 0);

                        string sqlCusto = $"UPDATE PRODUTO SET CUSTO = {valorUnitarioSQL} WHERE CODEMPRESA = {codEmpresa} AND CODPRODUTO = {codProduto}";
                        DataBaseConnection.Instance().ExecuteTransaction(sqlCusto);
                    }
                }

                DataBaseConnection.Instance().ExecuteTransaction($"UPDATE MOVIMENTACAO SET STATUS = 1 WHERE CODEMPRESA = {codEmpresa} AND CODMOVIMENTACAO = {codMovimentacao}");

                MessageBox.Show("Faturado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao faturar: " + ex.Message);
            }
        }

        private void iBtnCancelar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (gvMovimentacao.SelectedRows.Count > 0)
                {
                    int index = gvMovimentacao.SelectedRows[0].Index;
                    DataRow row1 = ((DataRowView)gvMovimentacao.Rows[index].DataBoundItem).Row;
                    CancelarMovimentacao(AppZenCodeContext.CodEmpresa, Convert.ToInt32(row1["Cód. Movimentação"]));
                    CarregaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CancelarMovimentacao(int codEmpresa, int codMovimentacao)
        {
            try
            {
                string sqlHeader = $"SELECT STATUS, TIPOMOVIMENTO FROM MOVIMENTACAO WHERE CODEMPRESA = {codEmpresa} AND CODMOVIMENTACAO = {codMovimentacao}";
                DataTable dtHeader = DataBaseConnection.Instance().ExecuteQuery(sqlHeader);

                if (dtHeader.Rows.Count == 0) throw new Exception("Movimentação não encontrada.");

                int statusAtual = Convert.ToInt32(dtHeader.Rows[0]["STATUS"]);
                string tipoMovimento = dtHeader.Rows[0]["TIPOMOVIMENTO"].ToString().ToUpper();

                if (statusAtual == 2) throw new Exception("Já está cancelada.");

                string sqlItens = $"SELECT CODPRODUTO, QUANTIDADE FROM MOVIMENTACAOITEM WHERE CODEMPRESA = {codEmpresa} AND CODMOVIMENTACAO = {codMovimentacao}";
                DataTable dtItens = DataBaseConnection.Instance().ExecuteQuery(sqlItens);

                foreach (DataRow item in dtItens.Rows)
                {
                    int codProduto = Convert.ToInt32(item["CODPRODUTO"]);
                    decimal qtd = Convert.ToDecimal(item["QUANTIDADE"]);

                    if (tipoMovimento == "SAIDA")
                    {
                        if (statusAtual == 0)
                        {
                            AtualizarOuCriarEstoque(codEmpresa, codProduto, 0, qtd, -qtd);
                        }
                        else if (statusAtual == 1)
                        {
                            AtualizarOuCriarEstoque(codEmpresa, codProduto, qtd, qtd, 0);
                        }
                    }
                    else if (tipoMovimento == "ENTRADA")
                    {
                        if (statusAtual == 1)
                        {
                            AtualizarOuCriarEstoque(codEmpresa, codProduto, -qtd, -qtd, 0);
                        }
                    }
                }

                DataBaseConnection.Instance().ExecuteTransaction($"UPDATE MOVIMENTACAO SET STATUS = 2 WHERE CODEMPRESA = {codEmpresa} AND CODMOVIMENTACAO = {codMovimentacao}");

                MessageBox.Show("Cancelado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cancelar: " + ex.Message);
            }
        }

        private void AtualizarOuCriarEstoque(int codEmpresa, int codProduto, decimal deltaAtual, decimal deltaSaldo, decimal deltaReservada)
        {
            string sqlCheck = $"SELECT 1 FROM CONTROLEESTOQUE WHERE CODEMPRESA = {codEmpresa} AND CODPRODUTO = {codProduto}";
            DataTable dt = DataBaseConnection.Instance().ExecuteQuery(sqlCheck);

            string sAtual = deltaAtual.ToString().Replace(",", ".");
            string sSaldo = deltaSaldo.ToString().Replace(",", ".");
            string sReservada = deltaReservada.ToString().Replace(",", ".");

            if (dt.Rows.Count > 0)
            {
                // UPDATE
                string sqlUpdate = $@"
            UPDATE CONTROLEESTOQUE 
            SET 
                QUANTIDADEATUAL = QUANTIDADEATUAL + ({sAtual}),
                QUANTIDADESALDO = QUANTIDADESALDO + ({sSaldo}),
                QUANTIDADERESERVADA = QUANTIDADERESERVADA + ({sReservada}),
                DATA = NOW()
            WHERE CODEMPRESA = {codEmpresa} AND CODPRODUTO = {codProduto}";
                DataBaseConnection.Instance().ExecuteTransaction(sqlUpdate);
            }
            else
            {
                // INSERT
                string sqlInsert = $@"
            INSERT INTO CONTROLEESTOQUE (CODEMPRESA, CODPRODUTO, QUANTIDADEATUAL, QUANTIDADESALDO, QUANTIDADERESERVADA, DATA)
            VALUES ({codEmpresa}, {codProduto}, {sAtual}, {sSaldo}, {sReservada}, NOW())";
                DataBaseConnection.Instance().ExecuteTransaction(sqlInsert);
            }
        }

        private void iBtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
