namespace UserForm
{
    partial class UserPractice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            lbTopic = new ListBox();
            label2 = new Label();
            lbExplain = new Label();
            btnNext = new Button();
            btnBack = new Button();
            lbAnswer4 = new Label();
            lbAnswer3 = new Label();
            lbQuestion = new Label();
            lbAnswer2 = new Label();
            lbAnswer1 = new Label();
            lbQuestionNum = new Label();
            pcbQuestion = new PictureBox();
            panel1 = new Panel();
            pnQuestion = new Panel();
            lbHome = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbQuestion).BeginInit();
            panel1.SuspendLayout();
            pnQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 284);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 10;
            label1.Text = "Explain:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LemonChiffon;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(lbTopic);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbExplain);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(btnBack);
            panel2.Location = new Point(1121, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 859);
            panel2.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumPurple;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(293, 244);
            button2.Name = "button2";
            button2.Size = new Size(64, 39);
            button2.TabIndex = 17;
            button2.Text = "All";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lbTopic
            // 
            lbTopic.FormattingEnabled = true;
            lbTopic.ItemHeight = 20;
            lbTopic.Location = new Point(30, 54);
            lbTopic.Name = "lbTopic";
            lbTopic.Size = new Size(327, 184);
            lbTopic.TabIndex = 13;
            lbTopic.SelectedIndexChanged += lbTopic_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 19);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 12;
            label2.Text = "Choose topic:";
            // 
            // lbExplain
            // 
            lbExplain.AutoSize = true;
            lbExplain.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbExplain.Location = new Point(26, 326);
            lbExplain.MaximumSize = new Size(350, 0);
            lbExplain.Name = "lbExplain";
            lbExplain.Size = new Size(76, 31);
            lbExplain.TabIndex = 11;
            lbExplain.Text = "label2";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.MediumPurple;
            btnNext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ButtonFace;
            btnNext.Location = new Point(234, 787);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(140, 50);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumPurple;
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(15, 787);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 50);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lbAnswer4
            // 
            lbAnswer4.AutoSize = true;
            lbAnswer4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnswer4.Location = new Point(18, 301);
            lbAnswer4.MaximumSize = new Size(950, 0);
            lbAnswer4.Name = "lbAnswer4";
            lbAnswer4.Size = new Size(53, 31);
            lbAnswer4.TabIndex = 4;
            lbAnswer4.Text = " 1 - ";
            // 
            // lbAnswer3
            // 
            lbAnswer3.AutoSize = true;
            lbAnswer3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnswer3.Location = new Point(18, 218);
            lbAnswer3.MaximumSize = new Size(950, 0);
            lbAnswer3.Name = "lbAnswer3";
            lbAnswer3.Size = new Size(53, 31);
            lbAnswer3.TabIndex = 5;
            lbAnswer3.Text = " 1 - ";
            // 
            // lbQuestion
            // 
            lbQuestion.AutoSize = true;
            lbQuestion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuestion.Location = new Point(39, 89);
            lbQuestion.MaximumSize = new Size(1000, 0);
            lbQuestion.Name = "lbQuestion";
            lbQuestion.Size = new Size(96, 38);
            lbQuestion.TabIndex = 1;
            lbQuestion.Text = "label1";
            // 
            // lbAnswer2
            // 
            lbAnswer2.AutoSize = true;
            lbAnswer2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnswer2.Location = new Point(18, 124);
            lbAnswer2.MaximumSize = new Size(950, 0);
            lbAnswer2.Name = "lbAnswer2";
            lbAnswer2.Size = new Size(53, 31);
            lbAnswer2.TabIndex = 6;
            lbAnswer2.Text = " 1 - ";
            lbAnswer2.Click += lbAnswer2_Click;
            // 
            // lbAnswer1
            // 
            lbAnswer1.AutoSize = true;
            lbAnswer1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnswer1.Location = new Point(18, 20);
            lbAnswer1.MaximumSize = new Size(950, 0);
            lbAnswer1.Name = "lbAnswer1";
            lbAnswer1.Size = new Size(53, 31);
            lbAnswer1.TabIndex = 3;
            lbAnswer1.Text = " 1 - ";
            // 
            // lbQuestionNum
            // 
            lbQuestionNum.AutoSize = true;
            lbQuestionNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuestionNum.Location = new Point(39, 45);
            lbQuestionNum.Name = "lbQuestionNum";
            lbQuestionNum.Size = new Size(117, 31);
            lbQuestionNum.TabIndex = 9;
            lbQuestionNum.Text = "Question ";
            // 
            // pcbQuestion
            // 
            pcbQuestion.Location = new Point(68, 222);
            pcbQuestion.Name = "pcbQuestion";
            pcbQuestion.Size = new Size(882, 204);
            pcbQuestion.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbQuestion.TabIndex = 2;
            pcbQuestion.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbQuestionNum);
            panel1.Controls.Add(pcbQuestion);
            panel1.Controls.Add(lbQuestion);
            panel1.Controls.Add(pnQuestion);
            panel1.Location = new Point(35, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 949);
            panel1.TabIndex = 13;
            // 
            // pnQuestion
            // 
            pnQuestion.Controls.Add(lbAnswer4);
            pnQuestion.Controls.Add(lbAnswer3);
            pnQuestion.Controls.Add(lbAnswer2);
            pnQuestion.Controls.Add(lbAnswer1);
            pnQuestion.Location = new Point(30, 553);
            pnQuestion.Name = "pnQuestion";
            pnQuestion.Size = new Size(990, 362);
            pnQuestion.TabIndex = 7;
            // 
            // lbHome
            // 
            lbHome.BackColor = Color.MediumPurple;
            lbHome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbHome.ForeColor = SystemColors.ButtonFace;
            lbHome.Location = new Point(1186, -146);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(140, 50);
            lbHome.TabIndex = 15;
            lbHome.Text = "Home";
            lbHome.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1369, 35);
            button1.Name = "button1";
            button1.Size = new Size(140, 50);
            button1.TabIndex = 16;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserPractice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1540, 1025);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbHome);
            Name = "UserPractice";
            Text = "UserPractice";
            Load += UserPractice_Load;
            KeyDown += UserPractice_KeyDown;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbQuestion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnQuestion.ResumeLayout(false);
            pnQuestion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label lbExplain;
        private Button btnNext;
        private Button btnBack;
        private Label lbAnswer4;
        private Label lbAnswer3;
        private Label lbQuestion;
        private Label lbAnswer2;
        private Label lbAnswer1;
        private Label lbQuestionNum;
        private PictureBox pcbQuestion;
        private Panel panel1;
        private Panel pnQuestion;
        private Button lbHome;
        private Button button1;
        private Label label2;
        private ListBox lbTopic;
        private Button button2;
    }
}