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
    public partial class UserPractice : Form
    {
        private int loggedInUser_Id = UserSession.SessionUser.UserId;
        private int lincese_Id;
        private List<Question> listQuestion;
        private List<Answer> listAnswers;
        private int indexQuestion = 0;
        private Question currentQuestion;

        //db context
        public Winapp_Final_ProjectContext context = new Winapp_Final_ProjectContext();
        public UserPractice()
        {
            InitializeComponent();
        }

        private void UserPractice_Load(object sender, EventArgs e)
        {
            try
            {
                listQuestion = context.Questions
                    .Where(p => p.LicenseId == lincese_Id)
                    .Include(q => q.Answers)
                    .ToList();
                loadQuiz();

                var setdata = context.Topics.ToList();
                lbTopic.DataSource = setdata;
                lbTopic.DisplayMember = "TopicName";
                lbTopic.ValueMember = "TopicId";
                lbTopic.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                // Ghi log lỗi vào tập tin
                string logFilePath = "error.log";
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine("Error occurred in UserPractice_Load method: " + ex.Message);
                }

                // Hiển thị thông báo lỗi cho người dùng nếu cần
                MessageBox.Show("An error occurred while loading data. Please check the log for details.");
            }


        }

        private void loadQuiz()
        {
            if (listQuestion.Count > 0)
            {
                //Question
                lbQuestionNum.Visible = true;
                lbQuestion.Visible = true;
                lbExplain.Visible = true;
                lbQuestionNum.Text = "Question " + (indexQuestion + 1) + "/" + listQuestion.Count;
                currentQuestion = listQuestion[indexQuestion];
                lbQuestion.Text = currentQuestion.QuestionDescription.ToString();
                lbExplain.Text = currentQuestion.QuestionExplain.ToString();
                //load picture
                if (String.IsNullOrEmpty(currentQuestion.QuestionImage))
                {
                    pcbQuestion.Visible = false;
                    pnQuestion.Location = new Point(50, 220);
                }
                else
                {
                    string imgPath = Path.Combine(Application.StartupPath, "Resources", currentQuestion.QuestionImage);

                    if (File.Exists(imgPath))
                    {
                        pcbQuestion.Image = new Bitmap(imgPath);
                        pcbQuestion.SizeMode = PictureBoxSizeMode.AutoSize;
                        pcbQuestion.Location = new Point(60, 180);
                        pcbQuestion.Visible = true;
                        pnQuestion.Location = new Point(50, 570);
                    }
                    else
                    {
                        pcbQuestion.Visible = false;
                        pnQuestion.Location = new Point(50, 220);
                    }
                }
                //Load and check Answer
                listAnswers = currentQuestion.Answers.ToList();
                lbAnswer1.Visible = true;
                lbAnswer1.Text = "1 - " + listAnswers[0].AnswerDescription.ToString();
                checkQuestion(lbAnswer1, listAnswers[0]);
                lbAnswer2.Visible = true;
                lbAnswer2.Text = "2 - " + listAnswers[1].AnswerDescription.ToString();
                checkQuestion(lbAnswer2, listAnswers[1]);
                if (listAnswers.Count >= 3)
                {
                    lbAnswer3.Text = "3 - " + listAnswers[2].AnswerDescription.ToString();
                    checkQuestion(lbAnswer3, listAnswers[2]);
                    lbAnswer3.Visible = true;

                }
                else
                {
                    lbAnswer3.Visible = false;

                }

                if (listAnswers.Count >= 4)
                {
                    lbAnswer4.Text = "4 - " + listAnswers[3].AnswerDescription.ToString();
                    checkQuestion(lbAnswer4, listAnswers[3]);
                    lbAnswer4.Visible = true;

                }
                else
                {
                    lbAnswer4.Visible = false;

                }

            }
            else
            {
                pcbQuestion.Visible = false;
                lbQuestionNum.Visible = false;
                lbQuestion.Text = "There are no questions at all!";
                lbExplain.Visible = false;
                lbAnswer1.Visible = false;
                lbAnswer2.Visible = false;
                lbAnswer3.Visible = false;
                lbAnswer4.Visible = false;
            }
        }

        private void checkQuestion(Label label, Answer answer)
        {
            if (answer.AnswerType == 1)
            {
                label.ForeColor = Color.White;
                label.BackColor = Color.Green;
            }
            else
            {
                label.ForeColor = Color.Black;
                label.BackColor = Color.White;
            }
        }


        public void SetUserHomeInfo(int linceseId)
        {
            lincese_Id = linceseId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserHome userHome = new UserHome();
            userHome.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (indexQuestion == 0)
            {
                //MessageBox.Show("There are no more questions!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                indexQuestion = listQuestion.Count - 1;
                loadQuiz();
            }
            else
            {
                indexQuestion -= 1;
                loadQuiz();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (indexQuestion == (listQuestion.Count - 1))
            {
                //MessageBox.Show("There are no more questions!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                indexQuestion = 0;
                loadQuiz() ;
            }
            else
            {
                indexQuestion += 1;
                loadQuiz();
            }
        }

        private void lbTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTopic.SelectedIndex != -1)
            {
                Topic selectedTopic = (Topic)lbTopic.SelectedItem;
                int chosen = selectedTopic.TopicId;
                listQuestion = context.Questions
                .Where(p => p.LicenseId == lincese_Id && p.TopicId == chosen)
                .Include(q => q.Answers)
                .ToList();
                indexQuestion = 0;
                loadQuiz();
            }
            else
            {
                listQuestion = context.Questions
                .Where(p => p.LicenseId == lincese_Id)
                .Include(q => q.Answers)
                .ToList();
                indexQuestion = 0;
                loadQuiz();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbTopic.SelectedIndex = -1;
        }

        private void UserPractice_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void lbAnswer2_Click(object sender, EventArgs e)
        {

        }
    }
}
