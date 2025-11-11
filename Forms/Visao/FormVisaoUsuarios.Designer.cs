using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ZenCodeERP.Forms.Visao
{
    partial class FormVisaoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisaoUsuarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.iBtnNovo = new FontAwesome.Sharp.IconToolStripButton();
            this.iBtnEditar = new FontAwesome.Sharp.IconToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvUsuarios = new System.Windows.Forms.DataGridView();
            this.iBtnExcluir = new FontAwesome.Sharp.IconToolStripButton();
            this.iBtnFechar = new IconToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 29);
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
            this.iBtnNovo.Size = new System.Drawing.Size(40, 26);
            this.iBtnNovo.Text = "Novo";
            this.iBtnNovo.Click += new System.EventHandler(this.iBtnNovo_Click);
            // 
            // iBtnEditar
            // 
            this.iBtnEditar.IconChar = IconChar.Edit;
            this.iBtnEditar.IconColor = Color.DodgerBlue;
            this.iBtnEditar.IconFont = IconFont.Auto;
            this.iBtnEditar.IconSize = 32;
            this.iBtnEditar.Name = "iBtnEditar";
            this.iBtnEditar.Size = new System.Drawing.Size(41, 26);
            this.iBtnEditar.Text = "Editar";
            this.iBtnEditar.Click += new System.EventHandler(this.iBtnEditar_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gvUsuarios);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.TabIndex = 1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // gvUsuarios
            // 
            this.gvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvUsuarios.MultiSelect = true;
            this.gvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUsuarios.AllowUserToAddRows = false;
            this.gvUsuarios.AllowUserToDeleteRows = false;
            this.gvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240))))); // Linhas zebradas
            this.gvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvUsuarios.RowHeadersVisible = false;
            this.gvUsuarios.ReadOnly = true;
            this.gvUsuarios.Name = "gvUsuarios";
            this.gvUsuarios.TabIndex = 0;
            this.gvUsuarios.DoubleClick += new System.EventHandler(this.gvUsuarios_DoubleClick);
            // 
            // iBtnExcluir
            // 
            this.iBtnExcluir.IconChar = IconChar.Trash;
            this.iBtnExcluir.IconColor = Color.DodgerBlue;
            this.iBtnExcluir.IconFont = IconFont.Auto;
            this.iBtnExcluir.IconSize = 32;
            this.iBtnExcluir.Name = "iBtnExcluir";
            this.iBtnExcluir.Size = new System.Drawing.Size(23, 26);
            this.iBtnExcluir.Text = "Excluir";
            this.iBtnExcluir.Click += new System.EventHandler(this.iBtnExcluir_Click);
            // 
            // FormVisaoUsuarios
            // 
            this.Dock = DockStyle.Fill;
            this.Icon = global:: ZenCodeERP.Properties.Resources.iconZenCode;
            this.Load += new System.EventHandler(this.FormVisaoUsuarios_Load);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormVisaoUsuarios";
            this.Text = "Visão Usuário";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvUsuarios;
        private FontAwesome.Sharp.IconToolStripButton iBtnNovo;
        private FontAwesome.Sharp.IconToolStripButton iBtnEditar;
        private FontAwesome.Sharp.IconToolStripButton iBtnExcluir;
        private IconToolStripButton iBtnFechar;

    }
}