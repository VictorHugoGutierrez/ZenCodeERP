using System.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Forms.Cadastro;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Visao
{
    public partial class FormVisaoClienteFornecedor : Form
    {
        private ClienteFornecedorRepository ClienteFornecedorRepository = new ClienteFornecedorRepository();

        public FormVisaoClienteFornecedor()
        {
            InitializeComponent();
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

                string where = "1 = 1";

                new Utilidades().GetVisao(gvClienteFornecedor, coluna, tabela, relacionamento, where);
            }
            catch(Exception ex)
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
            if(gvClienteFornecedor.SelectedRows.Count > 0)
            {
                int index = gvClienteFornecedor.SelectedRows[0].Index;
                DataRow row1 = ((DataRowView)gvClienteFornecedor.Rows[index].DataBoundItem).Row;
                FormCadastroClienteFornecedor frm = new FormCadastroClienteFornecedor();
                frm.edita = true;
                frm.codEmpresa = Convert.ToInt32(row1["Cód. Empresa"]);
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

                    ClienteFornecedorRepository.Delete(Convert.ToInt32(row1["CODCLIFOR"]));
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

        private void gvEmpresa_DoubleClick(object sender, EventArgs e)
        {
            if (gvClienteFornecedor.SelectedRows.Count > 0)
            {
                iBtnEditar_Click(sender, e);
            }
        }
    }
}
