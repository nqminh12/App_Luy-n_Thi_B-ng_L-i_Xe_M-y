namespace UserForm
{
    partial class AdminHome
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
            dgQuestion = new DataGridView();
            dgAnswer = new DataGridView();
            label3 = new Label();
            txtQuesId = new TextBox();
            label4 = new Label();
            rtQuestionDescription = new RichTextBox();
            label5 = new Label();
            txtImage = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbLinceseQuestion = new ComboBox();
            cbSetQuestion = new ComboBox();
            cbTopicQuestion = new ComboBox();
            rtQuestionExplain = new RichTextBox();
            label9 = new Label();
            btnQuestionAdd = new Button();
            btnQuestionDelete = new Button();
            btnQuestionUpdate = new Button();
            btnAddAnswer = new Button();
            btnUpdateAnswer = new Button();
            btnDeleteAnswer = new Button();
            label10 = new Label();
            txtAnswerId = new TextBox();
            label11 = new Label();
            rtAnswerDes = new RichTextBox();
            label12 = new Label();
            rdTrue = new RadioButton();
            rdFalse = new RadioButton();
            label13 = new Label();
            cbQuestionId = new ComboBox();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            btnUser = new Button();
            pcbImageSearch = new PictureBox();
            label1 = new Label();
            txtImageSearch = new TextBox();
            btnImageSearch = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            pcbImage = new PictureBox();
            label2 = new Label();
            btnBack = new Button();
            btnNext = new Button();
            lbTotalQues = new Label();
            lbCurrentPage = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgAnswer).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImageSearch).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImage).BeginInit();
            SuspendLayout();
            // 
            // dgQuestion
            // 
            dgQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgQuestion.Location = new Point(12, 545);
            dgQuestion.Name = "dgQuestion";
            dgQuestion.RowHeadersWidth = 51;
            dgQuestion.RowTemplate.Height = 29;
            dgQuestion.Size = new Size(918, 343);
            dgQuestion.TabIndex = 3;
            dgQuestion.CellClick += dgQuestion_CellClick;
            // 
            // dgAnswer
            // 
            dgAnswer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAnswer.Location = new Point(960, 545);
            dgAnswer.Name = "dgAnswer";
            dgAnswer.RowHeadersWidth = 51;
            dgAnswer.RowTemplate.Height = 29;
            dgAnswer.Size = new Size(415, 343);
            dgAnswer.TabIndex = 4;
            dgAnswer.CellClick += dgAnswer_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 189);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Question_Id:";
            // 
            // txtQuesId
            // 
            txtQuesId.Location = new Point(152, 186);
            txtQuesId.Name = "txtQuesId";
            txtQuesId.ReadOnly = true;
            txtQuesId.Size = new Size(125, 27);
            txtQuesId.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 272);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 7;
            label4.Text = "Question_Description:";
            // 
            // rtQuestionDescription
            // 
            rtQuestionDescription.Location = new Point(41, 295);
            rtQuestionDescription.Name = "rtQuestionDescription";
            rtQuestionDescription.Size = new Size(236, 136);
            rtQuestionDescription.TabIndex = 8;
            rtQuestionDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 193);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 9;
            label5.Text = "Question_Image:";
            // 
            // txtImage
            // 
            txtImage.Location = new Point(529, 186);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(146, 27);
            txtImage.TabIndex = 10;
            txtImage.TextChanged += txtImage_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(374, 251);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 11;
            label6.Text = "Lincese:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 331);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 13;
            label7.Text = "Topic:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(374, 398);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 14;
            label8.Text = "Set:";
            // 
            // cbLinceseQuestion
            // 
            cbLinceseQuestion.FormattingEnabled = true;
            cbLinceseQuestion.Location = new Point(464, 243);
            cbLinceseQuestion.Name = "cbLinceseQuestion";
            cbLinceseQuestion.Size = new Size(95, 28);
            cbLinceseQuestion.TabIndex = 17;
            // 
            // cbSetQuestion
            // 
            cbSetQuestion.FormattingEnabled = true;
            cbSetQuestion.Location = new Point(464, 390);
            cbSetQuestion.Name = "cbSetQuestion";
            cbSetQuestion.Size = new Size(95, 28);
            cbSetQuestion.TabIndex = 18;
            // 
            // cbTopicQuestion
            // 
            cbTopicQuestion.FormattingEnabled = true;
            cbTopicQuestion.Location = new Point(464, 323);
            cbTopicQuestion.Name = "cbTopicQuestion";
            cbTopicQuestion.Size = new Size(95, 28);
            cbTopicQuestion.TabIndex = 19;
            // 
            // rtQuestionExplain
            // 
            rtQuestionExplain.Location = new Point(615, 100);
            rtQuestionExplain.Name = "rtQuestionExplain";
            rtQuestionExplain.Size = new Size(233, 136);
            rtQuestionExplain.TabIndex = 20;
            rtQuestionExplain.Text = "";
            rtQuestionExplain.TextChanged += richTextBox2_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(615, 71);
            label9.Name = "label9";
            label9.Size = new Size(125, 20);
            label9.TabIndex = 21;
            label9.Text = "Question_Explain:";
            // 
            // btnQuestionAdd
            // 
            btnQuestionAdd.BackColor = Color.MediumPurple;
            btnQuestionAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuestionAdd.ForeColor = SystemColors.ButtonFace;
            btnQuestionAdd.Location = new Point(26, 453);
            btnQuestionAdd.Name = "btnQuestionAdd";
            btnQuestionAdd.Size = new Size(94, 41);
            btnQuestionAdd.TabIndex = 22;
            btnQuestionAdd.Text = "Add";
            btnQuestionAdd.UseVisualStyleBackColor = false;
            btnQuestionAdd.Click += btnQuestionAdd_Click;
            // 
            // btnQuestionDelete
            // 
            btnQuestionDelete.BackColor = Color.MediumPurple;
            btnQuestionDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuestionDelete.ForeColor = SystemColors.ButtonFace;
            btnQuestionDelete.Location = new Point(452, 453);
            btnQuestionDelete.Name = "btnQuestionDelete";
            btnQuestionDelete.Size = new Size(94, 41);
            btnQuestionDelete.TabIndex = 23;
            btnQuestionDelete.Text = "Delete";
            btnQuestionDelete.UseVisualStyleBackColor = false;
            btnQuestionDelete.Click += btnQuestionDelete_Click;
            // 
            // btnQuestionUpdate
            // 
            btnQuestionUpdate.BackColor = Color.MediumPurple;
            btnQuestionUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuestionUpdate.ForeColor = SystemColors.ButtonFace;
            btnQuestionUpdate.Location = new Point(241, 453);
            btnQuestionUpdate.Name = "btnQuestionUpdate";
            btnQuestionUpdate.Size = new Size(94, 41);
            btnQuestionUpdate.TabIndex = 24;
            btnQuestionUpdate.Text = "Update";
            btnQuestionUpdate.UseVisualStyleBackColor = false;
            btnQuestionUpdate.Click += btnQuestionUpdate_Click;
            // 
            // btnAddAnswer
            // 
            btnAddAnswer.BackColor = Color.MediumPurple;
            btnAddAnswer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAnswer.ForeColor = SystemColors.ButtonFace;
            btnAddAnswer.Location = new Point(977, 453);
            btnAddAnswer.Name = "btnAddAnswer";
            btnAddAnswer.Size = new Size(94, 41);
            btnAddAnswer.TabIndex = 25;
            btnAddAnswer.Text = "Add";
            btnAddAnswer.UseVisualStyleBackColor = false;
            btnAddAnswer.Click += btnAddAnswer_Click;
            // 
            // btnUpdateAnswer
            // 
            btnUpdateAnswer.BackColor = Color.MediumPurple;
            btnUpdateAnswer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateAnswer.ForeColor = SystemColors.ButtonFace;
            btnUpdateAnswer.Location = new Point(1126, 453);
            btnUpdateAnswer.Name = "btnUpdateAnswer";
            btnUpdateAnswer.Size = new Size(94, 41);
            btnUpdateAnswer.TabIndex = 26;
            btnUpdateAnswer.Text = "Update";
            btnUpdateAnswer.UseVisualStyleBackColor = false;
            btnUpdateAnswer.Click += btnUpdateAnswer_Click;
            // 
            // btnDeleteAnswer
            // 
            btnDeleteAnswer.BackColor = Color.MediumPurple;
            btnDeleteAnswer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteAnswer.ForeColor = SystemColors.ButtonFace;
            btnDeleteAnswer.Location = new Point(1274, 453);
            btnDeleteAnswer.Name = "btnDeleteAnswer";
            btnDeleteAnswer.Size = new Size(94, 41);
            btnDeleteAnswer.TabIndex = 27;
            btnDeleteAnswer.Text = "Delete";
            btnDeleteAnswer.UseVisualStyleBackColor = false;
            btnDeleteAnswer.Click += btnDeleteAnswer_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(977, 146);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 28;
            label10.Text = "Answer_Id:";
            // 
            // txtAnswerId
            // 
            txtAnswerId.Location = new Point(1082, 143);
            txtAnswerId.Name = "txtAnswerId";
            txtAnswerId.ReadOnly = true;
            txtAnswerId.Size = new Size(157, 27);
            txtAnswerId.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(977, 193);
            label11.Name = "label11";
            label11.Size = new Size(142, 20);
            label11.TabIndex = 30;
            label11.Text = "Answer_Description:";
            // 
            // rtAnswerDes
            // 
            rtAnswerDes.Location = new Point(977, 216);
            rtAnswerDes.Name = "rtAnswerDes";
            rtAnswerDes.Size = new Size(262, 120);
            rtAnswerDes.TabIndex = 31;
            rtAnswerDes.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(974, 398);
            label12.Name = "label12";
            label12.Size = new Size(97, 20);
            label12.TabIndex = 32;
            label12.Text = "Answer_Type:";
            // 
            // rdTrue
            // 
            rdTrue.AutoSize = true;
            rdTrue.Location = new Point(1095, 398);
            rdTrue.Name = "rdTrue";
            rdTrue.Size = new Size(58, 24);
            rdTrue.TabIndex = 34;
            rdTrue.TabStop = true;
            rdTrue.Text = "True";
            rdTrue.UseVisualStyleBackColor = true;
            // 
            // rdFalse
            // 
            rdFalse.AutoSize = true;
            rdFalse.Location = new Point(1177, 398);
            rdFalse.Name = "rdFalse";
            rdFalse.Size = new Size(62, 24);
            rdFalse.TabIndex = 35;
            rdFalse.TabStop = true;
            rdFalse.Text = "False";
            rdFalse.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(977, 357);
            label13.Name = "label13";
            label13.Size = new Size(90, 20);
            label13.TabIndex = 36;
            label13.Text = "Question_Id:";
            // 
            // cbQuestionId
            // 
            cbQuestionId.FormattingEnabled = true;
            cbQuestionId.Location = new Point(1082, 357);
            cbQuestionId.Name = "cbQuestionId";
            cbQuestionId.Size = new Size(157, 28);
            cbQuestionId.TabIndex = 37;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(1282, 20);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 38;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(rtQuestionExplain);
            panel2.Location = new Point(12, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 348);
            panel2.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(960, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 414);
            panel3.TabIndex = 40;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.MediumPurple;
            btnUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.ForeColor = SystemColors.ButtonFace;
            btnUser.Location = new Point(1115, 20);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(124, 40);
            btnUser.TabIndex = 41;
            btnUser.Text = "User Manage";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // pcbImageSearch
            // 
            pcbImageSearch.Location = new Point(12, 12);
            pcbImageSearch.Name = "pcbImageSearch";
            pcbImageSearch.Size = new Size(297, 120);
            pcbImageSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImageSearch.TabIndex = 42;
            pcbImageSearch.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(196, 7);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 43;
            label1.Text = "Image";
            // 
            // txtImageSearch
            // 
            txtImageSearch.Location = new Point(38, 64);
            txtImageSearch.Name = "txtImageSearch";
            txtImageSearch.Size = new Size(139, 27);
            txtImageSearch.TabIndex = 44;
            // 
            // btnImageSearch
            // 
            btnImageSearch.BackColor = Color.MediumPurple;
            btnImageSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImageSearch.ForeColor = SystemColors.ButtonFace;
            btnImageSearch.Location = new Point(38, 109);
            btnImageSearch.Name = "btnImageSearch";
            btnImageSearch.Size = new Size(139, 41);
            btnImageSearch.TabIndex = 45;
            btnImageSearch.Text = "Search Image";
            btnImageSearch.UseVisualStyleBackColor = false;
            btnImageSearch.Click += btnImageSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(183, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 145);
            panel1.TabIndex = 46;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LemonChiffon;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pcbImageSearch);
            panel4.Location = new Point(-1, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 145);
            panel4.TabIndex = 47;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LemonChiffon;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(pcbImage);
            panel5.Location = new Point(583, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(331, 145);
            panel5.TabIndex = 47;
            // 
            // pcbImage
            // 
            pcbImage.Location = new Point(16, 10);
            pcbImage.Name = "pcbImage";
            pcbImage.Size = new Size(297, 120);
            pcbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbImage.TabIndex = 48;
            pcbImage.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(600, 5);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 48;
            label2.Text = "Image";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumPurple;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(667, 908);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 30);
            btnBack.TabIndex = 49;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.MediumPurple;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ButtonFace;
            btnNext.Location = new Point(822, 908);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 30);
            btnNext.TabIndex = 50;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lbTotalQues
            // 
            lbTotalQues.AutoSize = true;
            lbTotalQues.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTotalQues.Location = new Point(771, 908);
            lbTotalQues.Name = "lbTotalQues";
            lbTotalQues.Size = new Size(40, 23);
            lbTotalQues.TabIndex = 52;
            lbTotalQues.Text = "/ 30";
            // 
            // lbCurrentPage
            // 
            lbCurrentPage.AutoSize = true;
            lbCurrentPage.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbCurrentPage.Location = new Point(748, 908);
            lbCurrentPage.Name = "lbCurrentPage";
            lbCurrentPage.Size = new Size(28, 23);
            lbCurrentPage.TabIndex = 53;
            lbCurrentPage.Text = "30";
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(617, 270);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(181, 27);
            txtSearch.TabIndex = 54;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumPurple;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(823, 266);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 34);
            btnSearch.TabIndex = 54;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1409, 954);
            Controls.Add(lbCurrentPage);
            Controls.Add(lbTotalQues);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(panel5);
            Controls.Add(btnImageSearch);
            Controls.Add(txtImageSearch);
            Controls.Add(label1);
            Controls.Add(btnUser);
            Controls.Add(button1);
            Controls.Add(cbQuestionId);
            Controls.Add(label13);
            Controls.Add(rdFalse);
            Controls.Add(rdTrue);
            Controls.Add(label12);
            Controls.Add(rtAnswerDes);
            Controls.Add(label11);
            Controls.Add(txtAnswerId);
            Controls.Add(label10);
            Controls.Add(btnDeleteAnswer);
            Controls.Add(btnUpdateAnswer);
            Controls.Add(btnAddAnswer);
            Controls.Add(btnQuestionUpdate);
            Controls.Add(btnQuestionDelete);
            Controls.Add(btnQuestionAdd);
            Controls.Add(cbTopicQuestion);
            Controls.Add(cbSetQuestion);
            Controls.Add(cbLinceseQuestion);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtImage);
            Controls.Add(label5);
            Controls.Add(rtQuestionDescription);
            Controls.Add(label4);
            Controls.Add(txtQuesId);
            Controls.Add(label3);
            Controls.Add(dgAnswer);
            Controls.Add(dgQuestion);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "AdminHome";
            Text = "AdminHome";
            Load += AdminHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgAnswer).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImageSearch).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgQuestion;
        private DataGridView dgAnswer;
        private Label label3;
        private TextBox txtQuesId;
        private Label label4;
        private RichTextBox rtQuestionDescription;
        private Label label5;
        private TextBox txtImage;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbLinceseQuestion;
        private ComboBox cbSetQuestion;
        private ComboBox cbTopicQuestion;
        private RichTextBox rtQuestionExplain;
        private Label label9;
        private Button btnQuestionAdd;
        private Button btnQuestionDelete;
        private Button btnQuestionUpdate;
        private Button btnAddAnswer;
        private Button btnUpdateAnswer;
        private Button btnDeleteAnswer;
        private Label label10;
        private TextBox txtAnswerId;
        private Label label11;
        private RichTextBox rtAnswerDes;
        private Label label12;
        private RadioButton rdTrue;
        private RadioButton rdFalse;
        private Label label13;
        private ComboBox cbQuestionId;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button btnUser;
        private PictureBox pcbImageSearch;
        private Label label1;
        private TextBox txtImageSearch;
        private Button btnImageSearch;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pcbImage;
        private Label label2;
        private Button btnBack;
        private Button btnNext;
        private Label lbTotalQues;
        private Label lbCurrentPage;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}