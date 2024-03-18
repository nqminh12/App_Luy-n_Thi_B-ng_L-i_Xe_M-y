namespace UserForm
{
    partial class TrafficSign
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
            btnHome = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            tabPage3 = new TabPage();
            pictureBox3 = new PictureBox();
            tabPage4 = new TabPage();
            pictureBox4 = new PictureBox();
            tabPage5 = new TabPage();
            pictureBox5 = new PictureBox();
            tabPage6 = new TabPage();
            pictureBox6 = new PictureBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.MediumPurple;
            btnHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = SystemColors.Control;
            btnHome.Location = new Point(21, 24);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 41);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(21, 82);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(968, 486);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(960, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Biển báo cấm";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bien_bao_cam;
            pictureBox1.Location = new Point(30, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(880, 1075);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(960, 450);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Biển báo nguy hiểm";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bien_bao_nguy_hiem;
            pictureBox2.Location = new Point(37, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(869, 1119);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pictureBox3);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(960, 450);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Biển hiệu lệnh";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.bien_hieu_lenh;
            pictureBox3.Location = new Point(20, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(919, 417);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.AutoScroll = true;
            tabPage4.Controls.Add(pictureBox4);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(960, 450);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Biển chỉ dẫn";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.bien_chi_dan;
            pictureBox4.Location = new Point(35, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(875, 1292);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // tabPage5
            // 
            tabPage5.AutoScroll = true;
            tabPage5.Controls.Add(pictureBox5);
            tabPage5.Location = new Point(4, 32);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(960, 450);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Biển phụ";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.bien_phu;
            pictureBox5.Location = new Point(47, 20);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(867, 489);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // tabPage6
            // 
            tabPage6.AutoScroll = true;
            tabPage6.Controls.Add(pictureBox6);
            tabPage6.Location = new Point(4, 32);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(960, 450);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Vạch kẻ đường";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.vach_ke_duong;
            pictureBox6.Location = new Point(39, 27);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(868, 585);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(891, 24);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 2;
            button1.Text = "Quiz";
            button1.UseVisualStyleBackColor = false;
            // 
            // TrafficSign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Aqua;
            ClientSize = new Size(1012, 607);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Controls.Add(btnHome);
            Name = "TrafficSign";
            Text = "TrafficSign";
            Load += TrafficSign_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button button1;
    }
}