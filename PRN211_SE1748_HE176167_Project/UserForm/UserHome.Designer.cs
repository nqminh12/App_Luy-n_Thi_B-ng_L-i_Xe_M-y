namespace UserForm
{
    partial class UserHome
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
            cbLincesetype = new ComboBox();
            label1 = new Label();
            pb1 = new PictureBox();
            button1 = new Button();
            pb2 = new PictureBox();
            pb3 = new PictureBox();
            pb4 = new PictureBox();
            pb5 = new PictureBox();
            pb6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb6).BeginInit();
            SuspendLayout();
            // 
            // cbLincesetype
            // 
            cbLincesetype.FormattingEnabled = true;
            cbLincesetype.Location = new Point(148, 23);
            cbLincesetype.Name = "cbLincesetype";
            cbLincesetype.Size = new Size(151, 28);
            cbLincesetype.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 31);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "License type: ";
            // 
            // pb1
            // 
            pb1.Image = Properties.Resources.img1;
            pb1.Location = new Point(39, 93);
            pb1.Name = "pb1";
            pb1.Size = new Size(200, 150);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.TabIndex = 2;
            pb1.TabStop = false;
            pb1.Click += pb1_Click;
            pb1.DoubleClick += pb1_DoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(712, 476);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 8;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pb2
            // 
            pb2.Image = Properties.Resources.img2;
            pb2.Location = new Point(330, 93);
            pb2.Name = "pb2";
            pb2.Size = new Size(200, 150);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.TabIndex = 9;
            pb2.TabStop = false;
            pb2.Click += pb2_Click;
            // 
            // pb3
            // 
            pb3.Image = Properties.Resources.img5;
            pb3.Location = new Point(612, 93);
            pb3.Name = "pb3";
            pb3.Size = new Size(200, 150);
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.TabIndex = 10;
            pb3.TabStop = false;
            pb3.Click += pb3_Click;
            // 
            // pb4
            // 
            pb4.Image = Properties.Resources.img3;
            pb4.Location = new Point(39, 293);
            pb4.Name = "pb4";
            pb4.Size = new Size(200, 150);
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.TabIndex = 11;
            pb4.TabStop = false;
            pb4.Click += pb4_Click;
            // 
            // pb5
            // 
            pb5.Image = Properties.Resources.img6;
            pb5.Location = new Point(330, 293);
            pb5.Name = "pb5";
            pb5.Size = new Size(200, 150);
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.TabIndex = 12;
            pb5.TabStop = false;
            // 
            // pb6
            // 
            pb6.Image = Properties.Resources.img4;
            pb6.Location = new Point(612, 293);
            pb6.Name = "pb6";
            pb6.Size = new Size(200, 150);
            pb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb6.TabIndex = 13;
            pb6.TabStop = false;
            // 
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(853, 532);
            Controls.Add(pb6);
            Controls.Add(pb5);
            Controls.Add(pb4);
            Controls.Add(pb3);
            Controls.Add(pb2);
            Controls.Add(button1);
            Controls.Add(pb1);
            Controls.Add(label1);
            Controls.Add(cbLincesetype);
            Name = "UserHome";
            Text = "UserHome";
            Load += UserHome_Load;
            DoubleClick += UserHome_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbLincesetype;
        private Label label1;
        private PictureBox pb1;
        private Button button1;
        private PictureBox pb2;
        private PictureBox pb3;
        private PictureBox pb4;
        private PictureBox pb5;
        private PictureBox pb6;
    }
}