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
            cbTipoCadastro = new ComboBox();
            cbTipoPessoa = new ComboBox();
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
            lbTipoCadastro = new Label();
            lbTipoPessoa = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            gpContato.SuspendLayout();
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
            tabPage1.Controls.Add(lbTipoPessoa);
            tabPage1.Controls.Add(lbTipoCadastro);
            tabPage1.Controls.Add(cbTipoPessoa);
            tabPage1.Controls.Add(cbTipoCadastro);
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(726, 297);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Identificação";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbTipoCadastro
            // 
            cbTipoCadastro.FormattingEnabled = true;
            cbTipoCadastro.Location = new Point(437, 155);
            cbTipoCadastro.Margin = new Padding(3, 2, 3, 2);
            cbTipoCadastro.Name = "cbTipoCadastro";
            cbTipoCadastro.Size = new Size(133, 23);
            cbTipoCadastro.TabIndex = 0;
            // 
            // cbTipoPessoa
            // 
            cbTipoPessoa.FormattingEnabled = true;
            cbTipoPessoa.Location = new Point(575, 155);
            cbTipoPessoa.Margin = new Padding(3, 2, 3, 2);
            cbTipoPessoa.Name = "cbTipoPessoa";
            cbTipoPessoa.Size = new Size(133, 23);
            cbTipoPessoa.TabIndex = 1;
            cbTipoPessoa.SelectedIndexChanged += cbTipoPessoa_SelectedIndexChanged;
            // 
            // lbNomeFantasia
            // 
            lbNomeFantasia.AutoSize = true;
            lbNomeFantasia.Location = new Point(9, 92);
            lbNomeFantasia.Margin = new Padding(4, 0, 4, 0);
            lbNomeFantasia.Name = "lbNomeFantasia";
            lbNomeFantasia.Size = new Size(86, 15);
            lbNomeFantasia.TabIndex = 18;
            lbNomeFantasia.Text = "Nome Fantasia";
            // 
            // tbNomeFantasia
            // 
            tbNomeFantasia.Location = new Point(9, 110);
            tbNomeFantasia.Margin = new Padding(4, 3, 4, 3);
            tbNomeFantasia.Name = "tbNomeFantasia";
            tbNomeFantasia.Size = new Size(700, 23);
            tbNomeFantasia.TabIndex = 19;
            // 
            // btnLookupEndereco
            // 
            btnLookupEndereco.Location = new Point(105, 156);
            btnLookupEndereco.Margin = new Padding(3, 2, 3, 2);
            btnLookupEndereco.Name = "btnLookupEndereco";
            btnLookupEndereco.Size = new Size(44, 22);
            btnLookupEndereco.TabIndex = 17;
            btnLookupEndereco.Text = "...";
            btnLookupEndereco.UseVisualStyleBackColor = true;
            btnLookupEndereco.Click += btnLookupEndereco_Click;
            // 
            // lbEndereco
            // 
            lbEndereco.AutoSize = true;
            lbEndereco.Location = new Point(9, 138);
            lbEndereco.Name = "lbEndereco";
            lbEndereco.Size = new Size(56, 15);
            lbEndereco.TabIndex = 16;
            lbEndereco.Text = "Endereço";
            // 
            // tbNomeEndereco
            // 
            tbNomeEndereco.Enabled = false;
            tbNomeEndereco.Location = new Point(155, 155);
            tbNomeEndereco.Margin = new Padding(3, 2, 3, 2);
            tbNomeEndereco.Name = "tbNomeEndereco";
            tbNomeEndereco.Size = new Size(276, 23);
            tbNomeEndereco.TabIndex = 15;
            // 
            // tbCodigoEndereco
            // 
            tbCodigoEndereco.Location = new Point(9, 155);
            tbCodigoEndereco.Margin = new Padding(3, 2, 3, 2);
            tbCodigoEndereco.Name = "tbCodigoEndereco";
            tbCodigoEndereco.Size = new Size(90, 23);
            tbCodigoEndereco.TabIndex = 14;
            tbCodigoEndereco.Leave += tbCodigoEndereco_Leave;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(9, 44);
            lbNome.Margin = new Padding(4, 0, 4, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 11;
            lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(9, 62);
            tbNome.Margin = new Padding(4, 3, 4, 3);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(700, 23);
            tbNome.TabIndex = 12;
            // 
            // gpContato
            // 
            gpContato.Controls.Add(tbTelefone);
            gpContato.Controls.Add(lbEmail);
            gpContato.Controls.Add(tbEmail);
            gpContato.Controls.Add(lbTelefone);
            gpContato.Location = new Point(9, 183);
            gpContato.Name = "gpContato";
            gpContato.Size = new Size(699, 108);
            gpContato.TabIndex = 10;
            gpContato.TabStop = false;
            gpContato.Text = "Contato";
            // 
            // tbTelefone
            // 
            tbTelefone.Location = new Point(6, 35);
            tbTelefone.Margin = new Padding(3, 2, 3, 2);
            tbTelefone.Mask = "(00) 00000-0000";
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(686, 23);
            tbTelefone.TabIndex = 17;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(6, 61);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 15;
            lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(6, 79);
            tbEmail.Margin = new Padding(4, 3, 4, 3);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(686, 23);
            tbEmail.TabIndex = 16;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(4, 19);
            lbTelefone.Margin = new Padding(4, 0, 4, 0);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(52, 15);
            lbTelefone.TabIndex = 13;
            lbTelefone.Text = "Telefone";
            // 
            // lbCNPJ
            // 
            lbCNPJ.AutoSize = true;
            lbCNPJ.Location = new Point(340, 3);
            lbCNPJ.Margin = new Padding(4, 0, 4, 0);
            lbCNPJ.Name = "lbCNPJ";
            lbCNPJ.Size = new Size(60, 15);
            lbCNPJ.TabIndex = 8;
            lbCNPJ.Text = "CNPJ/CPF";
            // 
            // tbCNPJ
            // 
            tbCNPJ.Location = new Point(339, 18);
            tbCNPJ.Margin = new Padding(4, 3, 4, 3);
            tbCNPJ.Mask = "00.000.000/0000-00";
            tbCNPJ.Name = "tbCNPJ";
            tbCNPJ.Size = new Size(370, 23);
            tbCNPJ.TabIndex = 9;
            // 
            // lbCodCliFor
            // 
            lbCodCliFor.AutoSize = true;
            lbCodCliFor.Location = new Point(172, 3);
            lbCodCliFor.Margin = new Padding(4, 0, 4, 0);
            lbCodCliFor.Name = "lbCodCliFor";
            lbCodCliFor.Size = new Size(132, 15);
            lbCodCliFor.TabIndex = 6;
            lbCodCliFor.Text = "Cod. ClienteFornecedor";
            // 
            // tbCodCliFor
            // 
            tbCodCliFor.Location = new Point(172, 18);
            tbCodCliFor.Margin = new Padding(4, 3, 4, 3);
            tbCodCliFor.Name = "tbCodCliFor";
            tbCodCliFor.ReadOnly = true;
            tbCodCliFor.Size = new Size(144, 23);
            tbCodCliFor.TabIndex = 7;
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
            tbCodEmpresa.Location = new Point(9, 18);
            tbCodEmpresa.Margin = new Padding(4, 3, 4, 3);
            tbCodEmpresa.Name = "tbCodEmpresa";
            tbCodEmpresa.ReadOnly = true;
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
            btnOk.Size = new Size(88, 30);
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
            btnCancelar.Size = new Size(88, 30);
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
            btnSalvar.Size = new Size(88, 30);
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
            flowButtons.Padding = new Padding(6, 6, 6, 6);
            flowButtons.Size = new Size(12, 46);
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
            // lbTipoCadastro
            // 
            lbTipoCadastro.AutoSize = true;
            lbTipoCadastro.Location = new Point(437, 138);
            lbTipoCadastro.Name = "lbTipoCadastro";
            lbTipoCadastro.Size = new Size(81, 15);
            lbTipoCadastro.TabIndex = 20;
            lbTipoCadastro.Text = "Tipo Cadastro";
            // 
            // lbTipoPessoa
            // 
            lbTipoPessoa.AutoSize = true;
            lbTipoPessoa.Location = new Point(575, 138);
            lbTipoPessoa.Name = "lbTipoPessoa";
            lbTipoPessoa.Size = new Size(70, 15);
            lbTipoPessoa.TabIndex = 21;
            lbTipoPessoa.Text = "Tipo Pessoa";
            // 
            // FormCadastroClienteFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 371);
            Controls.Add(tabControl1);
            Controls.Add(panelBottom);
            Icon = Properties.Resources.iconZenCode;
            Name = "FormCadastroClienteFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente Fornecedor";
            Load += FormCadastroClienteFornecedor_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
        private ComboBox cbTipoPessoa;
        private ComboBox cbTipoCadastro;
        private Label lbEmail;
        private TextBox tbEmail;
        private MaskedTextBox tbTelefone;
        private Label lbTipoCadastro;
        private Label lbTipoPessoa;
    }
}