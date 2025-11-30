namespace ZenCodeERP.Forms.Visao
{
    partial class formVisaoRelatorioVendas
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
            dgvRelatorio = new DataGridView();
            dtFim = new DateTimePicker();
            label1 = new Label();
            dtInicio = new DateTimePicker();
            toolStrip2 = new ToolStrip();
            iBtnGerarRelatorio = new FontAwesome.Sharp.IconToolStripButton();
            iBtnNovo = new FontAwesome.Sharp.IconToolStripButton();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            label2 = new Label();
            label3 = new Label();
            iconToolStripButton2 = new FontAwesome.Sharp.IconToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.AllowUserToAddRows = false;
            dgvRelatorio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dgvRelatorio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRelatorio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatorio.BackgroundColor = Color.WhiteSmoke;
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorio.Location = new Point(0, 107);
            dgvRelatorio.Margin = new Padding(5, 4, 5, 4);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.ReadOnly = true;
            dgvRelatorio.RowHeadersVisible = false;
            dgvRelatorio.RowHeadersWidth = 51;
            dgvRelatorio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelatorio.Size = new Size(1410, 459);
            dgvRelatorio.TabIndex = 9;
            // 
            // dtFim
            // 
            dtFim.Anchor = AnchorStyles.None;
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(193, 61);
            dtFim.Margin = new Padding(3, 4, 3, 4);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(129, 27);
            dtFim.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-44, 10);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 12;
            label1.Text = "Inicio:";
            // 
            // dtInicio
            // 
            dtInicio.Anchor = AnchorStyles.None;
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(33, 61);
            dtInicio.Margin = new Padding(10, 4, 3, 4);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(129, 27);
            dtInicio.TabIndex = 11;
            // 
            // toolStrip2
            // 
            toolStrip2.Font = new Font("Tahoma", 8.25F);
            toolStrip2.ImageScalingSize = new Size(30, 30);
            toolStrip2.Items.AddRange(new ToolStripItem[] { iBtnGerarRelatorio, iBtnNovo, iconToolStripButton2, iconToolStripButton1 });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1410, 37);
            toolStrip2.TabIndex = 15;
            toolStrip2.Text = "toolStrip2";
            // 
            // iBtnGerarRelatorio
            // 
            iBtnGerarRelatorio.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iBtnGerarRelatorio.IconColor = Color.DodgerBlue;
            iBtnGerarRelatorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnGerarRelatorio.IconSize = 32;
            iBtnGerarRelatorio.Name = "iBtnGerarRelatorio";
            iBtnGerarRelatorio.Size = new Size(132, 34);
            iBtnGerarRelatorio.Text = "Gerar Relatório";
            iBtnGerarRelatorio.TextAlign = ContentAlignment.MiddleRight;
            iBtnGerarRelatorio.Click += iBtnGerarRelatorio_Click_1;
            // 
            // iBtnNovo
            // 
            iBtnNovo.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iBtnNovo.IconColor = Color.DodgerBlue;
            iBtnNovo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnNovo.IconSize = 32;
            iBtnNovo.Name = "iBtnNovo";
            iBtnNovo.Size = new Size(108, 34);
            iBtnNovo.Text = "Baixar CSV";
            iBtnNovo.Click += iBtnNovo_Click;
            // 
            // iconToolStripButton1
            // 
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconToolStripButton1.IconColor = Color.DodgerBlue;
            iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton1.IconSize = 32;
            iconToolStripButton1.Name = "iconToolStripButton1";
            iconToolStripButton1.Size = new Size(83, 34);
            iconToolStripButton1.Text = "Fechar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 37);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 16;
            label2.Text = "Início:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 37);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 17;
            label3.Text = "Fim:";
            // 
            // iconToolStripButton2
            // 
            iconToolStripButton2.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconToolStripButton2.IconColor = Color.DodgerBlue;
            iconToolStripButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton2.IconSize = 32;
            iconToolStripButton2.Name = "iconToolStripButton2";
            iconToolStripButton2.Size = new Size(108, 34);
            iconToolStripButton2.Text = "Baixar PDF";
            iconToolStripButton2.Click += iconToolStripButton2_Click;
            // 
            // formVisaoRelatorioVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 569);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(toolStrip2);
            Controls.Add(dgvRelatorio);
            Controls.Add(dtFim);
            Controls.Add(label1);
            Controls.Add(dtInicio);
            Name = "formVisaoRelatorioVendas";
            Text = "formVisaoRelatorioVendas";
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRelatorio;
        private DateTimePicker dtFim;
        private Label label1;
        private DateTimePicker dtInicio;
        private ToolStrip toolStrip2;
        private FontAwesome.Sharp.IconToolStripButton iBtnNovo;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconToolStripButton iBtnGerarRelatorio;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton2;
    }
}