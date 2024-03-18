using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
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
    public partial class UserHome : Form
    {
        public int loggedInUser_Id = UserSession.SessionUser.UserId;
        public Winapp_Final_ProjectContext context = new Winapp_Final_ProjectContext();
        public UserHome()
        {
            InitializeComponent();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            var data = context.Licenses.ToList();
            cbLincesetype.Items.Clear();
            cbLincesetype.DataSource = data;
            cbLincesetype.DisplayMember = "LicenseName";
            cbLincesetype.ValueMember = "LicenseId";

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            UserSession.ClearSession();
            login.Show();
            this.Close();

        }

        private void UserHome_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pb1_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            TrafficSign traficsign = new TrafficSign();
            traficsign.Show();
            this.Hide();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (!CheckLincenseExit())
            {
                MessageBox.Show("Currently, the system has not updated questions for this type of this license.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UserChooseSet userChooseSet = new UserChooseSet();
            int lencese = (int)cbLincesetype.SelectedValue;
            string lenceseName = cbLincesetype.SelectedText;
            userChooseSet.SetUserHomeInfo(lencese, lenceseName);
            userChooseSet.Show();
            this.Hide();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (!CheckLincenseExit())
            {
                MessageBox.Show("Currently, the system has not updated questions for this type of this license.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UserPractice userPractice = new UserPractice();
            int lencese = (int)cbLincesetype.SelectedValue;
            userPractice.SetUserHomeInfo(lencese);
            userPractice.Show();
            this.Hide();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (!CheckLincenseExit())
            {
                MessageBox.Show("Currently, the system has not updated questions for this type of this license.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<DataLog> logs = new List<DataLog>();
            List<HistoryDetail> listHistory = context.HistoryDetails
    .Where(hd => hd.History.UserId == 1 && hd.Answer.AnswerType == 0 && hd.History.LicenseId == (int)cbLincesetype.SelectedValue)
    .Include(hd => hd.Answer)
    .Include(hd => hd.Question)
    .ThenInclude(q => q.Answers)
    .Distinct()
    .ToList();

            //foreach(HistoryDetail historyDetail in listHistory)
            //{
            //    var data = context.Questions
            //        .
            //}

            foreach (HistoryDetail his in listHistory)
            {
                logs.Add(new DataLog(his.Question, his.Answer));
            }

            UserResult userResult = new UserResult();

            userResult.SetUserTestQuiz(logs);

            userResult.Show();
            this.Hide();
        }


        public Boolean CheckLincenseExit()
        {
            var data = context.Questions
                .Where(p => p.LicenseId == (int)cbLincesetype.SelectedValue)
                .ToList();
            if(data.Count == 0) {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
