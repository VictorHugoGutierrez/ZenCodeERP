namespace ZenCodeERP.Forms.Cadastro
{
    partial class FormCadastroEndereco
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
            lbNomeEndereco = new Label();
            tbNomeEndereco = new TextBox();
            btnBuscaCEP = new Button();
            lbPais = new Label();
            tbPais = new TextBox();
            lbComplemento = new Label();
            tbComplemento = new TextBox();
            lbNumero = new Label();
            tbNumero = new TextBox();
            lbEstado = new Label();
            tbEstado = new TextBox();
            lbBairro = new Label();
            tbBairro = new TextBox();
            lbCidade = new Label();
            tbCidade = new TextBox();
            lbCEP = new Label();
            tbCEP = new MaskedTextBox();
            lbRua = new Label();
            tbRua = new TextBox();
            lbCodEndereco = new Label();
            tbCodEndereco = new TextBox();
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
            tabPage1.Controls.Add(lbNomeEndereco);
            tabPage1.Controls.Add(tbNomeEndereco);
            tabPage1.Controls.Add(btnBuscaCEP);
            tabPage1.Controls.Add(lbPais);
            tabPage1.Controls.Add(tbPais);
            tabPage1.Controls.Add(lbComplemento);
            tabPage1.Controls.Add(tbComplemento);
            tabPage1.Controls.Add(lbNumero);
            tabPage1.Controls.Add(tbNumero);
            tabPage1.Controls.Add(lbEstado);
            tabPage1.Controls.Add(tbEstado);
            tabPage1.Controls.Add(lbBairro);
            tabPage1.Controls.Add(tbBairro);
            tabPage1.Controls.Add(lbCidade);
            tabPage1.Controls.Add(tbCidade);
            tabPage1.Controls.Add(lbCEP);
            tabPage1.Controls.Add(tbCEP);
            tabPage1.Controls.Add(lbRua);
            tabPage1.Controls.Add(tbRua);
            tabPage1.Controls.Add(lbCodEndereco);
            tabPage1.Controls.Add(tbCodEndereco);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(726, 297);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Identificação";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbNomeEndereco
            // 
            lbNomeEndereco.AutoSize = true;
            lbNomeEndereco.Location = new Point(9, 44);
            lbNomeEndereco.Margin = new Padding(4, 0, 4, 0);
            lbNomeEndereco.Name = "lbNomeEndereco";
            lbNomeEndereco.Size = new Size(92, 15);
            lbNomeEndereco.TabIndex = 24;
            lbNomeEndereco.Text = "Nome Endereço";
            // 
            // tbNomeEndereco
            // 
            tbNomeEndereco.Location = new Point(9, 62);
            tbNomeEndereco.Margin = new Padding(4, 3, 4, 3);
            tbNomeEndereco.Name = "tbNomeEndereco";
            tbNomeEndereco.Size = new Size(707, 23);
            tbNomeEndereco.TabIndex = 25;
            // 
            // btnBuscaCEP
            // 
            btnBuscaCEP.Location = new Point(330, 17);
            btnBuscaCEP.Name = "btnBuscaCEP";
            btnBuscaCEP.Size = new Size(90, 23);
            btnBuscaCEP.TabIndex = 23;
            btnBuscaCEP.Text = "Buscar CEP";
            btnBuscaCEP.UseVisualStyleBackColor = true;
            btnBuscaCEP.Click += btnBuscaCEP_Click;
            // 
            // lbPais
            // 
            lbPais.AutoSize = true;
            lbPais.Location = new Point(471, 176);
            lbPais.Margin = new Padding(4, 0, 4, 0);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(28, 15);
            lbPais.TabIndex = 21;
            lbPais.Text = "País";
            // 
            // tbPais
            // 
            tbPais.Location = new Point(471, 193);
            tbPais.Margin = new Padding(4, 3, 4, 3);
            tbPais.Name = "tbPais";
            tbPais.Size = new Size(245, 23);
            tbPais.TabIndex = 22;
            // 
            // lbComplemento
            // 
            lbComplemento.AutoSize = true;
            lbComplemento.Location = new Point(239, 132);
            lbComplemento.Margin = new Padding(4, 0, 4, 0);
            lbComplemento.Name = "lbComplemento";
            lbComplemento.Size = new Size(84, 15);
            lbComplemento.TabIndex = 19;
            lbComplemento.Text = "Complemento";
            // 
            // tbComplemento
            // 
            tbComplemento.Location = new Point(239, 150);
            tbComplemento.Margin = new Padding(4, 3, 4, 3);
            tbComplemento.Name = "tbComplemento";
            tbComplemento.Size = new Size(223, 23);
            tbComplemento.TabIndex = 20;
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Location = new Point(9, 132);
            lbNumero.Margin = new Padding(4, 0, 4, 0);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(51, 15);
            lbNumero.TabIndex = 17;
            lbNumero.Text = "Número";
            // 
            // tbNumero
            // 
            tbNumero.Location = new Point(10, 150);
            tbNumero.Margin = new Padding(4, 3, 4, 3);
            tbNumero.Name = "tbNumero";
            tbNumero.Size = new Size(223, 23);
            tbNumero.TabIndex = 18;
            // 
            // lbEstado
            // 
            lbEstado.AutoSize = true;
            lbEstado.Location = new Point(379, 176);
            lbEstado.Margin = new Padding(4, 0, 4, 0);
            lbEstado.Name = "lbEstado";
            lbEstado.Size = new Size(42, 15);
            lbEstado.TabIndex = 15;
            lbEstado.Text = "Estado";
            // 
            // tbEstado
            // 
            tbEstado.Location = new Point(379, 194);
            tbEstado.Margin = new Padding(4, 3, 4, 3);
            tbEstado.Name = "tbEstado";
            tbEstado.Size = new Size(83, 23);
            tbEstado.TabIndex = 16;
            // 
            // lbBairro
            // 
            lbBairro.AutoSize = true;
            lbBairro.Location = new Point(471, 132);
            lbBairro.Margin = new Padding(4, 0, 4, 0);
            lbBairro.Name = "lbBairro";
            lbBairro.Size = new Size(38, 15);
            lbBairro.TabIndex = 13;
            lbBairro.Text = "Bairro";
            // 
            // tbBairro
            // 
            tbBairro.Location = new Point(471, 150);
            tbBairro.Margin = new Padding(4, 3, 4, 3);
            tbBairro.Name = "tbBairro";
            tbBairro.Size = new Size(245, 23);
            tbBairro.TabIndex = 14;
            // 
            // lbCidade
            // 
            lbCidade.AutoSize = true;
            lbCidade.Location = new Point(10, 176);
            lbCidade.Margin = new Padding(4, 0, 4, 0);
            lbCidade.Name = "lbCidade";
            lbCidade.Size = new Size(44, 15);
            lbCidade.TabIndex = 11;
            lbCidade.Text = "Cidade";
            // 
            // tbCidade
            // 
            tbCidade.Location = new Point(10, 193);
            tbCidade.Margin = new Padding(4, 3, 4, 3);
            tbCidade.Name = "tbCidade";
            tbCidade.Size = new Size(361, 23);
            tbCidade.TabIndex = 12;
            // 
            // lbCEP
            // 
            lbCEP.AutoSize = true;
            lbCEP.Location = new Point(159, 3);
            lbCEP.Margin = new Padding(4, 0, 4, 0);
            lbCEP.Name = "lbCEP";
            lbCEP.Size = new Size(28, 15);
            lbCEP.TabIndex = 8;
            lbCEP.Text = "CEP";
            // 
            // tbCEP
            // 
            tbCEP.Location = new Point(159, 18);
            tbCEP.Margin = new Padding(4, 3, 4, 3);
            tbCEP.Mask = "00000-000";
            tbCEP.Name = "tbCEP";
            tbCEP.Size = new Size(168, 23);
            tbCEP.TabIndex = 9;
            // 
            // lbRua
            // 
            lbRua.AutoSize = true;
            lbRua.Location = new Point(9, 88);
            lbRua.Margin = new Padding(4, 0, 4, 0);
            lbRua.Name = "lbRua";
            lbRua.Size = new Size(27, 15);
            lbRua.TabIndex = 6;
            lbRua.Text = "Rua";
            // 
            // tbRua
            // 
            tbRua.Location = new Point(10, 106);
            tbRua.Margin = new Padding(4, 3, 4, 3);
            tbRua.Name = "tbRua";
            tbRua.Size = new Size(707, 23);
            tbRua.TabIndex = 7;
            // 
            // lbCodEndereco
            // 
            lbCodEndereco.AutoSize = true;
            lbCodEndereco.Location = new Point(9, 3);
            lbCodEndereco.Margin = new Padding(4, 0, 4, 0);
            lbCodEndereco.Name = "lbCodEndereco";
            lbCodEndereco.Size = new Size(84, 15);
            lbCodEndereco.TabIndex = 3;
            lbCodEndereco.Text = "Cód. Endereço";
            // 
            // tbCodEndereco
            // 
            tbCodEndereco.Location = new Point(9, 18);
            tbCodEndereco.Margin = new Padding(4, 3, 4, 3);
            tbCodEndereco.Name = "tbCodEndereco";
            tbCodEndereco.ReadOnly = true;
            tbCodEndereco.Size = new Size(142, 23);
            tbCodEndereco.TabIndex = 4;
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
            // FormCadastroEndereco
            // 
            Icon = global::ZenCodeERP.Properties.Resources.iconZenCode; 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 371);
            Controls.Add(tabControl1);
            Controls.Add(panelBottom);
            Name = "FormCadastroEndereco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Endereço";
            Load += FormCadastroEndereco_Load;
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
        private FlowLayoutPanel flowButtons;
        private Label lbCodEndereco;
        private TextBox tbCodEndereco;
        private Label lbRua;
        private TextBox tbRua;
        private Label lbCEP;
        private MaskedTextBox tbCEP;
        private Label lbCidade;
        private TextBox tbCidade;
        private Label lbBairro;
        private TextBox tbBairro;
        private Label lbEstado;
        private TextBox tbEstado;
        private Label lbComplemento;
        private TextBox tbComplemento;
        private Label lbNumero;
        private TextBox tbNumero;
        private Label lbPais;
        private TextBox tbPais;
        private Button btnBuscaCEP;
        private Label lbNomeEndereco;
        private TextBox tbNomeEndereco;
    }
}