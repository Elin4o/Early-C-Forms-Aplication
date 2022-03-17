namespace GameTheWolfOfWallStreet
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbRegName = new System.Windows.Forms.TextBox();
            this.TbRegPass = new System.Windows.Forms.TextBox();
            this.TbRegPassConfirm = new System.Windows.Forms.TextBox();
            this.BtnReg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LlblLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Wolf Of Wall Street";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create account.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password";
            // 
            // TbRegName
            // 
            this.TbRegName.Location = new System.Drawing.Point(216, 152);
            this.TbRegName.Name = "TbRegName";
            this.TbRegName.Size = new System.Drawing.Size(267, 22);
            this.TbRegName.TabIndex = 5;
            // 
            // TbRegPass
            // 
            this.TbRegPass.Location = new System.Drawing.Point(216, 203);
            this.TbRegPass.Name = "TbRegPass";
            this.TbRegPass.PasswordChar = '*';
            this.TbRegPass.Size = new System.Drawing.Size(267, 22);
            this.TbRegPass.TabIndex = 6;
            // 
            // TbRegPassConfirm
            // 
            this.TbRegPassConfirm.Location = new System.Drawing.Point(216, 253);
            this.TbRegPassConfirm.Name = "TbRegPassConfirm";
            this.TbRegPassConfirm.PasswordChar = '*';
            this.TbRegPassConfirm.Size = new System.Drawing.Size(267, 22);
            this.TbRegPassConfirm.TabIndex = 7;
            // 
            // BtnReg
            // 
            this.BtnReg.Location = new System.Drawing.Point(277, 290);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(114, 40);
            this.BtnReg.TabIndex = 8;
            this.BtnReg.Text = "Register";
            this.BtnReg.UseVisualStyleBackColor = true;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Already have an account?";
            // 
            // LlblLogin
            // 
            this.LlblLogin.AutoSize = true;
            this.LlblLogin.Location = new System.Drawing.Point(313, 359);
            this.LlblLogin.Name = "LlblLogin";
            this.LlblLogin.Size = new System.Drawing.Size(43, 17);
            this.LlblLogin.TabIndex = 10;
            this.LlblLogin.TabStop = true;
            this.LlblLogin.Text = "Login";
            this.LlblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblLogin_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(660, 395);
            this.Controls.Add(this.LlblLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.TbRegPassConfirm);
            this.Controls.Add(this.TbRegPass);
            this.Controls.Add(this.TbRegName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbRegName;
        private System.Windows.Forms.TextBox TbRegPass;
        private System.Windows.Forms.TextBox TbRegPassConfirm;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel LlblLogin;
    }
}

