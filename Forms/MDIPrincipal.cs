using ZenCodeERP.Forms.Visao;

namespace ZenCodeERP.Forms
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButtonUsuario_Click(object sender, EventArgs e)
        {
            FormVisaoUsuarios form = new FormVisaoUsuarios();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButtonEmpresa_Click(object sender, EventArgs e)
        {
            FormVisaoEmpresa form = new FormVisaoEmpresa();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripButtonEndereco_Click(object sender, EventArgs e)
        {
            FormVisaoEndereco form = new FormVisaoEndereco();
            form.MdiParent = this;
            form.Show();
        }
    }
}
