namespace BouncingBallGame
{
    partial class MemoryTestOrderOld
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.scoreTextLabel = new System.Windows.Forms.Label();
            this.scoreShowLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.livesTextLabel = new System.Windows.Forms.Label();
            this.livesShowLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreTextLabel
            // 
            this.scoreTextLabel.AutoSize = true;
            this.scoreTextLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextLabel.Location = new System.Drawing.Point(621, 102);
            this.scoreTextLabel.Name = "scoreTextLabel";
            this.scoreTextLabel.Size = new System.Drawing.Size(113, 50);
            this.scoreTextLabel.TabIndex = 0;
            this.scoreTextLabel.Text = "Score";
            // 
            // scoreShowLabel
            // 
            this.scoreShowLabel.AutoSize = true;
            this.scoreShowLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreShowLabel.Location = new System.Drawing.Point(648, 163);
            this.scoreShowLabel.Name = "scoreShowLabel";
            this.scoreShowLabel.Size = new System.Drawing.Size(37, 45);
            this.scoreShowLabel.TabIndex = 1;
            this.scoreShowLabel.Text = "0";
            this.scoreShowLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // livesTextLabel
            // 
            this.livesTextLabel.AutoSize = true;
            this.livesTextLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesTextLabel.Location = new System.Drawing.Point(631, 8);
            this.livesTextLabel.Name = "livesTextLabel";
            this.livesTextLabel.Size = new System.Drawing.Size(89, 45);
            this.livesTextLabel.TabIndex = 2;
            this.livesTextLabel.Text = "Lives";
            // 
            // livesShowLabel
            // 
            this.livesShowLabel.AutoSize = true;
            this.livesShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesShowLabel.Location = new System.Drawing.Point(650, 53);
            this.livesShowLabel.Name = "livesShowLabel";
            this.livesShowLabel.Size = new System.Drawing.Size(29, 31);
            this.livesShowLabel.TabIndex = 3;
            this.livesShowLabel.Text = "3";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(266, 122);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(207, 39);
            this.gameOverLabel.TabIndex = 4;
            this.gameOverLabel.Text = "Game Over!";
            this.gameOverLabel.Visible = false;
            // 
            // MemoryTestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.livesShowLabel);
            this.Controls.Add(this.livesTextLabel);
            this.Controls.Add(this.scoreShowLabel);
            this.Controls.Add(this.scoreTextLabel);
            this.Name = "MemoryTestOrder";
            this.Text = "MemoryTestOrder";
            this.Load += new System.EventHandler(this.MemoryTestOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label scoreTextLabel;
        private System.Windows.Forms.Label scoreShowLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label livesTextLabel;
        private System.Windows.Forms.Label livesShowLabel;
        private System.Windows.Forms.Label gameOverLabel;
    }
}