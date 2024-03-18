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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserForm
{
    public partial class AdminHome : Form
    {

        int currentPageIndex = 1;
        int pageSize = 10;
        double pageNumber = 0;
        int pageCurrentNumber = 1;
        int rows;
        int pre = 0;
        int post = 19;

        public AdminHome()
        {
            InitializeComponent();
        }

        public Winapp_Final_ProjectContext context = new Winapp_Final_ProjectContext();

        private void AdminHome_Load(object sender, EventArgs e)
        {
            loadView();

        }

        private void loadView()
        {
            var dataques = context.Questions.ToList();
            pageNumber = Math.Ceiling((double)dataques.Count / pageSize);
            lbTotalQues.Text = "/ " + pageNumber.ToString();
            lbCurrentPage.Text = pageCurrentNumber.ToString();
            var dataLincese = context.Licenses.ToList();
            cbLinceseQuestion.DataSource = dataLincese;
            cbLinceseQuestion.DisplayMember = "LicenseName";
            cbLinceseQuestion.ValueMember = "LicenseId";

            var dataSet = context.Sets.ToList();
            cbSetQuestion.DataSource = dataSet;
            cbSetQuestion.DisplayMember = "SetNumber";
            cbSetQuestion.ValueMember = "SetId";

            var dataTopic = context.Topics.ToList();
            cbTopicQuestion.DataSource = dataTopic;
            cbTopicQuestion.DisplayMember = "TopicName";
            cbTopicQuestion.ValueMember = "TopicId";
            loadQues();




        }

        private void loadQues()
        {
            var dataquestion = context.Questions
                .Select(p => new
                {
                    QuestionId = p.QuestionId,
                    QuestionDescription = p.QuestionDescription,
                    QuestionImage = p.QuestionImage,
                    License = p.License.LicenseName,
                    Topic = p.Topic.TopicName,
                    Set = p.Set.SetNumber,
                    QuestionExplain = p.QuestionExplain,
                })
                .ToList();

            var dataquestionfilter = new List<dynamic>();
            for (int i = pre; i < Math.Min(dataquestion.Count, post); i++)
            {
                dataquestionfilter.Add(dataquestion[i]);
            }
            dgQuestion.DataSource = dataquestionfilter;


            txtQuesId.DataBindings.Clear();
            txtQuesId.DataBindings.Add("text", dataquestionfilter, "QuestionId");
            rtQuestionDescription.DataBindings.Clear();
            rtQuestionDescription.DataBindings.Add("text", dataquestionfilter, "QuestionDescription");
            txtImage.DataBindings.Clear();
            txtImage.DataBindings.Add("text", dataquestionfilter, "QuestionImage");
            cbLinceseQuestion.DataBindings.Clear();
            cbLinceseQuestion.DataBindings.Add("text", dataquestionfilter, "License");
            cbTopicQuestion.DataBindings.Clear();
            cbTopicQuestion.DataBindings.Add("text", dataquestionfilter, "Topic");
            cbSetQuestion.DataBindings.Clear();
            cbSetQuestion.DataBindings.Add("text", dataquestionfilter, "Set");
            rtQuestionExplain.DataBindings.Clear();
            rtQuestionExplain.DataBindings.Add("text", dataquestionfilter, "QuestionExplain");

            var dataquestionId = context.Questions
                .Select(p => new { QuestionId = p.QuestionId })
                .ToList();
            cbQuestionId.DataSource = dataquestionId;
            cbQuestionId.DisplayMember = "QuestionId";
            cbQuestionId.ValueMember = "QuestionId";
        }



        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuestionDelete_Click(object sender, EventArgs e)
        {
            Question question = context.Questions.FirstOrDefault(p => p.QuestionId == Convert.ToInt32(txtQuesId.Text));
            if (question != null)
            {
                context.Questions.Remove(question);
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

        private void btnQuestionAdd_Click(object sender, EventArgs e)
        {
            var question = new Question()
            {
                QuestionDescription = rtQuestionDescription.Text,
                QuestionImage = txtImage.Text,
                LicenseId = (int)cbLinceseQuestion.SelectedValue,
                TopicId = (int)cbTopicQuestion.SelectedValue,
                SetId = (int)cbSetQuestion.SelectedValue,
                QuestionExplain = rtQuestionExplain.Text

            };
            context.Questions.Add(question);
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

        private void btnQuestionUpdate_Click(object sender, EventArgs e)
        {
            Question q = context.Questions.FirstOrDefault(p => p.QuestionId == Convert.ToInt32(txtQuesId.Text));

            if (q != null)
            {
                q.QuestionDescription = rtQuestionDescription.Text;
                q.QuestionImage = txtImage.Text;
                q.LicenseId = (int)cbLinceseQuestion.SelectedValue;
                q.TopicId = (int)cbTopicQuestion.SelectedValue;
                q.SetId = (int)cbSetQuestion.SelectedValue;
                q.QuestionExplain = rtQuestionExplain.Text;
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

        private void dgQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgQuestion.Rows[e.RowIndex];
                int selectedQuestionId = Convert.ToInt32(row.Cells["QuestionId"].Value);
                var dataAnswer = context.Answers
                    .Where(p => p.QuestionId == selectedQuestionId)
                    .Select(p => new
                    {
                        AnswerId = p.AnswerId,
                        AnswerDescription = p.AnswerDescription,
                        AnswerType = p.AnswerType,
                        QuestionId = p.QuestionId
                    })
                    .ToList();
                dgAnswer.DataSource = dataAnswer;


                //txtAnswerId.DataBindings.Clear();
                //txtAnswerId.DataBindings.Add("text", dataAnswer, "AnswerId");
                //rtAnswerDes.DataBindings.Clear();
                //rtAnswerDes.DataBindings.Add("text", dataAnswer, "AnswerDescription");
                ////cbType.DataBindings.Clear();
                // cbType.DataBindings.Add("text", dataAnswer, "AnswerType");




            }

        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            int type;
            if (rdFalse.Checked)
            {
                type = 0;
            }
            else
            {
                type = 1;
            }
            var answer = new Answer()
            {
                AnswerDescription = rtAnswerDes.Text,
                QuestionId = (int)cbQuestionId.SelectedValue,
                AnswerType = type

            };
            context.Answers.Add(answer);
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

        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {
            Answer answer = context.Answers.FirstOrDefault(p => p.AnswerId == Convert.ToInt32(txtAnswerId.Text));
            if (answer != null)
            {
                context.Answers.Remove(answer);
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

        private void btnUpdateAnswer_Click(object sender, EventArgs e)
        {
            Answer q = context.Answers.FirstOrDefault(p => p.AnswerId == Convert.ToInt32(txtAnswerId.Text));

            if (q != null)
            {
                q.AnswerDescription = rtAnswerDes.Text;
                if (rdFalse.Checked)
                {
                    q.AnswerType = 0;
                }
                else
                {
                    q.AnswerType = 1;
                }
                q.QuestionId = (int)cbQuestionId.SelectedValue;
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

        private void dgAnswer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAnswerId.Text = dgAnswer.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            rtAnswerDes.Text = dgAnswer.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            if (Convert.ToInt32(dgAnswer.Rows[e.RowIndex].Cells[2].FormattedValue.ToString()) == 1)
            {
                rdTrue.Checked = true;
                rdFalse.Checked = false;
            }
            if (Convert.ToInt32(dgAnswer.Rows[e.RowIndex].Cells[2].FormattedValue.ToString()) == 0)
            {
                rdTrue.Checked = false;
                rdFalse.Checked = true;
            }
            int index = cbQuestionId.FindStringExact(dgAnswer.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());

            cbQuestionId.SelectedIndex = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            UserSession.ClearSession();
            login.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AdminUserManage adminUserManage = new AdminUserManage();
            adminUserManage.Show();
            this.Close();
        }

        private void btnImageSearch_Click(object sender, EventArgs e)
        {
            string imgPath = Path.Combine(Application.StartupPath, "Resources", txtImageSearch.Text);

            if (File.Exists(imgPath))
            {
                pcbImageSearch.Image = new Bitmap(imgPath);
                //pcbImageSearch.SizeMode = PictureBoxSizeMode.CenterImage;
                pcbImageSearch.Visible = true;
            }
            else
            {
                pcbImageSearch.Visible = false;
            }
        }

        private void txtImage_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(textBox.Text))
            //{ }
            //else
            //{
            //    pcbImage.Image = null;
            //}
            string imgPath = Path.Combine(Application.StartupPath, "Resources", txtImage.Text);

            if (File.Exists(imgPath))
            {
                pcbImage.Image = new Bitmap(imgPath);
                //pcbImageSearch.SizeMode = PictureBoxSizeMode.CenterImage;
                pcbImage.Visible = true;

            }
            else
            {
                pcbImage.Visible = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbCurrentPage.Text) == pageNumber)
            {
                return;
            }
            else
            {
                pageCurrentNumber += 1;
                lbCurrentPage.Text = (pageCurrentNumber).ToString();
                pre += pageSize;
                post += pageSize;
                loadQues();
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbCurrentPage.Text) == 1)
            {
                return;
            }
            else
            {
                pageCurrentNumber -= 1;
                lbCurrentPage.Text = (pageCurrentNumber).ToString();
                pre -= pageSize;
                post -= pageSize;
                loadQues();
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            var dataquestion = context.Questions
                .Where(p => p.QuestionDescription.Contains(searchText))
                .Select(p => new
                {
                    QuestionId = p.QuestionId,
                    QuestionDescription = p.QuestionDescription,
                    QuestionImage = p.QuestionImage,
                    License = p.License.LicenseName,
                    Topic = p.Topic.TopicName,
                    Set = p.Set.SetNumber,
                    QuestionExplain = p.QuestionExplain,
                })
                .ToList();

            
            dgQuestion.DataSource = dataquestion;


            txtQuesId.DataBindings.Clear();
            txtQuesId.DataBindings.Add("text", dataquestion, "QuestionId");
            rtQuestionDescription.DataBindings.Clear();
            rtQuestionDescription.DataBindings.Add("text", dataquestion, "QuestionDescription");
            txtImage.DataBindings.Clear();
            txtImage.DataBindings.Add("text", dataquestion, "QuestionImage");
            cbLinceseQuestion.DataBindings.Clear();
            cbLinceseQuestion.DataBindings.Add("text", dataquestion, "License");
            cbTopicQuestion.DataBindings.Clear();
            cbTopicQuestion.DataBindings.Add("text", dataquestion, "Topic");
            cbSetQuestion.DataBindings.Clear();
            cbSetQuestion.DataBindings.Add("text", dataquestion, "Set");
            rtQuestionExplain.DataBindings.Clear();
            rtQuestionExplain.DataBindings.Add("text", dataquestion, "QuestionExplain");

            var dataquestionId = context.Questions
                .Select(p => new { QuestionId = p.QuestionId })
                .ToList();
            cbQuestionId.DataSource = dataquestionId;
            cbQuestionId.DisplayMember = "QuestionId";
            cbQuestionId.ValueMember = "QuestionId";

        }
    }
}
