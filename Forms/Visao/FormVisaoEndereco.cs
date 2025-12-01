using System.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Forms.Cadastro;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Visao
{
    public partial class FormVisaoEndereco : Form
    {
        private EnderecoRepository enderecoRepository = new EnderecoRepository();

        private FormCadastroClienteFornecedor lookupClienteFornecedor;
        private FormCadastroEmpresa lookupEmpresa;

        public FormVisaoEndereco()
        {
            InitializeComponent();
        }

        public FormVisaoEndereco(FormCadastroClienteFornecedor lookupClienteFornecedor)
        {
            InitializeComponent();
            this.lookupClienteFornecedor = lookupClienteFornecedor;
        }

        public FormVisaoEndereco(FormCadastroEmpresa lookupEmpresa)
        {
            InitializeComponent();
            this.lookupEmpresa = lookupEmpresa;
        }

        private void FormVisaoEndereco_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            try
            {
                string coluna = "*";
                string tabela = "ENDERECO";
                string relacionamento = string.Empty;

                string where = "1 = 1";

                new Utilidades().GetVisao(gvEndereco, coluna, tabela, relacionamento, where);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iBtnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroEndereco frm = new FormCadastroEndereco();
            frm.ShowDialog();
            CarregaGrid();
        }

        private void iBtnEditar_Click(object sender, EventArgs e)
        {
            if (gvEndereco.SelectedRows.Count > 0)
            {
                int index = gvEndereco.SelectedRows[0].Index;
                DataRow row1 = ((DataRowView)gvEndereco.Rows[index].DataBoundItem).Row;
                FormCadastroEndereco frm = new FormCadastroEndereco();
                frm.edita = true;
                frm.codEndereco = Convert.ToInt32(row1["Cód. Endereço"]);
                frm.ShowDialog();
                CarregaGrid();
            }
        }

        private void iBtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < gvEndereco.SelectedRows.Count; i++)
                {
                    int index = gvEndereco.SelectedRows[i].Index;
                    DataRow row1 = ((DataRowView)gvEndereco.Rows[index].DataBoundItem).Row;

                    enderecoRepository.Delete(Convert.ToInt32(row1["CODENDERECO"]));
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

        private void gvEndereco_DoubleClick(object sender, EventArgs e)
        {
            if (gvEndereco.SelectedRows.Count > 0)
            {
                if(lookupClienteFornecedor != null)
                {
                    lookupClienteFornecedor.CodigoEndereco = ((DataRowView)gvEndereco.SelectedRows[0].DataBoundItem).Row["Cód. Endereço"].ToString();
                    lookupClienteFornecedor.NomeEndereco = ((DataRowView)gvEndereco.SelectedRows[0].DataBoundItem).Row["Nome"].ToString();
                    this.Dispose();
                }
                else if(lookupEmpresa != null)
                {
                    lookupEmpresa.CodigoEndereco = ((DataRowView)gvEndereco.SelectedRows[0].DataBoundItem).Row["Cód. Endereço"].ToString();
                    lookupEmpresa.NomeEndereco = ((DataRowView)gvEndereco.SelectedRows[0].DataBoundItem).Row["Nome"].ToString();
                    this.Dispose();
                }
                else
                {
                    iBtnEditar_Click(sender, e);
                }
            }
        }

        private void iBtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
