using DataAccess;
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
    public partial class UserResult : Form
    {
        private int loggedInUser_Id = UserSession.SessionUser.UserId;
        private List<DataLog> logs;
        private int indexQuestion = 0;
        private Question curentQuestion;
        private List<Answer> listAnswers;
        public UserResult()
        {
            InitializeComponent();
        }

        private void UserResult_Load(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (DataLog log in logs)
            {
                if (log.Answer != null)
                {
                    if (log.Answer.AnswerType == 1)
                    {
                        sum++;
                    }
                }
            }
            lbMark.Text = sum.ToString() + "/" + logs.Count;
            if (sum >= 21)
            {
                lbMark.ForeColor = Color.Green;
            }
            else
            {
                lbMark.ForeColor = Color.Red;
            }
            loadQuiz();
        }


        public void SetUserTestQuiz(List<DataLog> listlog)
        {
            logs = listlog;

        }

        private void loadQuiz()
        {
            //Question
            lbQuestionNum.Text = "Question " + (indexQuestion + 1) + "/" + logs.Count;
            checkQuestionMark();
            curentQuestion = logs[indexQuestion].Question;
            lbQuestion.Text = curentQuestion.QuestionDescription.ToString();
            lbExplain.Text = curentQuestion.QuestionExplain.ToString();
            //load picture
            if (String.IsNullOrEmpty(curentQuestion.QuestionImage))
            {
                pcbQuestion.Visible = false;
                pnQuestion.Location = new Point(50, 220);
            }
            else
            {
                string imgPath = Path.Combine(Application.StartupPath, "Resources", curentQuestion.QuestionImage);

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
            listAnswers = curentQuestion.Answers.ToList();
            lbAnswer1.Text = "1 - " + listAnswers[0].AnswerDescription.ToString();
            checkTrueFalse(lbAnswer1, 0);


            lbAnswer2.Text = "2 - " + listAnswers[1].AnswerDescription.ToString();
            checkTrueFalse(lbAnswer2, 1);
            if (listAnswers.Count >= 3)
            {
                lbAnswer3.Text = "3 - " + listAnswers[2].AnswerDescription.ToString();
                lbAnswer3.Visible = true;
                checkTrueFalse(lbAnswer3, 2);
            }
            else
            {
                lbAnswer3.Visible = false;
            }

            if (listAnswers.Count >= 4)
            {
                lbAnswer4.Text = "4 - " + listAnswers[3].AnswerDescription.ToString();
                lbAnswer4.Visible = true;
                checkTrueFalse(lbAnswer4, 3);
            }
            else
            {
                lbAnswer4.Visible = false;
            }
        }

        private void checkQuestionMark()
        {
            if (logs[indexQuestion].Answer != null)
            {
                if (logs[indexQuestion].Answer.AnswerType == 1)
                {
                    lbQuestionMark.Text = "1/1";
                    lbQuestionMark.ForeColor = Color.Green;
                }
                else
                {
                    lbQuestionMark.Text = "0/1";
                    lbQuestionMark.ForeColor = Color.Red;
                }
            }
            else
            {
                lbQuestionMark.Text = "0/1";
                lbQuestionMark.ForeColor = Color.Red;
            }
        }

        private void checkTrueFalse(Label label, int index)
        {
            if (listAnswers[index].AnswerType == 1)
            {
                label.ForeColor = Color.White;
                label.BackColor = Color.Green;
            }
            else if (logs[indexQuestion].Answer == listAnswers[index] && logs[indexQuestion].Answer.AnswerType == 0)
            {
                label.ForeColor = Color.White;
                label.BackColor = Color.Red;
            }
            else
            {
                label.ForeColor = Color.Black;
                label.BackColor = Color.White;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (indexQuestion == 0)
            {
                //MessageBox.Show("There are no more questions!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                indexQuestion = logs.Count - 1;
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
            if (indexQuestion == (logs.Count - 1))
            {
                //MessageBox.Show("There are no more questions!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                indexQuestion = 0;
                loadQuiz();
            }
            else
            {
                indexQuestion += 1;
                loadQuiz();
            }
        }

        private void lbHome_Click(object sender, EventArgs e)
        {
            UserHome userHome = new UserHome();
            userHome.Show();
            this.Hide();
        }
    }
}
