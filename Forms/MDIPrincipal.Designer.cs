using System.Windows.Forms;

namespace ZenCodeERP.Forms
{
    partial class MDIPrincipal
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
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            this.toolStrip1 = new ToolStrip();
            this.toolStripButtonEmpresa = new ToolStripButton();
            this.toolStripButtonUsuario = new ToolStripButton();
            this.toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonEmpresa, toolStripButtonUsuario });
            this.toolStrip1.Location = new Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new Size(875, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonEmpresa
            // 
            this.toolStripButtonEmpresa.Image = (Image)resources.GetObject("toolStripButtonEmpresa.Image");
            this.toolStripButtonEmpresa.ImageTransparentColor = Color.Magenta;
            this.toolStripButtonEmpresa.Name = "toolStripButtonEmpresa";
            this.toolStripButtonEmpresa.Size = new Size(72, 22);
            this.toolStripButtonEmpresa.Text = "Empresa";
            this.toolStripButtonEmpresa.Click += new EventHandler(this.toolStripButtonEmpresa_Click);
            // 
            // toolStripButtonUsuario
            // 
            this.toolStripButtonUsuario.Image = (Image)resources.GetObject("toolStripButtonUsuario.Image");
            this.toolStripButtonUsuario.ImageTransparentColor = Color.Magenta;
            this.toolStripButtonUsuario.Name = "toolStripButtonUsuario";
            this.toolStripButtonUsuario.Size = new Size(72, 22);
            this.toolStripButtonUsuario.Text = "Usuários";
            this.toolStripButtonUsuario.Click += new EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(875, 562);
            this.Controls.Add(toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIPrincipal";
            this.Text = "ZenCode ERP - Principal";
            this.WindowState = FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonEmpresa;
        private ToolStripButton toolStripButtonUsuario;
    }
}