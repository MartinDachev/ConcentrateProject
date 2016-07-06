using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseContent
{
    public static class DatabaseMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary> 

        // Declaring the currentUser variable, which can be used to get the current logged user info
        public static user currentUser;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
