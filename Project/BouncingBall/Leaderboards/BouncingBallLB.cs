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
    public partial class BouncingBallLB : Form
    {
        public BouncingBallLB()
        {
            InitializeComponent();
        }

        private void BouncingBallLB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'concentrate_testDataSet.bouncingballscores' table. You can move, or remove it, as needed.
            //this.bouncingballscoresTableAdapter.Fill(this.concentrate_testDataSet.bouncingballscores);
            if(!UpdateDatabase.LoggedState())
            {
                //try
                //{
                //    using (var db = new concentrate_testEntities4())
                //    {
                //        var scores = db.bouncingballscores
                //            .OrderByDescending(s => s.Score)
                //            .Select(s => new
                //            {
                //                Name = db.users.Where(u => u.Id == s.User_Id).Select(u => new { Name = u.Username }).FirstOrDefault().Name,
                //                Score = s.Score
                //            })
                //        .ToArray();

                //        var scoresItems = new ListViewItem[scores.Length];

                //        for (int i = 0; i < scores.Length; i++)
                //        {
                //            scoresItems[i] = new ListViewItem((i+1).ToString());
                //            scoresItems[i].SubItems.Add(scores[i].Score.ToString());
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
