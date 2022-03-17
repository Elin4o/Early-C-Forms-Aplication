using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameTheWolfOfWallStreet
{
    public partial class HighScoresForm : Form
    {
        public HighScoresForm()
        {
            InitializeComponent();
        }

        private const string Score = "Score.csv";

        private void HighScoresForm_Load(object sender, EventArgs e)
        {

            LblYourScore.Text = LoginForm.usernameFromForm + " : " + GameForm.money;

            
                LvHigh.Visible = true;
                StreamReader sr = new StreamReader(Score);
                string currentLine;
                while ((currentLine = sr.ReadLine()) != null)
                {
                    LvHigh.Items.Add(currentLine);
                }
                LvHigh.View = View.List;

            sr.Close();
        }
    }
}
