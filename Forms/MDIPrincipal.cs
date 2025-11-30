using System.Diagnostics.CodeAnalysis;
using ZenCodeERP.Forms.Visao;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = Text + " - Usuário: " + AppZenCodeContext.Usuario;
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            if (MessageBox.Show("Deseja realmente fechar o sistema?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void toolStripButtonUsuario_Click(object sender, EventArgs e)
        {
            FormVisaoUsuarios form = new FormVisaoUsuarios();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void toolStripButtonEmpresa_Click(object sender, EventArgs e)
        {
            FormVisaoEmpresa form = new FormVisaoEmpresa();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void toolStripButtonEndereco_Click(object sender, EventArgs e)
        {
            FormVisaoEndereco form = new FormVisaoEndereco();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void toolStripButtonRelatorio_Click(object sender, EventArgs e)
        {
            formVisaoRelatorioVendas form = new formVisaoRelatorioVendas();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }
    }
}
