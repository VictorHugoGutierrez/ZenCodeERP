using Org.BouncyCastle.Bcpg.OpenPgp;
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
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms.Visao
{
    public partial class FormVisaoUsuarios : Form
    {
        private UsuarioRepository usuarioRepository = new UsuarioRepository();

        public FormVisaoUsuarios()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormVisaoUsuarios_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            try
            {
                string coluna = "*";
                string tabela = "USUARIO";
                string relacionamento = string.Empty;

                string where = "1 = 1";

                new Utilidades().GetVisao(gvUsuarios, coluna, tabela, relacionamento, where);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iBtnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroUsuarios frm = new FormCadastroUsuarios();
            frm.ShowDialog();
            CarregaGrid();
        }

        private void iBtnEditar_Click(object sender, EventArgs e)
        {
            if(gvUsuarios.SelectedRows.Count > 0)
            {
                int index = gvUsuarios.SelectedRows[0].Index;
                DataRow row1 = ((DataRowView)gvUsuarios.Rows[index].DataBoundItem).Row;
                FormCadastroUsuarios frm = new FormCadastroUsuarios();
                frm.edita = true;
                frm.codUsuario = row1["CODUSUARIO"].ToString();
                frm.ShowDialog();
                CarregaGrid();
            }
        }

        private void iBtnExcluir_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < gvUsuarios.SelectedRows.Count; i++)
            {
                int index = gvUsuarios.SelectedRows[i].Index;
                DataRow row1 = ((DataRowView)gvUsuarios.Rows[index].DataBoundItem).Row;

                usuarioRepository.Delete(row1["CODUSUARIO"].ToString());
            }

            CarregaGrid();
        }

        private void gvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            if (gvUsuarios.SelectedRows.Count > 0)
            {
                iBtnEditar_Click(sender, e);
            }
        }
    }
}
