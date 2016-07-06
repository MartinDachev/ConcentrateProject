using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static MainForm mainForm;
        public static LoginForm loginForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new LoginForm();
            Application.Run(loginForm);
        }

        public static void Login()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            loginForm.FormClosing += new FormClosingEventHandler(loginForm_FormClosing);
        }

        static void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }

        public static void Exit(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        public static void ShowMainForm()
        {
            mainForm.Show();
        }

        public static void InitializeMainForm()
        {
            Program.mainForm = new MainForm();
            Program.mainForm.FormClosed += new FormClosedEventHandler(Program.Exit);
            Program.mainForm.Show();
        }

    }
}
