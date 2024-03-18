namespace UserForm
{
    partial class AdminUserManage
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
            dgUser = new DataGridView();
            btnUser = new Button();
            button1 = new Button();
            label1 = new Label();
            txtUserId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPhonenumber = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label6 = new Label();
            txtFullname = new TextBox();
            txtNameSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUser).BeginInit();
            SuspendLayout();
            // 
            // dgUser
            // 
            dgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUser.Location = new Point(12, 324);
            dgUser.Name = "dgUser";
            dgUser.RowHeadersWidth = 51;
            dgUser.RowTemplate.Height = 29;
            dgUser.Size = new Size(922, 214);
            dgUser.TabIndex = 0;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.MediumPurple;
            btnUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = SystemColors.ButtonFace;
            btnUser.Location = new Point(648, 12);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(156, 40);
            btnUser.TabIndex = 42;
            btnUser.Text = "Question Manage";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(834, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 43;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 76);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 44;
            label1.Text = "User_Id:";
            // 
            // txtUserId
            // 
            txtUserId.Enabled = false;
            txtUserId.Location = new Point(142, 73);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(137, 27);
            txtUserId.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 169);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 46;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 169);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 47;
            label3.Text = "Phonenumber:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 76);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 48;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(639, 169);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 49;
            label5.Text = "Email:";
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new Point(446, 162);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.Size = new Size(137, 27);
            txtPhonenumber.TabIndex = 50;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(446, 73);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(137, 27);
            txtPassword.TabIndex = 51;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(142, 162);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(137, 27);
            txtUsername.TabIndex = 52;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(737, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(157, 27);
            txtEmail.TabIndex = 53;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumPurple;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(76, 255);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 41);
            btnAdd.TabIndex = 54;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumPurple;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(303, 255);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 41);
            btnUpdate.TabIndex = 55;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MediumPurple;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(530, 255);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 41);
            btnDelete.TabIndex = 56;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(639, 76);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 57;
            label6.Text = "Fullname:";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(737, 73);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(157, 27);
            txtFullname.TabIndex = 58;
            // 
            // txtNameSearch
            // 
            txtNameSearch.Location = new Point(769, 269);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.Size = new Size(125, 27);
            txtNameSearch.TabIndex = 59;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumPurple;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(697, 255);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(66, 41);
            btnSearch.TabIndex = 60;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // AdminUserManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(961, 550);
            Controls.Add(btnSearch);
            Controls.Add(txtNameSearch);
            Controls.Add(txtFullname);
            Controls.Add(label6);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtPhonenumber);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUserId);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnUser);
            Controls.Add(dgUser);
            Name = "AdminUserManage";
            Text = "AdminUserManage";
            Load += AdminUserManage_Load;
            ((System.ComponentModel.ISupportInitialize)dgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgUser;
        private Button btnUser;
        private Button button1;
        private Label label1;
        private TextBox txtUserId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPhonenumber;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label6;
        private TextBox txtFullname;
        private TextBox txtNameSearch;
        private Button btnSearch;
    }
}