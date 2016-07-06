namespace MemoryTestOrderProject
{
    partial class AboutTheTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutTheTestForm));
            this.AimTest = new System.Windows.Forms.Label();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AimTest
            // 
            this.AimTest.AutoSize = true;
            this.AimTest.BackColor = System.Drawing.Color.Transparent;
            this.AimTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AimTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(64)))), ((int)(((byte)(95)))));
            this.AimTest.Location = new System.Drawing.Point(72, 30);
            this.AimTest.Name = "AimTest";
            this.AimTest.Size = new System.Drawing.Size(751, 31);
            this.AimTest.TabIndex = 3;
            this.AimTest.Text = "Целта на теста е да провери и подобри вашата памет.";
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.AboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(64)))), ((int)(((byte)(95)))));
            this.AboutLabel.Location = new System.Drawing.Point(637, 98);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(287, 336);
            this.AboutLabel.TabIndex = 4;
            this.AboutLabel.Text = resources.GetString("AboutLabel.Text");
            this.AboutLabel.Click += new System.EventHandler(this.AboutLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 336);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(64)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(143, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 120);
            this.label1.TabIndex = 5;
            this.label1.Text = "             Оценяване\r\n2 - 7 - Лош резултат\r\n8 - 15 - Добър резултат\r\n16 - 23 - " +
    "Много добър резултат\r\n24 - 30 - Отличен резултат";
            // 
            // AboutTheTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(926, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.AimTest);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutTheTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "За теста";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label AimTest;
        internal System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label label1;
    }
}