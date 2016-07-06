using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseContent
{
    public static class UpdateDatabase
    {
        // Check if Logged
        public static bool LoggedState()
        {
            if (DatabaseContent.DatabaseMain.currentUser != null)
            {
                return true;
            }

            return false;
        }


        // Methods for adding gamescores

        public static void AddBulbsTestScore(int scoreRight, int scoreWrong, int scoreMissed)
        {
            if (LoggedState())
            {
                using (var db = new DatabaseContent.sql369565Entities())
                {

                    var scoreObj = new DatabaseContent.bulbtestscore()
                    {
                        User_Id = DatabaseContent.DatabaseMain.currentUser.Id,
                        ScoreRight = scoreRight,
                        ScoreWrong = scoreWrong,
                        ScoreMissed = scoreMissed
                    };

                    db.bulbtestscores.Add(scoreObj);
                    db.SaveChanges();
                }
            }
        }

        public static void AddReactionTest3Score(int score)
        {
            if (LoggedState())
            {
                using (var db = new DatabaseContent.sql369565Entities())
                {
                    var scoreObj = new DatabaseContent.reactiontestscore()
                    {
                        User_Id = DatabaseContent.DatabaseMain.currentUser.Id,
                        Score = score
                    };

                    db.reactiontestscores.Add(scoreObj);
                    db.SaveChanges();
                }
            }
        }

        public static void AddBouncingBallScore(int score)
        {
            if (LoggedState())
            {
                using (var db = new sql369565Entities())
                {
                    var scoreObj = new bouncingballscore()
                    {
                        User_Id = DatabaseContent.DatabaseMain.currentUser.Id,
                        Score = score
                    };

                    db.bouncingballscores.Add(scoreObj);
                    db.SaveChanges();
                }
            }
        }

        public static void AddMindTest2EasyScore(int score)
        {
            if (LoggedState())
            {
                using (var db = new sql369565Entities())
                {
                    var scoreObj = new mindtestscoreseasy()
                    {
                        User_Id = DatabaseContent.DatabaseMain.currentUser.Id,
                        Score = score
                    };

                    db.mindtestscoreseasies.Add(scoreObj);
                    db.SaveChanges();
                }
            }
        }

        public static void AddMindTest2MediumScore(int score)
        {
            if (LoggedState())
            {
                using (var db = new sql369565Entities())
                {
                    var scoreObj = new mindtestscoresmedium()
                    {
                        User_Id = DatabaseContent.DatabaseMain.currentUser.Id,
                        Score = score
                    };

                    db.mindtestscoresmediums.Add(scoreObj);
                    db.SaveChanges();
                }
            }
        }

        public static void AddMindTest2HardScore(int score)
        {
            if (LoggedState())
            {
                using (var db = new sql369565Entities())
                {
                    var scoreObj = new mindtestscoreshard()
                    {
                        User_Id = DatabaseContent.DatabaseMain.currentUser.Id,
                        Score = score
                    };

                    db.mindtestscoreshards.Add(scoreObj);
                    db.SaveChanges();
                }
            }
        }

        public static void AddMindTest2VeryHardScore(int score)
        {
            if (LoggedState())
            {
                using (var db = new sql369565Entities())
                {
                    var scoreObj = new mindtestscoresveryhard()
                    {
                        User_Id = DatabaseContent.DatabaseMain.currentUser.Id,
                        Score = score
                    };

                    db.mindtestscoresveryhards.Add(scoreObj);
                    db.SaveChanges();
                }
            }
        }

        public static void AddMemoryTestOrderScore(int score)
        {
            if (LoggedState())
            {
                using (var db = new sql369565Entities())
                {
                    var scoreObj = new memorytestorderscore()
                    {
                        User_Id = DatabaseContent.DatabaseMain.currentUser.Id,
                        Score = score
                    };

                    db.memorytestorderscores.Add(scoreObj);
                    db.SaveChanges();
                }
            }
        }
    }
}
