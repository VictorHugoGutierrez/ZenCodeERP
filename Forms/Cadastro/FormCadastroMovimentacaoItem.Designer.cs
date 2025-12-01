using FontAwesome.Sharp;
using Org.BouncyCastle.Crypto;
using System.Windows.Forms;

namespace ZenCodeERP.Forms.Cadastro
{
    partial class FormCadastroMovimentacaoItem
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
            tabIdentificacao = new TabPage();
            tbQuantidade = new MaskedTextBox();
            lbQuantidade = new Label();
            tbValorUnitario = new MaskedTextBox();
            lbValorUnitario = new Label();
            tbCustoUnitario = new MaskedTextBox();
            lbCustoUnitario = new Label();
            btnLookupProduto = new Button();
            lbProduto = new Label();
            tbNomeProduto = new TextBox();
            tbCodProduto = new TextBox();
            lbCodMovimentacaoItem = new Label();
            tbCodMovimentacaoItem = new TextBox();
            tbValorTotal = new MaskedTextBox();
            lbValorTotal = new Label();
            lbCodMovimentacao = new Label();
            tbCodMovimentacao = new TextBox();
            lbCodEmpresa = new Label();
            tbCodEmpresa = new TextBox();
            panelBottom = new Panel();
            btnOk = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            tabIdentificacao.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabIdentificacao);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(734, 325);
            tabControl1.TabIndex = 5;
            // 
            // tabIdentificacao
            // 
            tabIdentificacao.Controls.Add(tbQuantidade);
            tabIdentificacao.Controls.Add(lbQuantidade);
            tabIdentificacao.Controls.Add(tbValorUnitario);
            tabIdentificacao.Controls.Add(lbValorUnitario);
            tabIdentificacao.Controls.Add(tbCustoUnitario);
            tabIdentificacao.Controls.Add(lbCustoUnitario);
            tabIdentificacao.Controls.Add(btnLookupProduto);
            tabIdentificacao.Controls.Add(lbProduto);
            tabIdentificacao.Controls.Add(tbNomeProduto);
            tabIdentificacao.Controls.Add(tbCodProduto);
            tabIdentificacao.Controls.Add(lbCodMovimentacaoItem);
            tabIdentificacao.Controls.Add(tbCodMovimentacaoItem);
            tabIdentificacao.Controls.Add(tbValorTotal);
            tabIdentificacao.Controls.Add(lbValorTotal);
            tabIdentificacao.Controls.Add(lbCodMovimentacao);
            tabIdentificacao.Controls.Add(tbCodMovimentacao);
            tabIdentificacao.Controls.Add(lbCodEmpresa);
            tabIdentificacao.Controls.Add(tbCodEmpresa);
            tabIdentificacao.Location = new Point(4, 24);
            tabIdentificacao.Margin = new Padding(4, 3, 4, 3);
            tabIdentificacao.Name = "tabIdentificacao";
            tabIdentificacao.Padding = new Padding(4, 3, 4, 3);
            tabIdentificacao.Size = new Size(726, 297);
            tabIdentificacao.TabIndex = 0;
            tabIdentificacao.Text = "Identificação";
            tabIdentificacao.UseVisualStyleBackColor = true;
            // 
            // tbQuantidade
            // 
            tbQuantidade.Location = new Point(9, 126);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(142, 23);
            tbQuantidade.TabIndex = 41;
            tbQuantidade.Validated += tbQuantidade_Validated;
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(9, 108);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(69, 15);
            lbQuantidade.TabIndex = 40;
            lbQuantidade.Text = "Quantidade";
            // 
            // tbValorUnitario
            // 
            tbValorUnitario.Location = new Point(157, 126);
            tbValorUnitario.Name = "tbValorUnitario";
            tbValorUnitario.Size = new Size(142, 23);
            tbValorUnitario.TabIndex = 39;
            tbValorUnitario.TextChanged += tbValorUnitario_TextChanged;
            tbValorUnitario.Validated += tbValorUnitario_Validated;
            // 
            // lbValorUnitario
            // 
            lbValorUnitario.AutoSize = true;
            lbValorUnitario.Location = new Point(157, 108);
            lbValorUnitario.Name = "lbValorUnitario";
            lbValorUnitario.Size = new Size(78, 15);
            lbValorUnitario.TabIndex = 38;
            lbValorUnitario.Text = "Valor Unitário";
            // 
            // tbCustoUnitario
            // 
            tbCustoUnitario.Location = new Point(305, 126);
            tbCustoUnitario.Name = "tbCustoUnitario";
            tbCustoUnitario.ReadOnly = true;
            tbCustoUnitario.Size = new Size(142, 23);
            tbCustoUnitario.TabIndex = 37;
            // 
            // lbCustoUnitario
            // 
            lbCustoUnitario.AutoSize = true;
            lbCustoUnitario.Location = new Point(305, 108);
            lbCustoUnitario.Name = "lbCustoUnitario";
            lbCustoUnitario.Size = new Size(83, 15);
            lbCustoUnitario.TabIndex = 36;
            lbCustoUnitario.Text = "Custo Unitário";
            // 
            // btnLookupProduto
            // 
            btnLookupProduto.Location = new Point(105, 67);
            btnLookupProduto.Margin = new Padding(3, 2, 3, 2);
            btnLookupProduto.Name = "btnLookupProduto";
            btnLookupProduto.Size = new Size(44, 22);
            btnLookupProduto.TabIndex = 35;
            btnLookupProduto.Text = "...";
            btnLookupProduto.UseVisualStyleBackColor = true;
            btnLookupProduto.Click += btnLookupProduto_Click;
            // 
            // lbProduto
            // 
            lbProduto.AutoSize = true;
            lbProduto.Location = new Point(9, 49);
            lbProduto.Name = "lbProduto";
            lbProduto.Size = new Size(50, 15);
            lbProduto.TabIndex = 34;
            lbProduto.Text = "Produto";
            // 
            // tbNomeProduto
            // 
            tbNomeProduto.Enabled = false;
            tbNomeProduto.Location = new Point(155, 66);
            tbNomeProduto.Margin = new Padding(3, 2, 3, 2);
            tbNomeProduto.Name = "tbNomeProduto";
            tbNomeProduto.Size = new Size(554, 23);
            tbNomeProduto.TabIndex = 33;
            // 
            // tbCodProduto
            // 
            tbCodProduto.Location = new Point(9, 66);
            tbCodProduto.Margin = new Padding(3, 2, 3, 2);
            tbCodProduto.Name = "tbCodProduto";
            tbCodProduto.Size = new Size(90, 23);
            tbCodProduto.TabIndex = 32;
            tbCodProduto.Leave += tbCodProduto_Leave;
            // 
            // lbCodMovimentacaoItem
            // 
            lbCodMovimentacaoItem.AutoSize = true;
            lbCodMovimentacaoItem.Location = new Point(281, 3);
            lbCodMovimentacaoItem.Margin = new Padding(4, 0, 4, 0);
            lbCodMovimentacaoItem.Name = "lbCodMovimentacaoItem";
            lbCodMovimentacaoItem.Size = new Size(142, 15);
            lbCodMovimentacaoItem.TabIndex = 30;
            lbCodMovimentacaoItem.Text = "Cód. Item Movimentação";
            // 
            // tbCodMovimentacaoItem
            // 
            tbCodMovimentacaoItem.Location = new Point(281, 21);
            tbCodMovimentacaoItem.Margin = new Padding(4, 3, 4, 3);
            tbCodMovimentacaoItem.Name = "tbCodMovimentacaoItem";
            tbCodMovimentacaoItem.ReadOnly = true;
            tbCodMovimentacaoItem.Size = new Size(144, 23);
            tbCodMovimentacaoItem.TabIndex = 31;
            // 
            // tbValorTotal
            // 
            tbValorTotal.Location = new Point(453, 126);
            tbValorTotal.Name = "tbValorTotal";
            tbValorTotal.ReadOnly = true;
            tbValorTotal.Size = new Size(142, 23);
            tbValorTotal.TabIndex = 27;
            // 
            // lbValorTotal
            // 
            lbValorTotal.AutoSize = true;
            lbValorTotal.Location = new Point(453, 108);
            lbValorTotal.Name = "lbValorTotal";
            lbValorTotal.Size = new Size(62, 15);
            lbValorTotal.TabIndex = 26;
            lbValorTotal.Text = "Valor Total";
            // 
            // lbCodMovimentacao
            // 
            lbCodMovimentacao.AutoSize = true;
            lbCodMovimentacao.Location = new Point(129, 3);
            lbCodMovimentacao.Margin = new Padding(4, 0, 4, 0);
            lbCodMovimentacao.Name = "lbCodMovimentacao";
            lbCodMovimentacao.Size = new Size(115, 15);
            lbCodMovimentacao.TabIndex = 6;
            lbCodMovimentacao.Text = "Cod. Movimentação";
            // 
            // tbCodMovimentacao
            // 
            tbCodMovimentacao.Location = new Point(129, 21);
            tbCodMovimentacao.Margin = new Padding(4, 3, 4, 3);
            tbCodMovimentacao.Name = "tbCodMovimentacao";
            tbCodMovimentacao.ReadOnly = true;
            tbCodMovimentacao.Size = new Size(144, 23);
            tbCodMovimentacao.TabIndex = 7;
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
            tbCodEmpresa.Size = new Size(112, 23);
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormCadastroMovimentacaoItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 371);
            Controls.Add(tabControl1);
            Controls.Add(panelBottom);
            Icon = Properties.Resources.iconZenCode;
            Name = "FormCadastroMovimentacaoItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Item da Movimentação";
            Load += FormCadastroMovimentacaoItem_Load;
            tabControl1.ResumeLayout(false);
            tabIdentificacao.ResumeLayout(false);
            tabIdentificacao.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabIdentificacao;
        private Panel panelBottom;
        private Button btnOk;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label lbCodEmpresa;
        private TextBox tbCodEmpresa;
        private Label lbCodMovimentacao;
        private TextBox tbCodMovimentacao;
        private Label lbValorTotal;
        private MaskedTextBox tbValorTotal;
        private Label lbCodMovimentacaoItem;
        private TextBox tbCodMovimentacaoItem;
        private Button btnLookupProduto;
        private Label lbProduto;
        private TextBox tbNomeProduto;
        private TextBox tbCodProduto;
        private MaskedTextBox tbValorUnitario;
        private Label lbValorUnitario;
        private MaskedTextBox tbCustoUnitario;
        private Label lbCustoUnitario;
        private MaskedTextBox tbQuantidade;
        private Label lbQuantidade;
        private ContextMenuStrip contextMenuStrip1;
    }
}