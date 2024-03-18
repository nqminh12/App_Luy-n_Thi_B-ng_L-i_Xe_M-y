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
    public partial class TrafficSign : Form
    {
        
        public TrafficSign()
        {
            InitializeComponent();
        }

        private void TrafficSign_Load(object sender, EventArgs e)
        {
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserHome userHome = new UserHome();
            userHome.Show();
            this.Close();
        }
    }
}
