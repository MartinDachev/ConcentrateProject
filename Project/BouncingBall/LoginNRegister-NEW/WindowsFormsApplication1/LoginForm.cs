using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        Thread loginThread;
        Graphics g;
        public LoginForm()
        {
            InitializeComponent();

            sha256 = new SHA256CryptoServiceProvider();
            utf8 = new UTF8Encoding();
            passwordSB = new StringBuilder(64);
            g = this.CreateGraphics();
        }

        public void DrawRect(CustomButton button)
        {
            Brush b = new SolidBrush(Color.Red);
            Pen pen = new Pen(b, 10);
            Point p = base.Location;
            Rectangle rectangle = new Rectangle(button.Location.X + 4, button.Location.Y+4, button.Width + 5, button.Height + 5);
            g.DrawRectangle(pen, rectangle);
            pen.Dispose();
        }


        // Method for Login

        public void LoginUser()
        {
            try
            {
                using (var db = new sql369565Entities())
                {
                    string _username = usernameTextBox.Text;
                    string _password = passwordBox.Text;

                    if (String.IsNullOrEmpty(_username) || String.IsNullOrEmpty(_password))
                    {
                        LoginErrorMessage.BeginInvoke((MethodInvoker)(() =>
                        {
                            this.loggingBufferPicBox.Visible = false;
                            this.LoginErrorMessage.Text = Constants.CREDENTIALS_REQUIRED_LOGIN;
                            this.LoginErrorMessage.Visible = true;
                            TrainButton.Enabled = true;
                            button1.Enabled = true;
                        }));

                        return;
                    }

                    // ^(\w+[-]*)+$
                    if (!(Regex.IsMatch(_username, @"^(\w+[-]*)+$", RegexOptions.IgnoreCase) && _username.Length >= 5 && _username.Length <= 64))
                    {
                        this.BeginInvoke((MethodInvoker)(() =>
                        {
                            InfoToolTip.Show(InfoToolTip.GetToolTip(usernameTextBox), usernameTextBox, 5000);
                            TrainButton.Enabled = true;
                            button1.Enabled = true;
                        }));
                        return;
                    }

                    loggingBufferPicBox.BeginInvoke((MethodInvoker)(() => { loggingBufferPicBox.Visible = true; }));

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
                    db.Dispose();

                    if (current == null)
                    {
                        loggingBufferPicBox.BeginInvoke((MethodInvoker)(() =>
                        {
                            this.loggingBufferPicBox.Visible = false;
                        }));

                        LoginErrorMessage.BeginInvoke((MethodInvoker)(() =>
                        {
                            this.LoginErrorMessage.Text = Constants.CREDENTIALS_WRONG;
                            this.LoginErrorMessage.Visible = true;
                        }));

                        this.BeginInvoke((MethodInvoker)(() =>
                        {
                            TrainButton.Enabled = true;
                            button1.Enabled = true;
                        }));

                        return;
                    }

                    DatabaseContent.DatabaseMain.currentUser = current;

                    loggingBufferPicBox.BeginInvoke((MethodInvoker)(() =>
                    {
                        this.loggingBufferPicBox.Visible = false;
                        TrainButton.Enabled = true;
                        button1.Enabled = true;
                    }));

                    this.BeginInvoke((MethodInvoker)(() => { this.Hide(); Program.InitializeMainForm(); }));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while trying to communicate with the database (check your internet connection) !");
            }
            //catch (InvalidOperationException)
            {

            }
        }


        //Login Button click
        private void button1_Click(object sender, EventArgs e)
        {
            TrainButton.Enabled = false;
            button1.Enabled = false;

            if (LoginErrorMessage.Visible)
            {
                LoginErrorMessage.Visible = false;
            }

            // Staring new thread to login user, so that the UI won't freeze
            loginThread = new Thread(new ThreadStart(LoginUser));
            loginThread.Start();
        }

        //Register Button click
        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.FormClosed += new FormClosedEventHandler(registerForm_FormClosed);
            this.Hide();
            registerForm.Show();
            return;
        }

        // When registerForm closed, show 'this' form
        private void registerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.mainForm == null || !Program.mainForm.Visible)
            {
                this.Show();
            }
        }

        private void LoginErrorMessage_Click(object sender, EventArgs e)
        {

        }


        // Methods for hover effect

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.Button3;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.Button2;
        }

        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            registerButton.BackgroundImage = Properties.Resources.Button3;
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackgroundImage = Properties.Resources.Button2;
        }

        private void TrainButton_MouseEnter(object sender, EventArgs e)
        {
            TrainButton.BackgroundImage = Properties.Resources.Button3;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.Button3;
        }

        private void TrainButton_MouseLeave(object sender, EventArgs e)
        {
            TrainButton.BackgroundImage = Properties.Resources.Button2;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackgroundImage = Properties.Resources.Button2;
        }
        
        private void TrainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.InitializeMainForm();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Abort loginThread if running
            if (loginThread != null && loginThread.IsAlive)
            {
                loginThread.Abort();
            }
        }
    }
}
