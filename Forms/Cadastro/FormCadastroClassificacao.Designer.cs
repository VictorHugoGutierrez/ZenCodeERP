using System;
using System.Windows.Forms;

namespace ZenCodeERP.Forms
{
    partial class FormCadastroClassificacao
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lbNome = new Label();
            tbNome = new TextBox();
            lbCodClassificacao = new Label();
            tbCodClassificacao = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lbDescricao = new Label();
            tbDescricao = new TextBox();
            lbCodEmpresa = new Label();
            tbCodEmpresa = new TextBox();
            panelBottom = new Panel();
            btnOk = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            flowButtons = new FlowLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(9, 63);
            lbNome.Margin = new Padding(5, 0, 5, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(50, 20);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(9, 87);
            tbNome.Margin = new Padding(5, 4, 5, 4);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(817, 27);
            tbNome.TabIndex = 1;
            // 
            // lbCodClassificacao
            // 
            lbCodClassificacao.AutoSize = true;
            lbCodClassificacao.Location = new Point(10, 4);
            lbCodClassificacao.Margin = new Padding(5, 0, 5, 0);
            lbCodClassificacao.Name = "lbCodClassificacao";
            lbCodClassificacao.Size = new Size(128, 20);
            lbCodClassificacao.TabIndex = 0;
            lbCodClassificacao.Text = "Cód. Classificação";
            // 
            // tbCodClassificacao
            // 
            tbCodClassificacao.Location = new Point(11, 28);
            tbCodClassificacao.Margin = new Padding(5, 4, 5, 4);
            tbCodClassificacao.Name = "tbCodClassificacao";
            tbCodClassificacao.ReadOnly = true;
            tbCodClassificacao.Size = new Size(238, 27);
            tbCodClassificacao.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(5, 4, 5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(844, 440);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbDescricao);
            tabPage1.Controls.Add(tbDescricao);
            tabPage1.Controls.Add(lbCodEmpresa);
            tabPage1.Controls.Add(tbCodEmpresa);
            tabPage1.Controls.Add(lbNome);
            tabPage1.Controls.Add(tbNome);
            tabPage1.Controls.Add(lbCodClassificacao);
            tabPage1.Controls.Add(tbCodClassificacao);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(5, 4, 5, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5, 4, 5, 4);
            tabPage1.Size = new Size(836, 407);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Identificação";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Location = new Point(10, 121);
            lbDescricao.Margin = new Padding(5, 0, 5, 0);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(74, 20);
            lbDescricao.TabIndex = 8;
            lbDescricao.Text = "Descrição";
            // 
            // tbDescricao
            // 
            tbDescricao.Location = new Point(11, 145);
            tbDescricao.Margin = new Padding(5, 4, 5, 4);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(815, 27);
            tbDescricao.TabIndex = 9;
            // 
            // lbCodEmpresa
            // 
            lbCodEmpresa.AutoSize = true;
            lbCodEmpresa.Location = new Point(257, 4);
            lbCodEmpresa.Margin = new Padding(5, 0, 5, 0);
            lbCodEmpresa.Name = "lbCodEmpresa";
            lbCodEmpresa.Size = new Size(100, 20);
            lbCodEmpresa.TabIndex = 4;
            lbCodEmpresa.Text = "Cód. Empresa";
            // 
            // tbCodEmpresa
            // 
            tbCodEmpresa.BackColor = SystemColors.Control;
            tbCodEmpresa.Location = new Point(259, 28);
            tbCodEmpresa.Margin = new Padding(5, 4, 5, 4);
            tbCodEmpresa.Name = "tbCodEmpresa";
            tbCodEmpresa.ReadOnly = true;
            tbCodEmpresa.Size = new Size(238, 27);
            tbCodEmpresa.TabIndex = 5;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnOk);
            panelBottom.Controls.Add(btnCancelar);
            panelBottom.Controls.Add(btnSalvar);
            panelBottom.Controls.Add(flowButtons);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 440);
            panelBottom.Margin = new Padding(5, 4, 5, 4);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(844, 61);
            panelBottom.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.AutoSize = true;
            btnOk.Location = new Point(624, 8);
            btnOk.Margin = new Padding(5, 4, 5, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(101, 40);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Location = new Point(734, 8);
            btnCancelar.Margin = new Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(101, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.Location = new Point(514, 8);
            btnSalvar.Margin = new Padding(5, 4, 5, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(101, 40);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // flowButtons
            // 
            flowButtons.AutoSize = true;
            flowButtons.Dock = DockStyle.Right;
            flowButtons.FlowDirection = FlowDirection.RightToLeft;
            flowButtons.Location = new Point(830, 0);
            flowButtons.Margin = new Padding(5, 4, 5, 4);
            flowButtons.Name = "flowButtons";
            flowButtons.Padding = new Padding(7, 8, 7, 8);
            flowButtons.Size = new Size(14, 61);
            flowButtons.TabIndex = 0;
            // 
            // FormCadastroClassificacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 501);
            Controls.Add(tabControl1);
            Controls.Add(panelBottom);
            Icon = Properties.Resources.iconZenCode;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormCadastroClassificacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Classificação";
            Load += FormCadastroClassificacao_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);

        }

        private CheckBox chkAtivo;
        private Label lbCodEmpresa;
        private TextBox tbCodEmpresa;
        private System.ComponentModel.IContainer components = null;
        private Label lbNome;
        private TextBox tbNome;
        private Label lbCodClassificacao;
        private TextBox tbCodClassificacao;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panelBottom;
        private Button btnOk;
        private Button btnCancelar;
        private Button btnSalvar;
        private FlowLayoutPanel flowButtons;
        private Label lbDescricao;
        private TextBox tbDescricao;
    }
}
