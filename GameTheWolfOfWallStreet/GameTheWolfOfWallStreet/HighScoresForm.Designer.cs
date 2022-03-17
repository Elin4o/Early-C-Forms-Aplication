namespace GameTheWolfOfWallStreet
{
    partial class HighScoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScoresForm));
            this.label1 = new System.Windows.Forms.Label();
            this.LblYourScore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LvHigh = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HighScores";
            // 
            // LblYourScore
            // 
            this.LblYourScore.AutoSize = true;
            this.LblYourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYourScore.Location = new System.Drawing.Point(265, 60);
            this.LblYourScore.Name = "LblYourScore";
            this.LblYourScore.Size = new System.Drawing.Size(132, 32);
            this.LblYourScore.TabIndex = 11;
            this.LblYourScore.Text = ".............";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Your Score";
            // 
            // LvHigh
            // 
            this.LvHigh.HideSelection = false;
            this.LvHigh.Location = new System.Drawing.Point(46, 104);
            this.LvHigh.Name = "LvHigh";
            this.LvHigh.Size = new System.Drawing.Size(351, 302);
            this.LvHigh.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.LvHigh.TabIndex = 14;
            this.LvHigh.UseCompatibleStateImageBehavior = false;
            // 
            // HighScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.LvHigh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblYourScore);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HighScoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScoresForm";
            this.Load += new System.EventHandler(this.HighScoresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblYourScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView LvHigh;
    }
}