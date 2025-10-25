using System.Windows.Forms;
using FontAwesome.Sharp;

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
            toolStrip1 = new ToolStrip();
            toolStripButtonEndereco = new IconToolStripButton();
            toolStripButtonEmpresa = new IconToolStripButton();
            toolStripButtonUsuario = new IconToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Tahoma", 9.25F);
            toolStrip1.Dock = DockStyle.Top;
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonEndereco, toolStripButtonEmpresa, toolStripButtonUsuario });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1000, 47);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonEndereco
            // 
            toolStripButtonEndereco.IconChar = IconChar.MapLocationDot;
            toolStripButtonEndereco.IconColor = Color.DodgerBlue;
            toolStripButtonEndereco.IconFont = IconFont.Auto;
            toolStripButtonEndereco.IconSize = 64;
            toolStripButtonEndereco.Name = "toolStripButtonEndereco";
            toolStripButtonEndereco.Size = new Size(75, 44);
            toolStripButtonEndereco.Text = "Endereço";
            toolStripButtonEndereco.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButtonEndereco.Click += toolStripButtonEndereco_Click;
            // 
            // toolStripButtonEmpresa
            // 
            toolStripButtonEmpresa.IconChar = IconChar.Building;
            toolStripButtonEmpresa.IconColor = Color.DodgerBlue;
            toolStripButtonEmpresa.IconFont = IconFont.Auto;
            toolStripButtonEmpresa.IconSize = 64;
            toolStripButtonEmpresa.Name = "toolStripButtonEmpresa";
            toolStripButtonEmpresa.Size = new Size(70, 44);
            toolStripButtonEmpresa.Text = "Empresa";
            toolStripButtonEmpresa.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButtonEmpresa.Click += toolStripButtonEmpresa_Click;
            // 
            // toolStripButtonUsuario
            // 
            toolStripButtonUsuario.IconChar = IconChar.User;
            toolStripButtonUsuario.IconColor = Color.DodgerBlue;
            toolStripButtonUsuario.IconFont = IconFont.Auto;
            toolStripButtonUsuario.IconSize = 64;
            toolStripButtonUsuario.Name = "toolStripButtonUsuario";
            toolStripButtonUsuario.Size = new Size(69, 44);
            toolStripButtonUsuario.Text = "Usuários";
            toolStripButtonUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButtonUsuario.Click += toolStripButtonUsuario_Click;
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 749);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MDIPrincipal";
            Text = "ZenCode ERP - Principal";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private IconToolStripButton toolStripButtonEndereco;
        private IconToolStripButton toolStripButtonEmpresa;
        private IconToolStripButton toolStripButtonUsuario;
    }
}