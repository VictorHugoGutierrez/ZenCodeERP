using FontAwesome.Sharp;
using System.Windows.Forms;

namespace ZenCodeERP.Forms.Visao
{
    partial class FormVisaoMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisaoMovimentacao));
            this.toolStrip1 = new ToolStrip();
            this.iBtnNovo = new IconToolStripButton();
            this.iBtnEditar = new IconToolStripButton();
            this.panel1 = new Panel();
            this.gvMovimentacao = new DataGridView();
            this.iBtnExcluir = new IconToolStripButton();
            this.iBtnFechar = new IconToolStripButton();
            this.iBtnProcessos = new IconDropDownButton();
            this.iBtnFaturar = new IconToolStripButton();
            this.iBtnCancelar = new IconToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimentacao)).BeginInit();
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { iBtnNovo, iBtnEditar, iBtnExcluir, iBtnAtualizar, iBtnFechar, iBtnProcessos });
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
            this.iBtnEditar.Name = "iBtnEditar";
            this.iBtnEditar.Size = new Size(90, 44);
            this.iBtnEditar.Text = "Editar";
            this.iBtnEditar.Click += iBtnEditar_Click;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvMovimentacao);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.TabIndex = 1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // gvMovimentacao
            // 
            this.gvMovimentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMovimentacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMovimentacao.MultiSelect = true;
            this.gvMovimentacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gvMovimentacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMovimentacao.AllowUserToAddRows = false;
            this.gvMovimentacao.AllowUserToDeleteRows = false;
            this.gvMovimentacao.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvMovimentacao.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvMovimentacao.RowHeadersVisible = false;
            this.gvMovimentacao.ReadOnly = true;
            this.gvMovimentacao.Name = "gvMovimentacao";
            this.gvMovimentacao.TabIndex = 0;
            this.gvMovimentacao.DoubleClick += new System.EventHandler(this.gvMovimentacao_DoubleClick);
            // 
            // iBtnExcluir
            // 
            this.iBtnExcluir.IconChar = IconChar.Trash;
            this.iBtnExcluir.IconColor = Color.DodgerBlue;
            this.iBtnExcluir.IconFont = IconFont.Auto;
            this.iBtnExcluir.IconSize = 32;
            this.iBtnExcluir.Name = "iBtnExcluir";
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
            this.iBtnFechar.Name = "iBtnFechar";
            this.iBtnFechar.Size = new Size(90, 44);
            this.iBtnFechar.Text = "Fechar";
            this.iBtnFechar.Click += iBtnFechar_Click;
            // 
            // iBtnProcessos
            // 
            this.iBtnProcessos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.iBtnFaturar, this.iBtnCancelar});
            this.iBtnProcessos.IconChar = IconChar.Cogs;
            this.iBtnProcessos.IconColor = Color.DodgerBlue;
            this.iBtnProcessos.IconFont = IconFont.Auto;
            this.iBtnProcessos.IconSize = 32;
            this.iBtnProcessos.Name = "iBtnProcessos";
            this.iBtnProcessos.Size = new Size(90, 44);
            this.iBtnProcessos.Text = "Processos";
            // 
            // iBtnFaturar
            // 
            this.iBtnFaturar.IconChar = IconChar.CheckCircle;
            this.iBtnFaturar.IconColor = Color.DodgerBlue;
            this.iBtnFaturar.IconFont = IconFont.Auto;
            this.iBtnFaturar.IconSize = 24;
            this.iBtnFaturar.Name = "iBtnFaturar";
            this.iBtnFaturar.Size = new Size(90, 44);
            this.iBtnFaturar.Text = "Faturar";
            this.iBtnFaturar.Click += iBtnFaturar_Click;
            // 
            // iBtnCancelar
            // 
            this.iBtnCancelar.IconChar = IconChar.Ban;
            this.iBtnCancelar.IconColor = Color.DodgerBlue;
            this.iBtnCancelar.IconFont = IconFont.Auto;
            this.iBtnCancelar.IconSize = 24;
            this.iBtnCancelar.Name = "iBtnCancelar";
            this.iBtnCancelar.Size = new Size(90, 44);
            this.iBtnCancelar.Text = "Cancelar";
            this.iBtnCancelar.Click += iBtnCancelar_Click;
            // 
            // FormVisaoMovimentacao
            // 
            this.Dock = DockStyle.Fill;
            this.Icon = global::ZenCodeERP.Properties.Resources.iconZenCode;
            this.Load += new System.EventHandler(this.FormVisaoMovimentacao_Load);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(840, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormVisaoMovimentacao";
            this.Text = "Visão Movimentação";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMovimentacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel panel1;
        private DataGridView gvMovimentacao;
        private IconToolStripButton iBtnNovo;
        private IconToolStripButton iBtnEditar;
        private IconToolStripButton iBtnExcluir;
        private IconToolStripButton iBtnFechar;
        private IconDropDownButton iBtnProcessos;
        private IconToolStripButton iBtnFaturar;
        private IconToolStripButton iBtnCancelar;
        private IconToolStripButton iBtnAtualizar;
    }
}