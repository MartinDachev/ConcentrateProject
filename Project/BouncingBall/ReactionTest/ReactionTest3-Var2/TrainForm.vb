Public Class TrainForm
    'PictureArray of PictureBoxes
    Dim PictureArray(60) As PictureBox
    'Random1 is for the location of the plus
    Dim Random1 As Integer
    'Booleans used for the clicked pluses
    Dim Change As Boolean = False
    Dim PointsBool As Boolean = False
    Public Sub ButtonClick()
        'Start button function
        If MinutesLabel.Text = "00" And TimeLabel.Text = "00" Then
            SettingsForm.Show()
        Else
            StartTimer.Start()
            StartButton.Enabled = False
            SwapTimer.Start()
            StopTimer.Start()
            Change = False
            Points.Text = "0"
        End If
    End Sub
    Sub ClickFunc()
        'Click function
        Dim p As Integer
        PointsBool = True
        For p = 1 To 60 Step 1
            PictureArray(p).BackgroundImage = My.Resources.images
        Next
        Change = True
    End Sub
    Sub GenerateRandomNumbers1()
        'Generating Random Numbers function
        Dim random As Random
        random = New Random
        Random1 = random.Next(1, 61)
        Change = True
        PointsBool = False
        'Adding Handler for clicked picture box
        AddHandler PictureArray(Random1).Click, AddressOf All_Buttons_Click
    End Sub
    Sub CreatePictureBox()
        'Creating PictureBoxes
        Dim horizontal As Integer = 40
        Dim vertical As Integer = 40
        Dim p As Integer
        For p = 1 To 60 Step 1
            PictureArray(p) = New PictureBox
            PictureArray(p).BackColor = Color.Black
            PictureArray(p).Size = New Size(25, 25)
            PictureArray(p).Location = New Point(horizontal, vertical)
            If p = 6 Or p = 12 Or p = 18 Or p = 24 Or p = 30 Or p = 36 Or p = 42 Or p = 48 Or p = 54 Or p = 60 Then
                vertical = 40
                horizontal = horizontal + 75
            Else : vertical = vertical + 75
                Controls.Add(PictureArray(p))
            End If
        Next
        'Adding the hidden PictureBoxes
        Controls.Add(PictureArray(6))
        Controls.Add(PictureArray(12))
        Controls.Add(PictureArray(18))
        Controls.Add(PictureArray(24))
        Controls.Add(PictureArray(30))
        Controls.Add(PictureArray(36))
        Controls.Add(PictureArray(42))
        Controls.Add(PictureArray(48))
        Controls.Add(PictureArray(54))
        Controls.Add(PictureArray(60))
    End Sub
    Private Sub TrainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreatePictureBox()
    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        ButtonClick()
        Points.Text = "0"
    End Sub
    Private Sub StartTimer_Tick(sender As Object, e As EventArgs) Handles StartTimer.Tick
        'Showing plus in picture box and adding 1 to points value
        If PointsBool = True Then
            Points.Text += 1
        End If
        GenerateRandomNumbers1()
        PictureArray(Random1).BackgroundImage = My.Resources.Plus
    End Sub
    Private Sub All_Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PictureBox click event
        ClickFunc()
        Change = False
        PictureArray(Random1).Enabled = False
    End Sub
    Private Sub SwapTimer_Tick(sender As Object, e As EventArgs) Handles SwapTimer.Tick
        'Changing the location of the plus
        If Change = True Then
            StartTimer.Stop()
            PictureArray(Random1).Enabled = True
        Else : StartTimer.Start()
        End If
    End Sub
    Private Sub StopTimer_Tick(sender As Object, e As EventArgs) Handles StopTimer.Tick
        'Timer for the time of the test
        If TimeLabel.Text = 0 Then
            MinutesLabel.Text -= 1
            TimeLabel.Text = 60
        End If
        TimeLabel.Text -= 1
        If (TimeLabel.Text = "0" And MinutesLabel.Text = "0") Or (TimeLabel.Text = "0" And MinutesLabel.Text = "00") Then
            SwapTimer.Stop()
            StartTimer.Stop()
            StartButton.Enabled = True
            StopTimer.Stop()
            TimeLabel.Text = "00"
            MinutesLabel.Text = "00"
            Dim BlackImage As Integer
            For BlackImage = 1 To 60 Step 1
                PictureArray(BlackImage).BackgroundImage = My.Resources.images
            Next
            'Adding the score to database
            DatabaseContent.UpdateDatabase.AddReactionTest3Score(Integer.Parse(Points.Text))
        End If
    End Sub
    'Hoover effect for the Start button
    Private Sub StartButton_MouseEnter(sender As Object, e As EventArgs) Handles StartButton.MouseEnter
        StartButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub StartButton_MouseLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave
        StartButton.BackgroundImage = My.Resources.Button2
    End Sub
End Class