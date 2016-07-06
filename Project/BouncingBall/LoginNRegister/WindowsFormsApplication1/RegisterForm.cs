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
    public partial class RegisterForm : Form
    {
        SHA256CryptoServiceProvider sha256;
        UTF8Encoding utf8;
        StringBuilder passwordSB;

        public RegisterForm()
        {
            InitializeComponent();

            sha256 = new SHA256CryptoServiceProvider();
            utf8 = new UTF8Encoding();
            passwordSB = new StringBuilder(64);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DatabaseContent.concentrate_testEntities4())
                {
                    string _username = usernameTextBox.Text;
                    string _password = passwordBox.Text;
                    string _repeatedPassword = repeatedPasswordBox.Text;
                    string _email = emailTextBox.Text;
                    string _firstName = firstNameTextBox.Text;
                    string _lastName = lastNameTextBox.Text;

                    if (String.IsNullOrEmpty(_username) || String.IsNullOrEmpty(_password) || String.IsNullOrEmpty(_email))
                    {
                        errorLabel.Text = Constants.CREDENTIALS_REQUIRED_REGISTER;
                        errorLabel.Visible = true;
                        return;
                    }

                    // ^(\w+[-]*)+$
                    if (!(Regex.IsMatch(_username, @"^(\w+[-]*)+$", RegexOptions.IgnoreCase) && _username.Length >= 5))
                    {
                        InfoToolTip.Show(InfoToolTip.GetToolTip(usernameTextBox), usernameTextBox, 5000);
                        return;
                    }

                    if(_password.Length < 5)
                    {
                        InfoToolTip.Show(InfoToolTip.GetToolTip(passwordBox), passwordBox, 5000);
                        return;
                    }

                    if (_password != _repeatedPassword)
                    {
                        errorLabel.Text = Constants.PASSWORD_NOT_MATCH;
                        errorLabel.Visible = true;
                        return;
                    }

                    if (!Regex.IsMatch(_email,
                            @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                            RegexOptions.IgnoreCase))
                    {
                        InfoToolTip.Show(InfoToolTip.GetToolTip(emailTextBox), emailTextBox, 5000);
                        return;
                    }

                    if (!Regex.IsMatch(_firstName, @"^(\w+[-]*)*$", RegexOptions.IgnoreCase))
                    {
                        InfoToolTip.Show(InfoToolTip.GetToolTip(firstNameTextBox), firstNameTextBox, 5000);
                        return;
                    }

                    if (!Regex.IsMatch(_lastName, @"^(\w+[-]*)*$", RegexOptions.IgnoreCase))
                    {
                        InfoToolTip.Show(InfoToolTip.GetToolTip(lastNameTextBox), lastNameTextBox, 5000);
                        return;
                    }

                    passwordSB.Clear();
                    byte[] passBytes = sha256.ComputeHash(utf8.GetBytes(_password));

                    for (int i = 0; i < passBytes.Length; i++)
                    {
                        passwordSB.Append(passBytes[i].ToString("x2"));
                    }

                    List<user>existingUsers = db.users
                        .Where(u => u.Username == _username || u.Email == _email).ToList();

                    foreach (user u in existingUsers)
                    {
                        if (u.Username == _username)
                        {
                            errorLabel.Text = Constants.CREDENTIALS_USERNAME_TAKEN;
                            errorLabel.Visible = true;
                            return;
                        }

                        if (u.Email == _email)
                        {
                            errorLabel.Text = Constants.CREDENTIALS_EMAIL_TAKEN;
                            errorLabel.Visible = true;
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

                    MessageBox.Show("Successful Registration");
                    this.Close();
                }
            }
            catch (EntityException)
            {
                MessageBox.Show("An error occured while trying to communicate with the database (check your internet connection) !");
            }
        }

        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            registerButton.BackgroundImage = Properties.Resources.transparentbutton;
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackgroundImage = Properties.Resources.rtransparentbutton2;
        }
    }
}
