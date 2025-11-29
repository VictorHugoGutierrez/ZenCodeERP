using FontAwesome.Sharp;
using Org.BouncyCastle.Crypto;
using System.Windows.Forms;

namespace ZenCodeERP.Forms.Cadastro
{
    partial class FormCadastroProduto
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
            lbPrecoUnitario = new Label();
            lbDescricao = new Label();
            rtbDescricao = new RichTextBox();
            chkAtivo = new CheckBox();
            lbTipoProduto = new Label();
            cbTipoProduto = new ComboBox();
            btnLookupClassificacao = new Button();
            lbClassificacao = new Label();
            tbNomeClassificacao = new TextBox();
            tbCodClassificacao = new TextBox();
            lbNome = new Label();
            tbNome = new TextBox();
            lbCodProduto = new Label();
            tbCodProduto = new TextBox();
            lbCodEmpresa = new Label();
            tbCodEmpresa = new TextBox();
            panelBottom = new Panel();
            btnOk = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            tbPrecoUnitario = new MaskedTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabPage1.Controls.Add(tbPrecoUnitario);
            tabPage1.Controls.Add(lbPrecoUnitario);
            tabPage1.Controls.Add(lbDescricao);
            tabPage1.Controls.Add(rtbDescricao);
            tabPage1.Controls.Add(chkAtivo);
            tabPage1.Controls.Add(lbTipoProduto);
            tabPage1.Controls.Add(cbTipoProduto);
            tabPage1.Controls.Add(btnLookupClassificacao);
            tabPage1.Controls.Add(lbClassificacao);
            tabPage1.Controls.Add(tbNomeClassificacao);
            tabPage1.Controls.Add(tbCodClassificacao);
            tabPage1.Controls.Add(lbNome);
            tabPage1.Controls.Add(tbNome);
            tabPage1.Controls.Add(lbCodProduto);
            tabPage1.Controls.Add(tbCodProduto);
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
            // lbPrecoUnitario
            // 
            lbPrecoUnitario.AutoSize = true;
            lbPrecoUnitario.Location = new Point(9, 138);
            lbPrecoUnitario.Name = "lbPrecoUnitario";
            lbPrecoUnitario.Size = new Size(82, 15);
            lbPrecoUnitario.TabIndex = 26;
            lbPrecoUnitario.Text = "Preço Unitário";
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Location = new Point(9, 182);
            lbDescricao.Margin = new Padding(4, 0, 4, 0);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(58, 15);
            lbDescricao.TabIndex = 24;
            lbDescricao.Text = "Descrição";
            // 
            // rtbDescricao
            // 
            rtbDescricao.Location = new Point(8, 200);
            rtbDescricao.Name = "rtbDescricao";
            rtbDescricao.Size = new Size(700, 91);
            rtbDescricao.TabIndex = 23;
            rtbDescricao.Text = "";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(452, 23);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 22;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // lbTipoProduto
            // 
            lbTipoProduto.AutoSize = true;
            lbTipoProduto.Location = new Point(310, 3);
            lbTipoProduto.Name = "lbTipoProduto";
            lbTipoProduto.Size = new Size(77, 15);
            lbTipoProduto.TabIndex = 21;
            lbTipoProduto.Text = "Tipo Produto";
            // 
            // cbTipoProduto
            // 
            cbTipoProduto.FormattingEnabled = true;
            cbTipoProduto.Location = new Point(310, 21);
            cbTipoProduto.Margin = new Padding(3, 2, 3, 2);
            cbTipoProduto.Name = "cbTipoProduto";
            cbTipoProduto.Size = new Size(133, 23);
            cbTipoProduto.TabIndex = 1;
            // 
            // btnLookupClassificacao
            // 
            btnLookupClassificacao.Location = new Point(105, 109);
            btnLookupClassificacao.Margin = new Padding(3, 2, 3, 2);
            btnLookupClassificacao.Name = "btnLookupClassificacao";
            btnLookupClassificacao.Size = new Size(44, 22);
            btnLookupClassificacao.TabIndex = 17;
            btnLookupClassificacao.Text = "...";
            btnLookupClassificacao.UseVisualStyleBackColor = true;
            btnLookupClassificacao.Click += btnLookupClassificacao_Click;
            // 
            // lbClassificacao
            // 
            lbClassificacao.AutoSize = true;
            lbClassificacao.Location = new Point(9, 91);
            lbClassificacao.Name = "lbClassificacao";
            lbClassificacao.Size = new Size(75, 15);
            lbClassificacao.TabIndex = 16;
            lbClassificacao.Text = "Classificação";
            // 
            // tbNomeClassificacao
            // 
            tbNomeClassificacao.Enabled = false;
            tbNomeClassificacao.Location = new Point(155, 108);
            tbNomeClassificacao.Margin = new Padding(3, 2, 3, 2);
            tbNomeClassificacao.Name = "tbNomeClassificacao";
            tbNomeClassificacao.Size = new Size(554, 23);
            tbNomeClassificacao.TabIndex = 15;
            // 
            // tbCodClassificacao
            // 
            tbCodClassificacao.Location = new Point(9, 108);
            tbCodClassificacao.Margin = new Padding(3, 2, 3, 2);
            tbCodClassificacao.Name = "tbCodClassificacao";
            tbCodClassificacao.Size = new Size(90, 23);
            tbCodClassificacao.TabIndex = 14;
            tbCodClassificacao.Leave += tbCodClassificacao_Leave;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(9, 47);
            lbNome.Margin = new Padding(4, 0, 4, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 11;
            lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(9, 65);
            tbNome.Margin = new Padding(4, 3, 4, 3);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(700, 23);
            tbNome.TabIndex = 12;
            // 
            // lbCodProduto
            // 
            lbCodProduto.AutoSize = true;
            lbCodProduto.Location = new Point(159, 3);
            lbCodProduto.Margin = new Padding(4, 0, 4, 0);
            lbCodProduto.Name = "lbCodProduto";
            lbCodProduto.Size = new Size(78, 15);
            lbCodProduto.TabIndex = 6;
            lbCodProduto.Text = "Cod. Produto";
            // 
            // tbCodProduto
            // 
            tbCodProduto.Location = new Point(159, 21);
            tbCodProduto.Margin = new Padding(4, 3, 4, 3);
            tbCodProduto.Name = "tbCodProduto";
            tbCodProduto.ReadOnly = true;
            tbCodProduto.Size = new Size(144, 23);
            tbCodProduto.TabIndex = 7;
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
            tbCodEmpresa.Location = new Point(9, 21);
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
            // tbPrecoUnitario
            // 
            tbPrecoUnitario.Location = new Point(9, 156);
            tbPrecoUnitario.Name = "tbPrecoUnitario";
            tbPrecoUnitario.Size = new Size(142, 23);
            tbPrecoUnitario.TabIndex = 27;
            tbPrecoUnitario.TextChanged += new System.EventHandler(this.tbPrecoUnitario_TextChanged);
            tbPrecoUnitario.KeyPress += new KeyPressEventHandler(this.tbPrecoUnitario_KeyPress);
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 371);
            Controls.Add(tabControl1);
            Controls.Add(panelBottom);
            Icon = Properties.Resources.iconZenCode;
            Name = "FormCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente Fornecedor";
            Load += FormCadastroProduto_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
        private Label lbCodEmpresa;
        private TextBox tbCodEmpresa;
        private Label lbCodProduto;
        private TextBox tbCodProduto;
        private Label lbNome;
        private TextBox tbNome;
        private Button btnLookupClassificacao;
        private Label lbClassificacao;
        private TextBox tbNomeClassificacao;
        private TextBox tbCodClassificacao;
        private ComboBox cbTipoProduto;
        private Label lbTipoProduto;
        private Label lbDescricao;
        private RichTextBox rtbDescricao;
        private CheckBox chkAtivo;
        private Label lbPrecoUnitario;
        private MaskedTextBox tbPrecoUnitario;
    }
}