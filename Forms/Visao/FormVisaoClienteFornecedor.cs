using System.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Forms.Cadastro;
using ZenCodeERP.Model;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Visao
{
    public partial class FormVisaoClienteFornecedor : Form
    {
        private ClienteFornecedorRepository ClienteFornecedorRepository = new ClienteFornecedorRepository();

        FormCadastroMovimentacao lookup;

        public FormVisaoClienteFornecedor()
        {
            InitializeComponent();
        }

        public FormVisaoClienteFornecedor(FormCadastroMovimentacao lookup)
        {
            InitializeComponent();
            this.lookup = lookup;
        }

        private void FormVisaoClienteFornecedor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            try
            {
                string coluna = "CODEMPRESA, CODCLIFOR, NOME, NOMEFANTASIA, CNPJCPF, TELEFONE, TIPOCADASTRO, TIPOPESSOA, EMAIL, CODENDERECO";
                string tabela = "CLIENTEFORNECEDOR";
                string relacionamento = string.Empty;

                string where = "CODEMPRESA = " + AppZenCodeContext.CodEmpresa;

                new Utilidades().GetVisao(gvClienteFornecedor, coluna, tabela, relacionamento, where);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iBtnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroClienteFornecedor frm = new FormCadastroClienteFornecedor();
            frm.ShowDialog();
            CarregaGrid();
        }

        private void iBtnEditar_Click(object sender, EventArgs e)
        {
            if (gvClienteFornecedor.SelectedRows.Count > 0)
            {
                int index = gvClienteFornecedor.SelectedRows[0].Index;
                DataRow row1 = ((DataRowView)gvClienteFornecedor.Rows[index].DataBoundItem).Row;
                FormCadastroClienteFornecedor frm = new FormCadastroClienteFornecedor();
                frm.edita = true;
                frm.codCliFor = Convert.ToInt32(row1["Cliente/Fornecedor"]);
                frm.ShowDialog();
                CarregaGrid();
            }
        }

        private void iBtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < gvClienteFornecedor.SelectedRows.Count; i++)
                {
                    int index = gvClienteFornecedor.SelectedRows[i].Index;
                    DataRow row1 = ((DataRowView)gvClienteFornecedor.Rows[index].DataBoundItem).Row;

                    ClienteFornecedorRepository.Delete(AppZenCodeContext.CodEmpresa, Convert.ToInt32(row1["Cliente/Fornecedor"]));
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

        private void gvClienteFornecedor_DoubleClick(object sender, EventArgs e)
        {
            if (gvClienteFornecedor.SelectedRows.Count > 0)
            {
                if(lookup == null)
                {
                    iBtnEditar_Click(sender, e);
                }
                else
                {
                    lookup.codCliFor = ((DataRowView)gvClienteFornecedor.SelectedRows[0].DataBoundItem).Row["Cliente/Fornecedor"].ToString();
                    lookup.nomeCliFor = ((DataRowView)gvClienteFornecedor.SelectedRows[0].DataBoundItem).Row["Nome"].ToString();

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
