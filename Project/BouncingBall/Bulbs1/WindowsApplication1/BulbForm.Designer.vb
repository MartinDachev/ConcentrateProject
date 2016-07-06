<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BulbForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BulbForm))
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.NumberOfWrongAnswers = New System.Windows.Forms.Label()
        Me.IncorrectLabel = New System.Windows.Forms.Label()
        Me.CorrectLabel = New System.Windows.Forms.Label()
        Me.ListOfResults = New System.Windows.Forms.ListBox()
        Me.TrueLabel = New System.Windows.Forms.Label()
        Me.NumberOfCorrectAnswers = New System.Windows.Forms.Label()
        Me.WrongLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.StartStopButton = New System.Windows.Forms.Button()
        Me.HoursLabel = New System.Windows.Forms.Label()
        Me.StopWatchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ChangeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RandomTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RestartButton = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LevelPanel = New System.Windows.Forms.Panel()
        Me.VeryHard = New System.Windows.Forms.RadioButton()
        Me.Medium = New System.Windows.Forms.RadioButton()
        Me.Hard = New System.Windows.Forms.RadioButton()
        Me.Easy = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Bulb2PictureBox = New System.Windows.Forms.PictureBox()
        Me.Bulb1PictureBox = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TimePanel = New System.Windows.Forms.Panel()
        Me.Min5 = New System.Windows.Forms.RadioButton()
        Me.Min2 = New System.Windows.Forms.RadioButton()
        Me.Min3 = New System.Windows.Forms.RadioButton()
        Me.Min1 = New System.Windows.Forms.RadioButton()
        Me.ProgramHelpButton = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.OptionsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveResultMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.Instructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu1 = New System.Windows.Forms.MenuStrip()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MissedBulbsLabel = New System.Windows.Forms.Label()
        Me.NumberOfMissed = New System.Windows.Forms.Label()
        Me.PropusnatiLabel = New System.Windows.Forms.Label()
        Me.ClearScreenButton = New System.Windows.Forms.Button()
        Me.SaveResultsButton = New System.Windows.Forms.Button()
        Me.TimeTestTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LevelPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Bulb2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bulb1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimePanel.SuspendLayout()
        Me.Menu1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(55, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(48, 20)
        Me.TextBox3.TabIndex = 103
        Me.TextBox3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(109, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(48, 20)
        Me.TextBox2.TabIndex = 102
        Me.TextBox2.Visible = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.LightCyan
        Me.ExitButton.Location = New System.Drawing.Point(270, 494)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(210, 55)
        Me.ExitButton.TabIndex = 100
        Me.ExitButton.TabStop = False
        Me.ExitButton.Text = "Изход"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'NumberOfWrongAnswers
        '
        Me.NumberOfWrongAnswers.AutoSize = True
        Me.NumberOfWrongAnswers.BackColor = System.Drawing.Color.Transparent
        Me.NumberOfWrongAnswers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NumberOfWrongAnswers.ForeColor = System.Drawing.Color.Red
        Me.NumberOfWrongAnswers.Location = New System.Drawing.Point(733, 526)
        Me.NumberOfWrongAnswers.Name = "NumberOfWrongAnswers"
        Me.NumberOfWrongAnswers.Size = New System.Drawing.Size(19, 20)
        Me.NumberOfWrongAnswers.TabIndex = 97
        Me.NumberOfWrongAnswers.Text = "0"
        '
        'IncorrectLabel
        '
        Me.IncorrectLabel.AutoSize = True
        Me.IncorrectLabel.BackColor = System.Drawing.Color.Transparent
        Me.IncorrectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.IncorrectLabel.ForeColor = System.Drawing.Color.Red
        Me.IncorrectLabel.Location = New System.Drawing.Point(551, 526)
        Me.IncorrectLabel.Name = "IncorrectLabel"
        Me.IncorrectLabel.Size = New System.Drawing.Size(176, 20)
        Me.IncorrectLabel.TabIndex = 96
        Me.IncorrectLabel.Text = "Грешни отговори :  "
        '
        'CorrectLabel
        '
        Me.CorrectLabel.AutoSize = True
        Me.CorrectLabel.Location = New System.Drawing.Point(119, 30)
        Me.CorrectLabel.Name = "CorrectLabel"
        Me.CorrectLabel.Size = New System.Drawing.Size(38, 13)
        Me.CorrectLabel.TabIndex = 92
        Me.CorrectLabel.Text = "Вярно"
        Me.CorrectLabel.Visible = False
        '
        'ListOfResults
        '
        Me.ListOfResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListOfResults.FormattingEnabled = True
        Me.ListOfResults.ItemHeight = 16
        Me.ListOfResults.Location = New System.Drawing.Point(519, 95)
        Me.ListOfResults.Name = "ListOfResults"
        Me.ListOfResults.ScrollAlwaysVisible = True
        Me.ListOfResults.Size = New System.Drawing.Size(326, 356)
        Me.ListOfResults.TabIndex = 88
        '
        'TrueLabel
        '
        Me.TrueLabel.AutoSize = True
        Me.TrueLabel.BackColor = System.Drawing.Color.Transparent
        Me.TrueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TrueLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.TrueLabel.Location = New System.Drawing.Point(559, 479)
        Me.TrueLabel.Name = "TrueLabel"
        Me.TrueLabel.Size = New System.Drawing.Size(164, 20)
        Me.TrueLabel.TabIndex = 95
        Me.TrueLabel.Text = "Верни отговори :  "
        '
        'NumberOfCorrectAnswers
        '
        Me.NumberOfCorrectAnswers.AutoSize = True
        Me.NumberOfCorrectAnswers.BackColor = System.Drawing.Color.Transparent
        Me.NumberOfCorrectAnswers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NumberOfCorrectAnswers.ForeColor = System.Drawing.Color.DarkGreen
        Me.NumberOfCorrectAnswers.Location = New System.Drawing.Point(733, 480)
        Me.NumberOfCorrectAnswers.Name = "NumberOfCorrectAnswers"
        Me.NumberOfCorrectAnswers.Size = New System.Drawing.Size(19, 20)
        Me.NumberOfCorrectAnswers.TabIndex = 94
        Me.NumberOfCorrectAnswers.Text = "0"
        '
        'WrongLabel
        '
        Me.WrongLabel.AutoSize = True
        Me.WrongLabel.Location = New System.Drawing.Point(119, 44)
        Me.WrongLabel.Name = "WrongLabel"
        Me.WrongLabel.Size = New System.Drawing.Size(45, 13)
        Me.WrongLabel.TabIndex = 93
        Me.WrongLabel.Text = "Грешка"
        Me.WrongLabel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(516, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Часове  :  Минути  :  Секунди  :  Милисекунди"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TimeLabel.Location = New System.Drawing.Point(616, 44)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(202, 25)
        Me.TimeLabel.TabIndex = 87
        Me.TimeLabel.Text = "00:00:00.0000000"
        '
        'StartStopButton
        '
        Me.StartStopButton.BackColor = System.Drawing.Color.Transparent
        Me.StartStopButton.BackgroundImage = CType(resources.GetObject("StartStopButton.BackgroundImage"), System.Drawing.Image)
        Me.StartStopButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartStopButton.FlatAppearance.BorderSize = 0
        Me.StartStopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StartStopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StartStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartStopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StartStopButton.ForeColor = System.Drawing.Color.LightCyan
        Me.StartStopButton.Location = New System.Drawing.Point(261, 44)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(210, 55)
        Me.StartStopButton.TabIndex = 85
        Me.StartStopButton.TabStop = False
        Me.StartStopButton.Text = "Старт"
        Me.StartStopButton.UseVisualStyleBackColor = False
        '
        'HoursLabel
        '
        Me.HoursLabel.AutoSize = True
        Me.HoursLabel.BackColor = System.Drawing.Color.Transparent
        Me.HoursLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoursLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HoursLabel.Location = New System.Drawing.Point(514, 44)
        Me.HoursLabel.Name = "HoursLabel"
        Me.HoursLabel.Size = New System.Drawing.Size(96, 25)
        Me.HoursLabel.TabIndex = 84
        Me.HoursLabel.Text = "Време :"
        '
        'StopWatchTimer
        '
        Me.StopWatchTimer.Interval = 1000
        '
        'ChangeTimer
        '
        Me.ChangeTimer.Interval = 1000
        '
        'RandomTimer
        '
        Me.RandomTimer.Interval = 1000
        '
        'RestartButton
        '
        Me.RestartButton.BackColor = System.Drawing.Color.Transparent
        Me.RestartButton.BackgroundImage = CType(resources.GetObject("RestartButton.BackgroundImage"), System.Drawing.Image)
        Me.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RestartButton.FlatAppearance.BorderSize = 0
        Me.RestartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.RestartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RestartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RestartButton.ForeColor = System.Drawing.Color.LightCyan
        Me.RestartButton.Location = New System.Drawing.Point(11, 494)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Size = New System.Drawing.Size(210, 55)
        Me.RestartButton.TabIndex = 111
        Me.RestartButton.TabStop = False
        Me.RestartButton.Text = "Нулиране"
        Me.RestartButton.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(402, 295)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 20)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Крушка"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(256, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 20)
        Me.Label11.TabIndex = 115
        Me.Label11.Text = "Крушка"
        '
        'LineShape8
        '
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 147
        Me.LineShape8.X2 = 274
        Me.LineShape8.Y1 = 5
        Me.LineShape8.Y2 = 5
        '
        'LineShape7
        '
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 148
        Me.LineShape7.X2 = 275
        Me.LineShape7.Y1 = 155
        Me.LineShape7.Y2 = 155
        '
        'LineShape6
        '
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 274
        Me.LineShape6.X2 = 274
        Me.LineShape6.Y1 = 8
        Me.LineShape6.Y2 = 154
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 147
        Me.LineShape5.X2 = 147
        Me.LineShape5.Y1 = 7
        Me.LineShape5.Y2 = 153
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 273
        Me.LineShape4.X2 = 273
        Me.LineShape4.Y1 = 7
        Me.LineShape4.Y2 = 153
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 133
        Me.LineShape3.X2 = 133
        Me.LineShape3.Y1 = 8
        Me.LineShape3.Y2 = 154
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 132
        Me.LineShape2.X2 = 132
        Me.LineShape2.Y1 = 8
        Me.LineShape2.Y2 = 155
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 6
        Me.LineShape1.X2 = 6
        Me.LineShape1.Y1 = 8
        Me.LineShape1.Y2 = 154
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(7, 5)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(124, 150)
        '
        'LevelPanel
        '
        Me.LevelPanel.BackColor = System.Drawing.Color.Transparent
        Me.LevelPanel.Controls.Add(Me.VeryHard)
        Me.LevelPanel.Controls.Add(Me.Medium)
        Me.LevelPanel.Controls.Add(Me.Hard)
        Me.LevelPanel.Controls.Add(Me.Easy)
        Me.LevelPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LevelPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LevelPanel.Location = New System.Drawing.Point(263, 376)
        Me.LevelPanel.Name = "LevelPanel"
        Me.LevelPanel.Size = New System.Drawing.Size(250, 84)
        Me.LevelPanel.TabIndex = 117
        '
        'VeryHard
        '
        Me.VeryHard.AutoSize = True
        Me.VeryHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.VeryHard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.VeryHard.Location = New System.Drawing.Point(106, 54)
        Me.VeryHard.Name = "VeryHard"
        Me.VeryHard.Size = New System.Drawing.Size(144, 24)
        Me.VeryHard.TabIndex = 129
        Me.VeryHard.TabStop = True
        Me.VeryHard.Text = "Много трудно"
        Me.VeryHard.UseVisualStyleBackColor = True
        '
        'Medium
        '
        Me.Medium.AutoSize = True
        Me.Medium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Medium.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Medium.Location = New System.Drawing.Point(7, 54)
        Me.Medium.Name = "Medium"
        Me.Medium.Size = New System.Drawing.Size(91, 24)
        Me.Medium.TabIndex = 128
        Me.Medium.TabStop = True
        Me.Medium.Text = "Средно"
        Me.Medium.UseVisualStyleBackColor = True
        '
        'Hard
        '
        Me.Hard.AutoSize = True
        Me.Hard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Hard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Hard.Location = New System.Drawing.Point(107, 11)
        Me.Hard.Name = "Hard"
        Me.Hard.Size = New System.Drawing.Size(87, 24)
        Me.Hard.TabIndex = 127
        Me.Hard.TabStop = True
        Me.Hard.Text = "Трудно"
        Me.Hard.UseVisualStyleBackColor = True
        '
        'Easy
        '
        Me.Easy.AutoSize = True
        Me.Easy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Easy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Easy.Location = New System.Drawing.Point(7, 11)
        Me.Easy.Name = "Easy"
        Me.Easy.Size = New System.Drawing.Size(79, 24)
        Me.Easy.TabIndex = 126
        Me.Easy.TabStop = True
        Me.Easy.Text = "Лесно"
        Me.Easy.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(266, 348)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(228, 24)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Степен на трудност : "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Bulb2PictureBox)
        Me.Panel2.Controls.Add(Me.Bulb1PictureBox)
        Me.Panel2.Controls.Add(Me.ShapeContainer2)
        Me.Panel2.Location = New System.Drawing.Point(223, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 162)
        Me.Panel2.TabIndex = 118
        '
        'Bulb2PictureBox
        '
        Me.Bulb2PictureBox.Location = New System.Drawing.Point(148, 6)
        Me.Bulb2PictureBox.Name = "Bulb2PictureBox"
        Me.Bulb2PictureBox.Size = New System.Drawing.Size(126, 149)
        Me.Bulb2PictureBox.TabIndex = 99
        Me.Bulb2PictureBox.TabStop = False
        '
        'Bulb1PictureBox
        '
        Me.Bulb1PictureBox.Location = New System.Drawing.Point(7, 6)
        Me.Bulb1PictureBox.Name = "Bulb1PictureBox"
        Me.Bulb1PictureBox.Size = New System.Drawing.Size(126, 149)
        Me.Bulb1PictureBox.TabIndex = 98
        Me.Bulb1PictureBox.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.RectangleShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(283, 162)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(19, 346)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 24)
        Me.Label14.TabIndex = 123
        Me.Label14.Text = "Времетраене : "
        '
        'TimePanel
        '
        Me.TimePanel.BackColor = System.Drawing.Color.Transparent
        Me.TimePanel.Controls.Add(Me.Min5)
        Me.TimePanel.Controls.Add(Me.Min2)
        Me.TimePanel.Controls.Add(Me.Min3)
        Me.TimePanel.Controls.Add(Me.Min1)
        Me.TimePanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TimePanel.Location = New System.Drawing.Point(17, 372)
        Me.TimePanel.Name = "TimePanel"
        Me.TimePanel.Size = New System.Drawing.Size(240, 89)
        Me.TimePanel.TabIndex = 124
        '
        'Min5
        '
        Me.Min5.AutoSize = True
        Me.Min5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Min5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Min5.Location = New System.Drawing.Point(125, 58)
        Me.Min5.Name = "Min5"
        Me.Min5.Size = New System.Drawing.Size(102, 24)
        Me.Min5.TabIndex = 128
        Me.Min5.TabStop = True
        Me.Min5.Text = "5 минути"
        Me.Min5.UseVisualStyleBackColor = True
        '
        'Min2
        '
        Me.Min2.AutoSize = True
        Me.Min2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Min2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Min2.Location = New System.Drawing.Point(6, 58)
        Me.Min2.Name = "Min2"
        Me.Min2.Size = New System.Drawing.Size(102, 24)
        Me.Min2.TabIndex = 127
        Me.Min2.TabStop = True
        Me.Min2.Text = "2 минути"
        Me.Min2.UseVisualStyleBackColor = True
        '
        'Min3
        '
        Me.Min3.AutoSize = True
        Me.Min3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Min3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Min3.Location = New System.Drawing.Point(125, 15)
        Me.Min3.Name = "Min3"
        Me.Min3.Size = New System.Drawing.Size(102, 24)
        Me.Min3.TabIndex = 126
        Me.Min3.TabStop = True
        Me.Min3.Text = "3 минути"
        Me.Min3.UseVisualStyleBackColor = True
        '
        'Min1
        '
        Me.Min1.AutoSize = True
        Me.Min1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Min1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Min1.Location = New System.Drawing.Point(6, 15)
        Me.Min1.Name = "Min1"
        Me.Min1.Size = New System.Drawing.Size(102, 24)
        Me.Min1.TabIndex = 125
        Me.Min1.TabStop = True
        Me.Min1.Text = "1 минута"
        Me.Min1.UseVisualStyleBackColor = True
        '
        'ProgramHelpButton
        '
        Me.ProgramHelpButton.BackColor = System.Drawing.Color.Transparent
        Me.ProgramHelpButton.BackgroundImage = CType(resources.GetObject("ProgramHelpButton.BackgroundImage"), System.Drawing.Image)
        Me.ProgramHelpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProgramHelpButton.FlatAppearance.BorderSize = 0
        Me.ProgramHelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ProgramHelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ProgramHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProgramHelpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ProgramHelpButton.ForeColor = System.Drawing.Color.LightCyan
        Me.ProgramHelpButton.Location = New System.Drawing.Point(7, 236)
        Me.ProgramHelpButton.Name = "ProgramHelpButton"
        Me.ProgramHelpButton.Size = New System.Drawing.Size(210, 55)
        Me.ProgramHelpButton.TabIndex = 125
        Me.ProgramHelpButton.TabStop = False
        Me.ProgramHelpButton.Text = "Инструкции"
        Me.ProgramHelpButton.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(3, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(48, 20)
        Me.TextBox4.TabIndex = 126
        Me.TextBox4.Visible = False
        '
        'OptionsMenu
        '
        Me.OptionsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveResultMenu, Me.ExitMenu})
        Me.OptionsMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsMenu.Name = "OptionsMenu"
        Me.OptionsMenu.Size = New System.Drawing.Size(58, 21)
        Me.OptionsMenu.Text = "Опции"
        '
        'SaveResultMenu
        '
        Me.SaveResultMenu.Name = "SaveResultMenu"
        Me.SaveResultMenu.Size = New System.Drawing.Size(172, 22)
        Me.SaveResultMenu.Text = "Запази резултат"
        '
        'ExitMenu
        '
        Me.ExitMenu.Name = "ExitMenu"
        Me.ExitMenu.Size = New System.Drawing.Size(172, 22)
        Me.ExitMenu.Text = "Изход"
        '
        'Help
        '
        Me.Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Instructions})
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(62, 21)
        Me.Help.Text = "Помощ"
        '
        'Instructions
        '
        Me.Instructions.Name = "Instructions"
        Me.Instructions.Size = New System.Drawing.Size(141, 22)
        Me.Instructions.Text = "Инструкции"
        '
        'Menu1
        '
        Me.Menu1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsMenu, Me.Help})
        Me.Menu1.Location = New System.Drawing.Point(0, 0)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(854, 25)
        Me.Menu1.TabIndex = 105
        Me.Menu1.Text = "MenuStrip1"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.MissedBulbsLabel)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.CorrectLabel)
        Me.Panel4.Controls.Add(Me.WrongLabel)
        Me.Panel4.Location = New System.Drawing.Point(864, 309)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(23, 27)
        Me.Panel4.TabIndex = 127
        Me.Panel4.Visible = False
        '
        'MissedBulbsLabel
        '
        Me.MissedBulbsLabel.AutoSize = True
        Me.MissedBulbsLabel.Location = New System.Drawing.Point(11, 44)
        Me.MissedBulbsLabel.Name = "MissedBulbsLabel"
        Me.MissedBulbsLabel.Size = New System.Drawing.Size(67, 13)
        Me.MissedBulbsLabel.TabIndex = 127
        Me.MissedBulbsLabel.Text = "Пропуснато"
        '
        'NumberOfMissed
        '
        Me.NumberOfMissed.AutoSize = True
        Me.NumberOfMissed.BackColor = System.Drawing.Color.Transparent
        Me.NumberOfMissed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NumberOfMissed.ForeColor = System.Drawing.Color.Chocolate
        Me.NumberOfMissed.Location = New System.Drawing.Point(733, 503)
        Me.NumberOfMissed.Name = "NumberOfMissed"
        Me.NumberOfMissed.Size = New System.Drawing.Size(19, 20)
        Me.NumberOfMissed.TabIndex = 128
        Me.NumberOfMissed.Text = "0"
        '
        'PropusnatiLabel
        '
        Me.PropusnatiLabel.AutoSize = True
        Me.PropusnatiLabel.BackColor = System.Drawing.Color.Transparent
        Me.PropusnatiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PropusnatiLabel.ForeColor = System.Drawing.Color.Chocolate
        Me.PropusnatiLabel.Location = New System.Drawing.Point(584, 503)
        Me.PropusnatiLabel.Name = "PropusnatiLabel"
        Me.PropusnatiLabel.Size = New System.Drawing.Size(134, 20)
        Me.PropusnatiLabel.TabIndex = 129
        Me.PropusnatiLabel.Text = "Пропуснати  :  "
        '
        'ClearScreenButton
        '
        Me.ClearScreenButton.BackColor = System.Drawing.Color.Transparent
        Me.ClearScreenButton.BackgroundImage = CType(resources.GetObject("ClearScreenButton.BackgroundImage"), System.Drawing.Image)
        Me.ClearScreenButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearScreenButton.FlatAppearance.BorderSize = 0
        Me.ClearScreenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ClearScreenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ClearScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearScreenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ClearScreenButton.ForeColor = System.Drawing.Color.LightCyan
        Me.ClearScreenButton.Location = New System.Drawing.Point(8, 44)
        Me.ClearScreenButton.Name = "ClearScreenButton"
        Me.ClearScreenButton.Size = New System.Drawing.Size(210, 55)
        Me.ClearScreenButton.TabIndex = 89
        Me.ClearScreenButton.TabStop = False
        Me.ClearScreenButton.Text = "Изчистване на резултатите"
        Me.ClearScreenButton.UseVisualStyleBackColor = False
        '
        'SaveResultsButton
        '
        Me.SaveResultsButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveResultsButton.BackgroundImage = CType(resources.GetObject("SaveResultsButton.BackgroundImage"), System.Drawing.Image)
        Me.SaveResultsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveResultsButton.FlatAppearance.BorderSize = 0
        Me.SaveResultsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SaveResultsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SaveResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveResultsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SaveResultsButton.ForeColor = System.Drawing.Color.LightCyan
        Me.SaveResultsButton.Location = New System.Drawing.Point(8, 139)
        Me.SaveResultsButton.Name = "SaveResultsButton"
        Me.SaveResultsButton.Size = New System.Drawing.Size(210, 55)
        Me.SaveResultsButton.TabIndex = 130
        Me.SaveResultsButton.TabStop = False
        Me.SaveResultsButton.Text = "Запазване на " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "резултатите"
        Me.SaveResultsButton.UseVisualStyleBackColor = False
        '
        'TimeTestTimer
        '
        '
        'BulbForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(854, 561)
        Me.Controls.Add(Me.SaveResultsButton)
        Me.Controls.Add(Me.PropusnatiLabel)
        Me.Controls.Add(Me.NumberOfMissed)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ProgramHelpButton)
        Me.Controls.Add(Me.TimePanel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ClearScreenButton)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LevelPanel)
        Me.Controls.Add(Me.RestartButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NumberOfWrongAnswers)
        Me.Controls.Add(Me.IncorrectLabel)
        Me.Controls.Add(Me.ListOfResults)
        Me.Controls.Add(Me.TrueLabel)
        Me.Controls.Add(Me.NumberOfCorrectAnswers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.StartStopButton)
        Me.Controls.Add(Me.HoursLabel)
        Me.Controls.Add(Me.Menu1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menu1
        Me.MaximizeBox = False
        Me.Name = "BulbForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Concentrate! Лампичка"
        Me.LevelPanel.ResumeLayout(False)
        Me.LevelPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Bulb2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bulb1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimePanel.ResumeLayout(False)
        Me.TimePanel.PerformLayout()
        Me.Menu1.ResumeLayout(False)
        Me.Menu1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Bulb2PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Bulb1PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents NumberOfWrongAnswers As System.Windows.Forms.Label
    Friend WithEvents IncorrectLabel As System.Windows.Forms.Label
    Friend WithEvents CorrectLabel As System.Windows.Forms.Label
    Friend WithEvents ListOfResults As System.Windows.Forms.ListBox
    Friend WithEvents TrueLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfCorrectAnswers As System.Windows.Forms.Label
    Friend WithEvents WrongLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents StartStopButton As System.Windows.Forms.Button
    Friend WithEvents HoursLabel As System.Windows.Forms.Label
    Friend WithEvents StopWatchTimer As System.Windows.Forms.Timer
    Friend WithEvents ChangeTimer As System.Windows.Forms.Timer
    Friend WithEvents RandomTimer As System.Windows.Forms.Timer
    Friend WithEvents RestartButton As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LevelPanel As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TimePanel As System.Windows.Forms.Panel
    Friend WithEvents ProgramHelpButton As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents OptionsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveResultMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Instructions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents NumberOfMissed As System.Windows.Forms.Label
    Friend WithEvents VeryHard As System.Windows.Forms.RadioButton
    Friend WithEvents Medium As System.Windows.Forms.RadioButton
    Friend WithEvents Hard As System.Windows.Forms.RadioButton
    Friend WithEvents Easy As System.Windows.Forms.RadioButton
    Friend WithEvents Min5 As System.Windows.Forms.RadioButton
    Friend WithEvents Min2 As System.Windows.Forms.RadioButton
    Friend WithEvents Min3 As System.Windows.Forms.RadioButton
    Friend WithEvents Min1 As System.Windows.Forms.RadioButton
    Friend WithEvents PropusnatiLabel As System.Windows.Forms.Label
    Friend WithEvents ClearScreenButton As System.Windows.Forms.Button
    Friend WithEvents MissedBulbsLabel As System.Windows.Forms.Label
    Friend WithEvents SaveResultsButton As System.Windows.Forms.Button
    Private WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Private WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents TimeTestTimer As System.Windows.Forms.Timer

End Class
