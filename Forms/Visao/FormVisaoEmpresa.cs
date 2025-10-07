using System.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Visao
{
    public partial class FormVisaoEmpresa : Form
    {
        private EmpresaRepository empresaRepository = new EmpresaRepository();

        public FormVisaoEmpresa()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormVisaoEmpresa_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            try
            {
                string coluna = "*";
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //FormCadastroUsuarios frm = new FormCadastroUsuarios();
            //frm.ShowDialog();
            //CarregaGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(gvEmpresa.SelectedRows.Count > 0)
            {
                //int index = gvEmpresa.SelectedRows[0].Index;
                //DataRow row1 = ((DataRowView)gvEmpresa.Rows[index].DataBoundItem).Row;
                //FormCadastroUsuarios frm = new FormCadastroUsuarios();
                //frm.edita = true;
                //frm.codUsuario = Convert.ToInt32(row1["CODUSUARIO"]);
                //frm.ShowDialog();
                //CarregaGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < gvEmpresa.SelectedRows.Count; i++)
            {
                int index = gvEmpresa.SelectedRows[i].Index;
                DataRow row1 = ((DataRowView)gvEmpresa.Rows[index].DataBoundItem).Row;

                empresaRepository.Delete(Convert.ToInt32(row1["CODEMPRESA"]));
            }

            CarregaGrid();
        }

        private void gvEmpresa_DoubleClick(object sender, EventArgs e)
        {
            if (gvEmpresa.SelectedRows.Count > 0)
            {
                btnEditar_Click(sender, e);
            }
        }
    }
}
