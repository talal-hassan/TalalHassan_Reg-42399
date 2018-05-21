namespace Student_Profile
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.attendanceMarkControl1 = new Student_Profile.AttendanceMarkControl();
            this.attendanceViewControl1 = new Student_Profile.AttendanceViewControl();
            this.delete1 = new Student_Profile.DeleteControl();
            this.searchControl1 = new Student_Profile.SearchControl();
            this.homeControl1 = new Student_Profile.HomeControl();
            this.userControl11 = new Student_Profile.UserControl1();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SidePanel.Controls.Add(this.btnMinimize);
            this.SidePanel.Controls.Add(this.btnClose);
            this.SidePanel.Controls.Add(this.UserName);
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Controls.Add(this.SideBar);
            this.SidePanel.Controls.Add(this.button6);
            this.SidePanel.Controls.Add(this.button5);
            this.SidePanel.Controls.Add(this.btnDelete);
            this.SidePanel.Controls.Add(this.btnCreate);
            this.SidePanel.Controls.Add(this.btnSearchStudent);
            this.SidePanel.Controls.Add(this.btnHome);
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(214, 517);
            this.SidePanel.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Location = new System.Drawing.Point(38, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 27);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(7, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.close_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UserName.Location = new System.Drawing.Point(41, 116);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(133, 24);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Talal Hassan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 65);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.IndianRed;
            this.SideBar.Location = new System.Drawing.Point(0, 160);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(8, 45);
            this.SideBar.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(12, 413);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 45);
            this.button6.TabIndex = 11;
            this.button6.Text = "  Mark Attendance";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(12, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 45);
            this.button5.TabIndex = 10;
            this.button5.Text = "  View Attendance";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(12, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 45);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "  Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.Location = new System.Drawing.Point(12, 260);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(202, 45);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "  Create";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.FlatAppearance.BorderSize = 0;
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStudent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchStudent.Image")));
            this.btnSearchStudent.Location = new System.Drawing.Point(12, 209);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(202, 45);
            this.btnSearchStudent.TabIndex = 1;
            this.btnSearchStudent.Text = "  Search";
            this.btnSearchStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(14, 158);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(202, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "  Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(214, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 10);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(284, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 108);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(0, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Profile";
            this.label1.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(37, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 79);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // attendanceMarkControl1
            // 
            this.attendanceMarkControl1.Location = new System.Drawing.Point(220, 118);
            this.attendanceMarkControl1.Name = "attendanceMarkControl1";
            this.attendanceMarkControl1.Size = new System.Drawing.Size(614, 372);
            this.attendanceMarkControl1.TabIndex = 15;
            // 
            // attendanceViewControl1
            // 
            this.attendanceViewControl1.Location = new System.Drawing.Point(220, 118);
            this.attendanceViewControl1.Name = "attendanceViewControl1";
            this.attendanceViewControl1.Size = new System.Drawing.Size(614, 372);
            this.attendanceViewControl1.TabIndex = 14;
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(220, 118);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(614, 372);
            this.delete1.TabIndex = 13;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(220, 118);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(614, 372);
            this.searchControl1.TabIndex = 11;
            this.searchControl1.Load += new System.EventHandler(this.searchControl1_Load);
            // 
            // homeControl1
            // 
            this.homeControl1.Location = new System.Drawing.Point(220, 118);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(614, 372);
            this.homeControl1.TabIndex = 10;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(220, 118);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(614, 372);
            this.userControl11.TabIndex = 16;
            // 
            // Date
            // 
            this.Date.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Date.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.Date.CalendarTitleBackColor = System.Drawing.Color.WhiteSmoke;
            this.Date.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.Date.Enabled = false;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Date.Location = new System.Drawing.Point(445, 16);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(384, 33);
            this.Date.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "Time";
            this.label2.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(956, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.attendanceMarkControl1);
            this.Controls.Add(this.attendanceViewControl1);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Panel SideBar;
        private HomeControl homeControl1;
        private SearchControl searchControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private DeleteControl delete1;
        private AttendanceViewControl attendanceViewControl1;
        private AttendanceMarkControl attendanceMarkControl1;
        private System.Windows.Forms.Button btnMinimize;
        private UserControl1 userControl11;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}