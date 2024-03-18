namespace UserForm
{
    partial class UserChooseSet
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
            cbChooseSet = new ComboBox();
            label1 = new Label();
            btnStart = new Button();
            btnView = new Button();
            button3 = new Button();
            label2 = new Label();
            lboxDate = new ListBox();
            SuspendLayout();
            // 
            // cbChooseSet
            // 
            cbChooseSet.DropDownHeight = 100;
            cbChooseSet.FormattingEnabled = true;
            cbChooseSet.IntegralHeight = false;
            cbChooseSet.Location = new Point(242, 99);
            cbChooseSet.Name = "cbChooseSet";
            cbChooseSet.Size = new Size(150, 28);
            cbChooseSet.TabIndex = 0;
            cbChooseSet.SelectedIndexChanged += cbChooseSet_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 99);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 1;
            label1.Text = "Choose set:";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.MediumPurple;
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = SystemColors.ButtonHighlight;
            btnStart.Location = new Point(291, 153);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(101, 40);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.MediumPurple;
            btnView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.ForeColor = SystemColors.ButtonHighlight;
            btnView.Location = new Point(611, 285);
            btnView.Name = "btnView";
            btnView.Size = new Size(140, 40);
            btnView.TabIndex = 3;
            btnView.Text = "View History";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumPurple;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1, 2);
            button3.Name = "button3";
            button3.Size = new Size(90, 38);
            button3.TabIndex = 4;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(454, 54);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 5;
            label2.Text = "Choose date:";
            // 
            // lboxDate
            // 
            lboxDate.FormattingEnabled = true;
            lboxDate.ItemHeight = 20;
            lboxDate.Location = new Point(454, 99);
            lboxDate.Name = "lboxDate";
            lboxDate.Size = new Size(297, 164);
            lboxDate.TabIndex = 6;
            // 
            // UserChooseSet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(849, 380);
            Controls.Add(lboxDate);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(btnView);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Controls.Add(cbChooseSet);
            Name = "UserChooseSet";
            Text = "UserChooseSet";
            Load += UserChooseSet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbChooseSet;
        private Label label1;
        private Button btnStart;
        private Button btnView;
        private Button button3;
        private Label label2;
        private ListBox lboxDate;
    }
}