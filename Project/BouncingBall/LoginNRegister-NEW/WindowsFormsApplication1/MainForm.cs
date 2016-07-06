using BouncingBallGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsApplication1;
using MindTest2;
using Leaderboards;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Forms.Properties;
namespace Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Show appropriate controls depending on the logged state - logged or not
            if (DatabaseContent.UpdateDatabase.LoggedState())
            {
                this.usernameLabel.Text = DatabaseContent.DatabaseMain.currentUser.Username;
                this.loginButton.Visible = false;
                this.registerButton.Visible = false;
            }
            else
            {
                this.usernameLabel.Visible = false;
                this.label1.Visible = false;
                this.logoutButton.Visible = false;
            }
        }

        // Method for showing new form and subscribing to the Form Closed Even - to show 'this' form when occured
        public void ShowNewForm(Form form)
        {
            form.FormClosed += new FormClosedEventHandler(this.ShowForm);
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Starting new thread for the Bouncing Ball game, and joining it so that current thread will wait for the new one's completion
            Thread bouncingBallThread = new Thread(new ThreadStart(BouncingBallGame.BouncingBallProgram.StartBouncingBallGame));
            bouncingBallThread.Start();
            bouncingBallThread.Join();
            BulbForm bf = new BulbForm();
            this.Show();
        }


        // Methods for launching tests

        private void launchRctnTst3Btn_Click(object sender, EventArgs e)
        {
            ReactionTest3_Var2.ChooseForm rctnTestForm = new ReactionTest3_Var2.ChooseForm();
            ShowNewForm(rctnTestForm);
        }

        private void launchMndTst2Btn_Click(object sender, EventArgs e)
        {
            MindTestMainForm mindTst2Main = new MindTestMainForm();
            ShowNewForm(mindTst2Main);
        }

        private void launchBlbsBtn_Click(object sender, EventArgs e)
        {
            BulbForm bulbForm = new BulbForm();
            ShowNewForm(bulbForm);
        }

        private void mindTestLBrdButton_Click(object sender, EventArgs e)
        {
        }

        public void ShowForm(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void bcngBallLBrdButton_Click(object sender, EventArgs e)
        {
            GlobalLeaderboadsForm globalLeaderboards = new GlobalLeaderboadsForm();
            ShowNewForm(globalLeaderboards);
        }

        private void rctnTst3LdBrdBtn_Click(object sender, EventArgs e)
        {
            PersonalLeaderboardsForm personalLeaderboards = new PersonalLeaderboardsForm();
            ShowNewForm(personalLeaderboards);
        }

        private void launchMmryTstOrder_Click(object sender, EventArgs e)
        {
            MemoryTestOrderProject.MemoryTestOrder memoryTestOrder = new MemoryTestOrderProject.MemoryTestOrder();
            ShowNewForm(memoryTestOrder);
        }


        // Methods for hover effect

        private void launchBcngBallBtn_MouseEnter(object sender, EventArgs e)
        {
            launchBcngBallBtn.BackgroundImage = Resources.Button3;
        }

        private void launchBcngBallBtn_MouseLeave(object sender, EventArgs e)
        {
            launchBcngBallBtn.BackgroundImage = Resources.Button2;
        }

        private void launchRctnTst3Btn_MouseEnter(object sender, EventArgs e)
        {
            launchRctnTst3Btn.BackgroundImage = Resources.Button3;
        }

        private void launchRctnTst3Btn_MouseLeave(object sender, EventArgs e)
        {
            launchRctnTst3Btn.BackgroundImage = Resources.Button2;
        }

        private void launchMndTst2Btn_MouseEnter(object sender, EventArgs e)
        {
            launchMndTst2Btn.BackgroundImage = Resources.Button3;
        }

        private void launchMndTst2Btn_MouseLeave(object sender, EventArgs e)
        {
            launchMndTst2Btn.BackgroundImage = Resources.Button2;
        }

        private void launchBulbsBtn_MouseEnter(object sender, EventArgs e)
        {
            launchBulbsBtn.BackgroundImage = Resources.Button3;
        }

        private void launchBulbsBtn_MouseLeave(object sender, EventArgs e)
        {
            launchBulbsBtn.BackgroundImage = Resources.Button2;
        }

        private void bulbsLdBrdBrn_MouseEnter(object sender, EventArgs e)
        {
            globalLeaderboardsButton.BackgroundImage = Resources.Button3;
        }

        private void bulbsLdBrdBrn_MouseLeave(object sender, EventArgs e)
        {
            globalLeaderboardsButton.BackgroundImage = Resources.Button2;
        }

        private void launchMmryTstOrder_MouseEnter(object sender, EventArgs e)
        {
            launchMmryTstOrder.BackgroundImage = Resources.Button3;
        }

        private void launchMmryTstOrder_MouseLeave(object sender, EventArgs e)
        {
            launchMmryTstOrder.BackgroundImage = Resources.Button2;
        }

        private void MmryTstOrderLdrBrd_MouseEnter(object sender, EventArgs e)
        {
            personLeaderboardsButton.BackgroundImage = Resources.Button3;
        }

        private void MmryTstOrderLdrBrd_MouseLeave(object sender, EventArgs e)
        {
            personLeaderboardsButton.BackgroundImage = Resources.Button2;
        }

        private void Login_MouseEnter(object sender, EventArgs e)
        {
            logoutButton.BackgroundImage = Resources.Button3;
        }

        private void Login_MouseLeave(object sender, EventArgs e)
        {
            logoutButton.BackgroundImage = Resources.Button2;
        }

        private void Log_MouseEnter(object sender, EventArgs e)
        {
            loginButton.BackgroundImage = Resources.Button3;
        }
        

        // Methods for login, logout and register that are called when button is pressed

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerButton.BackgroundImage = Resources.rtransparentbutton2;
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            ShowNewForm(registerForm);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DatabaseContent.DatabaseMain.currentUser = null;
            this.usernameLabel.Visible = false;
            this.label1.Visible = false;
            this.logoutButton.Visible = false;
            this.loginButton.Visible = true;
            this.registerButton.Visible = true;
        }

        private void Log_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            ShowNewForm(loginForm);
        }


        // Methods for launching leaderboards

        private void PersonalLeaderboardsButton_Click(object sender, EventArgs e)
        {
            PersonalLeaderboardsForm personalLeaderboards = new PersonalLeaderboardsForm();
            ShowNewForm(personalLeaderboards);
        }

        private void GlobalLeaderboardsButton_Click(object sender, EventArgs e)
        {
            GlobalLeaderboadsForm globalLeaderboards = new GlobalLeaderboadsForm();
            ShowNewForm(globalLeaderboards);
        }


        // Hover effects

        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            registerButton.BackgroundImage = Resources.Button3;
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackgroundImage = Resources.Button2;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackgroundImage = Resources.Button2;
        }

    }
}
