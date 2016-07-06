using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BouncingBallGame
{
    public partial class MemoryTestOrderOld : Form
    {
        public class ButtonExtended
        {
            public Button button;
            public int number;

            public ButtonExtended(Button button, int number)
            {
                this.button = button;
                this.number = number;
            }
        }

        List<ButtonExtended> buttons;
        static Button checkButton;
        List<bool> buttonsBool;
        Random r = new Random();
        Point[,] windowCells;
        int difficulty = 2;
        int pressOrder = 1;
        int score = 0;
        bool winning = true;
        int timerInterval = 2000;
        Predicate<ButtonExtended> predicate = FindPoints;
        int lives = 3;

        public MemoryTestOrderOld()
        {
            windowCells = new Point[5, 6];

            for (int i = 0; i < windowCells.GetLength(0); i++)
            {
                for (int j = 0; j < windowCells.GetLength(1); j++)
                {
                    windowCells[i, j].X = j * 100;
                    windowCells[i, j].Y = i * 100;
                }
            }

            buttons = new List<ButtonExtended>();
            buttons.Add(new ButtonExtended(new Button(), 1));
            buttons.Add(new ButtonExtended(new Button(), 2));

            ShuffleButtonPositions();

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].button.Location = windowCells[i / windowCells.GetLength(1), i % windowCells.GetLength(1)];
                buttons[i].button.Size = new System.Drawing.Size(100, 100);
                buttons[i].button.Visible = true;
                buttons[i].button.Text = (i + 1).ToString();
                buttons[i].button.UseVisualStyleBackColor = true;
                buttons[i].button.Click += new EventHandler(this.Button_Click);
                buttons[i].button.Enabled = false;
                Controls.Add(buttons[i].button);
            }

            InitializeComponent();

            timer1.Interval = timerInterval;
            timer1.Start();
        }

        public void UpdateButtonPositions()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].button.Location = windowCells[i / windowCells.GetLength(1), i % windowCells.GetLength(1)];
                buttons[i].button.Text = buttons[i].number.ToString();
                buttons[i].button.Enabled = false;
                buttons[i].button.Visible = true;
            }
        }

        public void ShuffleButtonPositions()
        { 
            int finalLength = this.windowCells.GetLength(0) * this.windowCells.GetLength(1);
            Point temp;
            int randomIndexX;
            int randomIndexY;

            for (int i = this.windowCells.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = this.windowCells.GetLength(1) - 1; j >= 0; j--)
                {
                    randomIndexX = r.Next(i + 1);
                    randomIndexY = r.Next(i + 1);
                    temp = windowCells[randomIndexX, randomIndexY];
                    windowCells[randomIndexX, randomIndexY] = windowCells[i, j];
                    windowCells[i, j] = temp;
                }
            }
        }

        public static bool FindPoints(ButtonExtended a)
        {
            return a.button.Location.Equals(checkButton.Location);
        }

        public void Button_Click(object sender, EventArgs e)
        {
            checkButton = (Button)sender;
            checkButton.Visible = false;
            if (pressOrder != buttons[buttons.FindIndex(predicate)].number)
            {
                winning = false;
            }

            pressOrder ++;

            if (pressOrder > buttons.Count)
            {
                if(winning)
                {
                    score++;
                    this.AddNewButton();
                }
                else
                {
                    this.lives--;
                    this.RemoveButton();
                }

                this.scoreShowLabel.Text = score.ToString();
                this.livesShowLabel.Text = lives.ToString();

                if(lives <= 0)
                {
                    this.gameOverLabel.Visible = true;
                    return;
                }

                pressOrder = 1;
                ShuffleButtonPositions();
                UpdateButtonPositions();
                winning = true;
                this.timer1.Interval = difficulty * 1000;
                this.timer1.Start();
            }
        }

        private void RemoveButton()
        {
            if (buttons.Count > 2)
            {
                difficulty--;
                Controls.Remove(buttons[buttons.Count - 1].button);
                buttons.RemoveAt(buttons.Count - 1);
            }
        }

        private void AddNewButton()
        {
            difficulty++;
            buttons.Add(new ButtonExtended(new Button(), difficulty));
            int newButtonIndex = buttons.Count - 1;
            buttons[newButtonIndex].button.Location = new Point(0, 0);
            buttons[newButtonIndex].button.Size = new System.Drawing.Size(100, 100);
            buttons[newButtonIndex].button.Visible = true;
            buttons[newButtonIndex].button.Text = (newButtonIndex + 1).ToString();
            buttons[newButtonIndex].button.UseVisualStyleBackColor = true;
            buttons[newButtonIndex].button.Click += new EventHandler(this.Button_Click);
            buttons[newButtonIndex].button.Enabled = false;
            Controls.Add(buttons[newButtonIndex].button);
        }

        private void MemoryTestOrder_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].button.Enabled = true;
                buttons[i].button.Text = "";
                Controls.Add(buttons[i].button);
                this.timer1.Stop();
            }
        }


    }
}
