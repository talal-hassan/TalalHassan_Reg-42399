namespace Student_Profile
{
    partial class PasswordChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password";
            // 
            // newPassword
            // 
            this.newPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPassword.Location = new System.Drawing.Point(184, 80);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(178, 20);
            this.newPassword.TabIndex = 1;
            this.newPassword.Click += new System.EventHandler(this.newPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirm Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPassword.Location = new System.Drawing.Point(184, 124);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(178, 20);
            this.confirmPassword.TabIndex = 3;
            this.confirmPassword.Click += new System.EventHandler(this.confirmPassword_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.IndianRed;
            this.btnChange.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(95, 191);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(203, 36);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Change Password";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 340);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "PasswordChange";
            this.Text = "PasswordChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Button btnChange;
    }
}