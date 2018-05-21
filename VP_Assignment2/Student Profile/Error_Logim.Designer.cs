namespace Student_Profile
{
    partial class Error_Login
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
            this.msgLoginError = new System.Windows.Forms.Label();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msgLoginError
            // 
            this.msgLoginError.AutoSize = true;
            this.msgLoginError.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLoginError.Location = new System.Drawing.Point(9, 21);
            this.msgLoginError.Name = "msgLoginError";
            this.msgLoginError.Size = new System.Drawing.Size(266, 80);
            this.msgLoginError.TabIndex = 2;
            this.msgLoginError.Text = "Please try the following credientials\r\n\r\nusername: admin\r\npassword: admin";
            this.msgLoginError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.BackColor = System.Drawing.Color.IndianRed;
            this.btnConfirmation.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmation.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmation.ForeColor = System.Drawing.Color.White;
            this.btnConfirmation.Location = new System.Drawing.Point(36, 139);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(203, 44);
            this.btnConfirmation.TabIndex = 3;
            this.btnConfirmation.Text = "OK";
            this.btnConfirmation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirmation.UseVisualStyleBackColor = false;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // Error_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.btnConfirmation);
            this.Controls.Add(this.msgLoginError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Error_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN ERROR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgLoginError;
        private System.Windows.Forms.Button btnConfirmation;
    }
}