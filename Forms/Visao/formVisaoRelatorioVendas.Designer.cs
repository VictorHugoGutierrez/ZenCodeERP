using ZenCodeERP.Model;
using System.Drawing;
using System.Windows.Forms;

namespace ZenCodeERP.Forms.Visao
{
    partial class formVisaoRelatorioVendas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvRelatorio = new DataGridView();
            dtFim = new DateTimePicker();
            dtInicio = new DateTimePicker();
            toolStrip2 = new ToolStrip();
            iBtnGerarRelatorio = new FontAwesome.Sharp.IconToolStripButton();
            iBtnBaixarCsv = new FontAwesome.Sharp.IconToolStripButton();
            iBtnBaixarPDF = new FontAwesome.Sharp.IconToolStripButton();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            toolStrip2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.AllowUserToAddRows = false;
            dgvRelatorio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dgvRelatorio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRelatorio.BackgroundColor = Color.WhiteSmoke;
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorio.Dock = DockStyle.Fill;
            dgvRelatorio.Location = new Point(0, 107);
            dgvRelatorio.Margin = new Padding(5, 4, 5, 4);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.ReadOnly = true;
            dgvRelatorio.RowHeadersVisible = false;
            dgvRelatorio.RowHeadersWidth = 51;
            dgvRelatorio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelatorio.Size = new Size(1378, 365);
            dgvRelatorio.TabIndex = 9;
            // 
            // dtFim
            // 
            dtFim.Format = DateTimePickerFormat.Short;
            dtFim.Location = new Point(160, 36);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(129, 27);
            dtFim.TabIndex = 14;
            // 
            // dtInicio
            // 
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(12, 36);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(129, 27);
            dtInicio.TabIndex = 11;
            // 
            // toolStrip2
            // 
            toolStrip2.Font = new Font("Tahoma", 8.25F);
            toolStrip2.ImageScalingSize = new Size(30, 30);
            toolStrip2.Items.AddRange(new ToolStripItem[] { iBtnGerarRelatorio, iBtnBaixarCsv, iBtnBaixarPDF, iconToolStripButton1 });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1378, 37);
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
            iBtnGerarRelatorio.Click += iBtnGerarRelatorio_Click_1;
            // 
            // iBtnBaixarCsv
            // 
            iBtnBaixarCsv.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            iBtnBaixarCsv.IconColor = Color.DodgerBlue;
            iBtnBaixarCsv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnBaixarCsv.IconSize = 32;
            iBtnBaixarCsv.Name = "iBtnBaixarCsv";
            iBtnBaixarCsv.Size = new Size(108, 34);
            iBtnBaixarCsv.Text = "Baixar CSV";
            iBtnBaixarCsv.Click += iBtnBaixarCsv_Click;
            // 
            // iBtnBaixarPDF
            // 
            iBtnBaixarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            iBtnBaixarPDF.IconColor = Color.DodgerBlue;
            iBtnBaixarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iBtnBaixarPDF.IconSize = 32;
            iBtnBaixarPDF.Name = "iBtnBaixarPDF";
            iBtnBaixarPDF.Size = new Size(108, 34);
            iBtnBaixarPDF.Text = "Baixar PDF";
            iBtnBaixarPDF.Click += iBtnBaixarPDF_Click;
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
            iconToolStripButton1.Click += iconToolStripButton1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtInicio);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtFim);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(1378, 70);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 16;
            label2.Text = "Início:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 13);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 17;
            label3.Text = "Fim:";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // formVisaoRelatorioVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 472);
            Controls.Add(dgvRelatorio);
            Controls.Add(panel1);
            Controls.Add(toolStrip2);
            Name = "formVisaoRelatorioVendas";
            Text = "Relatório de Vendas";
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private FontAwesome.Sharp.IconToolStripButton iBtnBaixarCsv;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconToolStripButton iBtnGerarRelatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconToolStripButton iBtnBaixarPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}