using System.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Forms.Cadastro;
using ZenCodeERP.Model;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Visao
{
    public partial class FormVisaoProduto : Form
    {
        private ProdutoRepository produtoRepository = new ProdutoRepository();

        FormCadastroMovimentacaoItem lookup;

        public FormVisaoProduto()
        {
            InitializeComponent();
        }
        public FormVisaoProduto(FormCadastroMovimentacaoItem lookup)
        {
            InitializeComponent();
            this.lookup = lookup;
        }

        private void FormVisaoProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            try
            {
                string coluna = "PRODUTO.CODEMPRESA, PRODUTO.CODPRODUTO, PRODUTO.TIPO, PRODUTO.ATIVO, PRODUTO.NOME, PRODUTO.DESCRICAO, PRODUTO.PRECOUNITARIO, PRODUTO.CODCLASSIFICACAO, CLASSIFICACAO.NOME";
                string tabela = "PRODUTO";
                string relacionamento = @"INNER JOIN CLASSIFICACAO
                    ON CLASSIFICACAO.CODEMPRESA = PRODUTO.CODEMPRESA 
                    AND CLASSIFICACAO.CODCLASSIFICACAO = PRODUTO.CODCLASSIFICACAO";
                
                string where = "PRODUTO.CODEMPRESA = " + AppZenCodeContext.CodEmpresa;

                new Utilidades().GetVisao(gvProduto, coluna, tabela, relacionamento, where);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iBtnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroProduto frm = new FormCadastroProduto();
            frm.ShowDialog();
            CarregaGrid();
        }

        private void iBtnEditar_Click(object sender, EventArgs e)
        {
            if (gvProduto.SelectedRows.Count > 0)
            {
                int index = gvProduto.SelectedRows[0].Index;
                DataRow row1 = ((DataRowView)gvProduto.Rows[index].DataBoundItem).Row;
                FormCadastroProduto frm = new FormCadastroProduto();
                frm.edita = true;
                frm.codProduto = Convert.ToInt32(row1["Cód. Produto"]);
                frm.ShowDialog();
                CarregaGrid();
            }
        }

        private void iBtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < gvProduto.SelectedRows.Count; i++)
                {
                    int index = gvProduto.SelectedRows[i].Index;
                    DataRow row1 = ((DataRowView)gvProduto.Rows[index].DataBoundItem).Row;

                    produtoRepository.Delete(AppZenCodeContext.CodEmpresa, Convert.ToInt32(row1["Cód. Produto"]));
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

        private void gvProduto_DoubleClick(object sender, EventArgs e)
        {
            if (gvProduto.SelectedRows.Count > 0)
            {
                if(lookup == null)
                {
                    iBtnEditar_Click(sender, e);
                }
                else
                {
                    lookup.codProduto = ((DataRowView)gvProduto.SelectedRows[0].DataBoundItem).Row["Cód. Produto"].ToString();
                    lookup.nomeProduto = ((DataRowView)gvProduto.SelectedRows[0].DataBoundItem).Row["Nome do Produto"].ToString();

                    this.Dispose();
                }
            }

        }

        private void iBtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
