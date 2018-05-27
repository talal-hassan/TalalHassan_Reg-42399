namespace NEXI
{
    partial class WebSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebSearch));
            this.btnCloseWebSearch = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.TitleIconWeb = new System.Windows.Forms.Button();
            this.textSearchBar = new System.Windows.Forms.TextBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.webSearchShow = new System.Windows.Forms.WebBrowser();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.getResult = new System.Windows.Forms.ListBox();
            this.labelText = new System.Windows.Forms.Label();
            this.labelGetResults = new System.Windows.Forms.Label();
            this.btnCopyScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseWebSearch
            // 
            this.btnCloseWebSearch.BackColor = System.Drawing.Color.Red;
            this.btnCloseWebSearch.FlatAppearance.BorderSize = 0;
            this.btnCloseWebSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWebSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseWebSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseWebSearch.Location = new System.Drawing.Point(586, 5);
            this.btnCloseWebSearch.Name = "btnCloseWebSearch";
            this.btnCloseWebSearch.Size = new System.Drawing.Size(34, 27);
            this.btnCloseWebSearch.TabIndex = 1;
            this.btnCloseWebSearch.Text = "X";
            this.btnCloseWebSearch.UseVisualStyleBackColor = false;
            this.btnCloseWebSearch.Click += new System.EventHandler(this.btnCloseWebSearch_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Gold;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimize.Location = new System.Drawing.Point(546, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 27);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // TitleIconWeb
            // 
            this.TitleIconWeb.BackColor = System.Drawing.Color.Transparent;
            this.TitleIconWeb.FlatAppearance.BorderSize = 0;
            this.TitleIconWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleIconWeb.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleIconWeb.ForeColor = System.Drawing.Color.Gold;
            this.TitleIconWeb.Image = ((System.Drawing.Image)(resources.GetObject("TitleIconWeb.Image")));
            this.TitleIconWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleIconWeb.Location = new System.Drawing.Point(12, 0);
            this.TitleIconWeb.Name = "TitleIconWeb";
            this.TitleIconWeb.Size = new System.Drawing.Size(287, 53);
            this.TitleIconWeb.TabIndex = 4;
            this.TitleIconWeb.Text = "EXI Web Search";
            this.TitleIconWeb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleIconWeb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TitleIconWeb.UseVisualStyleBackColor = false;
            // 
            // textSearchBar
            // 
            this.textSearchBar.Location = new System.Drawing.Point(103, 59);
            this.textSearchBar.Multiline = true;
            this.textSearchBar.Name = "textSearchBar";
            this.textSearchBar.Size = new System.Drawing.Size(397, 28);
            this.textSearchBar.TabIndex = 5;
            // 
            // btnForward
            // 
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(72, 58);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(27, 28);
            this.btnForward.TabIndex = 6;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.FlatAppearance.BorderSize = 0;
            this.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackward.Location = new System.Drawing.Point(42, 58);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(27, 28);
            this.btnBackward.TabIndex = 7;
            this.btnBackward.Text = "<";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(506, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 28);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // webSearchShow
            // 
            this.webSearchShow.Location = new System.Drawing.Point(42, 103);
            this.webSearchShow.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSearchShow.Name = "webSearchShow";
            this.webSearchShow.Size = new System.Drawing.Size(561, 265);
            this.webSearchShow.TabIndex = 9;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(42, 374);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 28);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(145, 374);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(97, 28);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(248, 374);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(97, 28);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(42, 434);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(561, 50);
            this.text.TabIndex = 13;
            // 
            // getResult
            // 
            this.getResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.getResult.FormattingEnabled = true;
            this.getResult.Location = new System.Drawing.Point(42, 521);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(561, 93);
            this.getResult.TabIndex = 14;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(39, 413);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(55, 18);
            this.labelText.TabIndex = 15;
            this.labelText.Text = "TEXT";
            // 
            // labelGetResults
            // 
            this.labelGetResults.AutoSize = true;
            this.labelGetResults.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetResults.Location = new System.Drawing.Point(39, 500);
            this.labelGetResults.Name = "labelGetResults";
            this.labelGetResults.Size = new System.Drawing.Size(176, 18);
            this.labelGetResults.TabIndex = 16;
            this.labelGetResults.Text = "FETCHED RESULTS";
            // 
            // btnCopyScreen
            // 
            this.btnCopyScreen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCopyScreen.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCopyScreen.FlatAppearance.BorderSize = 0;
            this.btnCopyScreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyScreen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyScreen.ForeColor = System.Drawing.Color.White;
            this.btnCopyScreen.Location = new System.Drawing.Point(470, 374);
            this.btnCopyScreen.Name = "btnCopyScreen";
            this.btnCopyScreen.Size = new System.Drawing.Size(133, 28);
            this.btnCopyScreen.TabIndex = 17;
            this.btnCopyScreen.Text = "COPY SCREEN";
            this.btnCopyScreen.UseVisualStyleBackColor = false;
            this.btnCopyScreen.Click += new System.EventHandler(this.btnCopyScreen_Click);
            // 
            // WebSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 618);
            this.Controls.Add(this.btnCopyScreen);
            this.Controls.Add(this.labelGetResults);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.getResult);
            this.Controls.Add(this.text);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.webSearchShow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.textSearchBar);
            this.Controls.Add(this.TitleIconWeb);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnCloseWebSearch);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebSearch";
            this.Text = "NEXI Web Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseWebSearch;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button TitleIconWeb;
        private System.Windows.Forms.TextBox textSearchBar;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.WebBrowser webSearchShow;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.ListBox getResult;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelGetResults;
        private System.Windows.Forms.Button btnCopyScreen;
    }
}