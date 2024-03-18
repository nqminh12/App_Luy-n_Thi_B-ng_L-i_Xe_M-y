namespace UserForm
{
    partial class UserTestQuiz
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
            components = new System.ComponentModel.Container();
            lbQuestion = new Label();
            panel1 = new Panel();
            pcbQuestion = new PictureBox();
            pnQuestion = new Panel();
            lbAnswer4 = new Label();
            lbAnswer3 = new Label();
            lbAnswer2 = new Label();
            lbAnswer1 = new Label();
            panel2 = new Panel();
            lbSet = new Label();
            lbLincese = new Label();
            lbCountDown = new Label();
            label3 = new Label();
            panel3 = new Panel();
            rdAnswer4 = new RadioButton();
            rdAnswer3 = new RadioButton();
            rdAnswer2 = new RadioButton();
            rdAnswer1 = new RadioButton();
            lbQuestionNum = new Label();
            btnBack = new Button();
            btnNext = new Button();
            btnFinish = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            cbFinish = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbQuestion).BeginInit();
            pnQuestion.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lbQuestion
            // 
            lbQuestion.AutoSize = true;
            lbQuestion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuestion.Location = new Point(30, 74);
            lbQuestion.MaximumSize = new Size(1000, 0);
            lbQuestion.Name = "lbQuestion";
            lbQuestion.Size = new Size(96, 38);
            lbQuestion.TabIndex = 1;
            lbQuestion.Text = "label1";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pcbQuestion);
            panel1.Controls.Add(lbQuestion);
            panel1.Controls.Add(pnQuestion);
            panel1.Location = new Point(33, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 925);
            panel1.TabIndex = 2;
            // 
            // pcbQuestion
            // 
            pcbQuestion.Location = new Point(60, 194);
            pcbQuestion.Name = "pcbQuestion";
            pcbQuestion.Size = new Size(882, 204);
            pcbQuestion.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbQuestion.TabIndex = 2;
            pcbQuestion.TabStop = false;
            // 
            // pnQuestion
            // 
            pnQuestion.Controls.Add(lbAnswer4);
            pnQuestion.Controls.Add(lbAnswer3);
            pnQuestion.Controls.Add(lbAnswer2);
            pnQuestion.Controls.Add(lbAnswer1);
            pnQuestion.Location = new Point(30, 561);
            pnQuestion.Name = "pnQuestion";
            pnQuestion.Size = new Size(990, 354);
            pnQuestion.TabIndex = 7;
            // 
            // lbAnswer4
            // 
            lbAnswer4.AutoSize = true;
            lbAnswer4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnswer4.Location = new Point(18, 269);
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
            lbAnswer3.Location = new Point(18, 188);
            lbAnswer3.MaximumSize = new Size(950, 0);
            lbAnswer3.Name = "lbAnswer3";
            lbAnswer3.Size = new Size(53, 31);
            lbAnswer3.TabIndex = 5;
            lbAnswer3.Text = " 1 - ";
            // 
            // lbAnswer2
            // 
            lbAnswer2.AutoSize = true;
            lbAnswer2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnswer2.Location = new Point(18, 105);
            lbAnswer2.MaximumSize = new Size(950, 0);
            lbAnswer2.Name = "lbAnswer2";
            lbAnswer2.Size = new Size(53, 31);
            lbAnswer2.TabIndex = 6;
            lbAnswer2.Text = " 1 - ";
            // 
            // lbAnswer1
            // 
            lbAnswer1.AutoSize = true;
            lbAnswer1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnswer1.Location = new Point(18, 18);
            lbAnswer1.MaximumSize = new Size(950, 0);
            lbAnswer1.Name = "lbAnswer1";
            lbAnswer1.Size = new Size(53, 31);
            lbAnswer1.TabIndex = 3;
            lbAnswer1.Text = " 1 - ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LemonChiffon;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbSet);
            panel2.Controls.Add(lbLincese);
            panel2.Controls.Add(lbCountDown);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(1100, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 134);
            panel2.TabIndex = 3;
            // 
            // lbSet
            // 
            lbSet.AutoSize = true;
            lbSet.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbSet.Location = new Point(164, 94);
            lbSet.Name = "lbSet";
            lbSet.Size = new Size(54, 25);
            lbSet.TabIndex = 3;
            lbSet.Text = "Set:  ";
            // 
            // lbLincese
            // 
            lbLincese.AutoSize = true;
            lbLincese.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbLincese.Location = new Point(13, 94);
            lbLincese.Name = "lbLincese";
            lbLincese.Size = new Size(89, 25);
            lbLincese.TabIndex = 2;
            lbLincese.Text = "Lincese:  ";
            // 
            // lbCountDown
            // 
            lbCountDown.AutoSize = true;
            lbCountDown.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbCountDown.Location = new Point(206, 1);
            lbCountDown.Name = "lbCountDown";
            lbCountDown.Size = new Size(126, 54);
            lbCountDown.TabIndex = 1;
            lbCountDown.Text = "25:00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(182, 31);
            label3.TabIndex = 0;
            label3.Text = "Time remaining:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LemonChiffon;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(rdAnswer4);
            panel3.Controls.Add(rdAnswer3);
            panel3.Controls.Add(rdAnswer2);
            panel3.Controls.Add(rdAnswer1);
            panel3.Controls.Add(lbQuestionNum);
            panel3.Location = new Point(1100, 287);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 560);
            panel3.TabIndex = 9;
            // 
            // rdAnswer4
            // 
            rdAnswer4.AutoSize = true;
            rdAnswer4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdAnswer4.Location = new Point(73, 381);
            rdAnswer4.Name = "rdAnswer4";
            rdAnswer4.Size = new Size(112, 32);
            rdAnswer4.TabIndex = 4;
            rdAnswer4.TabStop = true;
            rdAnswer4.Text = "Answer 4";
            rdAnswer4.UseVisualStyleBackColor = true;
            rdAnswer4.CheckedChanged += rdAnswer4_CheckedChanged;
            // 
            // rdAnswer3
            // 
            rdAnswer3.AutoSize = true;
            rdAnswer3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdAnswer3.Location = new Point(73, 294);
            rdAnswer3.Name = "rdAnswer3";
            rdAnswer3.Size = new Size(112, 32);
            rdAnswer3.TabIndex = 3;
            rdAnswer3.TabStop = true;
            rdAnswer3.Text = "Answer 3";
            rdAnswer3.UseVisualStyleBackColor = true;
            rdAnswer3.CheckedChanged += rdAnswer3_CheckedChanged;
            // 
            // rdAnswer2
            // 
            rdAnswer2.AutoSize = true;
            rdAnswer2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdAnswer2.Location = new Point(73, 210);
            rdAnswer2.Name = "rdAnswer2";
            rdAnswer2.Size = new Size(112, 32);
            rdAnswer2.TabIndex = 2;
            rdAnswer2.TabStop = true;
            rdAnswer2.Text = "Answer 2";
            rdAnswer2.UseVisualStyleBackColor = true;
            rdAnswer2.CheckedChanged += rdAnswer2_CheckedChanged;
            // 
            // rdAnswer1
            // 
            rdAnswer1.AutoSize = true;
            rdAnswer1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdAnswer1.Location = new Point(73, 126);
            rdAnswer1.Name = "rdAnswer1";
            rdAnswer1.Size = new Size(112, 32);
            rdAnswer1.TabIndex = 1;
            rdAnswer1.TabStop = true;
            rdAnswer1.Text = "Answer 1";
            rdAnswer1.UseVisualStyleBackColor = true;
            rdAnswer1.CheckedChanged += rdAnswer1_CheckedChanged;
            // 
            // lbQuestionNum
            // 
            lbQuestionNum.AutoSize = true;
            lbQuestionNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuestionNum.Location = new Point(36, 43);
            lbQuestionNum.Name = "lbQuestionNum";
            lbQuestionNum.Size = new Size(117, 31);
            lbQuestionNum.TabIndex = 0;
            lbQuestionNum.Text = "Question ";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumPurple;
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(1100, 205);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(132, 54);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.MediumPurple;
            btnNext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ButtonFace;
            btnNext.Location = new Point(1317, 205);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(132, 54);
            btnNext.TabIndex = 10;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.MediumPurple;
            btnFinish.Enabled = false;
            btnFinish.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinish.ForeColor = SystemColors.ButtonFace;
            btnFinish.Location = new Point(1317, 905);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(132, 54);
            btnFinish.TabIndex = 11;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // cbFinish
            // 
            cbFinish.AutoSize = true;
            cbFinish.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbFinish.Location = new Point(1298, 870);
            cbFinish.Name = "cbFinish";
            cbFinish.Size = new Size(151, 29);
            cbFinish.TabIndex = 12;
            cbFinish.Text = "I want to finish";
            cbFinish.UseVisualStyleBackColor = true;
            cbFinish.CheckedChanged += cbFinish_CheckedChanged;
            // 
            // UserTestQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1498, 982);
            Controls.Add(cbFinish);
            Controls.Add(btnFinish);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserTestQuiz";
            Text = "UserTestQuiz";
            Load += UserTestQuiz_Load;
            KeyDown += UserTestQuiz_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbQuestion).EndInit();
            pnQuestion.ResumeLayout(false);
            pnQuestion.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbQuestion;
        private Panel panel1;
        private PictureBox pcbQuestion;
        private Panel panel2;
        private Label label3;
        private Label lbCountDown;
        private Panel panel3;
        private Label lbQuestionNum;
        private RadioButton rdAnswer1;
        private Button btnBack;
        private Button btnNext;
        private Button btnFinish;
        private Label lbSet;
        private Label lbLincese;
        private Label lbAnswer1;
        private Label lbAnswer2;
        private Label lbAnswer3;
        private Label lbAnswer4;
        private Panel pnQuestion;
        private RadioButton rdAnswer2;
        private RadioButton rdAnswer4;
        private RadioButton rdAnswer3;
        private CheckBox cbFinish;
    }
}