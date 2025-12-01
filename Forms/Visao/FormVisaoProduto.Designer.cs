using FontAwesome.Sharp;
using System.Windows.Forms;

namespace ZenCodeERP.Forms.Visao
{
    partial class FormVisaoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisaoProduto));
            this.toolStrip1 = new ToolStrip();
            this.iBtnNovo = new IconToolStripButton();
            this.iBtnEditar = new IconToolStripButton();
            this.panel1 = new Panel();
            this.gvProduto = new DataGridView();
            this.iBtnExcluir = new IconToolStripButton();
            this.iBtnFechar = new IconToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStrip1.ImageScalingSize = new Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iBtnNovo,
            this.iBtnEditar,
            this.iBtnExcluir,
            this.iBtnFechar});
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
            this.panel1.Controls.Add(this.gvProduto);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.TabIndex = 1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // gvProduto
            // 
            this.gvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvProduto.MultiSelect = true;
            this.gvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gvProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProduto.AllowUserToAddRows = false;
            this.gvProduto.AllowUserToDeleteRows = false;
            this.gvProduto.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvProduto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvProduto.RowHeadersVisible = false;
            this.gvProduto.ReadOnly = true;
            this.gvProduto.Name = "gvProduto";
            this.gvProduto.TabIndex = 0;
            this.gvProduto.DoubleClick += new System.EventHandler(this.gvProduto_DoubleClick);
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
            // iBtnFechar
            // 
            this.iBtnFechar.IconChar = IconChar.Close;
            this.iBtnFechar.IconColor = Color.DodgerBlue;
            this.iBtnFechar.IconFont = IconFont.Auto;
            this.iBtnFechar.IconSize = 32;
            this.iBtnFechar.Name = "iBtnNovo";
            this.iBtnFechar.Size = new Size(90, 44);
            this.iBtnFechar.Text = "Fechar";
            this.iBtnFechar.Click += iBtnFechar_Click;
            // 
            // FormVisaoProduto
            // 
            this.Dock = DockStyle.Fill;
            this.Icon = global::ZenCodeERP.Properties.Resources.iconZenCode;
            this.Load += new System.EventHandler(this.FormVisaoProduto_Load);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(840, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormVisaoProduto";
            this.Text = "Visão Endereço";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel panel1;
        private DataGridView gvProduto;
        private IconToolStripButton iBtnNovo;
        private IconToolStripButton iBtnEditar;
        private IconToolStripButton iBtnExcluir;
        private IconToolStripButton iBtnFechar;
    }
}