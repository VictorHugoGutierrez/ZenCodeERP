using System.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Forms.Cadastro;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Visao
{
    public partial class FormVisaoEmpresa : Form
    {
        private EmpresaRepository empresaRepository = new EmpresaRepository();

        public FormVisaoEmpresa()
        {
            InitializeComponent();
        }

        private void FormVisaoEmpresa_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            try
            {
                string coluna = "CODEMPRESA, NOME, NOMEFANTASIA, CNPJ, TELEFONE, EMAIL, CODENDERECO";
                string tabela = "EMPRESA";
                string relacionamento = string.Empty;

                string where = "1 = 1";

                new Utilidades().GetVisao(gvEmpresa, coluna, tabela, relacionamento, where);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iBtnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroEmpresa frm = new FormCadastroEmpresa();
            frm.ShowDialog();
            CarregaGrid();
        }

        private void iBtnEditar_Click(object sender, EventArgs e)
        {
            if(gvEmpresa.SelectedRows.Count > 0)
            {
                int index = gvEmpresa.SelectedRows[0].Index;
                DataRow row1 = ((DataRowView)gvEmpresa.Rows[index].DataBoundItem).Row;
                FormCadastroEmpresa frm = new FormCadastroEmpresa();
                frm.edita = true;
                frm.codEmpresa = Convert.ToInt32(row1["Cód. Empresa"]);
                frm.ShowDialog();
                CarregaGrid();
            }
        }

        private void iBtnExcluir_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < gvEmpresa.SelectedRows.Count; i++)
            {
                int index = gvEmpresa.SelectedRows[i].Index;
                DataRow row1 = ((DataRowView)gvEmpresa.Rows[index].DataBoundItem).Row;

                empresaRepository.Delete(Convert.ToInt32(row1["Cód. Empresa"]));
            }

            CarregaGrid();
        }

        private void gvEmpresa_DoubleClick(object sender, EventArgs e)
        {
            if (gvEmpresa.SelectedRows.Count > 0)
            {
                iBtnEditar_Click(sender, e);
            }
        }
    }
}
