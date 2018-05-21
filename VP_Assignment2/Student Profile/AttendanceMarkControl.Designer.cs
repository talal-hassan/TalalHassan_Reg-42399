namespace Student_Profile
{
    partial class AttendanceMarkControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMArkAttendance = new System.Windows.Forms.Button();
            this.fieldDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enrollment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fieldSemester = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mark Atendance";
            // 
            // btnMArkAttendance
            // 
            this.btnMArkAttendance.BackColor = System.Drawing.Color.IndianRed;
            this.btnMArkAttendance.FlatAppearance.BorderSize = 0;
            this.btnMArkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMArkAttendance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMArkAttendance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMArkAttendance.Location = new System.Drawing.Point(381, 153);
            this.btnMArkAttendance.Name = "btnMArkAttendance";
            this.btnMArkAttendance.Size = new System.Drawing.Size(85, 35);
            this.btnMArkAttendance.TabIndex = 21;
            this.btnMArkAttendance.Text = "Mark";
            this.btnMArkAttendance.UseVisualStyleBackColor = false;
            this.btnMArkAttendance.Click += new System.EventHandler(this.btnMArkAttendance_Click);
            // 
            // fieldDepartment
            // 
            this.fieldDepartment.BackColor = System.Drawing.Color.White;
            this.fieldDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fieldDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fieldDepartment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.fieldDepartment.FormattingEnabled = true;
            this.fieldDepartment.Items.AddRange(new object[] {
            "Electrical",
            "Computer",
            "Software"});
            this.fieldDepartment.Location = new System.Drawing.Point(228, 84);
            this.fieldDepartment.Name = "fieldDepartment";
            this.fieldDepartment.Size = new System.Drawing.Size(238, 25);
            this.fieldDepartment.TabIndex = 19;
            this.fieldDepartment.Text = "  -select-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 122);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Department";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.StudentName,
            this.Enrollment,
            this.Department,
            this.Attendance});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(13, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(586, 177);
            this.dataGridView1.TabIndex = 22;
            // 
            // Serial
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.Serial.DefaultCellStyle = dataGridViewCellStyle6;
            this.Serial.HeaderText = "S.No.";
            this.Serial.Name = "Serial";
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            // 
            // Enrollment
            // 
            this.Enrollment.HeaderText = "Enrol. No.";
            this.Enrollment.Name = "Enrollment";
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // Attendance
            // 
            this.Attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.Name = "Attendance";
            this.Attendance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Attendance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fieldSemester
            // 
            this.fieldSemester.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fieldSemester.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldSemester.Location = new System.Drawing.Point(228, 124);
            this.fieldSemester.Name = "fieldSemester";
            this.fieldSemester.Size = new System.Drawing.Size(238, 19);
            this.fieldSemester.TabIndex = 23;
            // 
            // AttendanceMarkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fieldSemester);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMArkAttendance);
            this.Controls.Add(this.fieldDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AttendanceMarkControl";
            this.Size = new System.Drawing.Size(614, 398);
            this.Load += new System.EventHandler(this.AttendanceMarkControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMArkAttendance;
        private System.Windows.Forms.ComboBox fieldDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enrollment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attendance;
        private System.Windows.Forms.TextBox fieldSemester;
    }
}
