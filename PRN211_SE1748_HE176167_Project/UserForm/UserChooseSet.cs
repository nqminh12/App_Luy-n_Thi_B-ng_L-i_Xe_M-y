using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class UserChooseSet : Form
    {

        private int lincese_id;
        private string lincese_name;
        private int loggedInUser_Id = UserSession.SessionUser.UserId;
        public Winapp_Final_ProjectContext context = new Winapp_Final_ProjectContext();
        public UserChooseSet()
        {
            InitializeComponent();
        }

        private void UserChooseSet_Load(object sender, EventArgs e)
        {
            var data = context.Questions
                .Where(q => q.LicenseId == lincese_id)
                .Select(q => q.SetId)
                .Distinct()
                .ToList();
            cbChooseSet.DataSource = data;

            var date = context.Histories
                .Where(q => q.UserId == loggedInUser_Id 
                && q.SetId == (int)cbChooseSet.SelectedValue
                && q.LicenseId == lincese_id)

                .Select(p => new
                {
                    HistoryId = p.HistoryId,
                    DateTimeString = p.HistoryDate.ToString().Substring(0, 11) + " - " + p.HistoryTime.ToString().Substring(0, 5) + "     Score:" + p.Score
                    
                })
                .ToList();
            
            

            lboxDate.DataSource = date;
            lboxDate.DisplayMember = "DateTimeString";
            lboxDate.ValueMember = "HistoryId";

        }

        private int checkScore(int historyId)
        {
            int historyScore = 0;
            List<HistoryDetail> historyDetail = context.HistoryDetails
               .Where(p => p.HistoryId == historyId)
               .Include(q => q.Answer)
               .ToList();
            foreach(HistoryDetail his in historyDetail)
            {
                if(his.Answer.AnswerType!= null)
               {
                    historyScore++;
                }
            }
            return historyScore; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserHome userHome = new UserHome();
            userHome.Show();
            this.Close();
        }

        public void SetUserHomeInfo(int lincese, string linceseName)
        {
            lincese_id = lincese;
            lincese_name = linceseName;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            UserTestQuiz userTestQuiz = new UserTestQuiz();
            userTestQuiz.SetUserChooseSet(lincese_id, lincese_name, (int)cbChooseSet.SelectedItem, cbChooseSet.SelectedItem.ToString(), 25);
            userTestQuiz.Show();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List<DataLog> logs = new List<DataLog>();
            List<HistoryDetail> listHistory = context.HistoryDetails
                .Where(p => p.HistoryId == (int)lboxDate.SelectedValue)
                .Include(q => q.Answer)
                .Include(r => r.Question)
                .ThenInclude(r => r.Answers)
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

        private void cbChooseSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            var date = context.Histories
                .Where(q => q.UserId == loggedInUser_Id && q.SetId == (int)cbChooseSet.SelectedValue)
                .Select(p => new
                {
                    HistoryId = p.HistoryId,
                    DateTimeString = p.HistoryDate.ToString().Substring(0, 11) + " - " + p.HistoryTime.ToString().Substring(0, 5)
                })
                .ToList();
            lboxDate.DataSource = date;
            lboxDate.DisplayMember = "DateTimeString";
            lboxDate.ValueMember = "HistoryId";
        }
    }
}
