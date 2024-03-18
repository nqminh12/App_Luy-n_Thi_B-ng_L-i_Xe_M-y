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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserForm
{
    public partial class AdminUserManage : Form
    {
        public AdminUserManage()
        {
            InitializeComponent();
        }

        public Winapp_Final_ProjectContext context = new Winapp_Final_ProjectContext();

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            UserSession.ClearSession();
            login.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void AdminUserManage_Load(object sender, EventArgs e)
        {
            loadView();
        }

        private void loadView()
        {
            var data = context.Users
                .Where(p => p.UserRole == 0)
                .Select(p => new
                {
                    UserId = p.UserId,
                    UserName = p.Username,
                    Password = p.Password,
                    FullName = p.Fullname,
                    Phonenumber = p.Phonenumber,
                    Email = p.Email
                })
                .ToList();
            dgUser.DataSource = data;

            txtUserId.DataBindings.Clear();
            txtUserId.DataBindings.Add("text", data, "UserId");
            txtUsername.DataBindings.Clear();
            txtUsername.DataBindings.Add("text", data, "UserName");
            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("text", data, "Password");
            txtFullname.DataBindings.Clear();
            txtFullname.DataBindings.Add("text", data, "FullName");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("text", data, "Email");
            txtPhonenumber.DataBindings.Clear();
            txtPhonenumber.DataBindings.Add("text", data, "Phonenumber");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var User = new User()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Phonenumber = txtPhonenumber.Text,
                Email = txtEmail.Text,
                UserRole = 0,
                Fullname = txtFullname.Text

            };
            context.Users.Add(User);
            if (context.SaveChanges() > 0)
            {
                MessageBox.Show("Add success!");
                loadView();
            }
            else
            {
                MessageBox.Show("Add fail");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User q = context.Users.FirstOrDefault(p => p.UserId == Convert.ToInt32(txtUserId.Text));

            if (q != null)
            {
                q.Username = txtUsername.Text;
                q.Password = txtPassword.Text;
                q.Phonenumber = txtPhonenumber.Text;
                q.Email = txtEmail.Text;
                q.Fullname = txtFullname.Text;
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Update success!");
                    loadView();
                }
            }
            else
            {
                MessageBox.Show("Update fail!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = context.Users.FirstOrDefault(p => p.UserId == Convert.ToInt32(txtUserId.Text));
            if (user != null)
            {
                context.Users.Remove(user);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Delete success!");
                    loadView();
                }
            }
            else
            {
                MessageBox.Show("Delete fail!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtNameSearch.Text == "")
            {
                return;
            }
            else
            {
                var data = context.Users
                .Where(p => p.UserRole == 0)
                .Where(p => p.Username.Contains(txtNameSearch.Text))
                .Select(p => new
                {
                    UserId = p.UserId,
                    UserName = p.Username,
                    Password = p.Password,
                    FullName = p.Fullname,
                    Phonenumber = p.Phonenumber,
                    Email = p.Email
                })
                .ToList();
                dgUser.DataSource = data;

                txtUserId.DataBindings.Clear();
                txtUserId.DataBindings.Add("text", data, "UserId");
                txtUsername.DataBindings.Clear();
                txtUsername.DataBindings.Add("text", data, "UserName");
                txtPassword.DataBindings.Clear();
                txtPassword.DataBindings.Add("text", data, "Password");
                txtFullname.DataBindings.Clear();
                txtFullname.DataBindings.Add("text", data, "FullName");
                txtEmail.DataBindings.Clear();
                txtEmail.DataBindings.Add("text", data, "Email");
                txtPhonenumber.DataBindings.Clear();
                txtPhonenumber.DataBindings.Add("text", data, "Phonenumber");

            }

        }
    }
}
