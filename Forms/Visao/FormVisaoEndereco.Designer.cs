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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisaoEndereco));
            this.toolStrip1 = new ToolStrip();
            this.iBtnNovo = new IconToolStripButton();
            this.iBtnEditar = new IconToolStripButton();
            this.panel1 = new Panel();
            this.gvEndereco = new DataGridView();
            this.iBtnExcluir = new IconToolStripButton();
            this.iBtnFechar = new IconToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEndereco)).BeginInit();
            this.SuspendLayout();
            iBtnAtualizar = new IconToolStripButton();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStrip1.ImageScalingSize = new Size(30, 30);
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            toolStrip1.Items.AddRange(new ToolStripItem[] { iBtnNovo, iBtnEditar, iBtnExcluir, iBtnAtualizar, iBtnFechar });
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
            // iBtnAtualizar
            // 
            iBtnAtualizar.IconChar = IconChar.ArrowRotateForward;
            iBtnAtualizar.IconColor = Color.DodgerBlue;
            iBtnAtualizar.IconFont = IconFont.Auto;
            iBtnAtualizar.IconSize = 32;
            iBtnAtualizar.Name = "iBtnAtualizar";
            iBtnAtualizar.Size = new Size(92, 34);
            iBtnAtualizar.Text = "Atualizar";
            iBtnAtualizar.Click += iBtnAtualizar_Click;
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
            Dock = DockStyle.Fill;
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
        private IconToolStripButton iBtnAtualizar;
    }
}