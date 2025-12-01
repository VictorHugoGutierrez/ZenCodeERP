using System.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Forms.Cadastro;
using ZenCodeERP.Model;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Visao
{
    public partial class FormVisaoClassificacao : Form
    {
        private ClassificacaoRepository ClassificacaoRepository = new ClassificacaoRepository();

        private FormCadastroProduto lookup;

        public FormVisaoClassificacao()
        {
            InitializeComponent();
        }

        public FormVisaoClassificacao(FormCadastroProduto lookup)
        {
            InitializeComponent();
            this.lookup = lookup;
        }

        private void FormVisaoClassificacao_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            try
            {
                string coluna = "CODEMPRESA, CODCLASSIFICACAO, NOME, DESCRICAO";
                string tabela = "CLASSIFICACAO";
                string relacionamento = string.Empty;

                string where = "CODEMPRESA = " + AppZenCodeContext.CodEmpresa;

                new Utilidades().GetVisao(gvClassificacao, coluna, tabela, relacionamento, where);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iBtnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroClassificacao frm = new FormCadastroClassificacao();
            frm.ShowDialog();
            CarregaGrid();
        }

        private void iBtnEditar_Click(object sender, EventArgs e)
        {
            if (gvClassificacao.SelectedRows.Count > 0)
            {
                int index = gvClassificacao.SelectedRows[0].Index;
                DataRow row1 = ((DataRowView)gvClassificacao.Rows[index].DataBoundItem).Row;
                FormCadastroClassificacao frm = new FormCadastroClassificacao();
                frm.edita = true;
                frm.codClassificacao = Convert.ToInt32(row1["Classificação"]);
                frm.ShowDialog();
                CarregaGrid();
            }
        }

        private void iBtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < gvClassificacao.SelectedRows.Count; i++)
                {
                    int index = gvClassificacao.SelectedRows[i].Index;
                    DataRow row1 = ((DataRowView)gvClassificacao.Rows[index].DataBoundItem).Row;

                    ClassificacaoRepository.Delete(AppZenCodeContext.CodEmpresa, Convert.ToInt32(row1["Classificação"]));
                }

                CarregaGrid();
            }
        }

        private void iBtnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
            else
                return;
        }

        private void gvClassificacao_DoubleClick(object sender, EventArgs e)
        {
            if (gvClassificacao.SelectedRows.Count > 0)
            {
                if(lookup == null)
                {
                    iBtnEditar_Click(sender, e);
                }
                else
                {
                    lookup.codClassificacao = ((DataRowView)gvClassificacao.SelectedRows[0].DataBoundItem).Row["Classificação"].ToString();
                    lookup.nomeClassificacao = ((DataRowView)gvClassificacao.SelectedRows[0].DataBoundItem).Row["Nome"].ToString();

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
