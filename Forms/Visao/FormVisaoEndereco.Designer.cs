using FontAwesome.Sharp;
using System.Windows.Forms;

namespace ZenCodeERP.Forms.Visao
{
    partial class FormVisaoEndereco
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
            iBtnFechar = new IconToolStripButton();
            panel1 = new Panel();
            gvEndereco = new DataGridView();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvEndereco).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Tahoma", 8.25F);
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { iBtnNovo, iBtnEditar, iBtnExcluir, iBtnFechar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1410, 37);
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
            iBtnNovo.Size = new Size(75, 34);
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
            iBtnEditar.Size = new Size(77, 34);
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
            iBtnExcluir.Size = new Size(82, 34);
            iBtnExcluir.Text = "Excluir";
            iBtnExcluir.Click += iBtnExcluir_Click;
            // 
            // iBtnFechar
            // 
            iBtnFechar.IconChar = IconChar.Close;
            iBtnFechar.IconColor = Color.DodgerBlue;
            iBtnFechar.IconFont = IconFont.Auto;
            iBtnFechar.IconSize = 32;
            iBtnFechar.Name = "iBtnFechar";
            iBtnFechar.Size = new Size(83, 34);
            iBtnFechar.Text = "Fechar";
            iBtnFechar.Click += iBtnFechar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(gvEndereco);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 37);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1410, 532);
            panel1.TabIndex = 1;
            // 
            // gvEndereco
            // 
            gvEndereco.AllowUserToAddRows = false;
            gvEndereco.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            gvEndereco.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gvEndereco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvEndereco.BackgroundColor = Color.WhiteSmoke;
            gvEndereco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvEndereco.Dock = DockStyle.Fill;
            gvEndereco.Location = new Point(0, 0);
            gvEndereco.Margin = new Padding(4, 5, 4, 5);
            gvEndereco.Name = "gvEndereco";
            gvEndereco.ReadOnly = true;
            gvEndereco.RowHeadersVisible = false;
            gvEndereco.RowHeadersWidth = 51;
            gvEndereco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvEndereco.Size = new Size(1410, 532);
            gvEndereco.TabIndex = 0;
            gvEndereco.DoubleClick += gvEndereco_DoubleClick;
            // 
            // FormVisaoEndereco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1410, 569);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Icon = Properties.Resources.iconZenCode;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormVisaoEndereco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visão Endereço";
            Load += FormVisaoEndereco_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvEndereco).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel panel1;
        private DataGridView gvEndereco;
        private IconToolStripButton iBtnNovo;
        private IconToolStripButton iBtnEditar;
        private IconToolStripButton iBtnExcluir;
        private IconToolStripButton iBtnFechar;
    }
}