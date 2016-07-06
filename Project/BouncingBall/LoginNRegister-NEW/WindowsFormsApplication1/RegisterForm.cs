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
    public partial class RegisterForm : Form
    {
        SHA256CryptoServiceProvider sha256;
        UTF8Encoding utf8;
        StringBuilder passwordSB;
        Thread registerThread;

        public RegisterForm()
        {
            InitializeComponent();

            sha256 = new SHA256CryptoServiceProvider();
            utf8 = new UTF8Encoding();
            passwordSB = new StringBuilder(64);
        }


        // Method for user registration

        public void RegisterUser()
        {
            try
            {
                using (var db = new sql369565Entities())
                {
                    string _username = usernameTextBox.Text;
                    string _password = passwordBox.Text;
                    string _repeatedPassword = repeatedPasswordBox.Text;
                    string _email = emailTextBox.Text;
                    string _firstName = firstNameTextBox.Text;
                    string _lastName = lastNameTextBox.Text;

                    if (String.IsNullOrEmpty(_username) || String.IsNullOrEmpty(_password) || String.IsNullOrEmpty(_email))
                    {
                        this.BeginInvoke((MethodInvoker)(() =>
                        {
                            this.errorLabel.Text = Constants.CREDENTIALS_REQUIRED_REGISTER;
                            this.errorLabel.Visible = true;
                            this.registerButton.Enabled = true;
                        }));
                        return;
                    }

                    // ^(\w+[-]*)+$
                    if (!(Regex.IsMatch(_username, @"^(\w+[-]*)+$", RegexOptions.IgnoreCase) && _username.Length >= 5 && _username.Length <= 64))
                    {
                        InfoToolTip.Show(InfoToolTip.GetToolTip(usernameTextBox), usernameTextBox, 5000);
                        registerButton.BeginInvoke((MethodInvoker)(() =>
                        {
                            this.registerButton.Enabled = true;
                        }));
                        return;
                    }

                    if (_password.Length < 5 || _password.Length > 64)
                    {
                        InfoToolTip.Show(InfoToolTip.GetToolTip(passwordBox), passwordBox, 5000);
                        registerButton.BeginInvoke((MethodInvoker)(() =>
                        {
                            this.registerButton.Enabled = true;
                        }));
                        return;
                    }

                    if (_password != _repeatedPassword)
                    {
                        this.BeginInvoke((MethodInvoker)(() =>
                        {
                            errorLabel.Text = Constants.PASSWORD_NOT_MATCH;
                            errorLabel.Visible = true;
                            this.registerButton.Enabled = true;
                        }));
                        return;
                    }

                    if (!Regex.IsMatch(_email,
                            @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                        RegexOptions.IgnoreCase) && _email.Length <= 320)
                    {
                        InfoToolTip.Show(InfoToolTip.GetToolTip(emailTextBox), emailTextBox, 5000);
                        registerButton.BeginInvoke((MethodInvoker)(() =>
                        {
                            this.registerButton.Enabled = true;
                        }));
                        return;
                    }

                    if (!Regex.IsMatch(_firstName, @"^(\w+[-]*)*$", RegexOptions.IgnoreCase))
                    {
                        InfoToolTip.Show(InfoToolTip.GetToolTip(firstNameTextBox), firstNameTextBox, 5000);
                        registerButton.BeginInvoke((MethodInvoker)(() =>
                        {
                            this.registerButton.Enabled = true;
                        }));
                        return;
                    }

                    if (!Regex.IsMatch(_lastName, @"^(\w+[-]*)*$", RegexOptions.IgnoreCase))
                    {
                        InfoToolTip.Show(InfoToolTip.GetToolTip(lastNameTextBox), lastNameTextBox, 5000);
                        registerButton.BeginInvoke((MethodInvoker)(() =>
                        {
                            this.registerButton.Enabled = true;
                        }));
                        return;
                    }

                    registerBufferPicBox.BeginInvoke((MethodInvoker)(() => { registerBufferPicBox.Visible = true; }));

                    passwordSB.Clear();
                    byte[] passBytes = sha256.ComputeHash(utf8.GetBytes(_password));

                    for (int i = 0; i < passBytes.Length; i++)
                    {
                        passwordSB.Append(passBytes[i].ToString("x2"));
                    }

                    List<user> existingUsers = db.users
                        .Where(u => u.Username == _username || u.Email == _email).ToList();

                    foreach (user u in existingUsers)
                    {
                        if (u.Username == _username)
                        {
                            this.BeginInvoke((MethodInvoker)(() =>
                            {
                                errorLabel.Text = Constants.CREDENTIALS_USERNAME_TAKEN;
                                errorLabel.Visible = true;
                                registerButton.Enabled = true;
                                registerBufferPicBox.Visible = false;
                            }));
                            return;
                        }

                        if (u.Email == _email)
                        {
                            this.BeginInvoke((MethodInvoker)(() =>
                             {
                                 errorLabel.Text = Constants.CREDENTIALS_EMAIL_TAKEN;
                                 errorLabel.Visible = true;
                                 registerButton.Enabled = true;
                                 registerBufferPicBox.Visible = false;
                             }));
                            return;
                        }
                    }


                    user temp = new user()
                    {
                        Username = _username,
                        Password = passwordSB.ToString(),
                        Email = _email,
                        FirstName = _firstName,
                        LastName = _lastName
                    };

                    db.users.Add(temp);
                    db.SaveChanges();

                    MessageBox.Show("Успешна регистрация!");
                    this.BeginInvoke((MethodInvoker)(() =>
                    {
                        this.Close();
                    }));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while trying to communicate with the database (check your internet connection) !");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (errorLabel.Visible)
            {
                errorLabel.Visible = false;
            }

            registerButton.Enabled = false;

            // Starting new thread to register user, so the UI won't freeze
            registerThread = new Thread(new ThreadStart(RegisterUser));
            registerThread.Start();

        }


        // Hover effects

        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            registerButton.BackgroundImage = Properties.Resources.Button3;
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackgroundImage = Properties.Resources.Button2;
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Abort registerThread if running
            if (registerThread != null && registerThread.IsAlive)
            {
                registerThread.Abort();
            }
        }
    }
}
