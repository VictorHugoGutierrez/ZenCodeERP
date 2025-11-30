namespace ZenCodeERP.Forms.Visao
{
    partial class FormVisaoRelatorioEstoque
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolStrip2 = new ToolStrip();
            iBtnGerarRelatorio = new FontAwesome.Sharp.IconToolStripButton();
            iBtnBaixarCsv = new FontAwesome.Sharp.IconToolStripButton();
            iBtnBaixarPDF = new FontAwesome.Sharp.IconToolStripButton();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            dgvEstoqueClassificacao = new DataGridView();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoqueClassificacao).BeginInit();
            SuspendLayout();
            // 
            // toolStrip2
            // 
            toolStrip2.Font = new Font("Tahoma", 8.25F);
            toolStrip2.ImageScalingSize = new Size(30, 30);
            toolStrip2.Items.AddRange(new ToolStripItem[] { iBtnGerarRelatorio, iBtnBaixarCsv, iBtnBaixarPDF, iconToolStripButton1 });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1410, 37);
            toolStrip2.TabIndex = 22;
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
            iBtnGerarRelatorio.Click += iBtnGerarRelatorio_Click;
            // 
            // iBtnBaixarCsv
            // 
            iBtnBaixarCsv.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iBtnBaixarCsv.IconColor = Color.DodgerBlue;
            iBtnBaixarCsv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnBaixarCsv.IconSize = 32;
            iBtnBaixarCsv.Name = "iBtnBaixarCsv";
            iBtnBaixarCsv.Size = new Size(108, 34);
            iBtnBaixarCsv.Text = "Baixar CSV";
            // 
            // iBtnBaixarPDF
            // 
            iBtnBaixarPDF.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iBtnBaixarPDF.IconColor = Color.DodgerBlue;
            iBtnBaixarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnBaixarPDF.IconSize = 32;
            iBtnBaixarPDF.Name = "iBtnBaixarPDF";
            iBtnBaixarPDF.Size = new Size(108, 34);
            iBtnBaixarPDF.Text = "Baixar PDF";
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
            // dgvEstoqueClassificacao
            // 
            dgvEstoqueClassificacao.AllowUserToAddRows = false;
            dgvEstoqueClassificacao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 240, 240);
            dgvEstoqueClassificacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvEstoqueClassificacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstoqueClassificacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstoqueClassificacao.BackgroundColor = Color.WhiteSmoke;
            dgvEstoqueClassificacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoqueClassificacao.EnableHeadersVisualStyles = false;
            dgvEstoqueClassificacao.Location = new Point(0, 41);
            dgvEstoqueClassificacao.Margin = new Padding(5, 4, 5, 4);
            dgvEstoqueClassificacao.Name = "dgvEstoqueClassificacao";
            dgvEstoqueClassificacao.ReadOnly = true;
            dgvEstoqueClassificacao.RowHeadersVisible = false;
            dgvEstoqueClassificacao.RowHeadersWidth = 51;
            dgvEstoqueClassificacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoqueClassificacao.Size = new Size(1432, 526);
            dgvEstoqueClassificacao.TabIndex = 18;
            // 
            // FormVisaoRelatorioEstoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 569);
            Controls.Add(toolStrip2);
            Controls.Add(dgvEstoqueClassificacao);
            Name = "FormVisaoRelatorioEstoque";
            Text = "FormVisaoRelatorioEstoque";
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoqueClassificacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip2;
        private FontAwesome.Sharp.IconToolStripButton iBtnGerarRelatorio;
        private FontAwesome.Sharp.IconToolStripButton iBtnBaixarCsv;
        private FontAwesome.Sharp.IconToolStripButton iBtnBaixarPDF;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private DataGridView dgvEstoqueClassificacao;
    }
}