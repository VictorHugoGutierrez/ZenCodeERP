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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisaoEndereco));
            this.toolStrip1 = new ToolStrip();
            this.iBtnNovo = new IconToolStripButton();
            this.iBtnEditar = new IconToolStripButton();
            this.panel1 = new Panel();
            this.gvEndereco = new DataGridView();
            this.iBtnExcluir = new IconToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStrip1.ImageScalingSize = new Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iBtnNovo,
            this.iBtnEditar,
            this.iBtnExcluir});
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // iBtnNovo
            // 
            this.iBtnNovo.IconChar = IconChar.FileCirclePlus;
            this.iBtnNovo.IconColor = Color.DodgerBlue;
            this.iBtnNovo.IconFont = IconFont.Auto;
            this.iBtnNovo.IconSize = 32;
            this.iBtnNovo.Name = "iBtnNovo";
            this.iBtnNovo.Size = new Size(90, 44);
            this.iBtnNovo.Text = "Novo";
            this.iBtnNovo.Click += iBtnNovo_Click;
            // 
            // iBtnEditar
            // 
            this.iBtnEditar.IconChar = IconChar.Edit;
            this.iBtnEditar.IconColor = Color.DodgerBlue;
            this.iBtnEditar.IconFont = IconFont.Auto;
            this.iBtnEditar.IconSize = 32;
            this.iBtnEditar.Name = "iBtnNovo";
            this.iBtnEditar.Size = new Size(90, 44);
            this.iBtnEditar.Text = "Editar";
            this.iBtnEditar.Click += iBtnEditar_Click;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvEndereco);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.TabIndex = 1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // gvEndereco
            // 
            this.gvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvEndereco.MultiSelect = true;
            this.gvEndereco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gvEndereco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gvEndereco.AllowUserToAddRows = false;
            this.gvEndereco.AllowUserToDeleteRows = false;
            this.gvEndereco.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240))))); // Linhas zebradas
            this.gvEndereco.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvEndereco.RowHeadersVisible = false;
            this.gvEndereco.ReadOnly = true;
            this.gvEndereco.Name = "gvEndereco";
            this.gvEndereco.TabIndex = 0;
            this.gvEndereco.DoubleClick += new System.EventHandler(this.gvEndereco_DoubleClick);
            // 
            // iBtnExcluir
            // 
            this.iBtnExcluir.IconChar = IconChar.Trash;
            this.iBtnExcluir.IconColor = Color.DodgerBlue;
            this.iBtnExcluir.IconFont = IconFont.Auto;
            this.iBtnExcluir.IconSize = 32;
            this.iBtnExcluir.Name = "iBtnNovo";
            this.iBtnExcluir.Size = new Size(90, 44);
            this.iBtnExcluir.Text = "Excluir";
            this.iBtnExcluir.Click += iBtnExcluir_Click;
            // 
            // FormVisaoEndereco
            // 
            this.Load += new System.EventHandler(this.FormVisaoEndereco_Load);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(840, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormVisaoEndereco";
            this.Text = "Visão Endereço";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel panel1;
        private DataGridView gvEndereco;
        private IconToolStripButton iBtnNovo;
        private IconToolStripButton iBtnEditar;
        private IconToolStripButton iBtnExcluir;
    }
}