namespace UserForm
{
    partial class Register
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
            label3 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            txtFullname = new TextBox();
            txtPhonenumber = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtConfirm = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(140, 63);
            label3.Name = "label3";
            label3.Size = new Size(134, 41);
            label3.TabIndex = 20;
            label3.Text = "Register";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(234, 316);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(122, 27);
            txtPassword.TabIndex = 19;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(71, 316);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(117, 27);
            txtUsername.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MediumPurple;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(262, 440);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 41);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumPurple;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(140, 440);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 41);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(71, 135);
            txtFullname.Name = "txtFullname";
            txtFullname.PlaceholderText = "Fullname";
            txtFullname.Size = new Size(285, 27);
            txtFullname.TabIndex = 21;
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new Point(71, 191);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.PlaceholderText = "Phonenumber";
            txtPhonenumber.Size = new Size(285, 27);
            txtPhonenumber.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(71, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(285, 27);
            txtEmail.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 293);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 24;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 293);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 25;
            label2.Text = "Password";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(71, 381);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(136, 27);
            txtConfirm.TabIndex = 26;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 358);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 27;
            label4.Text = "Confirm Password";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(435, 556);
            Controls.Add(label4);
            Controls.Add(txtConfirm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtPhonenumber);
            Controls.Add(txtFullname);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnRegister;
        private Button btnLogin;
        private TextBox txtFullname;
        private TextBox txtPhonenumber;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private TextBox txtConfirm;
        private Label label4;
    }
}