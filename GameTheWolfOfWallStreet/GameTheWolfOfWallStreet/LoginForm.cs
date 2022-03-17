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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        List<string> usernames = new List<string>();
        List<string> passwords = new List<string>();
        private const string filePath = "users.csv";
        public static string usernameFromForm = "";
        public static string passwordFromForm = "";

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TbLogName.Text;
            string password = TbLogPass.Text;

            bool isFound = false;
            for (int i = 0; i < usernames.Count; i++)
            {
                if (usernames[i] == username && passwords[i] == password)
                {
                    isFound = true;
                }
            }

            if (isFound == true)
            {
                MessageBox.Show("Succesful login!");
                usernameFromForm = TbLogName.Text;
                passwordFromForm = TbLogPass.Text;
                this.Hide();
                GameForm newGameForm = new GameForm();
                newGameForm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Incorrect data!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] userData = line.Split(',');

                    usernames.Add(userData[0]);
                    passwords.Add(userData[1]);
                   

                }
            }
        }

        private void LlblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}

