namespace Student_Profile
{
    partial class SearchControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchStudent = new System.Windows.Forms.TextBox();
            this.SearchStudentBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchList = new System.Windows.Forms.ListView();
            this.Header1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(146, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(167, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(64, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search Student";
            // 
            // SearchStudent
            // 
            this.SearchStudent.BackColor = System.Drawing.Color.White;
            this.SearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchStudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SearchStudent.Location = new System.Drawing.Point(290, 153);
            this.SearchStudent.Name = "SearchStudent";
            this.SearchStudent.Size = new System.Drawing.Size(273, 16);
            this.SearchStudent.TabIndex = 4;
            this.SearchStudent.Text = "  type here";
            this.SearchStudent.Click += new System.EventHandler(this.SearchStudent_Click);
            // 
            // SearchStudentBy
            // 
            this.SearchStudentBy.BackColor = System.Drawing.Color.White;
            this.SearchStudentBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchStudentBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchStudentBy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStudentBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SearchStudentBy.FormattingEnabled = true;
            this.SearchStudentBy.Items.AddRange(new object[] {
            "Enrollment ID",
            "Name",
            "Semester"});
            this.SearchStudentBy.Location = new System.Drawing.Point(290, 96);
            this.SearchStudentBy.Name = "SearchStudentBy";
            this.SearchStudentBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchStudentBy.Size = new System.Drawing.Size(273, 25);
            this.SearchStudentBy.TabIndex = 5;
            this.SearchStudentBy.Text = "  -select-";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.IndianRed;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Location = new System.Drawing.Point(478, 192);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 35);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchList
            // 
            this.searchList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header1,
            this.Header2,
            this.Header3,
            this.Header4,
            this.Header5,
            this.Header6});
            this.searchList.Location = new System.Drawing.Point(72, 233);
            this.searchList.Name = "searchList";
            this.searchList.Size = new System.Drawing.Size(491, 130);
            this.searchList.TabIndex = 16;
            this.searchList.UseCompatibleStateImageBehavior = false;
            this.searchList.View = System.Windows.Forms.View.Details;
            // 
            // Header1
            // 
            this.Header1.Text = "Enrollment ID";
            this.Header1.Width = 76;
            // 
            // Header2
            // 
            this.Header2.Text = "Student Name";
            this.Header2.Width = 132;
            // 
            // Header3
            // 
            this.Header3.Text = "Semester";
            this.Header3.Width = 56;
            // 
            // Header4
            // 
            this.Header4.Text = "CGPA";
            this.Header4.Width = 41;
            // 
            // Header5
            // 
            this.Header5.Text = "Department";
            this.Header5.Width = 103;
            // 
            // Header6
            // 
            this.Header6.Text = "Campus";
            this.Header6.Width = 90;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchStudentBy);
            this.Controls.Add(this.SearchStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(600, 430);
            this.Load += new System.EventHandler(this.SearchControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchStudent;
        private System.Windows.Forms.ComboBox SearchStudentBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView searchList;
        private System.Windows.Forms.ColumnHeader Header1;
        private System.Windows.Forms.ColumnHeader Header2;
        private System.Windows.Forms.ColumnHeader Header3;
        private System.Windows.Forms.ColumnHeader Header4;
        private System.Windows.Forms.ColumnHeader Header5;
        private System.Windows.Forms.ColumnHeader Header6;
    }
}
