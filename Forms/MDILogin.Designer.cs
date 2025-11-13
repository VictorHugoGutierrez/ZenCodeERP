using ZenCodeERP.Model;

namespace ZenCodeERP.Forms
{
    partial class MDILogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDILogin));
            btnEntrar = new Button();
            tbSenha = new TextBox();
            tbUsuario = new TextBox();
            btnFechar = new Panel();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(0, 120, 215);
            btnEntrar.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 90, 180);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 150, 255);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.Transparent;
            btnEntrar.Location = new Point(195, 356);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(145, 42);
            btnEntrar.TabIndex = 4;
            btnEntrar.TabStop = false;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // tbSenha
            // 
            tbSenha.BorderStyle = BorderStyle.None;
            tbSenha.Font = new Font("Segoe UI", 11.5F);
            tbSenha.Location = new Point(90, 316);
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.PlaceholderText = "Senha";
            tbSenha.Size = new Size(353, 21);
            tbSenha.TabIndex = 3;
            tbSenha.UseSystemPasswordChar = true;
            // 
            // tbUsuario
            // 
            tbUsuario.BorderStyle = BorderStyle.None;
            tbUsuario.Font = new Font("Segoe UI", 11.5F);
            tbUsuario.Location = new Point(90, 273);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.PlaceholderText = "Usuário";
            tbUsuario.Size = new Size(353, 21);
            tbUsuario.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Location = new Point(503, 4);
            btnFechar.Margin = new Padding(3, 2, 3, 2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(30, 25);
            btnFechar.TabIndex = 5;
            btnFechar.Click += btnFechar_Click;
            // 
            // MDILogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(536, 556);
            Controls.Add(btnFechar);
            Controls.Add(btnEntrar);
            Controls.Add(tbSenha);
            Controls.Add(tbUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Icon = Properties.Resources.iconZenCode;
            Name = "MDILogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MDILogin";
            Shown += MDILogin_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbSenha;
        private TextBox tbUsuario;
        private Button btnEntrar;
        private Panel pnlLogin;
        private Panel btnFechar;
    }
}