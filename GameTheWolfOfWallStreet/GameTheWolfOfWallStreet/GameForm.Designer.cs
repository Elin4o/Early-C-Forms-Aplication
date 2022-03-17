namespace GameTheWolfOfWallStreet
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblMoney = new System.Windows.Forms.Label();
            this.LblSpace = new System.Windows.Forms.Label();
            this.BtnToBuySell = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PbBuySell = new System.Windows.Forms.PictureBox();
            this.PbPicture = new System.Windows.Forms.PictureBox();
            this.TimerChanges = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbBuySell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Money:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Garage Space:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(284, 43);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(74, 20);
            this.LblName.TabIndex = 4;
            this.LblName.Text = ".............";
            // 
            // LblMoney
            // 
            this.LblMoney.AutoSize = true;
            this.LblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoney.Location = new System.Drawing.Point(252, 109);
            this.LblMoney.Name = "LblMoney";
            this.LblMoney.Size = new System.Drawing.Size(74, 20);
            this.LblMoney.TabIndex = 5;
            this.LblMoney.Text = ".............";
            // 
            // LblSpace
            // 
            this.LblSpace.AutoSize = true;
            this.LblSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSpace.Location = new System.Drawing.Point(319, 173);
            this.LblSpace.Name = "LblSpace";
            this.LblSpace.Size = new System.Drawing.Size(74, 20);
            this.LblSpace.TabIndex = 6;
            this.LblSpace.Text = ".............";
            // 
            // BtnToBuySell
            // 
            this.BtnToBuySell.Location = new System.Drawing.Point(638, 153);
            this.BtnToBuySell.Name = "BtnToBuySell";
            this.BtnToBuySell.Size = new System.Drawing.Size(150, 43);
            this.BtnToBuySell.TabIndex = 8;
            this.BtnToBuySell.Text = "Buy and Sell";
            this.BtnToBuySell.UseVisualStyleBackColor = true;
            this.BtnToBuySell.Click += new System.EventHandler(this.BtnToBuySell_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.changePictureToolStripMenuItem,
            this.highScoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveScoreToolStripMenuItem,
            this.resetScoreToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // saveScoreToolStripMenuItem
            // 
            this.saveScoreToolStripMenuItem.Name = "saveScoreToolStripMenuItem";
            this.saveScoreToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.saveScoreToolStripMenuItem.Text = "Save score.";
            this.saveScoreToolStripMenuItem.Click += new System.EventHandler(this.saveScoreToolStripMenuItem_Click);
            // 
            // resetScoreToolStripMenuItem
            // 
            this.resetScoreToolStripMenuItem.Name = "resetScoreToolStripMenuItem";
            this.resetScoreToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.resetScoreToolStripMenuItem.Text = "Reset score.";
            this.resetScoreToolStripMenuItem.Click += new System.EventHandler(this.resetScoreToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.exitGameToolStripMenuItem.Text = "Exit Game.";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // changePictureToolStripMenuItem
            // 
            this.changePictureToolStripMenuItem.Name = "changePictureToolStripMenuItem";
            this.changePictureToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.changePictureToolStripMenuItem.Text = "Change Picture";
            this.changePictureToolStripMenuItem.Click += new System.EventHandler(this.changePictureToolStripMenuItem_Click);
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.highScoresToolStripMenuItem.Text = "HighScores";
            this.highScoresToolStripMenuItem.Click += new System.EventHandler(this.highScoresToolStripMenuItem_Click);
            // 
            // PbBuySell
            // 
            this.PbBuySell.Image = ((System.Drawing.Image)(resources.GetObject("PbBuySell.Image")));
            this.PbBuySell.Location = new System.Drawing.Point(638, 43);
            this.PbBuySell.Name = "PbBuySell";
            this.PbBuySell.Size = new System.Drawing.Size(150, 104);
            this.PbBuySell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbBuySell.TabIndex = 7;
            this.PbBuySell.TabStop = false;
            // 
            // PbPicture
            // 
            this.PbPicture.Image = global::GameTheWolfOfWallStreet.Properties.Resources.blank_profile_picture_973460_640;
            this.PbPicture.Location = new System.Drawing.Point(12, 43);
            this.PbPicture.Name = "PbPicture";
            this.PbPicture.Size = new System.Drawing.Size(150, 150);
            this.PbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbPicture.TabIndex = 3;
            this.PbPicture.TabStop = false;
            // 
            // TimerChanges
            // 
            this.TimerChanges.Enabled = true;
            this.TimerChanges.Tick += new System.EventHandler(this.TimerChanges_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.BtnToBuySell);
            this.Controls.Add(this.PbBuySell);
            this.Controls.Add(this.LblSpace);
            this.Controls.Add(this.LblMoney);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.PbPicture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Wolf Of Wall Street";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbBuySell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PbPicture;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblMoney;
        private System.Windows.Forms.Label LblSpace;
        private System.Windows.Forms.PictureBox PbBuySell;
        private System.Windows.Forms.Button BtnToBuySell;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
        private System.Windows.Forms.Timer TimerChanges;
    }
}