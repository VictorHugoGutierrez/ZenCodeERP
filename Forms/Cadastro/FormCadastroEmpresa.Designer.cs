using FontAwesome.Sharp;
using Org.BouncyCastle.Crypto;
using System.Windows.Forms;

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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            iBtnRemoverImagem = new IconButton();
            btnLookupEndereco = new Button();
            lbEndereco = new Label();
            tbNomeEndereco = new TextBox();
            tbCodigoEndereco = new TextBox();
            iBtnCarregarImagem = new IconButton();
            lbNomeFantasia = new Label();
            tbNomeFantasia = new TextBox();
            gpContato = new GroupBox();
            lbEmail = new Label();
            tbEmail = new TextBox();
            lbTelefone = new Label();
            tbTelefone = new TextBox();
            lbCNPJ = new Label();
            tbCNPJ = new MaskedTextBox();
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
            openFileDialog1 = new OpenFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
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
            tabPage1.Controls.Add(iBtnRemoverImagem);
            tabPage1.Controls.Add(btnLookupEndereco);
            tabPage1.Controls.Add(lbEndereco);
            tabPage1.Controls.Add(tbNomeEndereco);
            tabPage1.Controls.Add(tbCodigoEndereco);
            tabPage1.Controls.Add(iBtnCarregarImagem);
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
            // iBtnRemoverImagem
            // 
            iBtnRemoverImagem.IconChar = IconChar.FileExcel;
            iBtnRemoverImagem.IconColor = Color.Red;
            iBtnRemoverImagem.IconFont = IconFont.Auto;
            iBtnRemoverImagem.IconSize = 26;
            iBtnRemoverImagem.Location = new Point(561, 258);
            iBtnRemoverImagem.Margin = new Padding(3, 2, 3, 2);
            iBtnRemoverImagem.Name = "iBtnRemoverImagem";
            iBtnRemoverImagem.Size = new Size(158, 30);
            iBtnRemoverImagem.TabIndex = 18;
            iBtnRemoverImagem.Text = "Remover Imagem";
            iBtnRemoverImagem.TextImageRelation = TextImageRelation.ImageBeforeText;
            iBtnRemoverImagem.UseVisualStyleBackColor = true;
            iBtnRemoverImagem.Click += iBtnRemoverImage_Click;
            // 
            // btnLookupEndereco
            // 
            btnLookupEndereco.Location = new Point(105, 150);
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
            lbEndereco.Location = new Point(9, 132);
            lbEndereco.Name = "lbEndereco";
            lbEndereco.Size = new Size(56, 15);
            lbEndereco.TabIndex = 16;
            lbEndereco.Text = "Endereço";
            // 
            // tbNomeEndereco
            // 
            tbNomeEndereco.Enabled = false;
            tbNomeEndereco.Location = new Point(155, 149);
            tbNomeEndereco.Margin = new Padding(3, 2, 3, 2);
            tbNomeEndereco.Name = "tbNomeEndereco";
            tbNomeEndereco.Size = new Size(235, 23);
            tbNomeEndereco.TabIndex = 15;
            // 
            // tbCodigoEndereco
            // 
            tbCodigoEndereco.Location = new Point(9, 149);
            tbCodigoEndereco.Margin = new Padding(3, 2, 3, 2);
            tbCodigoEndereco.Name = "tbCodigoEndereco";
            tbCodigoEndereco.Size = new Size(90, 23);
            tbCodigoEndereco.TabIndex = 14;
            tbCodigoEndereco.Leave += tbCodigoEndereco_Leave;
            // 
            // iBtnCarregarImagem
            // 
            iBtnCarregarImagem.IconChar = IconChar.File;
            iBtnCarregarImagem.IconColor = Color.DodgerBlue;
            iBtnCarregarImagem.IconFont = IconFont.Auto;
            iBtnCarregarImagem.IconSize = 26;
            iBtnCarregarImagem.Location = new Point(396, 258);
            iBtnCarregarImagem.Margin = new Padding(3, 2, 3, 2);
            iBtnCarregarImagem.Name = "iBtnCarregarImagem";
            iBtnCarregarImagem.Size = new Size(158, 30);
            iBtnCarregarImagem.TabIndex = 13;
            iBtnCarregarImagem.Text = "Carregar Imagem";
            iBtnCarregarImagem.TextImageRelation = TextImageRelation.ImageBeforeText;
            iBtnCarregarImagem.UseVisualStyleBackColor = true;
            iBtnCarregarImagem.Click += iBtnCarregarImagem_Click;
            // 
            // lbNomeFantasia
            // 
            lbNomeFantasia.AutoSize = true;
            lbNomeFantasia.Location = new Point(9, 88);
            lbNomeFantasia.Margin = new Padding(4, 0, 4, 0);
            lbNomeFantasia.Name = "lbNomeFantasia";
            lbNomeFantasia.Size = new Size(86, 15);
            lbNomeFantasia.TabIndex = 11;
            lbNomeFantasia.Text = "Nome Fantasia";
            // 
            // tbNomeFantasia
            // 
            tbNomeFantasia.Location = new Point(9, 106);
            tbNomeFantasia.Margin = new Padding(4, 3, 4, 3);
            tbNomeFantasia.Name = "tbNomeFantasia";
            tbNomeFantasia.Size = new Size(381, 23);
            tbNomeFantasia.TabIndex = 12;
            // 
            // gpContato
            // 
            gpContato.Controls.Add(lbEmail);
            gpContato.Controls.Add(tbEmail);
            gpContato.Controls.Add(lbTelefone);
            gpContato.Controls.Add(tbTelefone);
            gpContato.Location = new Point(9, 173);
            gpContato.Name = "gpContato";
            gpContato.Size = new Size(381, 115);
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
            tbEmail.Size = new Size(367, 23);
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
            tbCNPJ.Mask = "00.000.000/0000-00";
            tbCNPJ.Name = "tbCNPJ";
            tbCNPJ.Size = new Size(231, 23);
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
            tbNome.Location = new Point(9, 62);
            tbNome.Margin = new Padding(4, 3, 4, 3);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(381, 23);
            tbNome.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(398, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            flowButtons.Padding = new Padding(6);
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
            // FormCadastroEmpresa
            // 
            Icon = global::ZenCodeERP.Properties.Resources.iconZenCode; 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 371);
            Controls.Add(tabControl1);
            Controls.Add(panelBottom);
            Name = "FormCadastroEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Empresa";
            Load += FormCadastroEmpresa_Load;
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
        private MaskedTextBox tbCNPJ;
        private Label lbNomeFantasia;
        private TextBox tbNomeFantasia;
        private GroupBox gpContato;
        private Label lbEmail;
        private TextBox tbEmail;
        private Label lbTelefone;
        private TextBox tbTelefone;
        private IconButton iBtnCarregarImagem;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnLookupEndereco;
        private Label lbEndereco;
        private TextBox tbNomeEndereco;
        private TextBox tbCodigoEndereco;
        private IconButton iBtnRemoverImagem;
    }
}