using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MemoryTestOrderProject.Properties;
using System.Windows.Input;
using DatabaseContent;

namespace MemoryTestOrderProject
{
    public partial class MemoryTestOrder : Form
    {

        // Defining custom class which have Button and number
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

        // Defining variables
        List<ButtonExtended> buttons;
        static Button checkButton;
        Random r = new Random();
        Point[,] windowCells;
        int difficulty = 2;
        int pressOrder = 1;
        int gameScore = 0;
        bool winning = true;
        bool gameOver = false;
        int timerInterval = 2000;
        double arrowIncrease = 4.6667;
        double arrowPosition;
        Point arrowNumPosition;
        Point arrowFinalPosition;
        Predicate<ButtonExtended> predicate = FindPoints;
        int lives = 3;

        public MemoryTestOrder()
        {
            InitializeComponent();
            this.KeyPreview = true;

            // Setting hardmeter default positions
            arrowPosition = arrowPictureBox.Location.Y;
            arrowNumPosition = arrowNum.Location;
            arrowFinalPosition = arrowPictureBox.Location;

            windowCells = new Point[5, 6];


            // Initializing form cells' positions
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
            float currentsize;


            // Initializing all Buttons
            for (int i = 0; i < buttons.Count; i++)
            {           
                buttons[i].button.Location = windowCells[i / windowCells.GetLength(1), i % windowCells.GetLength(1)];
                buttons[i].button.Size = new System.Drawing.Size(100, 100);
                buttons[i].button.Enabled = false;
                buttons[i].button.FlatStyle = FlatStyle.Flat;
                buttons[i].button.BackColor = Color.FromArgb(255,15, 80, 117);
                buttons[i].button.FlatAppearance.BorderSize = 1;
                buttons[i].button.FlatAppearance.BorderColor = Color.FromArgb(255, 31, 133, 163);
                currentsize = buttons[i].button.Font.Size;
                currentsize += 10.0F;
                buttons[i].button.Font = new Font(buttons[i].button.Font.Name, currentsize);
                buttons[i].button.Visible = false;
                buttons[i].button.Text = (i + 1).ToString(); 
                buttons[i].button.UseVisualStyleBackColor = true;
                buttons[i].button.Click += new EventHandler(this.Button_Click);
                buttons[i].button.Enabled = false;
                buttons[i].button.TabStop = false;
                Controls.Add(buttons[i].button);
            }
        }

        private void ClearButtons()
        {
            while(buttons.Count > 2)
            {
                RemoveButton();
            }
        }

        public void UpdateButtonPositions()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].button.Location = windowCells[i / windowCells.GetLength(1), i % windowCells.GetLength(1)];
                buttons[i].button.Text = buttons[i].number.ToString();
                buttons[i].button.Enabled = false;
                buttons[i].button.FlatStyle = FlatStyle.Flat;
                buttons[i].button.FlatAppearance.BorderSize = 1;
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
                    // Random shuffling form cells
                    randomIndexX = r.Next(i + 1);
                    randomIndexY = r.Next(j + 1);
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

        public void HandleGameOver()
        {
            UpdateDatabase.AddMemoryTestOrderScore(this.gameScore);
            this.gameOverLabel.Visible = true;
            this.playAgainLabel.Visible = true;
            this.gameOver = true;
        }

        public void Button_Click(object sender, EventArgs e)
        {
            checkButton = (Button)sender;
            checkButton.Visible = false;

            int index = buttons.FindIndex(predicate);

            // Check if index in List equals pressOrder
            if (index >= 0)
            {
                if (pressOrder != buttons[buttons.FindIndex(predicate)].number)
                {
                    winning = false;
                }
            }

            pressOrder ++;

            // If all Buttons pressed
            if (pressOrder > buttons.Count)
            {
                if(winning)
                {
                    gameScore += 25;
                    this.AddNewButton();
                }
                else
                {
                    this.lives--;
                    this.RemoveButton();
                }

                // Update labels
                this.scoreShowLabel.Text = gameScore.ToString();
                this.livesShowLabel.Text = lives.ToString();

                // If no lives left, declare game over
                if(lives <= 0)
                {
                    HandleGameOver();
                    return;
                }

                // Prepare for next round
                pressOrder = 1;
                this.Invalidate();
                arrowPictureBox.Location = arrowFinalPosition;
                arrowNum.Location = arrowNumPosition;
                arrowNum.Text = difficulty.ToString();
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
                // Decrease difficulty when removing button and update hardmeter
                difficulty--;
                arrowPosition += arrowIncrease;
                arrowFinalPosition.Y = (int)arrowPosition;
                arrowNumPosition.Y = arrowFinalPosition.Y - 2;
                Controls.Remove(buttons[buttons.Count - 1].button);
                buttons.RemoveAt(buttons.Count - 1);
            }
        }

        private void AddNewButton()
        {
            if (buttons.Count < 30)
            {
                // Increase difficulty when adding new button, initialize button and update hardmeter
                float currentsize;
                difficulty++;
                arrowPosition -= arrowIncrease;
                arrowFinalPosition.Y = (int)arrowPosition;
                arrowNumPosition.Y = arrowFinalPosition.Y - 2;
                buttons.Add(new ButtonExtended(new Button(), difficulty));
                int newButtonIndex = buttons.Count - 1;
                buttons[newButtonIndex].button.Location = new Point(0, 0);
                buttons[newButtonIndex].button.Size = new System.Drawing.Size(100, 100);
                buttons[newButtonIndex].button.FlatStyle = FlatStyle.Flat;
                buttons[newButtonIndex].button.FlatAppearance.BorderSize = 1;
                buttons[newButtonIndex].button.FlatAppearance.BorderColor = Color.FromArgb(255, 31, 133, 163);
                buttons[newButtonIndex].button.BackColor = Color.FromArgb(255, 15, 80, 117);
                currentsize = buttons[newButtonIndex].button.Font.Size;
                currentsize += 10.0F;

                buttons[newButtonIndex].button.Font = new Font(buttons[newButtonIndex].button.Font.Name, currentsize);
                buttons[newButtonIndex].button.Visible = true;
                buttons[newButtonIndex].button.Text = (newButtonIndex + 1).ToString();
                buttons[newButtonIndex].button.UseVisualStyleBackColor = true;
                buttons[newButtonIndex].button.Click += new EventHandler(this.Button_Click);
                buttons[newButtonIndex].button.Enabled = false;
                buttons[newButtonIndex].button.TabStop = false;
                Controls.Add(buttons[newButtonIndex].button);
            }
        }

        // When tick occured, enable all buttons, so that the user can click them
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].button.Enabled = true;
                buttons[i].button.Text = "";
                this.timer1.Stop();
            }
        }

        private void MemoryTestOrder_Load(object sender, EventArgs e)
        {

        }

        // When key press, if game state is game over and space is pressed, restart game
        private void MemoryTestOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar == (char)Keys.Space && this.gameOver == true)
           {
               ClearButtons();
               difficulty = 2;
               pressOrder = 1;
               gameScore = 0;
               winning = true;
               gameOver = false;
               timerInterval = 2000;
               lives = 3;
               ShuffleButtonPositions();
               UpdateButtonPositions();
               this.gameOverLabel.Visible = false;
               this.playAgainLabel.Visible = false;
               this.scoreShowLabel.Text = gameScore.ToString();
               this.livesShowLabel.Text = lives.ToString();
               timer1.Start();
           }
        }

        // When start game button is pressed, prepare and start the button
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0; i < buttons.Count; i++)
            {
                buttons[i].button.Visible = true;
            }

            this.button1.Visible = false;
            this.button1.Enabled = false;
            timer1.Interval = timerInterval;
            timer1.Start();
        }

        // Method to for showing the about form, which is called on Instructions Button Click
        private void button2_Click(object sender, EventArgs e)
        {
            //TODO: Call About Form
            AboutTheTestForm aboutTheTestForm = new AboutTheTestForm();
            aboutTheTestForm.Show();
        }
    }
}
