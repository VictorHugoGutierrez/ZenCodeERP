using System.Data;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Model;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms
{
    public partial class MDISelecaoEmpresa : Form
    {
        public MDISelecaoEmpresa()
        {
            InitializeComponent();
        }

        private void MDISelecaoEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && this.DialogResult != DialogResult.OK)
            {
                e.Cancel = true;
                MessageBox.Show("Seleção de empresa obrigatória para continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MDISelecaoEmpresa_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            try
            {
                string coluna = "CODEMPRESA, NOME, NOMEFANTASIA, CNPJ";
                string tabela = "EMPRESA";
                string relacionamento = string.Empty;

                string where = "1 = 1";

                new Utilidades().GetVisao(gvEmpresa, coluna, tabela, relacionamento, where);
                gvEmpresa.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar as empresas. Entre em contato com o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void gvEmpresa_DoubleClick(object sender, EventArgs e)
        {
            iconBtnSelecionar_Click(sender, e);
        }

        private void iconBtnSelecionar_Click(object sender, EventArgs e)
        {
            if (gvEmpresa.SelectedRows.Count > 0)
            {
                int index = gvEmpresa.SelectedRows[0].Index;
                DataRow row1 = ((DataRowView)gvEmpresa.Rows[index].DataBoundItem).Row;
                AppZenCodeContext.CodEmpresa = Convert.ToInt32(row1["Cód. Empresa"]);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Selecione uma empresa para continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
