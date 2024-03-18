using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserForm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public Winapp_Final_ProjectContext context = new Winapp_Final_ProjectContext();

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text.Length == 0)
            {
                MessageBox.Show("Please input your full name!", "Alert",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPhonenumber.Text.Length != 10)
            {
                MessageBox.Show("Please input your phone number with 10 numbers!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtEmail.Text.Length == 0 || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please input your email!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Please input your user name!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please input your pass word!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtConfirm.Text.Length == 0)
            {
                MessageBox.Show("Please input your confirm pass word!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtConfirm.Text != txtPassword.Text)
            {
                MessageBox.Show("Password don't match!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var UserName = context.Users
                .Where(p => p.Username == txtUsername.Text)
                .FirstOrDefault();
            if (UserName != null)
            {
                MessageBox.Show("Username already exists!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            User newuser = new User()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Fullname = txtFullname.Text,
                Phonenumber = txtPhonenumber.Text,
                Email = txtEmail.Text,
                UserRole = 0
            };

            context.Users.Add(newuser);
            context.SaveChanges();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
