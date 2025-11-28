using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ZenCodeERP.Forms
{
    partial class MDISelecaoEmpresa
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
            gvEmpresa = new DataGridView();
            panel1 = new Panel();
            iconBtnSelecionar = new IconButton();
            ((System.ComponentModel.ISupportInitialize)gvEmpresa).BeginInit();
            SuspendLayout();
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
            gvEmpresa.MultiSelect = false;
            gvEmpresa.Name = "gvEmpresa";
            gvEmpresa.ReadOnly = true;
            gvEmpresa.RowHeadersVisible = false;
            gvEmpresa.RowHeadersWidth = 51;
            gvEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvEmpresa.Size = new Size(535, 52);
            gvEmpresa.TabIndex = 0;
            gvEmpresa.DoubleClick += gvEmpresa_DoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(gvEmpresa);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 198);
            panel1.TabIndex = 0;
            // 
            // iconBtnSelecionar
            // 
            iconBtnSelecionar.IconChar = IconChar.Check;
            iconBtnSelecionar.IconColor = Color.DodgerBlue;
            iconBtnSelecionar.IconFont = IconFont.Auto;
            iconBtnSelecionar.IconSize = 32;
            iconBtnSelecionar.Location = new Point(382, 203);
            iconBtnSelecionar.Name = "iconBtnSelecionar";
            iconBtnSelecionar.Size = new Size(142, 34);
            iconBtnSelecionar.TabIndex = 1;
            iconBtnSelecionar.Text = "Selecionar";
            iconBtnSelecionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnSelecionar.Click += new System.EventHandler(this.iconBtnSelecionar_Click);
            // 
            // MDISelecaoEmpresa
            // 
            ShowInTaskbar = true; 
            ShowIcon = true;
            FormClosing += new FormClosingEventHandler(MDISelecaoEmpresa_FormClosing);
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(536, 243);
            Controls.Add(iconBtnSelecionar);
            Controls.Add(panel1);
            Icon = Properties.Resources.iconZenCode;
            Name = "MDISelecaoEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleção de Empresa";
            Load += MDISelecaoEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)gvEmpresa).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlLogin;
        private DataGridView gvEmpresa;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnSelecionar;
    }
}