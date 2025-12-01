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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.iBtnGerarRelatorio = new FontAwesome.Sharp.IconToolStripButton();
            this.iBtnBaixarCsv = new FontAwesome.Sharp.IconToolStripButton();
            this.iBtnBaixarPDF = new FontAwesome.Sharp.IconToolStripButton();
            this.iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iBtnGerarRelatorio,
            this.iBtnBaixarCsv,
            this.iBtnBaixarPDF,
            this.iconToolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1202, 37);
            this.toolStrip2.TabIndex = 15;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // iBtnGerarRelatorio
            // 
            this.iBtnGerarRelatorio.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.iBtnGerarRelatorio.IconColor = System.Drawing.Color.DodgerBlue;
            this.iBtnGerarRelatorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnGerarRelatorio.IconSize = 32;
            this.iBtnGerarRelatorio.Name = "iBtnGerarRelatorio";
            this.iBtnGerarRelatorio.Size = new System.Drawing.Size(113, 34);
            this.iBtnGerarRelatorio.Text = "Gerar Relatório";
            this.iBtnGerarRelatorio.Click += new System.EventHandler(this.iBtnGerarRelatorio_Click_1);
            // 
            // iBtnBaixarCsv
            // 
            this.iBtnBaixarCsv.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.iBtnBaixarCsv.IconColor = System.Drawing.Color.DodgerBlue;
            this.iBtnBaixarCsv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBaixarCsv.IconSize = 32;
            this.iBtnBaixarCsv.Name = "iBtnBaixarCsv";
            this.iBtnBaixarCsv.Size = new System.Drawing.Size(94, 34);
            this.iBtnBaixarCsv.Text = "Baixar CSV";
            this.iBtnBaixarCsv.Click += new System.EventHandler(this.iBtnBaixarCsv_Click);
            // 
            // iBtnBaixarPDF
            // 
            this.iBtnBaixarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iBtnBaixarPDF.IconColor = System.Drawing.Color.DodgerBlue;
            this.iBtnBaixarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnBaixarPDF.IconSize = 32;
            this.iBtnBaixarPDF.Name = "iBtnBaixarPDF";
            this.iBtnBaixarPDF.Size = new System.Drawing.Size(93, 34);
            this.iBtnBaixarPDF.Text = "Baixar PDF";
            this.iBtnBaixarPDF.Click += new System.EventHandler(this.iBtnBaixarPDF_Click);
            // 
            // iconToolStripButton1
            // 
            this.iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconToolStripButton1.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconToolStripButton1.IconSize = 32;
            this.iconToolStripButton1.Name = "iconToolStripButton1";
            this.iconToolStripButton1.Size = new System.Drawing.Size(73, 34);
            this.iconToolStripButton1.Text = "Fechar";
            this.iconToolStripButton1.Click += new System.EventHandler(this.iconToolStripButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtInicio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtFim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 70);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Início:";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(12, 36);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(129, 27);
            this.dtInicio.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fim:";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(160, 36);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(129, 27);
            this.dtFim.TabIndex = 14;
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.AllowUserToAddRows = false;
            this.dgvRelatorio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvRelatorio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRelatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRelatorio.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRelatorio.Location = new System.Drawing.Point(0, 107);
            this.dgvRelatorio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.RowHeadersVisible = false;
            this.dgvRelatorio.RowHeadersWidth = 51;
            this.dgvRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorio.Size = new System.Drawing.Size(1202, 328);
            this.dgvRelatorio.TabIndex = 9;
            // 
            // formVisaoRelatorioVendas
            // 
            this.Dock = DockStyle.Fill;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 435);
            this.Controls.Add(this.dgvRelatorio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "formVisaoRelatorioVendas";
            this.Text = "Relatório de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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