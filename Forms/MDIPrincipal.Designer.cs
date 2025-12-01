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
            iconToolStripButtonEndereco = new IconToolStripButton();
            iconToolStripButtonEmpresa = new IconToolStripButton();
            iconToolStripButtonUsuario = new IconToolStripButton();
            toolStripButtonRelatorio = new IconDropDownButton();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            relatórioTicketMédioPorClienteToolStripMenuItem = new ToolStripMenuItem();
            iconToolStripButtonCliFor = new IconToolStripButton();
            iconToolStripButtonProduto = new IconToolStripButton();
            iconToolStripButtonMovimentacao = new IconToolStripButton();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            iconToolStripButtonClassificacao = new IconToolStripButton();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Tahoma", 9.25F);
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { iconToolStripButtonEndereco, iconToolStripButtonEmpresa, iconToolStripButtonUsuario, iconToolStripButtonCliFor, iconToolStripButtonClassificacao, iconToolStripButtonProduto, iconToolStripButtonMovimentacao, toolStripButtonRelatorio });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1000, 56);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // iconToolStripButtonEndereco
            // 
            iconToolStripButtonEndereco.IconChar = IconChar.MapLocationDot;
            iconToolStripButtonEndereco.IconColor = Color.DodgerBlue;
            iconToolStripButtonEndereco.IconFont = IconFont.Auto;
            iconToolStripButtonEndereco.IconSize = 64;
            iconToolStripButtonEndereco.Name = "iconToolStripButtonEndereco";
            iconToolStripButtonEndereco.Size = new Size(78, 53);
            iconToolStripButtonEndereco.Text = "Endereço";
            iconToolStripButtonEndereco.TextImageRelation = TextImageRelation.ImageAboveText;
            iconToolStripButtonEndereco.Click += iconToolStripButtonEndereco_Click;
            // 
            // iconToolStripButtonEmpresa
            // 
            iconToolStripButtonEmpresa.IconChar = IconChar.Building;
            iconToolStripButtonEmpresa.IconColor = Color.DodgerBlue;
            iconToolStripButtonEmpresa.IconFont = IconFont.Auto;
            iconToolStripButtonEmpresa.IconSize = 64;
            iconToolStripButtonEmpresa.Name = "iconToolStripButtonEmpresa";
            iconToolStripButtonEmpresa.Size = new Size(74, 53);
            iconToolStripButtonEmpresa.Text = "Empresa";
            iconToolStripButtonEmpresa.TextImageRelation = TextImageRelation.ImageAboveText;
            iconToolStripButtonEmpresa.Click += iconToolStripButtonEmpresa_Click;
            // 
            // iconToolStripButtonUsuario
            // 
            iconToolStripButtonUsuario.IconChar = IconChar.User;
            iconToolStripButtonUsuario.IconColor = Color.DodgerBlue;
            iconToolStripButtonUsuario.IconFont = IconFont.Auto;
            iconToolStripButtonUsuario.IconSize = 64;
            iconToolStripButtonUsuario.Name = "iconToolStripButtonUsuario";
            iconToolStripButtonUsuario.Size = new Size(74, 53);
            iconToolStripButtonUsuario.Text = "Usuários";
            iconToolStripButtonUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            iconToolStripButtonUsuario.Click += iconToolStripButtonUsuario_Click;
            // 
            // iconToolStripButtonCliFor
            // 
            iconToolStripButtonCliFor.IconChar = IconChar.PeopleGroup;
            iconToolStripButtonCliFor.IconColor = Color.DodgerBlue;
            iconToolStripButtonCliFor.IconFont = IconFont.Auto;
            iconToolStripButtonCliFor.IconSize = 64;
            iconToolStripButtonCliFor.Name = "iconToolStripButtonCliFor";
            iconToolStripButtonCliFor.Size = new Size(145, 53);
            iconToolStripButtonCliFor.Text = "Cliente/Fornecedor";
            iconToolStripButtonCliFor.TextImageRelation = TextImageRelation.ImageAboveText;
            iconToolStripButtonCliFor.Click += iconToolStripButtonCliFor_Click;
            // 
            // iconToolStripButtonProduto
            // 
            iconToolStripButtonProduto.IconChar = IconChar.BoxesPacking;
            iconToolStripButtonProduto.IconColor = Color.DodgerBlue;
            iconToolStripButtonProduto.IconFont = IconFont.Auto;
            iconToolStripButtonProduto.IconSize = 64;
            iconToolStripButtonProduto.Name = "iconToolStripButtonProduto";
            iconToolStripButtonProduto.Size = new Size(145, 53);
            iconToolStripButtonProduto.Text = "Produto";
            iconToolStripButtonProduto.TextImageRelation = TextImageRelation.ImageAboveText;
            iconToolStripButtonProduto.Click += iconToolStripButtonProduto_Click;
            // 
            // toolStripButtonRelatorio
            // 
            toolStripButtonRelatorio.DropDownItems.AddRange(new ToolStripItem[] { relatórioToolStripMenuItem, relatórioTicketMédioPorClienteToolStripMenuItem });
            toolStripButtonRelatorio.IconChar = IconChar.Newspaper;
            toolStripButtonRelatorio.IconColor = Color.DodgerBlue;
            toolStripButtonRelatorio.IconFont = IconFont.Auto;
            toolStripButtonRelatorio.Name = "toolStripButtonRelatorio";
            toolStripButtonRelatorio.Size = new Size(89, 53);
            toolStripButtonRelatorio.Text = "Relatórios";
            toolStripButtonRelatorio.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(357, 26);
            relatórioToolStripMenuItem.Text = "Estoque de produtos por classificação";
            relatórioToolStripMenuItem.Click += relatórioToolStripMenuItem_Click;
            // 
            // relatórioTicketMédioPorClienteToolStripMenuItem
            // 
            relatórioTicketMédioPorClienteToolStripMenuItem.Name = "relatórioTicketMédioPorClienteToolStripMenuItem";
            relatórioTicketMédioPorClienteToolStripMenuItem.Size = new Size(357, 26);
            relatórioTicketMédioPorClienteToolStripMenuItem.Text = "Ticket Médio por cliente";
            relatórioTicketMédioPorClienteToolStripMenuItem.Click += relatórioTicketMédioPorClienteToolStripMenuItem_Click;
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
            // iconToolStripButtonClassificacao
            // 
            iconToolStripButtonClassificacao.IconChar = IconChar.Tags;
            iconToolStripButtonClassificacao.IconColor = Color.DodgerBlue;
            iconToolStripButtonClassificacao.IconFont = IconFont.Auto;
            iconToolStripButtonClassificacao.IconSize = 64;
            iconToolStripButtonClassificacao.Name = "iconToolStripButtonClassificacao";
            iconToolStripButtonClassificacao.Size = new Size(101, 53);
            iconToolStripButtonClassificacao.Text = "Classificação";
            iconToolStripButtonClassificacao.TextImageRelation = TextImageRelation.ImageAboveText;
            iconToolStripButtonClassificacao.Click += iconToolStripButtonClassificacao_Click;
            // 
            // iconToolStripButtonMovimentacao
            // 
            iconToolStripButtonMovimentacao.IconChar = IconChar.BoxArchive;
            iconToolStripButtonMovimentacao.IconColor = Color.DodgerBlue;
            iconToolStripButtonMovimentacao.IconFont = IconFont.Auto;
            iconToolStripButtonMovimentacao.IconSize = 64;
            iconToolStripButtonMovimentacao.Name = "iconToolStripButtonMovimentacao";
            iconToolStripButtonMovimentacao.Size = new Size(101, 53);
            iconToolStripButtonMovimentacao.Text = "Movimentação";
            iconToolStripButtonMovimentacao.TextImageRelation = TextImageRelation.ImageAboveText;
            iconToolStripButtonMovimentacao.Click += iconToolStripButtonMovimentacao_Click;
            // 
            // estoqueGeralDeProdutosToolStripMenuItem
            // 
            //estoqueGeralDeProdutosToolStripMenuItem.Name = "estoqueGeralDeProdutosToolStripMenuItem";
            //estoqueGeralDeProdutosToolStripMenuItem.Size = new Size(357, 26);
            //estoqueGeralDeProdutosToolStripMenuItem.Text = "Estoque geral de Produtos";
            //estoqueGeralDeProdutosToolStripMenuItem.Click += estoqueGeralDeProdutosToolStripMenuItem_Click;
            // 
            // MDIPrincipal
            // 
            ShowInTaskbar = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = Properties.Resources.iconZenCode;
            ShowIcon = true;
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
        private IconToolStripButton iconToolStripButtonEndereco;
        private IconToolStripButton iconToolStripButtonEmpresa;
        private IconToolStripButton iconToolStripButtonUsuario;
        private IconToolStripButton iconToolStripButtonCliFor;
        private IconToolStripButton iconToolStripButtonClassificacao;
        private IconToolStripButton iconToolStripButtonProduto;
        private IconToolStripButton iconToolStripButtonMovimentacao;
        private IconDropDownButton toolStripButtonRelatorio;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem relatórioTicketMédioPorClienteToolStripMenuItem;
        private ToolStripMenuItem estoqueGeralDeProdutosToolStripMenuItem;
    }
    }