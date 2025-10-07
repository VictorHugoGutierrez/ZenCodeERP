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
        private DataBaseConnection connection = new DataBaseConnection();
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
                carragaCampos();
        }

        private void carragaCampos()
        {
            Usuario usuario = usuarioRepository.GetByCodUsuario(codUsuario);

            tbNome.Text = usuario.NOME;
        }

        private bool Salvar()
        {
            try
            {
                string name = tbNome.Text;
                string codUsuario = tbCodUsuario.Text;

                if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(codUsuario))
                {
                    MessageBox.Show("Nome e Email são obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if(!connection.ExecuteHasRows($"SELECT * FROM USUARIO WHERE ID = {codUsuario}"))
                {
                    connection.ExecuteTransaction($"INSERT INTO USUARIO (NOME, EMAIL) VALUES (?, ?)", new object[] {name, codUsuario });
                }
                else
                {
                    connection.ExecuteTransaction($"UPDATE USUARIO SET NOME = '{name}', EMAIL = '{codUsuario}' WHERE ID = {codUsuario}");
                }

                return true;
            }
            catch(Exception ex)
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
