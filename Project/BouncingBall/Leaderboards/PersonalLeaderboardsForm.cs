using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DatabaseContent;

namespace Leaderboards
{
    public partial class PersonalLeaderboardsForm : Form
    {
        public PersonalLeaderboardsForm()
        {
            InitializeComponent();
            this.subTabControl.GotFocus += new System.EventHandler(this.subTabControl_GotFocus);
            this.mainTabControl.GotFocus += new EventHandler(this.mainTabControl_GotFocus);
        }


        // Methods for loading the leaderboards for each game

        private void LoadBouncingBallLeaderboard()
        {
            //try
            //{
            //    using (var db = new sql369565Entities())
            //    {
            //        var scores = db.bouncingballscores
            //            .Where(u => u.User_Id == DatabaseContent.DatabaseMain.currentUser.Id)
            //            .OrderByDescending(s => s.Score)
            //            .Select(s => new
            //            {
            //                Name = DatabaseContent.DatabaseMain.currentUser.Username,
            //                Score = s.Score
            //            })
            //            .ToArray();

            //        var scoresItems = new ListViewItem[scores.Length];

            //        bool lightColor = false;

            //        for (int i = 0; i < scores.Length; i++)
            //        {
            //            scoresItems[i] = new ListViewItem((i+1).ToString() + ".");
            //            scoresItems[i].SubItems.Add(scores[i].Score.ToString());
            //            scoresItems[i].SubItems.Add(scores[i].Name);
            //            if (!lightColor)
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(67, 133, 208);
            //            }
            //            else
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(92, 151, 216);
            //            }
            //            scoresItems[i].ForeColor = Color.FromArgb(226, 219, 230);
            //            lightColor = !lightColor;
            //        }

            //        bouncingBallListView.Items.Clear();
            //        bouncingBallListView.Items.AddRange(scoresItems);
            //    }
            //}
            //catch (EntityException)
            //{
            //}
        }

        public void LoadBulbsLeaderboards()
        {
        //    try
        //    {
        //        using (var db = new DatabaseContent.sql369565Entities())
        //        {
        //            var scores = db.bulbtestscores
        //                .Where(u => u.User_Id == DatabaseContent.DatabaseMain.currentUser.Id)
        //                .OrderByDescending(s => s.ScoreRight)
        //                .Select(s => new
        //                {
        //                    Name = DatabaseContent.DatabaseMain.currentUser.Username,
        //                    Right = s.ScoreRight,
        //                    Wrong = s.ScoreWrong,
        //                    Missed = s.ScoreMissed
        //                })
        //                .ToArray();

        //            var scoresItems = new ListViewItem[scores.Length];

        //            bool lightColor = false;

        //            for (int i = 0; i < scores.Length; i++)
        //            {
        //                scoresItems[i] = new ListViewItem((i + 1).ToString() + ".");
        //                scoresItems[i].SubItems.Add(scores[i].Right.ToString());
        //                scoresItems[i].SubItems.Add(scores[i].Wrong.ToString());
        //                scoresItems[i].SubItems.Add(scores[i].Missed.ToString());
        //                scoresItems[i].SubItems.Add(scores[i].Name);
        //                if (!lightColor)
        //                {
        //                    scoresItems[i].BackColor = Color.FromArgb(67, 133, 208);
        //                }
        //                else
        //                {
        //                    scoresItems[i].BackColor = Color.FromArgb(92, 151, 216);
        //                }
        //                scoresItems[i].ForeColor = Color.FromArgb(226, 219, 230);
        //                lightColor = !lightColor;
        //            }

        //            bulbsListView.Items.Clear();
        //            bulbsListView.Items.AddRange(scoresItems);
        //        }
        //    }
        //    catch (EntityException)
        //    {
        //    }
        }

        public void LoadReactionTest3Leaderboards()
        {
            //try
            //{
            //    using (var db = new sql369565Entities())
            //    {
            //        var scores = db.reactiontestscores
            //            .Where(u => u.User_Id == DatabaseContent.DatabaseMain.currentUser.Id)
            //            .OrderByDescending(s => s.Score)
            //            .Select(s => new
            //            {
            //                Name = DatabaseContent.DatabaseMain.currentUser.Username,
            //                Score = s.Score
            //            })
            //            .ToArray();

            //        var scoresItems = new ListViewItem[scores.Length];

            //        bool lightColor = false;

            //        for (int i = 0; i < scores.Length; i++)
            //        {
            //            scoresItems[i] = new ListViewItem((i + 1).ToString() + ".");
            //            scoresItems[i].SubItems.Add(scores[i].Score.ToString());
            //            scoresItems[i].SubItems.Add(scores[i].Name);
            //            if (!lightColor)
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(67, 133, 208);
            //            }
            //            else
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(92, 151, 216);
            //            }
            //            scoresItems[i].ForeColor = Color.FromArgb(226, 219, 230);
            //            lightColor = !lightColor;
            //        }

            //        rctTest3ListView.Items.Clear();
            //        rctTest3ListView.Items.AddRange(scoresItems);
            //    }
            //}
            //catch (EntityException)
            //{
            //}
        }

        public void LoadMemoryTestOrderLeaderboards()
        {
        //    try
        //    {
        //        using (var db = new sql369565Entities())
        //        {
        //            var scores = db.memorytestorderscores
        //               .Where(u => u.User_Id == DatabaseContent.DatabaseMain.currentUser.Id)
        //               .OrderByDescending(s => s.Score)
        //               .Select(s => new
        //               {
        //                   Name = DatabaseContent.DatabaseMain.currentUser.Username,
        //                   Score = s.Score
        //               })
        //               .ToArray();


        //            var scoresItems = new ListViewItem[scores.Length];

        //            bool lightColor = false;

        //            for (int i = 0; i < scores.Length; i++)
        //            {
        //                scoresItems[i] = new ListViewItem((i + 1).ToString() + ".");
        //                scoresItems[i].SubItems.Add(scores[i].Score.ToString());
        //                scoresItems[i].SubItems.Add(scores[i].Name);
        //                if (!lightColor)
        //                {
        //                    scoresItems[i].BackColor = Color.FromArgb(67, 133, 208);
        //                }
        //                else
        //                {
        //                    scoresItems[i].BackColor = Color.FromArgb(92, 151, 216);
        //                }
        //                scoresItems[i].ForeColor = Color.FromArgb(226, 219, 230);
        //                lightColor = !lightColor;
        //            }

        //            memTestOrderListView.Items.Clear();
        //            memTestOrderListView.Items.AddRange(scoresItems);
        //        }
        //    }
        //    catch (EntityException)
        //    {
        //    }

        }
        public void LoadMindTest2EasyLeaderboards()
        {
            //try
            //{
            //    using (var db = new sql369565Entities())
            //    {
            //        var scores = db.mindtestscoreseasies
            //           .Where(u => u.User_Id == DatabaseContent.DatabaseMain.currentUser.Id)
            //           .OrderByDescending(s => s.Score)
            //           .Select(s => new
            //           {
            //               Name = DatabaseContent.DatabaseMain.currentUser.Username,
            //               Score = s.Score
            //           })
            //           .ToArray();

            //        var scoresItems = new ListViewItem[scores.Length];

            //        bool lightColor = false;

            //        for (int i = 0; i < scores.Length; i++)
            //        {
            //            scoresItems[i] = new ListViewItem((i + 1).ToString() + ".");
            //            scoresItems[i].SubItems.Add(scores[i].Score.ToString());
            //            scoresItems[i].SubItems.Add(scores[i].Name);
            //            if (!lightColor)
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(67, 133, 208);
            //            }
            //            else
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(92, 151, 216);
            //            }
            //            scoresItems[i].ForeColor = Color.FromArgb(226, 219, 230);
            //            lightColor = !lightColor;
            //        }

            //        if (memTestOrderEasyListView.Items.Count > 0)
            //        {
            //            memTestOrderEasyListView.Items.Clear();
            //        }
            //        memTestOrderEasyListView.Items.AddRange(scoresItems);
            //    }
            //}
            //catch (EntityException)
            //{
            //}
        }

        public void LoadMindTest2MediumLeaderboards()
        {
            //try
            //{
            //    using (var db = new sql369565Entities())
            //    {
            //        var scores = db.mindtestscoresmediums
            //            .Where(u => u.User_Id == DatabaseContent.DatabaseMain.currentUser.Id)
            //            .OrderByDescending(s => s.Score)
            //            .Select(s => new
            //            {
            //                Name = DatabaseContent.DatabaseMain.currentUser.Username,
            //                Score = s.Score
            //            })
            //            .ToArray();

            //        var scoresItems = new ListViewItem[scores.Length];

            //        bool lightColor = false;

            //        for (int i = 0; i < scores.Length; i++)
            //        {
            //            scoresItems[i] = new ListViewItem((i + 1).ToString() + ".");
            //            scoresItems[i].SubItems.Add(scores[i].Score.ToString());
            //            scoresItems[i].SubItems.Add(scores[i].Name);
                        
            //            if (!lightColor)
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(67, 133, 208);
            //            }
            //            else
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(92, 151, 216);
            //            }
            //            scoresItems[i].ForeColor = Color.FromArgb(226, 219, 230);
            //            lightColor = !lightColor;
            //        }

            //        memTestOrderMediumListView.Items.Clear();
            //        memTestOrderMediumListView.Items.AddRange(scoresItems);
            //    }
            //}
            //catch (EntityException)
            //{
            //}
        }

        public void LoadMindTest2HardLeaderboards()
        {
            //try
            //{
            //    using (var db = new sql369565Entities())
            //    { 
            //        var scores = db.mindtestscoreshards
            //           .Where(u => u.User_Id == DatabaseContent.DatabaseMain.currentUser.Id)
            //           .OrderByDescending(s => s.Score)
            //           .Select(s => new
            //           {
            //               Name = DatabaseContent.DatabaseMain.currentUser.Username,
            //               Score = s.Score
            //           })
            //           .ToArray();

            //        var scoresItems = new ListViewItem[scores.Length];

            //        bool lightColor = false;

            //        for (int i = 0; i < scores.Length; i++)
            //        {
            //            scoresItems[i] = new ListViewItem((i + 1).ToString() + ".");
            //            scoresItems[i].SubItems.Add(scores[i].Score.ToString());
            //            scoresItems[i].SubItems.Add(scores[i].Name);

            //            if (!lightColor)
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(67, 133, 208);
            //            }
            //            else
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(92, 151, 216);
            //            }
            //            scoresItems[i].ForeColor = Color.FromArgb(226, 219, 230);
            //            lightColor = !lightColor;
            //        }

            //        memTestOrderHardListView.Items.Clear();
            //        memTestOrderHardListView.Items.AddRange(scoresItems);
            //    }
            //}
            //catch (EntityException)
            //{
            //}
        }

        public void LoadMindTest2VeryHardLeaderboards()
        {
            //try
            //{
            //    using (var db = new sql369565Entities())
            //    {
            //        var scores = db.mindtestscoresveryhards
            //           .Where(u => u.User_Id == DatabaseContent.DatabaseMain.currentUser.Id)
            //           .OrderByDescending(s => s.Score)
            //           .Select(s => new
            //           {
            //               Name = DatabaseContent.DatabaseMain.currentUser.Username,
            //               Score = s.Score
            //           })
            //           .ToArray();

            //        var scoresItems = new ListViewItem[scores.Length];

            //        bool lightColor = false;

            //        for (int i = 0; i < scores.Length; i++)
            //        {
            //            scoresItems[i] = new ListViewItem((i + 1).ToString() + ".");
            //            scoresItems[i].SubItems.Add(scores[i].Score.ToString());
            //            scoresItems[i].SubItems.Add(scores[i].Name);

            //            if (!lightColor)
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(67, 133, 208);
            //            }
            //            else
            //            {
            //                scoresItems[i].BackColor = Color.FromArgb(92, 151, 216);
            //            }
            //            scoresItems[i].ForeColor = Color.FromArgb(226, 219, 230);
            //            lightColor = !lightColor;
            //        }

            //        memTestOrderVeryHardListView.Items.Clear();
            //        memTestOrderVeryHardListView.Items.AddRange(scoresItems);
            //    }
            //}
            //catch (EntityException)
            //{
            //}
        }

        
        //When tab changed, load the new leaderboard

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (DatabaseContent.UpdateDatabase.LoggedState())
            //{
            //    if (mainTabControl.SelectedTab == tabPage1)
            //    {
            //        LoadBouncingBallLeaderboard();
            //    }
            //    else if (mainTabControl.SelectedTab == tabPage2)
            //    {
            //        LoadMemoryTestOrderLeaderboards();
            //    }
            //    else if (mainTabControl.SelectedTab == tabPage3)
            //    {
            //        LoadReactionTest3Leaderboards();
            //    }
            //    else if (mainTabControl.SelectedTab == tabPage4)
            //    {
            //        LoadBulbsLeaderboards();
            //    }
            //    else if (mainTabControl.SelectedTab == tabPage5)
            //    {
            //        LoadMindTest2EasyLeaderboards();
            //    }
            //}
        }

        private void subTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (DatabaseContent.UpdateDatabase.LoggedState())
            //{
            //    if (subTabControl.SelectedTab == tabPage6)
            //    {
            //        LoadMindTest2EasyLeaderboards();
            //    }
            //    else if (subTabControl.SelectedTab == tabPage7)
            //    {
            //        LoadMindTest2MediumLeaderboards();
            //    }
            //    else if (subTabControl.SelectedTab == tabPage8)
            //    {
            //        LoadMindTest2HardLeaderboards();
            //    }
            //    else if (subTabControl.SelectedTab == tabPage9)
            //    {
            //        LoadMindTest2VeryHardLeaderboards();
            //    }
            //}
        }
        

        // Methods for showing the leaderboards when first tabs get focus on load and click 

        private void subTabControl_GotFocus(object sender, EventArgs e)
        {
            //if (DatabaseContent.UpdateDatabase.LoggedState())
            //{
            //    LoadMindTest2EasyLeaderboards();
            //}
        }

        private void mainTabControl_GotFocus(object sender, EventArgs e)
        {
            //if (DatabaseContent.UpdateDatabase.LoggedState())
            //{
            //    LoadBouncingBallLeaderboard();
            //}
        }

    }
}
