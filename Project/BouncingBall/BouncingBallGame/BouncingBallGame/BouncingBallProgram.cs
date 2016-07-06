using System;
using System.Windows.Forms;
using DatabaseContent;

namespace BouncingBallGame
{
#if WINDOWS || XBOX
    public static class BouncingBallProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //public static user currentUser;

        [STAThread]
        public static void Main(string[] args)
        {
            StartBouncingBallGame();
        }

        public static void StartBouncingBallGame()
        {
            using (Game1 game = new Game1())
            {
                game.Run();
            }
        }
    }
#endif
}

