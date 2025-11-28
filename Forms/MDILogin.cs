using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Model;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms
{
    public partial class MDILogin : Form
    {
        public MDILogin()
        {
            InitializeComponent();
        }

        private void MDILogin_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AppZenCodeContext.Usuario))
            {
                tbUsuario.Text = AppZenCodeContext.Usuario;
                tbSenha.Focus();
            }
        }

        private bool ValidaCampos()
        {
            if (string.IsNullOrEmpty(tbUsuario.Text))
            {
                MessageBox.Show("O campo Usuário é obrigatório.", "Mensagem.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsuario.Focus();
                return false;
            }

            if(string.IsNullOrEmpty(tbSenha.Text))
            {
                MessageBox.Show("O campo Senha é obrigatório.", "Mensagem.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSenha.Focus();
                return false;
            }

            return true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            { 
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                Usuario usuario = usuarioRepository.GetByUsuario(tbUsuario.Text);

                if(usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado.", "Mensagem.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbUsuario.Focus();
                    return;
                }

                if (Convert.ToBoolean(usuario.ATIVO))
                {
                    bool passwordMatch = usuarioRepository.VerificarSenhaBCrypt(tbSenha.Text, usuario.SENHA);

                    if (passwordMatch)
                    {
                        AppZenCodeContext.CodUsuario = usuario.CODUSUARIO;
                        AppZenCodeContext.Usuario = usuario.USUARIO;
                        Properties.Settings.Default.UltimoUsuario = usuario.USUARIO;
                        Properties.Settings.Default.Save();

                        usuarioRepository.AtualizaUltimoLogin(usuario.CODUSUARIO);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta.", "Mensagem.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbSenha.Focus();
                        return;
                    }
                }
            }
        }
    }
}
