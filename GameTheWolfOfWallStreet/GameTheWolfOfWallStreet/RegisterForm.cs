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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        public static List<string> usernames = new List<string>();
        public static List<string> passwords = new List<string>();
        public static string username;
        public static string password;

        private const string filePath = "users.csv";       

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] userData = line.Split(',');

                        usernames.Add(userData[0]);
                       
                    }
                }
            }
            catch (IOException)
            {
                File.Create(filePath);
            }
        }

        private bool IsValid(string username)
        {
            if (usernames.Contains(username))
            {
                MessageBox.Show("Name already exists!");
                return false;
            }

            if (username == "")
            {
                MessageBox.Show("Invalid name!");
                return false;
            }

            return true;
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            username = TbRegName.Text.Trim();
            password = TbRegPass.Text;

            if (IsValid(username))
            {
                if (TbRegPass.Text == TbRegPassConfirm.Text)
                {
                    usernames.Add(username);
                    passwords.Add(password);
                    MessageBox.Show("Succesful registration!");
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(username + "," + password);
                    }

                    this.Hide();
                    LoginForm newLoginForm = new LoginForm();
                    newLoginForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect password!");
                }            
            }
        }

        private void LlblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
