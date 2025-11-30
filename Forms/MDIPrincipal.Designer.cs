    using System.Windows.Controls;
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
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            toolStripButtonRelatorio = new IconToolStripButton();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Tahoma", 9.25F);
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonEndereco, toolStripButtonEmpresa, toolStripButtonUsuario, toolStripButtonRelatorio });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1000, 56);
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
            toolStripButtonEndereco.Size = new Size(78, 53);
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
            toolStripButtonEmpresa.Size = new Size(74, 53);
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
            toolStripButtonUsuario.Size = new Size(74, 53);
            toolStripButtonUsuario.Text = "Usuários";
            toolStripButtonUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButtonUsuario.Click += toolStripButtonUsuario_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 70);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 679);
            panel2.TabIndex = 8;
            // 
            // toolStripButtonRelatorio
            // 
            toolStripButtonRelatorio.IconChar = IconChar.User;
            toolStripButtonRelatorio.IconColor = Color.DodgerBlue;
            toolStripButtonRelatorio.IconFont = IconFont.Auto;
            toolStripButtonRelatorio.IconSize = 64;
            toolStripButtonRelatorio.Name = "toolStripButtonRelatorio";
            toolStripButtonRelatorio.Size = new Size(79, 53);
            toolStripButtonRelatorio.Text = "relatorios";
            toolStripButtonRelatorio.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButtonRelatorio.Click += toolStripButtonRelatorio_Click;
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = Properties.Resources.iconZenCode;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MDIPrincipal";
            Text = "ZenCode ERP";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            Load += MDIPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
            private System.Windows.Forms.Panel panel1;
            private System.Windows.Forms.Panel panel2;
            private IconToolStripButton toolStripButtonEndereco;
            private IconToolStripButton toolStripButtonEmpresa;
            private IconToolStripButton toolStripButtonUsuario;
        private IconToolStripButton toolStripButtonRelatorio;
    }
    }