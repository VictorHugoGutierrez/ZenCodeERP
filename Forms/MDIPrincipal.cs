using FontAwesome.Sharp;
using System.Diagnostics.CodeAnalysis;
using ZenCodeERP.Data.Repositories;
using ZenCodeERP.Forms.Visao;
using ZenCodeERP.Model;
using ZenCodeERP.Utils;

namespace ZenCodeERP.Forms
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
            iconToolStripButtonUsuario.Visible = Utilidades.Permissoes.permissao_gerente();

            iconToolStripButtonClassificacao.Visible = Utilidades.Permissoes.permissao_gerente() || Utilidades.Permissoes.permissao_vendedor();

            iconToolStripButtonEmpresa.Visible = Utilidades.Permissoes.permissao_gerente() || Utilidades.Permissoes.permissao_estoquista();
            iconToolStripButtonProduto.Visible = Utilidades.Permissoes.permissao_gerente() || Utilidades.Permissoes.permissao_estoquista();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            EmpresaRepository empresaRepository = new EmpresaRepository();
            List<Empresa> empresas = empresaRepository.GetAll();
            if (empresas.Count > 1)
            {
                MDISelecaoEmpresa form = new MDISelecaoEmpresa();
                if (form.ShowDialog() != DialogResult.OK)
                {
                    this.Close();
                }
            }
            else if (empresas.Count == 1)
            {
                AppZenCodeContext.CodEmpresa = empresas[0].CODEMPRESA;
            }

            Empresa empresa = empresaRepository.GetByCodEmpresa(AppZenCodeContext.CodEmpresa);
            this.Text = "ZenCode ERP - " + empresa.NOMEFANTASIA + " - Usuário: " + AppZenCodeContext.Usuario;
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            if (MessageBox.Show("Deseja realmente fechar o sistema?", "Mensagem.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void iconToolStripButtonUsuario_Click(object sender, EventArgs e)
        {
            FormVisaoUsuarios form = new FormVisaoUsuarios();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void iconToolStripButtonEmpresa_Click(object sender, EventArgs e)
        {
            FormVisaoEmpresa form = new FormVisaoEmpresa();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void iconToolStripButtonEndereco_Click(object sender, EventArgs e)
        {
            FormVisaoEndereco form = new FormVisaoEndereco();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilidades.Permissoes.permissao_gerente() && !Utilidades.Permissoes.permissao_estoquista())
            {
                MessageBox.Show("Não possui permissão pra gerar esse relatório", "Mensagem.");
                return;
            }
            FormVisaoRelatorioEstoque form = new FormVisaoRelatorioEstoque();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void iconToolStripButtonCliFor_Click(object sender, EventArgs e)
        {
            FormVisaoClienteFornecedor form = new FormVisaoClienteFornecedor();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void relatórioTicketMédioPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utilidades.Permissoes.permissao_gerente() && !Utilidades.Permissoes.permissao_vendedor())
            {
                MessageBox.Show("Não possui permissão pra gerar esse relatório", "Mensagem.");
                return;
            }
            formVisaoRelatorioVendas form = new formVisaoRelatorioVendas();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void iconToolStripButtonClassificacao_Click(object sender, EventArgs e)
        {
            FormVisaoClassificacao form = new FormVisaoClassificacao();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void iconToolStripButtonProduto_Click(object sender, EventArgs e)
        {
            FormVisaoProduto form = new FormVisaoProduto();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void iconToolStripButtonMovimentacao_Click(object sender, EventArgs e)
        {
            FormVisaoMovimentacao form = new FormVisaoMovimentacao();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!Utilidades.Permissoes.permissao_gerente() && !Utilidades.Permissoes.permissao_estoquista())
            {
                MessageBox.Show("Não possui permissão pra gerar esse relatório", "Mensagem.");
                return;
            }
            FormRelatorioEstoqueProdutos form = new FormRelatorioEstoqueProdutos();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(form);
            form.Show();
        }

        private void toolStripButtonRelatorio_Click(object sender, EventArgs e)
        {

        }
    }
}
