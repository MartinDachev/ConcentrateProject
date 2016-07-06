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
    public partial class BulbsLB : Form
    {
        public BulbsLB()
        {
            InitializeComponent();
        }

        private void BulbsLB_Load(object sender, EventArgs e)
        {
            //try
            //{
            //using (var db = new DatabaseContent.concentrate_testEntities4())
            //    {
            //        var scores = db.bulbtestscores
            //            .OrderByDescending(s => s.ScoreRight)
            //            .Select(s => new
            //            {
            //                Name = db.users.Where(u => u.Id == s.User_Id).Select(u => new { Name = u.Username }).FirstOrDefault().Name,
            //                Right = s.ScoreRight,
            //                Wrong = s.ScoreWrong,
            //                Missed = s.ScoreMissed
            //            })
            //        .ToArray();

            //        var scoresItems = new ListViewItem[scores.Length];

            //        for (int i = 0; i < scores.Length; i++)
            //        {
            //            scoresItems[i] = new ListViewItem((i+1).ToString());
            //            scoresItems[i].SubItems.Add(scores[i].Right.ToString());
            //            scoresItems[i].SubItems.Add(scores[i].Wrong.ToString());
            //            scoresItems[i].SubItems.Add(scores[i].Missed.ToString());
            //            scoresItems[i].SubItems.Add(scores[i].Name);
            //        }

            //        listView1.Items.AddRange(scoresItems);
            //        MessageBox.Show(scores.ToString());
            //    }
            //}
            //catch (EntityException)
            //{
            //    MessageBox.Show("An error occured while trying to communicate with the database (check your internet connection) !");
            //}
        }
    }
}
