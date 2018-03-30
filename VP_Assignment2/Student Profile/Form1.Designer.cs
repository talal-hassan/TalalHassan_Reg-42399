namespace Student_Profile
{
    partial class login_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_screen));
            this.header = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.field_password = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.field_user = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.selected = new System.Windows.Forms.TextBox();
            this.btnCloseLogin = new System.Windows.Forms.Button();
            this.btnMinimizeLogin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Cursor = System.Windows.Forms.Cursors.Hand;
            this.header.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.DarkGray;
            this.header.Location = new System.Drawing.Point(89, 26);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(207, 78);
            this.header.TabIndex = 0;
            this.header.Text = "Login";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.field_password,
            this.field_user});
            this.shapeContainer1.Size = new System.Drawing.Size(384, 488);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // field_password
            // 
            this.field_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.field_password.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.field_password.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.field_password.Location = new System.Drawing.Point(58, 228);
            this.field_password.Name = "field_password";
            this.field_password.Size = new System.Drawing.Size(270, 55);
            // 
            // field_user
            // 
            this.field_user.BackColor = System.Drawing.Color.WhiteSmoke;
            this.field_user.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.field_user.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.field_user.Location = new System.Drawing.Point(56, 148);
            this.field_user.Name = "field_user";
            this.field_user.Size = new System.Drawing.Size(270, 55);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.WhiteSmoke;
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.DarkGray;
            this.user.Location = new System.Drawing.Point(84, 163);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(212, 26);
            this.user.TabIndex = 2;
            this.user.Text = "username";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user.Click += new System.EventHandler(this.user_Click);
            this.user.Enter += new System.EventHandler(this.user_Enter);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.DarkGray;
            this.pass.Location = new System.Drawing.Point(85, 242);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(212, 26);
            this.pass.TabIndex = 3;
            this.pass.Text = "password";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            // 
            // selected
            // 
            this.selected.Location = new System.Drawing.Point(389, 113);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(100, 20);
            this.selected.TabIndex = 7;
            // 
            // btnCloseLogin
            // 
            this.btnCloseLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseLogin.FlatAppearance.BorderSize = 0;
            this.btnCloseLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCloseLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseLogin.Image")));
            this.btnCloseLogin.Location = new System.Drawing.Point(0, 0);
            this.btnCloseLogin.Name = "btnCloseLogin";
            this.btnCloseLogin.Size = new System.Drawing.Size(29, 27);
            this.btnCloseLogin.TabIndex = 13;
            this.btnCloseLogin.UseVisualStyleBackColor = true;
            this.btnCloseLogin.Click += new System.EventHandler(this.btnCloseLogin_Click);
            // 
            // btnMinimizeLogin
            // 
            this.btnMinimizeLogin.FlatAppearance.BorderSize = 0;
            this.btnMinimizeLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnMinimizeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeLogin.Image")));
            this.btnMinimizeLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizeLogin.Location = new System.Drawing.Point(32, 0);
            this.btnMinimizeLogin.Name = "btnMinimizeLogin";
            this.btnMinimizeLogin.Size = new System.Drawing.Size(29, 27);
            this.btnMinimizeLogin.TabIndex = 14;
            this.btnMinimizeLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimizeLogin.UseVisualStyleBackColor = true;
            this.btnMinimizeLogin.Click += new System.EventHandler(this.btnMinimizeLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(57, 342);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(270, 55);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(384, 488);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnMinimizeLogin);
            this.Controls.Add(this.btnCloseLogin);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.header);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape field_password;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape field_user;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox selected;
        private System.Windows.Forms.Button btnCloseLogin;
        private System.Windows.Forms.Button btnMinimizeLogin;
        private System.Windows.Forms.Button btnLogin;
    }
}

