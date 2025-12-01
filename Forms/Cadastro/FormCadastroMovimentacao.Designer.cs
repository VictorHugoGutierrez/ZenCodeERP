using FontAwesome.Sharp;
using Org.BouncyCastle.Crypto;
using System.Windows.Forms;

namespace ZenCodeERP.Forms.Cadastro
{
    partial class FormCadastroMovimentacao
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabIdentificacao = new TabPage();
            cbStatus = new ComboBox();
            lbData = new Label();
            dtData = new DateTimePicker();
            btnLookupUsuario = new Button();
            lbUsuario = new Label();
            tbNomeUsuario = new TextBox();
            tbCodUsuario = new TextBox();
            lbStatus = new Label();
            tbValorTotal = new MaskedTextBox();
            lbValorTotal = new Label();
            lbObservacao = new Label();
            rtbObservacao = new RichTextBox();
            lbTipoMovimento = new Label();
            cbTipoMovimento = new ComboBox();
            btnLookupCliente = new Button();
            lbCliente = new Label();
            tbNomeCliente = new TextBox();
            tbCodCliente = new TextBox();
            lbCodMovimentacao = new Label();
            tbCodMovimentacao = new TextBox();
            lbCodEmpresa = new Label();
            tbCodEmpresa = new TextBox();
            tabMovimentacaoItem = new TabPage();
            toolStrip1 = new ToolStrip();
            iBtnNovo = new IconToolStripButton();
            iBtnEditar = new IconToolStripButton();
            iBtnExcluir = new IconToolStripButton();
            iBtnAtualizar = new IconToolStripButton();
            panel1 = new Panel();
            gvMovimentacaoItem = new DataGridView();
            panelBottom = new Panel();
            btnOk = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            tabControl1.SuspendLayout();
            tabIdentificacao.SuspendLayout();
            tabMovimentacaoItem.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvMovimentacaoItem).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabIdentificacao);
            tabControl1.Controls.Add(tabMovimentacaoItem);
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
            tabIdentificacao.Controls.Add(cbStatus);
            tabIdentificacao.Controls.Add(lbData);
            tabIdentificacao.Controls.Add(dtData);
            tabIdentificacao.Controls.Add(btnLookupUsuario);
            tabIdentificacao.Controls.Add(lbUsuario);
            tabIdentificacao.Controls.Add(tbNomeUsuario);
            tabIdentificacao.Controls.Add(tbCodUsuario);
            tabIdentificacao.Controls.Add(lbStatus);
            tabIdentificacao.Controls.Add(tbValorTotal);
            tabIdentificacao.Controls.Add(lbValorTotal);
            tabIdentificacao.Controls.Add(lbObservacao);
            tabIdentificacao.Controls.Add(rtbObservacao);
            tabIdentificacao.Controls.Add(lbTipoMovimento);
            tabIdentificacao.Controls.Add(cbTipoMovimento);
            tabIdentificacao.Controls.Add(btnLookupCliente);
            tabIdentificacao.Controls.Add(lbCliente);
            tabIdentificacao.Controls.Add(tbNomeCliente);
            tabIdentificacao.Controls.Add(tbCodCliente);
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
            // cbStatus
            // 
            cbStatus.Enabled = false;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(280, 20);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(133, 23);
            cbStatus.TabIndex = 38;
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(157, 246);
            lbData.Name = "lbData";
            lbData.Size = new Size(74, 15);
            lbData.TabIndex = 37;
            lbData.Text = "Data Criação";
            // 
            // dtData
            // 
            dtData.CustomFormat = "dd/MM/yyyy HH:mm";
            dtData.Enabled = false;
            dtData.ForeColor = Color.Black;
            dtData.Format = DateTimePickerFormat.Custom;
            dtData.Location = new Point(157, 264);
            dtData.Name = "dtData";
            dtData.Size = new Size(200, 23);
            dtData.TabIndex = 36;
            // 
            // btnLookupUsuario
            // 
            btnLookupUsuario.Location = new Point(105, 67);
            btnLookupUsuario.Margin = new Padding(3, 2, 3, 2);
            btnLookupUsuario.Name = "btnLookupUsuario";
            btnLookupUsuario.Size = new Size(44, 22);
            btnLookupUsuario.TabIndex = 35;
            btnLookupUsuario.Text = "...";
            btnLookupUsuario.UseVisualStyleBackColor = true;
            btnLookupUsuario.Click += btnLookupUsuario_Click;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(9, 49);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(47, 15);
            lbUsuario.TabIndex = 34;
            lbUsuario.Text = "Usuário";
            // 
            // tbNomeUsuario
            // 
            tbNomeUsuario.Enabled = false;
            tbNomeUsuario.Location = new Point(155, 66);
            tbNomeUsuario.Margin = new Padding(3, 2, 3, 2);
            tbNomeUsuario.Name = "tbNomeUsuario";
            tbNomeUsuario.Size = new Size(554, 23);
            tbNomeUsuario.TabIndex = 33;
            // 
            // tbCodUsuario
            // 
            tbCodUsuario.Location = new Point(9, 66);
            tbCodUsuario.Margin = new Padding(3, 2, 3, 2);
            tbCodUsuario.Name = "tbCodUsuario";
            tbCodUsuario.Size = new Size(90, 23);
            tbCodUsuario.TabIndex = 32;
            tbCodUsuario.Leave += tbCodUsuario_Leave;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(281, 3);
            lbStatus.Margin = new Padding(4, 0, 4, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 15);
            lbStatus.TabIndex = 30;
            lbStatus.Text = "Status";
            // 
            // tbValorTotal
            // 
            tbValorTotal.Location = new Point(9, 264);
            tbValorTotal.Name = "tbValorTotal";
            tbValorTotal.ReadOnly = true;
            tbValorTotal.Size = new Size(142, 23);
            tbValorTotal.TabIndex = 27;
            tbValorTotal.TextChanged += tbPrecoUnitario_TextChanged;
            tbValorTotal.KeyPress += tbPrecoUnitario_KeyPress;
            // 
            // lbValorTotal
            // 
            lbValorTotal.AutoSize = true;
            lbValorTotal.Location = new Point(9, 246);
            lbValorTotal.Name = "lbValorTotal";
            lbValorTotal.Size = new Size(62, 15);
            lbValorTotal.TabIndex = 26;
            lbValorTotal.Text = "Valor Total";
            // 
            // lbObservacao
            // 
            lbObservacao.AutoSize = true;
            lbObservacao.Location = new Point(9, 133);
            lbObservacao.Margin = new Padding(4, 0, 4, 0);
            lbObservacao.Name = "lbObservacao";
            lbObservacao.Size = new Size(58, 15);
            lbObservacao.TabIndex = 24;
            lbObservacao.Text = "Descrição";
            // 
            // rtbObservacao
            // 
            rtbObservacao.Location = new Point(8, 151);
            rtbObservacao.Name = "rtbObservacao";
            rtbObservacao.Size = new Size(700, 92);
            rtbObservacao.TabIndex = 23;
            rtbObservacao.Text = "";
            // 
            // lbTipoMovimento
            // 
            lbTipoMovimento.AutoSize = true;
            lbTipoMovimento.Location = new Point(419, 3);
            lbTipoMovimento.Name = "lbTipoMovimento";
            lbTipoMovimento.Size = new Size(96, 15);
            lbTipoMovimento.TabIndex = 21;
            lbTipoMovimento.Text = "Tipo Movimento";
            // 
            // cbTipoMovimento
            // 
            cbTipoMovimento.FormattingEnabled = true;
            cbTipoMovimento.Location = new Point(419, 20);
            cbTipoMovimento.Margin = new Padding(3, 2, 3, 2);
            cbTipoMovimento.Name = "cbTipoMovimento";
            cbTipoMovimento.Size = new Size(133, 23);
            cbTipoMovimento.TabIndex = 1;
            // 
            // btnLookupCliente
            // 
            btnLookupCliente.Location = new Point(105, 109);
            btnLookupCliente.Margin = new Padding(3, 2, 3, 2);
            btnLookupCliente.Name = "btnLookupCliente";
            btnLookupCliente.Size = new Size(44, 22);
            btnLookupCliente.TabIndex = 17;
            btnLookupCliente.Text = "...";
            btnLookupCliente.UseVisualStyleBackColor = true;
            btnLookupCliente.Click += btnLookupCliente_Click;
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Location = new Point(9, 91);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(44, 15);
            lbCliente.TabIndex = 16;
            lbCliente.Text = "Cliente";
            // 
            // tbNomeCliente
            // 
            tbNomeCliente.Enabled = false;
            tbNomeCliente.Location = new Point(155, 108);
            tbNomeCliente.Margin = new Padding(3, 2, 3, 2);
            tbNomeCliente.Name = "tbNomeCliente";
            tbNomeCliente.Size = new Size(554, 23);
            tbNomeCliente.TabIndex = 15;
            // 
            // tbCodCliente
            // 
            tbCodCliente.Location = new Point(9, 108);
            tbCodCliente.Margin = new Padding(3, 2, 3, 2);
            tbCodCliente.Name = "tbCodCliente";
            tbCodCliente.Size = new Size(90, 23);
            tbCodCliente.TabIndex = 14;
            tbCodCliente.Leave += tbCodCliente_Leave;
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
            // tabMovimentacaoItem
            // 
            tabMovimentacaoItem.Controls.Add(toolStrip1);
            tabMovimentacaoItem.Controls.Add(panel1);
            tabMovimentacaoItem.Location = new Point(4, 24);
            tabMovimentacaoItem.Margin = new Padding(4, 3, 4, 3);
            tabMovimentacaoItem.Name = "tabMovimentacaoItem";
            tabMovimentacaoItem.Padding = new Padding(4, 3, 4, 3);
            tabMovimentacaoItem.Size = new Size(726, 297);
            tabMovimentacaoItem.TabIndex = 0;
            tabMovimentacaoItem.Text = "Item da Movimentação";
            tabMovimentacaoItem.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Tahoma", 8.25F);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { iBtnNovo, iBtnEditar, iBtnExcluir, iBtnAtualizar });
            toolStrip1.Location = new Point(4, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(718, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // iBtnNovo
            // 
            iBtnNovo.IconChar = IconChar.FileCirclePlus;
            iBtnNovo.IconColor = Color.DodgerBlue;
            iBtnNovo.IconFont = IconFont.Auto;
            iBtnNovo.IconSize = 32;
            iBtnNovo.Name = "iBtnNovo";
            iBtnNovo.Size = new Size(56, 24);
            iBtnNovo.Text = "Novo";
            iBtnNovo.Click += iBtnNovo_Click;
            // 
            // iBtnEditar
            // 
            iBtnEditar.IconChar = IconChar.Edit;
            iBtnEditar.IconColor = Color.DodgerBlue;
            iBtnEditar.IconFont = IconFont.Auto;
            iBtnEditar.IconSize = 32;
            iBtnEditar.Name = "iBtnEditar";
            iBtnEditar.Size = new Size(59, 24);
            iBtnEditar.Text = "Editar";
            iBtnEditar.Click += iBtnEditar_Click;
            // 
            // iBtnExcluir
            // 
            iBtnExcluir.IconChar = IconChar.Trash;
            iBtnExcluir.IconColor = Color.DodgerBlue;
            iBtnExcluir.IconFont = IconFont.Auto;
            iBtnExcluir.IconSize = 32;
            iBtnExcluir.Name = "iBtnExcluir";
            iBtnExcluir.Size = new Size(62, 24);
            iBtnExcluir.Text = "Excluir";
            iBtnExcluir.Click += iBtnExcluir_Click;
            // 
            // iBtnAtualizar
            // 
            iBtnAtualizar.IconChar = IconChar.ArrowRotateForward;
            iBtnAtualizar.IconColor = Color.DodgerBlue;
            iBtnAtualizar.IconFont = IconFont.Auto;
            iBtnAtualizar.IconSize = 32;
            iBtnAtualizar.Name = "iBtnAtualizar";
            iBtnAtualizar.Size = new Size(73, 24);
            iBtnAtualizar.Text = "Atualizar";
            iBtnAtualizar.Click += iBtnAtualizar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(gvMovimentacaoItem);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 264);
            panel1.TabIndex = 2;
            // 
            // gvMovimentacaoItem
            // 
            gvMovimentacaoItem.AllowUserToAddRows = false;
            gvMovimentacaoItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            gvMovimentacaoItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gvMovimentacaoItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvMovimentacaoItem.BackgroundColor = Color.WhiteSmoke;
            gvMovimentacaoItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvMovimentacaoItem.Dock = DockStyle.Fill;
            gvMovimentacaoItem.Location = new Point(0, 0);
            gvMovimentacaoItem.Name = "gvMovimentacaoItem";
            gvMovimentacaoItem.ReadOnly = true;
            gvMovimentacaoItem.RowHeadersVisible = false;
            gvMovimentacaoItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvMovimentacaoItem.Size = new Size(726, 264);
            gvMovimentacaoItem.TabIndex = 0;
            gvMovimentacaoItem.DoubleClick += gvMovimentacaoItem_DoubleClick;
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
            // FormCadastroMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 371);
            Controls.Add(tabControl1);
            Controls.Add(panelBottom);
            Icon = Properties.Resources.iconZenCode;
            Name = "FormCadastroMovimentacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Movimentação";
            Load += FormCadastroMovimentacao_Load;
            tabControl1.ResumeLayout(false);
            tabIdentificacao.ResumeLayout(false);
            tabIdentificacao.PerformLayout();
            tabMovimentacaoItem.ResumeLayout(false);
            tabMovimentacaoItem.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvMovimentacaoItem).EndInit();
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
        private Button btnLookupCliente;
        private Label lbCliente;
        private TextBox tbNomeCliente;
        private TextBox tbCodCliente;
        private ComboBox cbTipoMovimento;
        private Label lbTipoMovimento;
        private Label lbObservacao;
        private RichTextBox rtbObservacao;
        private Label lbValorTotal;
        private MaskedTextBox tbValorTotal;
        private Label lbStatus;
        private Button btnLookupUsuario;
        private Label lbUsuario;
        private TextBox tbNomeUsuario;
        private TextBox tbCodUsuario;
        private Label lbData;
        private DateTimePicker dtData;
        private TabPage tabMovimentacaoItem;
        private Panel panel1;
        private DataGridView gvMovimentacaoItem;
        private ToolStrip toolStrip1;
        private IconToolStripButton iBtnNovo;
        private IconToolStripButton iBtnEditar;
        private IconToolStripButton iBtnExcluir;
        private IconToolStripButton iBtnAtualizar;
        private ComboBox cbStatus;
    }
}