namespace Speech_Recognition
{
    partial class InteractionScreen
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
            this.Nexi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nexi
            // 
            this.Nexi.ForeColor = System.Drawing.Color.White;
            this.Nexi.Location = new System.Drawing.Point(12, 9);
            this.Nexi.Name = "Nexi";
            this.Nexi.Size = new System.Drawing.Size(403, 75);
            this.Nexi.TabIndex = 0;
            this.Nexi.Text = "NexiResponse";
            // 
            // InteractionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.Nexi);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InteractionScreen";
            this.Size = new System.Drawing.Size(430, 95);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Nexi;
    }
}
