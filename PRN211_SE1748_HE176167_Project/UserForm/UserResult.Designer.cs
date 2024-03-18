namespace UserForm
{
    partial class UserResult
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
            panel1 = new Panel();
            lbQuestionMark = new Label();
            lbQuestionNum = new Label();
            pcbQuestion = new PictureBox();
            lbQuestion = new Label();
            pnQuestion = new Panel();
            lbAnswer4 = new Label();
            lbAnswer3 = new Label();
            lbAnswer2 = new Label();
            lbAnswer1 = new Label();
            btnNext = new Button();
            btnBack = new Button();
            lbMark = new Label();
            panel2 = new Panel();
            lbExplain = new Label();
            label1 = new Label();
            lbHome = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbQuestion).BeginInit();
            pnQuestion.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbQuestionMark);
            panel1.Controls.Add(lbQuestionNum);
            panel1.Controls.Add(pcbQuestion);
            panel1.Controls.Add(lbQuestion);
            panel1.Controls.Add(pnQuestion);
            panel1.Location = new Point(35, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 990);
            panel1.TabIndex = 3;
            // 
            // lbQuestionMark
            // 
            lbQuestionMark.AutoSize = true;
            lbQuestionMark.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            lbQuestionMark.Location = new Point(222, 46);
            lbQuestionMark.Name = "lbQuestionMark";
            lbQuestionMark.Size = new Size(79, 31);
            lbQuestionMark.TabIndex = 10;
            lbQuestionMark.Text = "label1";
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
            pcbQuestion.Location = new Point(62, 215);
            pcbQuestion.Name = "pcbQuestion";
            pcbQuestion.Size = new Size(882, 204);
            pcbQuestion.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbQuestion.TabIndex = 2;
            pcbQuestion.TabStop = false;
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
            lbAnswer4.Location = new Point(18, 323);
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
            lbAnswer3.Location = new Point(18, 225);
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
            lbAnswer2.Location = new Point(18, 132);
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
            lbAnswer1.Location = new Point(18, 24);
            lbAnswer1.MaximumSize = new Size(950, 0);
            lbAnswer1.Name = "lbAnswer1";
            lbAnswer1.Size = new Size(53, 31);
            lbAnswer1.TabIndex = 3;
            lbAnswer1.Text = " 1 - ";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.MediumPurple;
            btnNext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ButtonFace;
            btnNext.Location = new Point(234, 819);
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
            btnBack.Location = new Point(15, 819);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 50);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lbMark
            // 
            lbMark.AutoSize = true;
            lbMark.BackColor = Color.LemonChiffon;
            lbMark.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbMark.Location = new Point(241, 14);
            lbMark.Name = "lbMark";
            lbMark.Size = new Size(133, 54);
            lbMark.TabIndex = 8;
            lbMark.Text = "25/25";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LemonChiffon;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbExplain);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(lbMark);
            panel2.Location = new Point(1121, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 900);
            panel2.TabIndex = 4;
            // 
            // lbExplain
            // 
            lbExplain.AutoSize = true;
            lbExplain.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbExplain.Location = new Point(26, 188);
            lbExplain.MaximumSize = new Size(350, 0);
            lbExplain.Name = "lbExplain";
            lbExplain.Size = new Size(76, 31);
            lbExplain.TabIndex = 11;
            lbExplain.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 125);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 10;
            label1.Text = "Explain:";
            // 
            // lbHome
            // 
            lbHome.BackColor = Color.MediumPurple;
            lbHome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbHome.ForeColor = SystemColors.ButtonFace;
            lbHome.Location = new Point(1356, 35);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(140, 50);
            lbHome.TabIndex = 12;
            lbHome.Text = "Home";
            lbHome.UseVisualStyleBackColor = false;
            lbHome.Click += lbHome_Click;
            // 
            // UserResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1540, 1051);
            Controls.Add(lbHome);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserResult";
            Text = "UserResult";
            Load += UserResult_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbQuestion).EndInit();
            pnQuestion.ResumeLayout(false);
            pnQuestion.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pcbQuestion;
        private Label lbQuestion;
        private Panel pnQuestion;
        private Label lbAnswer4;
        private Label lbAnswer3;
        private Label lbAnswer2;
        private Label lbAnswer1;
        private Label lbMark;
        private Label lbQuestionNum;
        private Button btnBack;
        private Button btnNext;
        private Label lbQuestionMark;
        private Panel panel2;
        private Label lbExplain;
        private Label label1;
        private Button lbHome;
    }
}