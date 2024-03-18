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
    public partial class UserTestQuiz : Form
    {
        // test info
        private int Lincese_id;
        private string Lincese_name;
        private int Set_id;
        private string Set_number;
        private int Total_question;
        private int loggedInUser_Id = UserSession.SessionUser.UserId;
        //db context
        public Winapp_Final_ProjectContext context = new Winapp_Final_ProjectContext();
        //List
        private List<Question> listQuestion;
        private List<Answer> listAnswers;
        private int indexQuestion = 0;
        // quiz now
        private Question currentQuestion = new Question();
        // ghi lại tiến trình làm bài
        private List<DataLog> logs = new List<DataLog>();
        //time
        private System.Windows.Forms.Timer Timer;
        private int countdown = 60 * 25;
        public UserTestQuiz()
        {
            InitializeComponent();

        }

        private void UserTestQuiz_Load(object sender, EventArgs e)
        {
            //set up time
            // Khởi tạo và cấu hình Timer
            Timer = new System.Windows.Forms.Timer();
            Timer.Interval = 1000; // Cập nhật countdown mỗi giây
            Timer.Tick += Timer_Tick;
            // Khởi động Timer
            Timer.Start();
            //sat up question
            lbLincese.Text += Lincese_name;
            lbSet.Text += Set_number;
            listQuestion = context.Questions
                .Where(p => p.LicenseId == Lincese_id && p.SetId == Set_id)
                .Include(q => q.Answers)
                .OrderBy(x => Guid.NewGuid())//sắp xếp random tất cả các câu hỏi
                .Take(Total_question)//chọn top 25
                .OrderBy(p => p.TopicId)
                .ToList();
            foreach (Question quiz in listQuestion)
            {
                logs.Add(new DataLog(quiz, null));
            }
            loadQuiz();
        }



        public void SetUserChooseSet(int Lincese_Id, string Lincese_Name, int Set_Id, string Set_Number, int totalQuestion)
        {
            Lincese_id = Lincese_Id;
            Lincese_name = Lincese_Name;
            Set_id = Set_Id;
            Set_number = Set_Number;
            Total_question = totalQuestion;
        }

        private void loadQuiz()
        {
            //Question
            lbQuestionNum.Text = "Question " + (indexQuestion + 1) + "/" + listQuestion.Count;
            currentQuestion = listQuestion[indexQuestion];
            lbQuestion.Text = currentQuestion.QuestionDescription.ToString();
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
                    pcbQuestion.Location = new Point(60, 150);
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
            lbAnswer1.Text = "1 - " + listAnswers[0].AnswerDescription.ToString();
            lbAnswer2.Text = "2 - " + listAnswers[1].AnswerDescription.ToString();
            if (listAnswers.Count >= 3)
            {
                lbAnswer3.Text = "3 - " + listAnswers[2].AnswerDescription.ToString();
                lbAnswer3.Visible = true;
                rdAnswer3.Visible = true;
            }
            else
            {
                lbAnswer3.Visible = false;
                rdAnswer3.Visible = false;
            }

            if (listAnswers.Count >= 4)
            {
                lbAnswer4.Text = "4 - " + listAnswers[3].AnswerDescription.ToString();
                lbAnswer4.Visible = true;
                rdAnswer4.Visible = true;
            }
            else
            {
                lbAnswer4.Visible = false;
                rdAnswer4.Visible = false;
            }
            // check xem cau này đã khoanh chưa
            int indexChoosen = -1;
            for (int i = 0; i < listAnswers.Count; i++)
            {
                if (listAnswers[i].Equals(logs[indexQuestion].Answer))
                {
                    indexChoosen = i + 1;
                }
            }
            switch (indexChoosen)
            {
                case 1:
                    rdAnswer1.Checked = true;
                    break;
                case 2:
                    rdAnswer2.Checked = true;
                    break;
                case 3:
                    rdAnswer3.Checked = true;
                    break;
                case 4:
                    rdAnswer4.Checked = true;
                    break;
                default:
                    break;

            }

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            unCheckedRadio();
            if (indexQuestion == 0)
            {
                //MessageBox.Show("There are no more questions!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                indexQuestion = listQuestion.Count - 1;
            }
            else
            {
                indexQuestion -= 1;
                
            }
            loadQuiz();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            unCheckedRadio();
            if (indexQuestion == (listQuestion.Count - 1))
            {
                //MessageBox.Show("There are no more questions!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                indexQuestion = 0;
            }
            else
            {
                indexQuestion += 1;
            }
            loadQuiz();

        }

        private void unCheckedRadio()
        {
            rdAnswer1.Checked = false;
            rdAnswer2.Checked = false;
            rdAnswer3.Checked = false;
            rdAnswer4.Checked = false;
        }

        private void rdAnswer1_CheckedChanged(object sender, EventArgs e)
        {
            logs[indexQuestion].Answer = listAnswers[0];
        }

        private void rdAnswer2_CheckedChanged(object sender, EventArgs e)
        {
            logs[indexQuestion].Answer = listAnswers[1];
        }

        private void rdAnswer3_CheckedChanged(object sender, EventArgs e)
        {
            logs[indexQuestion].Answer = listAnswers[2];
        }

        private void rdAnswer4_CheckedChanged(object sender, EventArgs e)
        {
            logs[indexQuestion].Answer = listAnswers[3];
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Decrease the value of countdown
            countdown--;

            if (countdown <= 0)
            {
                Timer.Stop();

                // Perform actions when the countdown reaches 0
                lbCountDown.Text = $"00:00";
                Close();
                UserHome lf = new UserHome();
                lf.Show();
            }

            int minutes = countdown / 60;
            int seconds = countdown % 60;

            lbCountDown.Text = $"{minutes:00}:{seconds:00}";
        }

        private void cbFinish_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFinish.Checked)
            {
                btnFinish.Enabled = true;
            }
            else
            {
                btnFinish.Enabled = false;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
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
            //history
            UserResult userResult = new UserResult();
            History history = new History
            {
                HistoryDate = DateTime.Now.Date, // Ngày hiện tại
                HistoryTime = DateTime.Now.TimeOfDay, // Lưu thời gian là 25 phút
                UserId = loggedInUser_Id,
                SetId = Set_id,
                LicenseId = Lincese_id,
                Score = sum
            };
            context.Histories.Add(history);
            context.SaveChanges();
            int historyId = history.HistoryId;
            //history detail
            foreach (DataLog log in logs)
            {
                HistoryDetail detail = new HistoryDetail();
                detail.HistoryId = historyId;
                if (log.Answer != null)
                {
                    detail.AnswerId = log.Answer.AnswerId;
                }
                detail.QuestionId = log.Question.QuestionId;
                context.HistoryDetails.Add(detail);
                context.SaveChanges();
            }

            userResult.SetUserTestQuiz(logs);

            userResult.Show();
            this.Close();

        }

        private void UserTestQuiz_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
