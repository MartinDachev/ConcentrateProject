namespace BulbsProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ClearScreenButton = new System.Windows.Forms.Button();
            this.Bulb2PictureBox = new System.Windows.Forms.PictureBox();
            this.Bulb1PictureBox = new System.Windows.Forms.PictureBox();
            this.Min1Timer = new System.Windows.Forms.Timer(this.components);
            this.Min2Timer = new System.Windows.Forms.Timer(this.components);
            this.TimePanel = new System.Windows.Forms.Panel();
            this.Min5 = new System.Windows.Forms.RadioButton();
            this.Min2 = new System.Windows.Forms.RadioButton();
            this.Min3 = new System.Windows.Forms.RadioButton();
            this.Min1 = new System.Windows.Forms.RadioButton();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Min3Timer = new System.Windows.Forms.Timer(this.components);
            this.ProgramHelpButton = new System.Windows.Forms.Button();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.ЗапазиКатоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЗапазиРезултатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ИзходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПомощToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЗаПрограматаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.MissedBulbsLabel = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.CorrectLabel = new System.Windows.Forms.Label();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.PropusnatiLabel = new System.Windows.Forms.Label();
            this.NumberOfMissed = new System.Windows.Forms.Label();
            this.Min5Timer = new System.Windows.Forms.Timer(this.components);
            this.SaveResultsButton = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label12 = new System.Windows.Forms.Label();
            this.LevelPanel = new System.Windows.Forms.Panel();
            this.VeryHard = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NumberOfWrongAnswers = new System.Windows.Forms.Label();
            this.IncorrectLabel = new System.Windows.Forms.Label();
            this.ListOfResults = new System.Windows.Forms.ListBox();
            this.TrueLabel = new System.Windows.Forms.Label();
            this.NumberOfCorrectAnswers = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.StopWatchTimer = new System.Windows.Forms.Timer(this.components);
            this.Menu1 = new System.Windows.Forms.MenuStrip();
            this.ChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.RandomTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bulb2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bulb1PictureBox)).BeginInit();
            this.TimePanel.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.LevelPanel.SuspendLayout();
            this.Menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearScreenButton
            // 
            this.ClearScreenButton.BackColor = System.Drawing.Color.LightBlue;
            this.ClearScreenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearScreenButton.BackgroundImage")));
            this.ClearScreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearScreenButton.Location = new System.Drawing.Point(-6, 49);
            this.ClearScreenButton.Name = "ClearScreenButton";
            this.ClearScreenButton.Size = new System.Drawing.Size(196, 49);
            this.ClearScreenButton.TabIndex = 136;
            this.ClearScreenButton.Text = "Изчистване на екрана с резултатите";
            this.ClearScreenButton.UseVisualStyleBackColor = false;
            // 
            // Bulb2PictureBox
            // 
            this.Bulb2PictureBox.Location = new System.Drawing.Point(148, 6);
            this.Bulb2PictureBox.Name = "Bulb2PictureBox";
            this.Bulb2PictureBox.Size = new System.Drawing.Size(126, 149);
            this.Bulb2PictureBox.TabIndex = 99;
            this.Bulb2PictureBox.TabStop = false;
            // 
            // Bulb1PictureBox
            // 
            this.Bulb1PictureBox.Location = new System.Drawing.Point(7, 6);
            this.Bulb1PictureBox.Name = "Bulb1PictureBox";
            this.Bulb1PictureBox.Size = new System.Drawing.Size(126, 149);
            this.Bulb1PictureBox.TabIndex = 98;
            this.Bulb1PictureBox.TabStop = false;
            // 
            // Min1Timer
            // 
            this.Min1Timer.Interval = 60000;
            // 
            // Min2Timer
            // 
            this.Min2Timer.Interval = 120000;
            // 
            // TimePanel
            // 
            this.TimePanel.BackColor = System.Drawing.Color.Transparent;
            this.TimePanel.Controls.Add(this.Min5);
            this.TimePanel.Controls.Add(this.Min2);
            this.TimePanel.Controls.Add(this.Min3);
            this.TimePanel.Controls.Add(this.Min1);
            this.TimePanel.Location = new System.Drawing.Point(-8, 259);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(213, 58);
            this.TimePanel.TabIndex = 150;
            // 
            // Min5
            // 
            this.Min5.AutoSize = true;
            this.Min5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min5.Location = new System.Drawing.Point(98, 30);
            this.Min5.Name = "Min5";
            this.Min5.Size = new System.Drawing.Size(85, 19);
            this.Min5.TabIndex = 128;
            this.Min5.TabStop = true;
            this.Min5.Text = "5 минути";
            this.Min5.UseVisualStyleBackColor = true;
            // 
            // Min2
            // 
            this.Min2.AutoSize = true;
            this.Min2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min2.Location = new System.Drawing.Point(6, 30);
            this.Min2.Name = "Min2";
            this.Min2.Size = new System.Drawing.Size(85, 19);
            this.Min2.TabIndex = 127;
            this.Min2.TabStop = true;
            this.Min2.Text = "2 минути";
            this.Min2.UseVisualStyleBackColor = true;
            // 
            // Min3
            // 
            this.Min3.AutoSize = true;
            this.Min3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min3.Location = new System.Drawing.Point(98, 8);
            this.Min3.Name = "Min3";
            this.Min3.Size = new System.Drawing.Size(85, 19);
            this.Min3.TabIndex = 126;
            this.Min3.TabStop = true;
            this.Min3.Text = "3 минути";
            this.Min3.UseVisualStyleBackColor = true;
            // 
            // Min1
            // 
            this.Min1.AutoSize = true;
            this.Min1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min1.Location = new System.Drawing.Point(6, 8);
            this.Min1.Name = "Min1";
            this.Min1.Size = new System.Drawing.Size(85, 19);
            this.Min1.TabIndex = 125;
            this.Min1.TabStop = true;
            this.Min1.Text = "1 минута";
            this.Min1.UseVisualStyleBackColor = true;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label14.Location = new System.Drawing.Point(-6, 233);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(120, 16);
            this.Label14.TabIndex = 149;
            this.Label14.Text = "Времетраене : ";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(250, 278);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(62, 16);
            this.Label11.TabIndex = 146;
            this.Label11.Text = "Крушка";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label13.Location = new System.Drawing.Point(-6, 329);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(169, 16);
            this.Label13.TabIndex = 131;
            this.Label13.Text = "Степен на трудност : ";
            // 
            // Min3Timer
            // 
            this.Min3Timer.Interval = 180000;
            // 
            // ProgramHelpButton
            // 
            this.ProgramHelpButton.BackColor = System.Drawing.Color.LightBlue;
            this.ProgramHelpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgramHelpButton.BackgroundImage")));
            this.ProgramHelpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProgramHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProgramHelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgramHelpButton.Location = new System.Drawing.Point(-6, 170);
            this.ProgramHelpButton.Name = "ProgramHelpButton";
            this.ProgramHelpButton.Size = new System.Drawing.Size(196, 49);
            this.ProgramHelpButton.TabIndex = 151;
            this.ProgramHelpButton.Text = "За теста";
            this.ProgramHelpButton.UseVisualStyleBackColor = false;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(3, 4);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(48, 20);
            this.TextBox4.TabIndex = 126;
            this.TextBox4.Visible = false;
            // 
            // ЗапазиКатоToolStripMenuItem
            // 
            this.ЗапазиКатоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ЗапазиРезултатToolStripMenuItem,
            this.ИзходToolStripMenuItem});
            this.ЗапазиКатоToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ЗапазиКатоToolStripMenuItem.Name = "ЗапазиКатоToolStripMenuItem";
            this.ЗапазиКатоToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.ЗапазиКатоToolStripMenuItem.Text = "Опции";
            // 
            // ЗапазиРезултатToolStripMenuItem
            // 
            this.ЗапазиРезултатToolStripMenuItem.Name = "ЗапазиРезултатToolStripMenuItem";
            this.ЗапазиРезултатToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ЗапазиРезултатToolStripMenuItem.Text = "Запази резултат";
            // 
            // ИзходToolStripMenuItem
            // 
            this.ИзходToolStripMenuItem.Name = "ИзходToolStripMenuItem";
            this.ИзходToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ИзходToolStripMenuItem.Text = "Изход";
            // 
            // ПомощToolStripMenuItem
            // 
            this.ПомощToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ЗаПрограматаToolStripMenuItem});
            this.ПомощToolStripMenuItem.Name = "ПомощToolStripMenuItem";
            this.ПомощToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.ПомощToolStripMenuItem.Text = "Помощ";
            // 
            // ЗаПрограматаToolStripMenuItem
            // 
            this.ЗаПрограматаToolStripMenuItem.Name = "ЗаПрограматаToolStripMenuItem";
            this.ЗаПрограматаToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.ЗаПрограматаToolStripMenuItem.Text = "За теста";
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.MissedBulbsLabel);
            this.Panel4.Controls.Add(this.TextBox4);
            this.Panel4.Controls.Add(this.TextBox3);
            this.Panel4.Controls.Add(this.TextBox2);
            this.Panel4.Controls.Add(this.CorrectLabel);
            this.Panel4.Controls.Add(this.WrongLabel);
            this.Panel4.Location = new System.Drawing.Point(850, 314);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(23, 27);
            this.Panel4.TabIndex = 152;
            this.Panel4.Visible = false;
            // 
            // MissedBulbsLabel
            // 
            this.MissedBulbsLabel.AutoSize = true;
            this.MissedBulbsLabel.Location = new System.Drawing.Point(11, 44);
            this.MissedBulbsLabel.Name = "MissedBulbsLabel";
            this.MissedBulbsLabel.Size = new System.Drawing.Size(67, 13);
            this.MissedBulbsLabel.TabIndex = 127;
            this.MissedBulbsLabel.Text = "Пропуснато";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(55, 4);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(48, 20);
            this.TextBox3.TabIndex = 103;
            this.TextBox3.Visible = false;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(109, 4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(48, 20);
            this.TextBox2.TabIndex = 102;
            this.TextBox2.Visible = false;
            // 
            // CorrectLabel
            // 
            this.CorrectLabel.AutoSize = true;
            this.CorrectLabel.Location = new System.Drawing.Point(119, 30);
            this.CorrectLabel.Name = "CorrectLabel";
            this.CorrectLabel.Size = new System.Drawing.Size(38, 13);
            this.CorrectLabel.TabIndex = 92;
            this.CorrectLabel.Text = "Вярно";
            this.CorrectLabel.Visible = false;
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.Location = new System.Drawing.Point(119, 44);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(45, 13);
            this.WrongLabel.TabIndex = 93;
            this.WrongLabel.Text = "Грешка";
            this.WrongLabel.Visible = false;
            // 
            // PropusnatiLabel
            // 
            this.PropusnatiLabel.AutoSize = true;
            this.PropusnatiLabel.BackColor = System.Drawing.Color.Transparent;
            this.PropusnatiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropusnatiLabel.Location = new System.Drawing.Point(599, 379);
            this.PropusnatiLabel.Name = "PropusnatiLabel";
            this.PropusnatiLabel.Size = new System.Drawing.Size(118, 16);
            this.PropusnatiLabel.TabIndex = 154;
            this.PropusnatiLabel.Text = "Пропуснати  :  ";
            // 
            // NumberOfMissed
            // 
            this.NumberOfMissed.AutoSize = true;
            this.NumberOfMissed.BackColor = System.Drawing.Color.Transparent;
            this.NumberOfMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfMissed.Location = new System.Drawing.Point(719, 379);
            this.NumberOfMissed.Name = "NumberOfMissed";
            this.NumberOfMissed.Size = new System.Drawing.Size(16, 16);
            this.NumberOfMissed.TabIndex = 153;
            this.NumberOfMissed.Text = "0";
            // 
            // Min5Timer
            // 
            this.Min5Timer.Interval = 300000;
            // 
            // SaveResultsButton
            // 
            this.SaveResultsButton.BackColor = System.Drawing.Color.LightBlue;
            this.SaveResultsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveResultsButton.BackgroundImage")));
            this.SaveResultsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveResultsButton.Location = new System.Drawing.Point(-6, 113);
            this.SaveResultsButton.Name = "SaveResultsButton";
            this.SaveResultsButton.Size = new System.Drawing.Size(196, 49);
            this.SaveResultsButton.TabIndex = 155;
            this.SaveResultsButton.Text = "Запазване на \r\nрезултатите";
            this.SaveResultsButton.UseVisualStyleBackColor = false;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel2.Controls.Add(this.Bulb2PictureBox);
            this.Panel2.Controls.Add(this.Bulb1PictureBox);
            this.Panel2.Location = new System.Drawing.Point(209, 113);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(283, 162);
            this.Panel2.TabIndex = 148;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(396, 278);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(62, 16);
            this.Label12.TabIndex = 145;
            this.Label12.Text = "Крушка";
            // 
            // LevelPanel
            // 
            this.LevelPanel.BackColor = System.Drawing.Color.Transparent;
            this.LevelPanel.Controls.Add(this.VeryHard);
            this.LevelPanel.Controls.Add(this.Medium);
            this.LevelPanel.Controls.Add(this.Hard);
            this.LevelPanel.Controls.Add(this.Easy);
            this.LevelPanel.Location = new System.Drawing.Point(-9, 350);
            this.LevelPanel.Name = "LevelPanel";
            this.LevelPanel.Size = new System.Drawing.Size(225, 63);
            this.LevelPanel.TabIndex = 147;
            // 
            // VeryHard
            // 
            this.VeryHard.AutoSize = true;
            this.VeryHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VeryHard.Location = new System.Drawing.Point(99, 32);
            this.VeryHard.Name = "VeryHard";
            this.VeryHard.Size = new System.Drawing.Size(117, 19);
            this.VeryHard.TabIndex = 129;
            this.VeryHard.TabStop = true;
            this.VeryHard.Text = "Много трудно";
            this.VeryHard.UseVisualStyleBackColor = true;
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Medium.Location = new System.Drawing.Point(6, 31);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(74, 19);
            this.Medium.TabIndex = 128;
            this.Medium.TabStop = true;
            this.Medium.Text = "Средно";
            this.Medium.UseVisualStyleBackColor = true;
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hard.Location = new System.Drawing.Point(99, 7);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(71, 19);
            this.Hard.TabIndex = 127;
            this.Hard.TabStop = true;
            this.Hard.Text = "Трудно";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Easy.Location = new System.Drawing.Point(7, 7);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(65, 19);
            this.Easy.TabIndex = 126;
            this.Easy.TabStop = true;
            this.Easy.Text = "Лесно";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.LightBlue;
            this.RestartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RestartButton.BackgroundImage")));
            this.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartButton.Location = new System.Drawing.Point(253, 310);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(199, 49);
            this.RestartButton.TabIndex = 144;
            this.RestartButton.Text = "Нулиране";
            this.RestartButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightBlue;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(253, 367);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(199, 49);
            this.ExitButton.TabIndex = 142;
            this.ExitButton.Text = "Изход";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // NumberOfWrongAnswers
            // 
            this.NumberOfWrongAnswers.AutoSize = true;
            this.NumberOfWrongAnswers.BackColor = System.Drawing.Color.Transparent;
            this.NumberOfWrongAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfWrongAnswers.Location = new System.Drawing.Point(719, 402);
            this.NumberOfWrongAnswers.Name = "NumberOfWrongAnswers";
            this.NumberOfWrongAnswers.Size = new System.Drawing.Size(16, 16);
            this.NumberOfWrongAnswers.TabIndex = 141;
            this.NumberOfWrongAnswers.Text = "0";
            // 
            // IncorrectLabel
            // 
            this.IncorrectLabel.AutoSize = true;
            this.IncorrectLabel.BackColor = System.Drawing.Color.Transparent;
            this.IncorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectLabel.Location = new System.Drawing.Point(566, 402);
            this.IncorrectLabel.Name = "IncorrectLabel";
            this.IncorrectLabel.Size = new System.Drawing.Size(151, 16);
            this.IncorrectLabel.TabIndex = 140;
            this.IncorrectLabel.Text = "Грешни отговори :  ";
            // 
            // ListOfResults
            // 
            this.ListOfResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfResults.FormattingEnabled = true;
            this.ListOfResults.ItemHeight = 16;
            this.ListOfResults.Location = new System.Drawing.Point(505, 100);
            this.ListOfResults.Name = "ListOfResults";
            this.ListOfResults.ScrollAlwaysVisible = true;
            this.ListOfResults.Size = new System.Drawing.Size(326, 244);
            this.ListOfResults.TabIndex = 135;
            // 
            // TrueLabel
            // 
            this.TrueLabel.AutoSize = true;
            this.TrueLabel.BackColor = System.Drawing.Color.Transparent;
            this.TrueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueLabel.Location = new System.Drawing.Point(574, 355);
            this.TrueLabel.Name = "TrueLabel";
            this.TrueLabel.Size = new System.Drawing.Size(143, 16);
            this.TrueLabel.TabIndex = 139;
            this.TrueLabel.Text = "Верни отговори :  ";
            // 
            // NumberOfCorrectAnswers
            // 
            this.NumberOfCorrectAnswers.AutoSize = true;
            this.NumberOfCorrectAnswers.BackColor = System.Drawing.Color.Transparent;
            this.NumberOfCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfCorrectAnswers.Location = new System.Drawing.Point(719, 356);
            this.NumberOfCorrectAnswers.Name = "NumberOfCorrectAnswers";
            this.NumberOfCorrectAnswers.Size = new System.Drawing.Size(16, 16);
            this.NumberOfCorrectAnswers.TabIndex = 138;
            this.NumberOfCorrectAnswers.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(502, 79);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(341, 16);
            this.Label2.TabIndex = 137;
            this.Label2.Text = "Часове  :  Минути  :  Секунди  :  Милисекунди";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(602, 49);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(202, 25);
            this.TimeLabel.TabIndex = 134;
            this.TimeLabel.Text = "00:00:00.0000000";
            // 
            // StartStopButton
            // 
            this.StartStopButton.BackColor = System.Drawing.Color.LightBlue;
            this.StartStopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartStopButton.BackgroundImage")));
            this.StartStopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartStopButton.Location = new System.Drawing.Point(253, 49);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(199, 49);
            this.StartStopButton.TabIndex = 133;
            this.StartStopButton.Text = "Старт";
            this.StartStopButton.UseVisualStyleBackColor = false;
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.BackColor = System.Drawing.Color.Transparent;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.Location = new System.Drawing.Point(500, 49);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(96, 25);
            this.HoursLabel.TabIndex = 132;
            this.HoursLabel.Text = "Време :";
            // 
            // StopWatchTimer
            // 
            this.StopWatchTimer.Interval = 1000;
            // 
            // Menu1
            // 
            this.Menu1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ЗапазиКатоToolStripMenuItem,
            this.ПомощToolStripMenuItem});
            this.Menu1.Location = new System.Drawing.Point(0, 0);
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(858, 25);
            this.Menu1.TabIndex = 143;
            this.Menu1.Text = "MenuStrip1";
            // 
            // ChangeTimer
            // 
            this.ChangeTimer.Interval = 1000;
            // 
            // RandomTimer
            // 
            this.RandomTimer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 422);
            this.Controls.Add(this.ClearScreenButton);
            this.Controls.Add(this.TimePanel);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.ProgramHelpButton);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.PropusnatiLabel);
            this.Controls.Add(this.NumberOfMissed);
            this.Controls.Add(this.SaveResultsButton);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.LevelPanel);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NumberOfWrongAnswers);
            this.Controls.Add(this.IncorrectLabel);
            this.Controls.Add(this.ListOfResults);
            this.Controls.Add(this.TrueLabel);
            this.Controls.Add(this.NumberOfCorrectAnswers);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.Menu1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Bulb2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bulb1PictureBox)).EndInit();
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.LevelPanel.ResumeLayout(false);
            this.LevelPanel.PerformLayout();
            this.Menu1.ResumeLayout(false);
            this.Menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ClearScreenButton;
        internal System.Windows.Forms.PictureBox Bulb2PictureBox;
        internal System.Windows.Forms.PictureBox Bulb1PictureBox;
        internal System.Windows.Forms.Timer Min1Timer;
        internal System.Windows.Forms.Timer Min2Timer;
        internal System.Windows.Forms.Panel TimePanel;
        internal System.Windows.Forms.RadioButton Min5;
        internal System.Windows.Forms.RadioButton Min2;
        internal System.Windows.Forms.RadioButton Min3;
        internal System.Windows.Forms.RadioButton Min1;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Timer Min3Timer;
        internal System.Windows.Forms.Button ProgramHelpButton;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.ToolStripMenuItem ЗапазиКатоToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ЗапазиРезултатToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ИзходToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ПомощToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ЗаПрограматаToolStripMenuItem;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Label MissedBulbsLabel;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label CorrectLabel;
        internal System.Windows.Forms.Label WrongLabel;
        internal System.Windows.Forms.Label PropusnatiLabel;
        internal System.Windows.Forms.Label NumberOfMissed;
        internal System.Windows.Forms.Timer Min5Timer;
        internal System.Windows.Forms.Button SaveResultsButton;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Panel LevelPanel;
        internal System.Windows.Forms.RadioButton VeryHard;
        internal System.Windows.Forms.RadioButton Medium;
        internal System.Windows.Forms.RadioButton Hard;
        internal System.Windows.Forms.RadioButton Easy;
        internal System.Windows.Forms.Button RestartButton;
        internal System.Windows.Forms.Button ExitButton;
        internal System.Windows.Forms.Label NumberOfWrongAnswers;
        internal System.Windows.Forms.Label IncorrectLabel;
        internal System.Windows.Forms.ListBox ListOfResults;
        internal System.Windows.Forms.Label TrueLabel;
        internal System.Windows.Forms.Label NumberOfCorrectAnswers;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label TimeLabel;
        internal System.Windows.Forms.Button StartStopButton;
        internal System.Windows.Forms.Label HoursLabel;
        internal System.Windows.Forms.Timer StopWatchTimer;
        internal System.Windows.Forms.MenuStrip Menu1;
        internal System.Windows.Forms.Timer ChangeTimer;
        internal System.Windows.Forms.Timer RandomTimer;

    }
}

