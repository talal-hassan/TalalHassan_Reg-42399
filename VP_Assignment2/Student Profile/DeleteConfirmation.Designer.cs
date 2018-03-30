namespace Student_Profile
{
    partial class DeleteConfirmation
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
            this.msgStudentDelete = new System.Windows.Forms.Label();
            this.btnDeleteConfirmation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msgStudentDelete
            // 
            this.msgStudentDelete.AutoSize = true;
            this.msgStudentDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgStudentDelete.Location = new System.Drawing.Point(21, -2);
            this.msgStudentDelete.Name = "msgStudentDelete";
            this.msgStudentDelete.Size = new System.Drawing.Size(127, 20);
            this.msgStudentDelete.TabIndex = 1;
            this.msgStudentDelete.Text = "Student Deleted";
            // 
            // btnDeleteConfirmation
            // 
            this.btnDeleteConfirmation.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteConfirmation.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnDeleteConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteConfirmation.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteConfirmation.ForeColor = System.Drawing.Color.White;
            this.btnDeleteConfirmation.Location = new System.Drawing.Point(41, 20);
            this.btnDeleteConfirmation.Name = "btnDeleteConfirmation";
            this.btnDeleteConfirmation.Size = new System.Drawing.Size(68, 23);
            this.btnDeleteConfirmation.TabIndex = 2;
            this.btnDeleteConfirmation.Text = "OK";
            this.btnDeleteConfirmation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteConfirmation.UseVisualStyleBackColor = false;
            this.btnDeleteConfirmation.Click += new System.EventHandler(this.btnDeleteConfirmation_Click);
            // 
            // DeleteConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 49);
            this.Controls.Add(this.btnDeleteConfirmation);
            this.Controls.Add(this.msgStudentDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(838, 555);
            this.Name = "DeleteConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DeleteConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgStudentDelete;
        private System.Windows.Forms.Button btnDeleteConfirmation;
    }
}