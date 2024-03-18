using DataAccess.Models;

namespace UserForm
{
    public partial class Login : Form
    {
        //public static int currentUser_Id;
        public Login()
        {
            InitializeComponent();
        }

        public Winapp_Final_ProjectContext context = new Winapp_Final_ProjectContext();

        private void Login_Load(object sender, EventArgs e)
        {
            rdbUser.Checked = true;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int role = 0;
            if (rdbAdmin.Checked)
            {
                role = 1;
            }

            User user = context.Users.FirstOrDefault
                        (x => x.Username == username && x.Password == password && x.UserRole == role);
            if (user == null)
            {
                MessageBox.Show("Login failed! Wrong username or password or role", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserSession.SessionUser = user;
                //currentUser_Id = user.UserId;
                if (user.UserRole == 0)
                {
                    UserHome userhome = new UserHome();
                    userhome.Show();
                    this.Hide();
                }
                else
                {
                    AdminHome adminhome = new AdminHome();
                    adminhome.Show();
                    this.Hide();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
