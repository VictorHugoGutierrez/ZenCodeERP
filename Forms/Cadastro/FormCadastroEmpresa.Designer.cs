namespace ZenCodeERP.Forms.Cadastro
{
    partial class FormCadastroEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lbNomeFantasia = new Label();
            tbNomeFantasia = new TextBox();
            gpContato = new GroupBox();
            lbEmail = new Label();
            tbEmail = new TextBox();
            lbTelefone = new Label();
            tbTelefone = new TextBox();
            lbCNPJ = new Label();
            tbCNPJ = new TextBox();
            lbNome = new Label();
            tbNome = new TextBox();
            pictureBox1 = new PictureBox();
            lbCodEmpresa = new Label();
            tbCodEmpresa = new TextBox();
            panelBottom = new Panel();
            btnOk = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            flowButtons = new FlowLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            gpContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
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
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbNomeFantasia);
            tabPage1.Controls.Add(tbNomeFantasia);
            tabPage1.Controls.Add(gpContato);
            tabPage1.Controls.Add(lbCNPJ);
            tabPage1.Controls.Add(tbCNPJ);
            tabPage1.Controls.Add(lbNome);
            tabPage1.Controls.Add(tbNome);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(lbCodEmpresa);
            tabPage1.Controls.Add(tbCodEmpresa);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(726, 297);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Identificação";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbNomeFantasia
            // 
            lbNomeFantasia.AutoSize = true;
            lbNomeFantasia.Location = new Point(9, 85);
            lbNomeFantasia.Margin = new Padding(4, 0, 4, 0);
            lbNomeFantasia.Name = "lbNomeFantasia";
            lbNomeFantasia.Size = new Size(86, 15);
            lbNomeFantasia.TabIndex = 11;
            lbNomeFantasia.Text = "Nome Fantasia";
            // 
            // tbNomeFantasia
            // 
            tbNomeFantasia.Location = new Point(9, 100);
            tbNomeFantasia.Margin = new Padding(4, 3, 4, 3);
            tbNomeFantasia.Name = "tbNomeFantasia";
            tbNomeFantasia.Size = new Size(457, 23);
            tbNomeFantasia.TabIndex = 12;
            // 
            // gpContato
            // 
            gpContato.Controls.Add(lbEmail);
            gpContato.Controls.Add(tbEmail);
            gpContato.Controls.Add(lbTelefone);
            gpContato.Controls.Add(tbTelefone);
            gpContato.Location = new Point(9, 131);
            gpContato.Name = "gpContato";
            gpContato.Size = new Size(457, 122);
            gpContato.TabIndex = 10;
            gpContato.TabStop = false;
            gpContato.Text = "Contato";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(7, 60);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 13;
            lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(7, 75);
            tbEmail.Margin = new Padding(4, 3, 4, 3);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(443, 23);
            tbEmail.TabIndex = 14;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(7, 19);
            lbTelefone.Margin = new Padding(4, 0, 4, 0);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(52, 15);
            lbTelefone.TabIndex = 13;
            lbTelefone.Text = "Telefone";
            // 
            // tbTelefone
            // 
            tbTelefone.Location = new Point(7, 34);
            tbTelefone.Margin = new Padding(4, 3, 4, 3);
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(202, 23);
            tbTelefone.TabIndex = 14;
            // 
            // lbCNPJ
            // 
            lbCNPJ.AutoSize = true;
            lbCNPJ.Location = new Point(159, 3);
            lbCNPJ.Margin = new Padding(4, 0, 4, 0);
            lbCNPJ.Name = "lbCNPJ";
            lbCNPJ.Size = new Size(34, 15);
            lbCNPJ.TabIndex = 8;
            lbCNPJ.Text = "CNPJ";
            // 
            // tbCNPJ
            // 
            tbCNPJ.Location = new Point(159, 18);
            tbCNPJ.Margin = new Padding(4, 3, 4, 3);
            tbCNPJ.Name = "tbCNPJ";
            tbCNPJ.Size = new Size(202, 23);
            tbCNPJ.TabIndex = 9;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(9, 44);
            lbNome.Margin = new Padding(4, 0, 4, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 6;
            lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(9, 59);
            tbNome.Margin = new Padding(4, 3, 4, 3);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(457, 23);
            tbNome.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(483, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 235);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lbCodEmpresa
            // 
            lbCodEmpresa.AutoSize = true;
            lbCodEmpresa.Location = new Point(9, 3);
            lbCodEmpresa.Margin = new Padding(4, 0, 4, 0);
            lbCodEmpresa.Name = "lbCodEmpresa";
            lbCodEmpresa.Size = new Size(80, 15);
            lbCodEmpresa.TabIndex = 3;
            lbCodEmpresa.Text = "Cód. Empresa";
            // 
            // tbCodEmpresa
            // 
            tbCodEmpresa.ReadOnly = true;
            tbCodEmpresa.Location = new Point(9, 18);
            tbCodEmpresa.Margin = new Padding(4, 3, 4, 3);
            tbCodEmpresa.Name = "tbCodEmpresa";
            tbCodEmpresa.Size = new Size(142, 23);
            tbCodEmpresa.TabIndex = 4;
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
            panelBottom.TabIndex = 6;
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
            btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            // FormCadastroEmpresa
            // 
            Load += new System.EventHandler(this.FormCadastroEmpresa_Load);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 371);
            Controls.Add(tabControl1);
            Controls.Add(panelBottom);
            Name = "FormCadastroEmpresa";
            Text = "FormCadastroEmpresa";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            gpContato.ResumeLayout(false);
            gpContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panelBottom;
        private Button btnOk;
        private Button btnCancelar;
        private Button btnSalvar;
        private FlowLayoutPanel flowButtons;
        private Label lbCodEmpresa;
        private TextBox tbCodEmpresa;
        private Label lbNome;
        private TextBox tbNome;
        private PictureBox pictureBox1;
        private Label lbCNPJ;
        private TextBox tbCNPJ;
        private Label lbNomeFantasia;
        private TextBox tbNomeFantasia;
        private GroupBox gpContato;
        private Label lbEmail;
        private TextBox tbEmail;
        private Label lbTelefone;
        private TextBox tbTelefone;
    }
}