using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenCodeERP.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Model;
using ZstdSharp.Unsafe;

namespace ZenCodeERP.Forms
{
    public partial class FormCadastroUsuarios : Form
    {
        private UsuarioRepository usuarioRepository = new UsuarioRepository();
        public string codUsuario;
        public bool edita = false;

        public FormCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void FormCadastroUsuarios_Load(object sender, EventArgs e)
        {
            if (edita)
                CarregaCampos();
            else
                tbCodUsuario.Text = usuarioRepository.GetNextCodUsuario().ToString();
        }

        private void CarregaCampos()
        {
            Usuario usuario = usuarioRepository.GetByCodUsuario(codUsuario);

            tbCodUsuario.Text = usuario.CODUSUARIO;
            tbUsuario.Text = usuario.USUARIO;
            tbSenha.Text = usuario.SENHA;
            tbNome.Text = usuario.NOME;
            dtUltimoLogin.Value = usuario.ULTIMOLOGIN;
            chkAtivo.Checked = usuario.ATIVO == 1 ? true : false;
        }

        private bool Salvar()
        {
            try
            {
                if (!DataBaseConnection.Instance().ExecuteHasRows($"SELECT * FROM USUARIO WHERE ID = {codUsuario}"))
                {
                    usuarioRepository.Add(new Usuario
                    {
                        CODUSUARIO = tbCodUsuario.Text,
                        USUARIO = tbUsuario.Text,
                        NOME = tbNome.Text,
                        SENHA = tbSenha.Text,
                        ATIVO = chkAtivo.Checked ? 1 : 0,
                        ULTIMOLOGIN = DateTime.Now
                    });
                }
                else
                {
                    usuarioRepository.Update(new Usuario
                    {
                        CODUSUARIO = tbCodUsuario.Text,
                        USUARIO = tbUsuario.Text,
                        NOME = tbNome.Text,
                        SENHA = tbSenha.Text,
                        ATIVO = chkAtivo.Checked ? 1 : 0,
                        ULTIMOLOGIN = DateTime.Now
                    });
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Salvar())
                return;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!Salvar())
                return;

            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
