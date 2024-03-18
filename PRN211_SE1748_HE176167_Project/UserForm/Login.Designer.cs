namespace UserForm
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            rdbUser = new RadioButton();
            rdbAdmin = new RadioButton();
            btnRegister = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumPurple;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(171, 319);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 41);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // rdbUser
            // 
            rdbUser.AutoSize = true;
            rdbUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbUser.Location = new Point(96, 255);
            rdbUser.Name = "rdbUser";
            rdbUser.Size = new Size(62, 24);
            rdbUser.TabIndex = 0;
            rdbUser.TabStop = true;
            rdbUser.Text = "User";
            rdbUser.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            rdbAdmin.AutoSize = true;
            rdbAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdbAdmin.Location = new Point(191, 255);
            rdbAdmin.Name = "rdbAdmin";
            rdbAdmin.Size = new Size(77, 24);
            rdbAdmin.TabIndex = 7;
            rdbAdmin.TabStop = true;
            rdbAdmin.Text = "Admin";
            rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MediumPurple;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(291, 319);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 41);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(96, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(285, 27);
            txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(96, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(285, 27);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 49);
            label3.Name = "label3";
            label3.Size = new Size(329, 41);
            label3.TabIndex = 13;
            label3.Text = "Login to Your Account";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(481, 413);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Controls.Add(rdbAdmin);
            Controls.Add(rdbUser);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Register";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private RadioButton rdbUser;
        private RadioButton rdbAdmin;
        private Button btnRegister;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
    }
}
