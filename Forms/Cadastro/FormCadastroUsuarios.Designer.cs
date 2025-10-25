using System;
using System.Windows.Forms;

namespace ZenCodeERP.Forms
{
    partial class FormCadastroUsuarios
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
            lbCodUsuario = new Label();
            tbCodUsuario = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lbUsuario = new Label();
            tbUsuario = new TextBox();
            lbUltimoLogin = new Label();
            dtUltimoLogin = new DateTimePicker();
            lbSenha = new Label();
            tbSenha = new TextBox();
            chkAtivo = new CheckBox();
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
            lbNome.Location = new Point(8, 47);
            lbNome.Margin = new Padding(4, 0, 4, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(100, 15);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome do Usuário";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(8, 65);
            tbNome.Margin = new Padding(4, 3, 4, 3);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(708, 23);
            tbNome.TabIndex = 1;
            // 
            // lbCodUsuario
            // 
            lbCodUsuario.AutoSize = true;
            lbCodUsuario.Location = new Point(9, 3);
            lbCodUsuario.Margin = new Padding(4, 0, 4, 0);
            lbCodUsuario.Name = "lbCodUsuario";
            lbCodUsuario.Size = new Size(75, 15);
            lbCodUsuario.TabIndex = 0;
            lbCodUsuario.Text = "Cód. Usuário";
            // 
            // tbCodUsuario
            // 
            tbCodUsuario.ReadOnly = true;
            tbCodUsuario.Location = new Point(10, 21);
            tbCodUsuario.Margin = new Padding(4, 3, 4, 3);
            tbCodUsuario.Name = "tbCodUsuario";
            tbCodUsuario.Size = new Size(209, 23);
            tbCodUsuario.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(734, 325);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbUsuario);
            tabPage1.Controls.Add(tbUsuario);
            tabPage1.Controls.Add(lbUltimoLogin);
            tabPage1.Controls.Add(dtUltimoLogin);
            tabPage1.Controls.Add(lbSenha);
            tabPage1.Controls.Add(tbSenha);
            tabPage1.Controls.Add(chkAtivo);
            tabPage1.Controls.Add(lbNome);
            tabPage1.Controls.Add(tbNome);
            tabPage1.Controls.Add(lbCodUsuario);
            tabPage1.Controls.Add(tbCodUsuario);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(726, 297);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Identificação";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(9, 91);
            lbUsuario.Margin = new Padding(4, 0, 4, 0);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(47, 15);
            lbUsuario.TabIndex = 8;
            lbUsuario.Text = "Usuário";
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(10, 109);
            tbUsuario.Margin = new Padding(4, 3, 4, 3);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(350, 23);
            tbUsuario.TabIndex = 9;
            // 
            // lbUltimoLogin
            // 
            lbUltimoLogin.AutoSize = true;
            lbUltimoLogin.Location = new Point(226, 3);
            lbUltimoLogin.Margin = new Padding(4, 0, 4, 0);
            lbUltimoLogin.Name = "lbUltimoLogin";
            lbUltimoLogin.Size = new Size(76, 15);
            lbUltimoLogin.TabIndex = 7;
            lbUltimoLogin.Text = "Último Login";
            // 
            // dtUltimoLogin
            // 
            dtUltimoLogin.CustomFormat = "dd/MM/yyyy HH:mm";
            dtUltimoLogin.Enabled = false;
            dtUltimoLogin.ForeColor = Color.Black;
            dtUltimoLogin.Format = DateTimePickerFormat.Custom;
            dtUltimoLogin.Location = new Point(226, 21);
            dtUltimoLogin.Name = "dtUltimoLogin";
            dtUltimoLogin.Size = new Size(134, 23);
            dtUltimoLogin.TabIndex = 6;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(367, 91);
            lbSenha.Margin = new Padding(4, 0, 4, 0);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 4;
            lbSenha.Text = "Senha";
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(366, 109);
            tbSenha.Margin = new Padding(4, 3, 4, 3);
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.Size = new Size(350, 23);
            tbSenha.TabIndex = 5;
            tbSenha.UseSystemPasswordChar = true;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(367, 23);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 3;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnOk);
            panelBottom.Controls.Add(btnCancelar);
            panelBottom.Controls.Add(btnSalvar);
            panelBottom.Controls.Add(flowButtons);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 325);
            panelBottom.Margin = new Padding(4, 3, 4, 3);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(734, 46);
            panelBottom.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.AutoSize = true;
            btnOk.Location = new Point(546, 6);
            btnOk.Margin = new Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(88, 29);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Location = new Point(642, 6);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.Location = new Point(450, 6);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 29);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // flowButtons
            // 
            flowButtons.AutoSize = true;
            flowButtons.Dock = DockStyle.Right;
            flowButtons.FlowDirection = FlowDirection.RightToLeft;
            flowButtons.Location = new Point(722, 0);
            flowButtons.Margin = new Padding(4, 3, 4, 3);
            flowButtons.Name = "flowButtons";
            flowButtons.Padding = new Padding(6);
            flowButtons.Size = new Size(12, 46);
            flowButtons.TabIndex = 0;
            // 
            // FormCadastroUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 371);
            Controls.Add(tabControl1);
            Controls.Add(panelBottom);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCadastroUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuário";
            Load += FormCadastroUsuarios_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);

        }

        private CheckBox chkAtivo;
        private Label lbSenha;
        private TextBox tbSenha;
        private DateTimePicker dtUltimoLogin;
        private System.ComponentModel.IContainer components = null;
        private Label lbNome;
        private TextBox tbNome;
        private Label lbCodUsuario;
        private TextBox tbCodUsuario;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panelBottom;
        private Button btnOk;
        private Button btnCancelar;
        private Button btnSalvar;
        private FlowLayoutPanel flowButtons;
        private Label lbUltimoLogin;
        private Label lbUsuario;
        private TextBox tbUsuario;
    }
}
