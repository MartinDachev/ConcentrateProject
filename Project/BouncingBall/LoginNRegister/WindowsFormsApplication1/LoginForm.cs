using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using DatabaseContent;

namespace Forms
{
    public partial class LoginForm : Form
    {
        SHA256CryptoServiceProvider sha256;
        UTF8Encoding utf8;
        StringBuilder passwordSB;

        public LoginForm()
        {
            InitializeComponent();

            sha256 = new SHA256CryptoServiceProvider();
            utf8 = new UTF8Encoding();
            passwordSB = new StringBuilder(64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            using (var db = new concentrate_testEntities4())
                {
                    var _username = usernameTextBox.Text;
                    var _password = passwordBox.Text;

                    if (String.IsNullOrEmpty(_username) || String.IsNullOrEmpty(_password))
                    {
                        LoginErrorMessage.Text = Constants.CREDENTIALS_REQUIRED_LOGIN;
                        LoginErrorMessage.Visible = true;
                        return;
                    }

                    if (LoginErrorMessage.Visible)
                    {
                        LoginErrorMessage.Visible = false;
                    }

                    // ^(\w+[-]*)+$
                    if (!(Regex.IsMatch(_username, @"^(\w+[-]*)+$", RegexOptions.IgnoreCase) && _username.Length >= 5))
                    {
                        InfoToolTip.Show(InfoToolTip.GetToolTip(usernameTextBox), usernameTextBox, 5000);
                        return;
                    }

                    passwordSB.Clear();
                    byte[] passBytes = sha256.ComputeHash(utf8.GetBytes(_password));

                    for (int i = 0; i < passBytes.Length; i++)
                    {
                        passwordSB.Append(passBytes[i].ToString("x2"));
                    }

                    _password = passwordSB.ToString();

                    user current = db.users
                        .Where(u => u.Username == _username && u.Password == _password)
                        .FirstOrDefault();

                    if (current == null)
                    {
                        LoginErrorMessage.Text = Constants.CREDENTIALS_WRONG;
                        LoginErrorMessage.Visible = true;
                        return;
                    }

                    DatabaseContent.DatabaseMain.currentUser = current;
                    this.Hide();
                    Program.InitializeMainForm();

                    MessageBox.Show("Successful login");
                }
            //}
            //catch(EntityException)
            //{
            //    MessageBox.Show("An error occured while trying to communicate with the database (check your internet connection) !");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.FormClosed += new FormClosedEventHandler(registerForm_FormClosed);
            this.Hide();
            registerForm.Show();
            return;
        }

        private void registerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void LoginErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.transparentbutton;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.rtransparentbutton2;
        }

        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            registerButton.BackgroundImage = Properties.Resources.transparentbutton;
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackgroundImage = Properties.Resources.rtransparentbutton2;
        }

        private void TrainButton_MouseEnter(object sender, EventArgs e)
        {
            TrainButton.BackgroundImage = Properties.Resources.transparentbutton;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.transparentbutton;
        }

        private void TrainButton_MouseLeave(object sender, EventArgs e)
        {
            TrainButton.BackgroundImage = Properties.Resources.rtransparentbutton2;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.rtransparentbutton2;
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.InitializeMainForm();
        }
    }
}
