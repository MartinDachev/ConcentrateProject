namespace MemoryTestOrderProject
{
    partial class MemoryTestOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryTestOrder));
            this.scoreTextLabel = new System.Windows.Forms.Label();
            this.scoreShowLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.livesTextLabel = new System.Windows.Forms.Label();
            this.livesShowLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hardmeterLabel = new System.Windows.Forms.Label();
            this.arrowPictureBox = new System.Windows.Forms.PictureBox();
            this.arrowNumLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.arrowNum = new System.Windows.Forms.Label();
            this.playAgainLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreTextLabel
            // 
            this.scoreTextLabel.AutoSize = true;
            this.scoreTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.scoreTextLabel.Location = new System.Drawing.Point(627, 84);
            this.scoreTextLabel.Name = "scoreTextLabel";
            this.scoreTextLabel.Size = new System.Drawing.Size(111, 33);
            this.scoreTextLabel.TabIndex = 0;
            this.scoreTextLabel.Text = "Точки: ";
            // 
            // scoreShowLabel
            // 
            this.scoreShowLabel.AutoSize = true;
            this.scoreShowLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreShowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.scoreShowLabel.Location = new System.Drawing.Point(742, 84);
            this.scoreShowLabel.Name = "scoreShowLabel";
            this.scoreShowLabel.Size = new System.Drawing.Size(31, 33);
            this.scoreShowLabel.TabIndex = 1;
            this.scoreShowLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // livesTextLabel
            // 
            this.livesTextLabel.AutoSize = true;
            this.livesTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.livesTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.livesTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.livesTextLabel.Location = new System.Drawing.Point(627, 27);
            this.livesTextLabel.Name = "livesTextLabel";
            this.livesTextLabel.Size = new System.Drawing.Size(125, 33);
            this.livesTextLabel.TabIndex = 2;
            this.livesTextLabel.Text = "Животи:";
            // 
            // livesShowLabel
            // 
            this.livesShowLabel.AutoSize = true;
            this.livesShowLabel.BackColor = System.Drawing.Color.Transparent;
            this.livesShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.livesShowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.livesShowLabel.Location = new System.Drawing.Point(758, 27);
            this.livesShowLabel.Name = "livesShowLabel";
            this.livesShowLabel.Size = new System.Drawing.Size(31, 33);
            this.livesShowLabel.TabIndex = 3;
            this.livesShowLabel.Text = "3";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.gameOverLabel.Location = new System.Drawing.Point(157, 244);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(293, 42);
            this.gameOverLabel.TabIndex = 4;
            this.gameOverLabel.Text = "Край на играта!";
            this.gameOverLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(610, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 563);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(694, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 228);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // hardmeterLabel
            // 
            this.hardmeterLabel.AutoSize = true;
            this.hardmeterLabel.BackColor = System.Drawing.Color.Transparent;
            this.hardmeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardmeterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.hardmeterLabel.Location = new System.Drawing.Point(660, 433);
            this.hardmeterLabel.Name = "hardmeterLabel";
            this.hardmeterLabel.Size = new System.Drawing.Size(141, 33);
            this.hardmeterLabel.TabIndex = 7;
            this.hardmeterLabel.Text = "Трудност";
            // 
            // arrowPictureBox
            // 
            this.arrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.arrowPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("arrowPictureBox.Image")));
            this.arrowPictureBox.Location = new System.Drawing.Point(746, 355);
            this.arrowPictureBox.Name = "arrowPictureBox";
            this.arrowPictureBox.Size = new System.Drawing.Size(14, 13);
            this.arrowPictureBox.TabIndex = 8;
            this.arrowPictureBox.TabStop = false;
            // 
            // arrowNumLabel
            // 
            this.arrowNumLabel.AutoSize = true;
            this.arrowNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.arrowNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowNumLabel.ForeColor = System.Drawing.Color.White;
            this.arrowNumLabel.Location = new System.Drawing.Point(710, 354);
            this.arrowNumLabel.Name = "arrowNumLabel";
            this.arrowNumLabel.Size = new System.Drawing.Size(14, 13);
            this.arrowNumLabel.TabIndex = 9;
            this.arrowNumLabel.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(704, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(704, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "15";
            // 
            // arrowNum
            // 
            this.arrowNum.AutoSize = true;
            this.arrowNum.BackColor = System.Drawing.Color.Transparent;
            this.arrowNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowNum.ForeColor = System.Drawing.Color.White;
            this.arrowNum.Location = new System.Drawing.Point(757, 353);
            this.arrowNum.Name = "arrowNum";
            this.arrowNum.Size = new System.Drawing.Size(16, 16);
            this.arrowNum.TabIndex = 12;
            this.arrowNum.Text = "2";
            // 
            // playAgainLabel
            // 
            this.playAgainLabel.AutoSize = true;
            this.playAgainLabel.BackColor = System.Drawing.Color.Transparent;
            this.playAgainLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.playAgainLabel.Location = new System.Drawing.Point(159, 307);
            this.playAgainLabel.Name = "playAgainLabel";
            this.playAgainLabel.Size = new System.Drawing.Size(267, 60);
            this.playAgainLabel.TabIndex = 13;
            this.playAgainLabel.Text = "      Натиснете \'Space\'\r\n за да започнете отново.";
            this.playAgainLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(217, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 145);
            this.button1.TabIndex = 14;
            this.button1.Text = "Стартиране на играта";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(80)))), ((int)(((byte)(117)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(133)))), ((int)(((byte)(163)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(675, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 66);
            this.button2.TabIndex = 16;
            this.button2.TabStop = false;
            this.button2.Text = "Инструкции";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MemoryTestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(851, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playAgainLabel);
            this.Controls.Add(this.arrowNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrowNumLabel);
            this.Controls.Add(this.arrowPictureBox);
            this.Controls.Add(this.hardmeterLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.livesShowLabel);
            this.Controls.Add(this.livesTextLabel);
            this.Controls.Add(this.scoreShowLabel);
            this.Controls.Add(this.scoreTextLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MemoryTestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concentrate! Последователни квадрати";
            this.Load += new System.EventHandler(this.MemoryTestOrder_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MemoryTestOrder_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreTextLabel;
        private System.Windows.Forms.Label scoreShowLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label livesTextLabel;
        private System.Windows.Forms.Label livesShowLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label hardmeterLabel;
        private System.Windows.Forms.PictureBox arrowPictureBox;
        private System.Windows.Forms.Label arrowNumLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label arrowNum;
        private System.Windows.Forms.Label playAgainLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}