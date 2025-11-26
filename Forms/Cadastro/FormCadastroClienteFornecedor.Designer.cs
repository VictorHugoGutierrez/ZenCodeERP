using FontAwesome.Sharp;
using Org.BouncyCastle.Crypto;
using System.Windows.Forms;

namespace ZenCodeERP.Forms.Cadastro
{
    partial class FormCadastroClienteFornecedor
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            cbTipoPessoa = new ComboBox();
            gbTipoCadastro = new GroupBox();
            cbTipoCadastro = new ComboBox();
            lbNomeFantasia = new Label();
            tbNomeFantasia = new TextBox();
            btnLookupEndereco = new Button();
            lbEndereco = new Label();
            tbNomeEndereco = new TextBox();
            tbCodigoEndereco = new TextBox();
            lbNome = new Label();
            tbNome = new TextBox();
            gpContato = new GroupBox();
            tbTelefone = new MaskedTextBox();
            lbEmail = new Label();
            tbEmail = new TextBox();
            lbTelefone = new Label();
            lbCNPJ = new Label();
            tbCNPJ = new MaskedTextBox();
            lbCodCliFor = new Label();
            tbCodCliFor = new TextBox();
            lbCodEmpresa = new Label();
            tbCodEmpresa = new TextBox();
            panelBottom = new Panel();
            btnOk = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            flowButtons = new FlowLayoutPanel();
            openFileDialog1 = new OpenFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            gbTipoCadastro.SuspendLayout();
            gpContato.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(5, 4, 5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(839, 434);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(gbTipoCadastro);
            tabPage1.Controls.Add(lbNomeFantasia);
            tabPage1.Controls.Add(tbNomeFantasia);
            tabPage1.Controls.Add(btnLookupEndereco);
            tabPage1.Controls.Add(lbEndereco);
            tabPage1.Controls.Add(tbNomeEndereco);
            tabPage1.Controls.Add(tbCodigoEndereco);
            tabPage1.Controls.Add(lbNome);
            tabPage1.Controls.Add(tbNome);
            tabPage1.Controls.Add(gpContato);
            tabPage1.Controls.Add(lbCNPJ);
            tabPage1.Controls.Add(tbCNPJ);
            tabPage1.Controls.Add(lbCodCliFor);
            tabPage1.Controls.Add(tbCodCliFor);
            tabPage1.Controls.Add(lbCodEmpresa);
            tabPage1.Controls.Add(tbCodEmpresa);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(5, 4, 5, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5, 4, 5, 4);
            tabPage1.Size = new Size(831, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Identificação";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbTipoPessoa);
            groupBox2.Location = new Point(642, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 71);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo Pessoa";
            // 
            // cbTipoPessoa
            // 
            cbTipoPessoa.FormattingEnabled = true;
            cbTipoPessoa.Location = new Point(7, 28);
            cbTipoPessoa.Name = "cbTipoPessoa";
            cbTipoPessoa.Size = new Size(151, 28);
            cbTipoPessoa.TabIndex = 1;
            cbTipoPessoa.SelectedIndexChanged += cbTipoPessoa_SelectedIndexChanged;
            // 
            // gbTipoCadastro
            // 
            gbTipoCadastro.Controls.Add(cbTipoCadastro);
            gbTipoCadastro.Location = new Point(461, 181);
            gbTipoCadastro.Name = "gbTipoCadastro";
            gbTipoCadastro.Size = new Size(164, 71);
            gbTipoCadastro.TabIndex = 20;
            gbTipoCadastro.TabStop = false;
            gbTipoCadastro.Text = "Tipo do Cadastro";
            // 
            // cbTipoCadastro
            // 
            cbTipoCadastro.FormattingEnabled = true;
            cbTipoCadastro.Location = new Point(7, 28);
            cbTipoCadastro.Name = "cbTipoCadastro";
            cbTipoCadastro.Size = new Size(151, 28);
            cbTipoCadastro.TabIndex = 0;
            // 
            // lbNomeFantasia
            // 
            lbNomeFantasia.AutoSize = true;
            lbNomeFantasia.Location = new Point(10, 123);
            lbNomeFantasia.Margin = new Padding(5, 0, 5, 0);
            lbNomeFantasia.Name = "lbNomeFantasia";
            lbNomeFantasia.Size = new Size(107, 20);
            lbNomeFantasia.TabIndex = 18;
            lbNomeFantasia.Text = "Nome Fantasia";
            // 
            // tbNomeFantasia
            // 
            tbNomeFantasia.Location = new Point(10, 147);
            tbNomeFantasia.Margin = new Padding(5, 4, 5, 4);
            tbNomeFantasia.Name = "tbNomeFantasia";
            tbNomeFantasia.Size = new Size(799, 27);
            tbNomeFantasia.TabIndex = 19;
            // 
            // btnLookupEndereco
            // 
            btnLookupEndereco.Location = new Point(120, 208);
            btnLookupEndereco.Name = "btnLookupEndereco";
            btnLookupEndereco.Size = new Size(50, 29);
            btnLookupEndereco.TabIndex = 17;
            btnLookupEndereco.Text = "...";
            btnLookupEndereco.UseVisualStyleBackColor = true;
            btnLookupEndereco.Click += btnLookupEndereco_Click;
            // 
            // lbEndereco
            // 
            lbEndereco.AutoSize = true;
            lbEndereco.Location = new Point(10, 184);
            lbEndereco.Name = "lbEndereco";
            lbEndereco.Size = new Size(71, 20);
            lbEndereco.TabIndex = 16;
            lbEndereco.Text = "Endereço";
            // 
            // tbNomeEndereco
            // 
            tbNomeEndereco.Enabled = false;
            tbNomeEndereco.Location = new Point(177, 207);
            tbNomeEndereco.Name = "tbNomeEndereco";
            tbNomeEndereco.Size = new Size(268, 27);
            tbNomeEndereco.TabIndex = 15;
            // 
            // tbCodigoEndereco
            // 
            tbCodigoEndereco.Location = new Point(10, 207);
            tbCodigoEndereco.Name = "tbCodigoEndereco";
            tbCodigoEndereco.Size = new Size(102, 27);
            tbCodigoEndereco.TabIndex = 14;
            tbCodigoEndereco.Leave += tbCodigoEndereco_Leave;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(10, 59);
            lbNome.Margin = new Padding(5, 0, 5, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(50, 20);
            lbNome.TabIndex = 11;
            lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(10, 83);
            tbNome.Margin = new Padding(5, 4, 5, 4);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(799, 27);
            tbNome.TabIndex = 12;
            // 
            // gpContato
            // 
            gpContato.Controls.Add(tbTelefone);
            gpContato.Controls.Add(lbEmail);
            gpContato.Controls.Add(tbEmail);
            gpContato.Controls.Add(lbTelefone);
            gpContato.Location = new Point(10, 255);
            gpContato.Margin = new Padding(3, 4, 3, 4);
            gpContato.Name = "gpContato";
            gpContato.Padding = new Padding(3, 4, 3, 4);
            gpContato.Size = new Size(799, 134);
            gpContato.TabIndex = 10;
            gpContato.TabStop = false;
            gpContato.Text = "Contato";
            // 
            // tbTelefone
            // 
            tbTelefone.Location = new Point(7, 50);
            tbTelefone.Mask = "(00) 00000-0000";
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(783, 27);
            tbTelefone.TabIndex = 17;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(7, 80);
            lbEmail.Margin = new Padding(5, 0, 5, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 15;
            lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(7, 100);
            tbEmail.Margin = new Padding(5, 4, 5, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(783, 27);
            tbEmail.TabIndex = 16;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(7, 29);
            lbTelefone.Margin = new Padding(5, 0, 5, 0);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(66, 20);
            lbTelefone.TabIndex = 13;
            lbTelefone.Text = "Telefone";
            // 
            // lbCNPJ
            // 
            lbCNPJ.AutoSize = true;
            lbCNPJ.Location = new Point(388, 4);
            lbCNPJ.Margin = new Padding(5, 0, 5, 0);
            lbCNPJ.Name = "lbCNPJ";
            lbCNPJ.Size = new Size(71, 20);
            lbCNPJ.TabIndex = 8;
            lbCNPJ.Text = "CNPJ/CPF";
            // 
            // tbCNPJ
            // 
            tbCNPJ.Location = new Point(387, 24);
            tbCNPJ.Margin = new Padding(5, 4, 5, 4);
            tbCNPJ.Mask = "00.000.000/0000-00";
            tbCNPJ.Name = "tbCNPJ";
            tbCNPJ.Size = new Size(422, 27);
            tbCNPJ.TabIndex = 9;
            // 
            // lbCodCliFor
            // 
            lbCodCliFor.AutoSize = true;
            lbCodCliFor.Location = new Point(197, 4);
            lbCodCliFor.Margin = new Padding(5, 0, 5, 0);
            lbCodCliFor.Name = "lbCodCliFor";
            lbCodCliFor.Size = new Size(164, 20);
            lbCodCliFor.TabIndex = 6;
            lbCodCliFor.Text = "Cod. ClienteFornecedor";
            // 
            // tbCodCliFor
            // 
            tbCodCliFor.Location = new Point(197, 24);
            tbCodCliFor.Margin = new Padding(5, 4, 5, 4);
            tbCodCliFor.Name = "tbCodCliFor";
            tbCodCliFor.Size = new Size(164, 27);
            tbCodCliFor.TabIndex = 7;
            // 
            // lbCodEmpresa
            // 
            lbCodEmpresa.AutoSize = true;
            lbCodEmpresa.Location = new Point(10, 4);
            lbCodEmpresa.Margin = new Padding(5, 0, 5, 0);
            lbCodEmpresa.Name = "lbCodEmpresa";
            lbCodEmpresa.Size = new Size(100, 20);
            lbCodEmpresa.TabIndex = 3;
            lbCodEmpresa.Text = "Cód. Empresa";
            // 
            // tbCodEmpresa
            // 
            tbCodEmpresa.Location = new Point(10, 24);
            tbCodEmpresa.Margin = new Padding(5, 4, 5, 4);
            tbCodEmpresa.Name = "tbCodEmpresa";
            tbCodEmpresa.ReadOnly = true;
            tbCodEmpresa.Size = new Size(162, 27);
            tbCodEmpresa.TabIndex = 4;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnOk);
            panelBottom.Controls.Add(btnCancelar);
            panelBottom.Controls.Add(btnSalvar);
            panelBottom.Controls.Add(flowButtons);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 434);
            panelBottom.Margin = new Padding(5, 4, 5, 4);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(839, 61);
            panelBottom.TabIndex = 6;
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
            flowButtons.Location = new Point(825, 0);
            flowButtons.Margin = new Padding(5, 4, 5, 4);
            flowButtons.Name = "flowButtons";
            flowButtons.Padding = new Padding(7, 8, 7, 8);
            flowButtons.Size = new Size(14, 61);
            flowButtons.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";
            openFileDialog1.Title = "Selecione uma Imagem";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormCadastroClienteFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 495);
            Controls.Add(tabControl1);
            Controls.Add(panelBottom);
            Icon = Properties.Resources.iconZenCode;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCadastroClienteFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente Fornecedor";
            Load += FormCadastroClienteFornecedor_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            gbTipoCadastro.ResumeLayout(false);
            gpContato.ResumeLayout(false);
            gpContato.PerformLayout();
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
        private Label lbCodCliFor;
        private TextBox tbCodCliFor;
        private Label lbCNPJ;
        private MaskedTextBox tbCNPJ;
        private Label lbNome;
        private TextBox tbNome;
        private GroupBox gpContato;
        private Label lbTelefone;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnLookupEndereco;
        private Label lbEndereco;
        private TextBox tbNomeEndereco;
        private TextBox tbCodigoEndereco;
        private Label lbNomeFantasia;
        private TextBox tbNomeFantasia;
        private GroupBox groupBox2;
        private GroupBox gbTipoCadastro;
        private ComboBox cbTipoPessoa;
        private ComboBox cbTipoCadastro;
        private Label lbEmail;
        private TextBox tbEmail;
        private MaskedTextBox tbTelefone;
    }
}