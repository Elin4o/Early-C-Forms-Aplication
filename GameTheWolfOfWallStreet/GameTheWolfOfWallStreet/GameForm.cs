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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            TimerChanges.Enabled = true;
        }

        public static List<string> amountOfMoney = new List<string>();
        public static List<string> pictures = new List<string>();
        public static List<string> Shares = new List<string>();
        public static List<string> Pens = new List<string>();
       

        public static double money;
        public static double garagespace;
        public static double sumOfItems;
        public static double amountPen;
        public static double amountShare;      

        private const string filePath = "users.csv";
        private const string Score = "Score.csv";
        public static string pictureDir = "";

        private void GameForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.usernameFromForm != null)
            {
                LblName.Text = LoginForm.usernameFromForm;
            }

            PbPicture.Image = Properties.Resources.blank_profile_picture_973460_640;
            pictureDir = PbPicture.ImageLocation;

            if (money == 0)
            {
                money = 1000;
                amountPen = 0;
                amountShare = 0;
            }

            string text = File.ReadAllText(filePath);
            text = text.Replace(LoginForm.usernameFromForm + "," + LoginForm.passwordFromForm, LoginForm.usernameFromForm + "," + LoginForm.passwordFromForm + "," + money + "," + amountPen + "," + amountShare );
            File.WriteAllText(filePath, text);

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] userData = line.Split(',');
                    string name = userData[0];
                    string pass = userData[1];
                }
            }
        }

        private void changePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPEG files|*.jpg|PNG files|*.png|BMP files|*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(open.FileName);
                bmp.Save(open.SafeFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                File.Move(open.SafeFileName, "Pictures\\" + open.SafeFileName);

                PbPicture.ImageLocation = "Pictures\\" + open.SafeFileName;
                pictureDir = open.SafeFileName;
            }
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit without saving? You'll loose all the info/score. ", "Your exiting the game.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void BtnToBuySell_Click(object sender, EventArgs e)
        {
            BuySellForm form = new BuySellForm();
            form.ShowDialog();
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScoresForm formhigh = new HighScoresForm();
            DialogResult res = formhigh.ShowDialog();
        }    

        private void resetScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            money = 1000;
            garagespace = 15;
            amountPen = 0;
            amountShare = 0;
            sumOfItems = 0;

            PbPicture.Image = Properties.Resources.blank_profile_picture_973460_640;

            string text = File.ReadAllText(filePath);            
            text = text.Replace(LoginForm.usernameFromForm + "," + LoginForm.passwordFromForm + "," + money +  "," + amountPen + "," + amountShare, LoginForm.usernameFromForm + "," + LoginForm.passwordFromForm + "," + 1000 + "," + 0 + "," + 0);
            File.WriteAllText(filePath, text);

            string newScore = File.ReadAllText(Score);
            newScore = newScore.Replace(money + "," + LoginForm.usernameFromForm,1000 + "," + LoginForm.usernameFromForm);
            File.WriteAllText(Score, newScore);

        }

        private void saveScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            using (StreamWriter writer = new StreamWriter(Score,true))
            {
                writer.WriteLine(money + "," + LoginForm.usernameFromForm);
            }

            string text = File.ReadAllText(filePath);
            text = text.Replace(LoginForm.usernameFromForm + "," + LoginForm.passwordFromForm + "," + amountOfMoney + "," + amountPen + "," + amountShare, LoginForm.usernameFromForm + "," + LoginForm.passwordFromForm + "," + money + "," + "," + amountPen + "," + amountShare);
            File.WriteAllText(filePath, text);

        }

        private void TimerChanges_Tick(object sender, EventArgs e)
        {           
            garagespace = 15;
            LblMoney.Text = money.ToString();
            LblSpace.Text = sumOfItems + "/" + garagespace.ToString();
        }
    }
    
}
