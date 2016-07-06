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
using Leaderboards;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Forms.Properties;
using MindTest2;

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
        }

        public void ShowNewForm(Form form)
        {
            form.FormClosed += new FormClosedEventHandler(this.ShowForm);
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread bouncingBallThread = new Thread(new ThreadStart(BouncingBallGame.BouncingBallProgram.StartBouncingBallGame));
            bouncingBallThread.Start();
            bouncingBallThread.Join();
            BulbForm bf = new BulbForm();
            this.Show();
        }

        private void launchRctnTst3Btn_Click(object sender, EventArgs e)
        {
            //RctnTst3Form rctnTst3Main = new RctnTst3Form();
            //ShowNewForm(rctnTst3Main);
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
            //ReactionTest3LB reactionTest3LB = new ReactionTest3LB();
            //ShowNewForm(reactionTest3LB);
            PersonalLeaderboardsForm personalLeaderboards = new PersonalLeaderboardsForm();
            ShowNewForm(personalLeaderboards);
        }

        private void bulbsLdBrdBrn_Click(object sender, EventArgs e)
        {
            BulbsLB bulbsLB = new BulbsLB();
            ShowNewForm(bulbsLB);
        }

        private void launchMmryTstOrder_Click(object sender, EventArgs e)
        {
            MemoryTestOrderProject.MemoryTestOrder memoryTestOrder = new MemoryTestOrderProject.MemoryTestOrder();
            ShowNewForm(memoryTestOrder);
        }

        private void launchBcngBallBtn_MouseEnter(object sender, EventArgs e)
        {
            launchBcngBallBtn.BackgroundImage = Resources.transparentbutton;
        }

        private void launchBcngBallBtn_MouseLeave(object sender, EventArgs e)
        {
            launchBcngBallBtn.BackgroundImage = Resources.rtransparentbutton2;
        }

        private void bcngBallLdBrdBtn_MouseEnter(object sender, EventArgs e)
        {
            bcngBallLdBrdBtn.BackgroundImage = Resources.transparentbutton;
        }

        private void bcngBallLdBrdBtn_MouseLeave(object sender, EventArgs e)
        {
            bcngBallLdBrdBtn.BackgroundImage = Resources.rtransparentbutton2;
        }

        private void launchRctnTst3Btn_MouseEnter(object sender, EventArgs e)
        {
            launchRctnTst3Btn.BackgroundImage = Resources.transparentbutton;
        }

        private void launchRctnTst3Btn_MouseLeave(object sender, EventArgs e)
        {
            launchRctnTst3Btn.BackgroundImage = Resources.rtransparentbutton2;
        }

        private void rctnTst3LdBrdBtn_MouseEnter(object sender, EventArgs e)
        {
            rctnTst3LdBrdBtn.BackgroundImage = Resources.transparentbutton;
        }

        private void rctnTst3LdBrdBtn_MouseLeave(object sender, EventArgs e)
        {
            rctnTst3LdBrdBtn.BackgroundImage = Resources.rtransparentbutton2;
        }

        private void launchMndTst2Btn_MouseEnter(object sender, EventArgs e)
        {
            launchMndTst2Btn.BackgroundImage = Resources.transparentbutton;
        }

        private void launchMndTst2Btn_MouseLeave(object sender, EventArgs e)
        {
            launchMndTst2Btn.BackgroundImage = Resources.rtransparentbutton2;
        }

        private void mindTestLdBrdBtn_MouseEnter(object sender, EventArgs e)
        {
            mindTestLdBrdBtn.BackgroundImage = Resources.transparentbutton;
        }

        private void mindTestLdBrdBtn_MouseLeave(object sender, EventArgs e)
        {
            mindTestLdBrdBtn.BackgroundImage = Resources.rtransparentbutton2;
        }

        private void launchBulbsBtn_MouseEnter(object sender, EventArgs e)
        {
            launchBulbsBtn.BackgroundImage = Resources.transparentbutton;
        }

        private void launchBulbsBtn_MouseLeave(object sender, EventArgs e)
        {
            launchBulbsBtn.BackgroundImage = Resources.rtransparentbutton2;
        }

        private void bulbsLdBrdBrn_MouseEnter(object sender, EventArgs e)
        {
            bulbsLdBrdBrn.BackgroundImage = Resources.transparentbutton;
        }

        private void bulbsLdBrdBrn_MouseLeave(object sender, EventArgs e)
        {
            bulbsLdBrdBrn.BackgroundImage = Resources.rtransparentbutton2;
        }

        private void launchMmryTstOrder_MouseEnter(object sender, EventArgs e)
        {
            launchMmryTstOrder.BackgroundImage = Resources.transparentbutton;
        }

        private void launchMmryTstOrder_MouseLeave(object sender, EventArgs e)
        {
            launchMmryTstOrder.BackgroundImage = Resources.rtransparentbutton2;
        }

        private void MmryTstOrderLdrBrd_MouseEnter(object sender, EventArgs e)
        {
            MmryTstOrderLdrBrd.BackgroundImage = Resources.transparentbutton;
        }

        private void MmryTstOrderLdrBrd_MouseLeave(object sender, EventArgs e)
        {
            MmryTstOrderLdrBrd.BackgroundImage = Resources.rtransparentbutton2;
        }

    }
}
