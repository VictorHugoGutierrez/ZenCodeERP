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
            btnEntrar.BackColor = SystemColors.Highlight;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 10.5F);
            btnEntrar.ForeColor = SystemColors.ButtonFace;
            btnEntrar.Location = new Point(283, 508);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(205, 58);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // tbSenha
            // 
            tbSenha.BorderStyle = BorderStyle.None;
            tbSenha.Font = new Font("Segoe UI", 11.5F);
            tbSenha.Location = new Point(128, 452);
            tbSenha.Margin = new Padding(3, 4, 3, 4);
            tbSenha.Name = "tbSenha";
            tbSenha.PlaceholderText = "Senha";
            tbSenha.Size = new Size(509, 26);
            tbSenha.TabIndex = 3;
            tbSenha.PasswordChar = '*';
            tbSenha.UseSystemPasswordChar = true;
            // 
            // tbUsuario
            // 
            tbUsuario.BorderStyle = BorderStyle.None;
            tbUsuario.Font = new Font("Segoe UI", 11.5F);
            tbUsuario.Location = new Point(128, 391);
            tbUsuario.Margin = new Padding(3, 4, 3, 4);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.PlaceholderText = "Usuário";
            tbUsuario.Size = new Size(509, 26);
            tbUsuario.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Location = new Point(726, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(37, 27);
            btnFechar.TabIndex = 5;
            btnFechar.Click += btnFechar_Click;
            // 
            // MDILogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(765, 750);
            Controls.Add(btnFechar);
            Controls.Add(btnEntrar);
            Controls.Add(tbSenha);
            Controls.Add(tbUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MDILogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MDILogin";
            Icon = global::ZenCodeERP.Properties.Resources.iconZenCode;
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