using FontAwesome.Sharp;
using System.Windows.Forms;

namespace ZenCodeERP.Forms.Visao
{
    partial class FormVisaoEmpresa
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
            toolStrip1 = new ToolStrip();
            iBtnNovo = new IconToolStripButton();
            iBtnEditar = new IconToolStripButton();
            iBtnExcluir = new IconToolStripButton();
            panel1 = new Panel();
            gvEmpresa = new DataGridView();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvEmpresa).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            toolStrip1.Font = new Font("Tahoma", 8.25F);
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { iBtnNovo, iBtnEditar, iBtnExcluir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1067, 47);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // iBtnNovo
            // 
            iBtnNovo.IconChar = IconChar.FileCirclePlus;
            iBtnNovo.IconColor = Color.DodgerBlue;
            iBtnNovo.IconFont = IconFont.Auto;
            iBtnNovo.IconSize = 32;
            iBtnNovo.Name = "iBtnNovo";
            iBtnNovo.Size = new Size(90, 44);
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
            iBtnEditar.Size = new Size(94, 44);
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
            iBtnExcluir.Size = new Size(100, 44);
            iBtnExcluir.Text = "Excluir";
            iBtnExcluir.Click += iBtnExcluir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(gvEmpresa);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 47);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 645);
            panel1.TabIndex = 1;
            // 
            // gvEmpresa
            // 
            gvEmpresa.AllowUserToAddRows = false;
            gvEmpresa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            gvEmpresa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gvEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvEmpresa.BackgroundColor = Color.WhiteSmoke;
            gvEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvEmpresa.Dock = DockStyle.Fill;
            gvEmpresa.Location = new Point(0, 0);
            gvEmpresa.Margin = new Padding(4, 5, 4, 5);
            gvEmpresa.Name = "gvEmpresa";
            gvEmpresa.ReadOnly = true;
            gvEmpresa.RowHeadersVisible = false;
            gvEmpresa.RowHeadersWidth = 51;
            gvEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvEmpresa.Size = new Size(1067, 645);
            gvEmpresa.TabIndex = 0;
            gvEmpresa.DoubleClick += gvEmpresa_DoubleClick;
            // 
            // FormVisaoEmpresa
            //
            Dock = DockStyle.Fill;
            Icon = global::ZenCodeERP.Properties.Resources.iconZenCode; 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormVisaoEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visão Empresa";
            Load += FormVisaoEmpresa_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvEmpresa).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvEmpresa;
        private IconToolStripButton iBtnNovo;
        private IconToolStripButton iBtnEditar;
        private IconToolStripButton iBtnExcluir;
    }
}