Option Strict On
Public Class BulbForm
    'SW is for the StopWatch
    Dim SW As New Stopwatch
    Public Property Dialog As DialogResult
    'Random1 and Random2 are for the RandomFunction. In those variables we are saving the generated random numbers.
    Dim Random1 As Integer
    Dim Random2 As Integer
    'IFMissed is a boolean variable which checks if green bulb is missed
    Dim IFMissed As Boolean = False
    'missed is the number of missed green bulbs
    Dim missed As Integer = 0
    Private Sub StopWatchTimer_Tick(sender As Object, e As EventArgs) Handles StopWatchTimer.Tick
        'Showing the time in TimeLabel
        TimeLabel.Text = SW.Elapsed.ToString
    End Sub
    Sub WrongAnswer()
        'Right answer function
        ListOfResults.Items.Add(WrongLabel.Text)
        Dim Item As New ListViewItem(CStr(ListOfResults.Items.Count + 1))
        Item.SubItems.Add(SW.Elapsed.ToString)
        ListOfResults.Items.Add(TimeLabel.Text)
        NumberOfWrongAnswers.Text = CStr(Val(NumberOfWrongAnswers.Text) + 1)
    End Sub
    Sub CorrectAnswer()
        'Wrong answer function
        ListOfResults.Items.Add(CorrectLabel.Text)
        Dim Item As New ListViewItem(CStr(ListOfResults.Items.Count + 1))
        Item.SubItems.Add(SW.Elapsed.ToString)
        ListOfResults.Items.Add(TimeLabel.Text)
        NumberOfCorrectAnswers.Text = CStr(Val(NumberOfCorrectAnswers.Text) + 1)
    End Sub
    Sub MissedClick()
        'Checking for missed click
        If Random2 = 1 And Random1 = 1 Or Random2 = 1 And Random1 = 4 Then
            IFMissed = True
        Else
            IFMissed = False
        End If
        If IFMissed = True Then
            missed = missed + 1
        End If
        NumberOfMissed.Text = CStr(missed - Val(NumberOfCorrectAnswers.Text))
    End Sub
    Sub Level()
        'Fuction about the start of the test
        ListOfResults.Items.Clear()
        StartStopButton.Text = "Стоп"
        SW = Stopwatch.StartNew
        StopWatchTimer.Interval = 1
        StopWatchTimer.Start()
        RandomTimer.Enabled = True
        RandomTimer.Enabled = False
        ChangeTimer.Enabled = True
        Bulb1PictureBox.Image = My.Resources.kp
        Bulb2PictureBox.Image = My.Resources.kp
        RandomTimer.Enabled = True
        ChangeTimer.Enabled = False
    End Sub
    Sub startEasy()
        Level()
        'Setting the difficulty of the level from 2 timers - Easy level
        RandomTimer.Interval = 850
        ChangeTimer.Interval = 1350
    End Sub
    Sub startVeryHard()
        Level()
        'Setting the difficulty of the level from 2 timers - very hard level
        RandomTimer.Interval = 400
        ChangeTimer.Interval = 400
    End Sub
    Sub startHard()
        Level()
        'Setting the difficulty of the level from 2 timers - hard level
        RandomTimer.Interval = 600
        ChangeTimer.Interval = 600
    End Sub
    Sub startMedium()
        Level()
        'Setting the difficulty of the level from 2 timers - medium level
        RandomTimer.Interval = 850
        ChangeTimer.Interval = 850
    End Sub
    Sub Vreme()
        'Finished Test function
        StopWatchTimer.Stop()
        StopWatchTimer.Enabled = False
        StartStopButton.Text = "Старт"
        StopWatchTimer.Stop()
        SW.Stop()
        TimeLabel.Text = SW.Elapsed.ToString
        RandomTimer.Enabled = False
        ChangeTimer.Enabled = False
        TimeTestTimer.Enabled = False
        LevelPanel.Enabled = True
        Bulb1PictureBox.Image = My.Resources.kp
        Bulb2PictureBox.Image = My.Resources.kp
        Bulb1PictureBox.Enabled = False
        Bulb2PictureBox.Enabled = False
    End Sub
    Sub AddScoreToDB()
        'Adding the score to database
        DatabaseContent.UpdateDatabase.AddBulbsTestScore(Integer.Parse(NumberOfCorrectAnswers.Text), Integer.Parse(NumberOfWrongAnswers.Text), Integer.Parse(NumberOfMissed.Text))
    End Sub

    Sub Minn1()
        'Finished test - 1 minute
        Vreme()
        TimeLabel.Text = "00:01:00.0000000"
        'Adding the score to DataBase
        AddScoreToDB()
    End Sub
    Sub Minn2()
        'Finished test - 2 minutes
        Vreme()
        TimeLabel.Text = "00:02:00.0000000"
        'Adding the score to DataBase
        AddScoreToDB()
    End Sub
    Sub Minn3()
        'Finished test - 3 minutes
        Vreme()
        TimeLabel.Text = "00:03:00.0000000"
        'Adding the score to DataBase
        AddScoreToDB()
    End Sub
    Sub Minn5()
        'Finished test - 5 minutes
        Vreme()
        TimeLabel.Text = "00:05:00.0000000"
        'Adding the score to DataBase
        AddScoreToDB()
    End Sub
    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click
        NumberOfCorrectAnswers.Text = "0"
        NumberOfWrongAnswers.Text = "0"
        NumberOfMissed.Text = "0"
        missed = 0
        'Setting the interval of TimeTestTimer according to what time we have chosen
        If Min1.Checked Then
            TimeTestTimer.Interval = 60000
            TimeTestTimer.Start()
        End If
        If Min2.Checked Then
            TimeTestTimer.Interval = 120000
            TimeTestTimer.Start()
        End If
        If Min3.Checked Then
            TimeTestTimer.Interval = 180000
            TimeTestTimer.Start()
        End If
        If Min5.Checked Then
            TimeTestTimer.Interval = 300000
            TimeTestTimer.Start()
        End If
        Select Case StartStopButton.Text
            Case "Старт"
                'Starting easy level of difficulty
                If Easy.Checked Then
                    startEasy()
                End If
                'Starting very hard level of difficulty
                If VeryHard.Checked Then
                    startVeryHard()
                End If
                'Starting hard level of difficulty
                If Hard.Checked Then
                    startHard()
                End If
                'Starting medium level of difficulty
                If Medium.Checked Then
                    startMedium()
                End If
                LevelPanel.Enabled = False
                TimePanel.Enabled = False
            Case "Стоп"
                'Stop button function
                StartStopButton.Text = "Старт"
                Min1.Checked = True
                Easy.Checked = True
                StopWatchTimer.Stop()
                SW.Stop()
                TimeLabel.Text = SW.Elapsed.ToString
                RandomTimer.Enabled = False
                ChangeTimer.Enabled = False
                Bulb1PictureBox.Image = My.Resources.kp
                Bulb2PictureBox.Image = My.Resources.kp
                TimeTestTimer.Stop()
                LevelPanel.Enabled = True
                TimePanel.Enabled = True
        End Select
    End Sub

    Private Sub Bulb1PictureBox_Click(sender As Object, e As EventArgs) Handles Bulb1PictureBox.Click
        'Determine if the answer is correct or wrong in Bulb1PictureBox
        If Random2 = 1 And Random1 = 1 Then
            CorrectAnswer()
        End If
        If Random2 = 1 And Random1 = 2 Then
            WrongAnswer()
        End If
        If Random2 = 1 And Random1 = 3 Then
            WrongAnswer()
        End If
        If Random2 = 2 Then
            WrongAnswer()
        End If
        Bulb1PictureBox.Enabled = False
    End Sub
    Private Sub Bulb2PictureBox_Click(sender As Object, e As EventArgs) Handles Bulb2PictureBox.Click
        'Determine if the answer is correct or wrong in Bulb2PictureBox
        If Random1 = 3 Then
            WrongAnswer()
        End If
        If Random1 = 2 And Random2 = 3 Then
            CorrectAnswer()
        End If
        If Random1 = 2 And Random2 = 1 Then
            WrongAnswer()
        End If
        If Random1 = 2 And Random2 = 2 Then
            WrongAnswer()
        End If
        Bulb2PictureBox.Enabled = False
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exit button click
        Me.Close()
    End Sub
    Private Sub RandomTimer_Tick(sender As Object, e As EventArgs) Handles RandomTimer.Tick
        If Bulb1PictureBox.Enabled = False And Bulb2PictureBox.Enabled = False Then
            Bulb1PictureBox.Enabled = True
            Bulb2PictureBox.Enabled = True
        End If
        'Random function, which shows the bulbs in Bulb1PictureBox
        Dim vqrno As Random
        vqrno = New Random
        Random2 = vqrno.Next(1, 4)
        TextBox4.Text = Random2.ToString
        If Random2 = 1 Then
            Bulb1PictureBox.Image = My.Resources.green1
        End If
        If Random2 = 2 Then
            Bulb1PictureBox.Image = My.Resources.red1
        End If
        'Random function, which shows the bulbs in Bulb2PictureBox
        Dim random As Random
        random = New Random
        Random1 = random.Next(1, 5)
        TextBox3.Text = Random1.ToString
        If Random1 = 3 Then
            Bulb2PictureBox.Image = My.Resources.red1
        End If
        If Random1 = 2 Then
            Bulb2PictureBox.Image = My.Resources.green1
        End If
        Bulb2PictureBox.Enabled = True
        Bulb2PictureBox.Visible = True
        RandomTimer.Enabled = False
        ChangeTimer.Enabled = True
    End Sub
    Private Sub ChangeTimer_Tick(sender As Object, e As EventArgs) Handles ChangeTimer.Tick
        'Changing the bulbs with gray background
        Bulb1PictureBox.Image = My.Resources.kp
        Bulb2PictureBox.Image = My.Resources.kp
        Bulb1PictureBox.Enabled = False
        Bulb2PictureBox.Enabled = False
        MissedClick()
        RandomTimer.Enabled = True
        ChangeTimer.Enabled = False
    End Sub

    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        'Restarting the test
        ListOfResults.Items.Clear()
        NumberOfCorrectAnswers.Text = "0"
        NumberOfWrongAnswers.Text = "0"
        NumberOfMissed.Text = "0"
        missed = 0
        LevelPanel.Enabled = False
        LevelPanel.Enabled = True
        TimePanel.Enabled = False
        TimePanel.Enabled = True
        Min1.Checked = False
        Min2.Checked = False
        Min3.Checked = False
        Min5.Checked = False
        Easy.Checked = False
        Medium.Checked = False
        Hard.Checked = False
        VeryHard.Checked = False
        StartStopButton.Text = "Старт"
        SW = Stopwatch.StartNew
        StopWatchTimer.Interval = 1
        StopWatchTimer.Stop()
        SW.Stop()
        TimeLabel.Text = "00:00:00:0000000"
        RandomTimer.Enabled = False
        ChangeTimer.Enabled = False
        Bulb1PictureBox.Image = My.Resources.kp
        Bulb2PictureBox.Image = My.Resources.kp
    End Sub
    Private Sub ExitMenu_Click(sender As Object, e As EventArgs) Handles ExitMenu.Click
        'Exit from the Menu
    End Sub
    Private Sub Instructions_Click(sender As Object, e As EventArgs) Handles Instructions.Click
        'Showing Instruction Form from the Menu
        HelpForm.Show()
    End Sub
    Private Sub ProgramHelpButton_Click(sender As Object, e As EventArgs) Handles ProgramHelpButton.Click
        'Showing Instruction form
        HelpForm.Show()
    End Sub
    Private Sub ClearScreenButton_Click(sender As Object, e As EventArgs) Handles ClearScreenButton.Click
        'Erasing the items from the ListOfResults and the labels which are showing our right, wrong and missed answers
        ListOfResults.Items.Clear()
        NumberOfCorrectAnswers.Text = "0"
        NumberOfMissed.Text = "0"
        NumberOfWrongAnswers.Text = "0"
    End Sub
    Private Sub SaveResultsButton_Click(sender As Object, e As EventArgs) Handles SaveResultsButton.Click
        'Opening the Saving Results Form
        SaveForm.Show()
    End Sub
    'Hoover effect for the Exit button
    Private Sub ExitButton_MouseEnter(sender As Object, e As EventArgs) Handles ExitButton.MouseEnter
        ExitButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub ExitButton_MouseLeave(sender As Object, e As EventArgs) Handles ExitButton.MouseLeave
        ExitButton.BackgroundImage = My.Resources.Button2
    End Sub
    'Hoover effect for the Restart button
    Private Sub RestartButton_MouseEnter(sender As Object, e As EventArgs) Handles RestartButton.MouseEnter
        RestartButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub RestartButton_MouseLeave(sender As Object, e As EventArgs) Handles RestartButton.MouseLeave
        RestartButton.BackgroundImage = My.Resources.Button2
    End Sub
    'Hoover effect for the Instructions button
    Private Sub ProgramHelpButton_MouseEnter(sender As Object, e As EventArgs) Handles ProgramHelpButton.MouseEnter
        ProgramHelpButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub ProgramHelpButton_MouseLeave(sender As Object, e As EventArgs) Handles ProgramHelpButton.MouseLeave
        ProgramHelpButton.BackgroundImage = My.Resources.Button2
    End Sub
    'Hoover effect for the SaveResults button
    Private Sub SaveResultsButton_MouseEnter(sender As Object, e As EventArgs) Handles SaveResultsButton.MouseEnter
        SaveResultsButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub SaveResultsButton_MouseLeave(sender As Object, e As EventArgs) Handles SaveResultsButton.MouseLeave
        SaveResultsButton.BackgroundImage = My.Resources.Button2
    End Sub
    'Hoover effect for the ClearScreen button
    Private Sub ClearScreenButton_MouseEnter(sender As Object, e As EventArgs) Handles ClearScreenButton.MouseEnter
        ClearScreenButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub ClearScreenButton_MouseLeave(sender As Object, e As EventArgs) Handles ClearScreenButton.MouseLeave
        ClearScreenButton.BackgroundImage = My.Resources.Button2
    End Sub
    'Hoover effect for the Start/Stop button
    Private Sub StartStopButton_MouseEnter(sender As Object, e As EventArgs) Handles StartStopButton.MouseEnter
        StartStopButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub StartStopButton_MouseLeave(sender As Object, e As EventArgs) Handles StartStopButton.MouseLeave
        StartStopButton.BackgroundImage = My.Resources.Button2
    End Sub
    Private Sub SaveResultMenu_Click(sender As Object, e As EventArgs) Handles SaveResultMenu.Click
        'Showing the form for saving results
        SaveForm.Show()
    End Sub
    Private Sub TimeTestTimer_Tick(sender As Object, e As EventArgs) Handles TimeTestTimer.Tick
        'Set the time of test to 1 minute 
        If Min1.Checked Then
            Minn1()
            TimeTestTimer.Stop()
            TimePanel.Enabled = True
        End If
        'Set the time of test to 2 minutes        
        If Min2.Checked Then
            Minn2()
            TimeTestTimer.Stop()
            TimePanel.Enabled = True
        End If
        'Set the time of test to 3 minutes 
        If Min3.Checked Then
            Minn3()
            TimeTestTimer.Stop()
            TimePanel.Enabled = True
        End If
        'Set the time of test to 5 minutes 
        If Min5.Checked Then
            Minn5()
            TimeTestTimer.Stop()
            TimePanel.Enabled = True
        End If
    End Sub
    Private Sub BulbForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Min1.Checked = True
        Easy.Checked = True
    End Sub
End Class

