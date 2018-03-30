namespace Student_Profile
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCreate = new System.Windows.Forms.Label();
            this.getCGPA = new System.Windows.Forms.TextBox();
            this.getID = new System.Windows.Forms.TextBox();
            this.getDepartment = new System.Windows.Forms.ComboBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.btnCancelCreate = new System.Windows.Forms.Button();
            this.btnSaveCreate = new System.Windows.Forms.Button();
            this.getCampus = new System.Windows.Forms.ComboBox();
            this.getSemester = new System.Windows.Forms.TextBox();
            this.getName = new System.Windows.Forms.TextBox();
            this.labelCampus = new System.Windows.Forms.Label();
            this.labelCGPA = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tabCreate
            // 
            this.tabCreate.AutoSize = true;
            this.tabCreate.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCreate.Location = new System.Drawing.Point(64, 39);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Size = new System.Drawing.Size(138, 45);
            this.tabCreate.TabIndex = 2;
            this.tabCreate.Text = "Create";
            // 
            // getCGPA
            // 
            this.getCGPA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getCGPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getCGPA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCGPA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.getCGPA.Location = new System.Drawing.Point(239, 189);
            this.getCGPA.Name = "getCGPA";
            this.getCGPA.Size = new System.Drawing.Size(235, 16);
            this.getCGPA.TabIndex = 33;
            this.getCGPA.Text = "-int-";
            this.getCGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getCGPA.Click += new System.EventHandler(this.getCGPA_Click);
            // 
            // getID
            // 
            this.getID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.getID.Location = new System.Drawing.Point(239, 87);
            this.getID.Name = "getID";
            this.getID.Size = new System.Drawing.Size(235, 16);
            this.getID.TabIndex = 32;
            this.getID.Text = "-enter ID-";
            this.getID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getID.Click += new System.EventHandler(this.getID_Click);
            // 
            // getDepartment
            // 
            this.getDepartment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getDepartment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.getDepartment.FormattingEnabled = true;
            this.getDepartment.Items.AddRange(new object[] {
            "Software",
            "Computer",
            "Electrical"});
            this.getDepartment.Location = new System.Drawing.Point(239, 225);
            this.getDepartment.Name = "getDepartment";
            this.getDepartment.Size = new System.Drawing.Size(235, 25);
            this.getDepartment.TabIndex = 31;
            this.getDepartment.Text = "-select-";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.labelDepartment.Location = new System.Drawing.Point(109, 225);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(97, 20);
            this.labelDepartment.TabIndex = 30;
            this.labelDepartment.Text = "Department";
            // 
            // btnCancelCreate
            // 
            this.btnCancelCreate.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelCreate.FlatAppearance.BorderSize = 0;
            this.btnCancelCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelCreate.Location = new System.Drawing.Point(278, 312);
            this.btnCancelCreate.Name = "btnCancelCreate";
            this.btnCancelCreate.Size = new System.Drawing.Size(85, 35);
            this.btnCancelCreate.TabIndex = 29;
            this.btnCancelCreate.Text = "Cancel";
            this.btnCancelCreate.UseVisualStyleBackColor = false;
            // 
            // btnSaveCreate
            // 
            this.btnSaveCreate.BackColor = System.Drawing.Color.IndianRed;
            this.btnSaveCreate.FlatAppearance.BorderSize = 0;
            this.btnSaveCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveCreate.Location = new System.Drawing.Point(389, 312);
            this.btnSaveCreate.Name = "btnSaveCreate";
            this.btnSaveCreate.Size = new System.Drawing.Size(85, 35);
            this.btnSaveCreate.TabIndex = 28;
            this.btnSaveCreate.Text = "Save";
            this.btnSaveCreate.UseVisualStyleBackColor = false;
            this.btnSaveCreate.Click += new System.EventHandler(this.btnSaveCreate_Click);
            // 
            // getCampus
            // 
            this.getCampus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getCampus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getCampus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getCampus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCampus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.getCampus.FormattingEnabled = true;
            this.getCampus.Items.AddRange(new object[] {
            "Karachi",
            "Islamabad",
            "Lahore"});
            this.getCampus.Location = new System.Drawing.Point(239, 271);
            this.getCampus.Name = "getCampus";
            this.getCampus.Size = new System.Drawing.Size(235, 25);
            this.getCampus.TabIndex = 27;
            this.getCampus.Text = "-select-";
            // 
            // getSemester
            // 
            this.getSemester.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getSemester.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getSemester.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.getSemester.Location = new System.Drawing.Point(239, 154);
            this.getSemester.Name = "getSemester";
            this.getSemester.Size = new System.Drawing.Size(235, 16);
            this.getSemester.TabIndex = 26;
            this.getSemester.Text = "-in digits-";
            this.getSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getSemester.Click += new System.EventHandler(this.getSemester_Click_1);
            // 
            // getName
            // 
            this.getName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.getName.Location = new System.Drawing.Point(239, 119);
            this.getName.Name = "getName";
            this.getName.Size = new System.Drawing.Size(235, 16);
            this.getName.TabIndex = 25;
            this.getName.Text = "-full name-";
            this.getName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getName.Click += new System.EventHandler(this.getName_Click);
            // 
            // labelCampus
            // 
            this.labelCampus.AutoSize = true;
            this.labelCampus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.labelCampus.Location = new System.Drawing.Point(133, 272);
            this.labelCampus.Name = "labelCampus";
            this.labelCampus.Size = new System.Drawing.Size(69, 20);
            this.labelCampus.TabIndex = 24;
            this.labelCampus.Text = "Campus";
            // 
            // labelCGPA
            // 
            this.labelCGPA.AutoSize = true;
            this.labelCGPA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCGPA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.labelCGPA.Location = new System.Drawing.Point(145, 186);
            this.labelCGPA.Name = "labelCGPA";
            this.labelCGPA.Size = new System.Drawing.Size(54, 20);
            this.labelCGPA.TabIndex = 23;
            this.labelCGPA.Text = "CGPA";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.labelSemester.Location = new System.Drawing.Point(124, 150);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(75, 20);
            this.labelSemester.TabIndex = 22;
            this.labelSemester.Text = "Semester";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.labelID.Location = new System.Drawing.Point(101, 84);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(101, 20);
            this.labelID.TabIndex = 21;
            this.labelID.Text = "Enrolment ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.labelName.Location = new System.Drawing.Point(146, 115);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Name";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getCGPA);
            this.Controls.Add(this.getID);
            this.Controls.Add(this.getDepartment);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.btnCancelCreate);
            this.Controls.Add(this.btnSaveCreate);
            this.Controls.Add(this.getCampus);
            this.Controls.Add(this.getSemester);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.labelCampus);
            this.Controls.Add(this.labelCGPA);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tabCreate);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(614, 372);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tabCreate;
        private System.Windows.Forms.TextBox getCGPA;
        private System.Windows.Forms.TextBox getID;
        private System.Windows.Forms.ComboBox getDepartment;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Button btnCancelCreate;
        private System.Windows.Forms.Button btnSaveCreate;
        private System.Windows.Forms.ComboBox getCampus;
        private System.Windows.Forms.TextBox getSemester;
        private System.Windows.Forms.TextBox getName;
        private System.Windows.Forms.Label labelCampus;
        private System.Windows.Forms.Label labelCGPA;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
    }
}
