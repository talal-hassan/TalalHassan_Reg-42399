namespace Student_Profile
{
    partial class Error_Save
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
            this.btnDisposeSaveError = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisposeSaveError
            // 
            this.btnDisposeSaveError.BackColor = System.Drawing.Color.IndianRed;
            this.btnDisposeSaveError.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnDisposeSaveError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisposeSaveError.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisposeSaveError.ForeColor = System.Drawing.Color.White;
            this.btnDisposeSaveError.Location = new System.Drawing.Point(42, 24);
            this.btnDisposeSaveError.Name = "btnDisposeSaveError";
            this.btnDisposeSaveError.Size = new System.Drawing.Size(68, 23);
            this.btnDisposeSaveError.TabIndex = 2;
            this.btnDisposeSaveError.Text = "OK";
            this.btnDisposeSaveError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDisposeSaveError.UseVisualStyleBackColor = false;
            this.btnDisposeSaveError.Click += new System.EventHandler(this.btnDisposeSaveError_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(21, 2);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(112, 21);
            this.Error.TabIndex = 3;
            this.Error.Text = "Field is Empty";
            // 
            // Error_Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 49);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.btnDisposeSaveError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(838, 548);
            this.Name = "Error_Save";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Error_Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisposeSaveError;
        private System.Windows.Forms.Label Error;
    }
}