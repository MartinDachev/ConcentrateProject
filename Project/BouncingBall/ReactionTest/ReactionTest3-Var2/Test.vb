Public Class Test
    'Array of PictureBoxes
    Dim array(60) As PictureBox
    'RandomMaker is for the location of the plus
    Dim RandomMaker As Integer
    Dim CheckValue As Boolean = True
    Dim MissedClick As Boolean = True
    'count is the value of the points
    Dim count As Integer = 0
    Sub GenerateRandomNumbers()
        'Generating Random Numbers function
        Dim Number As Random
        Number = New Random
        RandomMaker = Number.Next(1, 61)
        'Adding Handler for clicked picture box
        AddHandler array(RandomMaker).Click, AddressOf All_Buttons_Click
    End Sub
    Sub ClickFunc()
        'Click function
        Dim p As Integer
        MissedClick = False
        For p = 1 To 60 Step 1
            'When plus is clicked - the background of the picture box is changing to black. In this way the plus is prevented from click more than once.
            array(p).BackgroundImage = My.Resources.images
        Next
    End Sub
    Sub CreatePictureBox()
        'Creating PictureBoxes
        Dim horizontal As Integer = 40
        Dim vertical As Integer = 40
        Dim p As Integer
        For p = 1 To 60 Step 1
            array(p) = New PictureBox
            array(p).BackColor = Color.Black
            array(p).Size = New Size(25, 25)
            array(p).Location = New Point(horizontal, vertical)
            If p = 6 Or p = 12 Or p = 18 Or p = 24 Or p = 30 Or p = 36 Or p = 42 Or p = 48 Or p = 54 Or p = 60 Then
                vertical = 40
                horizontal = horizontal + 75
            Else : vertical = vertical + 75
                Controls.Add(array(p))
            End If
        Next
        'Adding the hidden PictureBoxes
        Controls.Add(array(6))
        Controls.Add(array(12))
        Controls.Add(array(18))
        Controls.Add(array(24))
        Controls.Add(array(30))
        Controls.Add(array(36))
        Controls.Add(array(42))
        Controls.Add(array(48))
        Controls.Add(array(54))
        Controls.Add(array(60))
    End Sub
    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreatePictureBox()
    End Sub
    Private Sub All_Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClickFunc()
        array(RandomMaker).Enabled = False
    End Sub
    Private Sub RandomTimer_Tick(sender As Object, e As EventArgs) Handles RandomTimer.Tick
        'Showing plus in picture box
        If CheckValue = True Then
            GenerateRandomNumbers()
            MissedClick = True
            array(RandomMaker).BackgroundImage = My.Resources.Plus
            CheckValue = False
            SwapTimer.Start()
            array(RandomMaker).Enabled = True
        End If
    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        'Checking if the time of the test is set
        If MinutesLabel.Text = "00" And SecondsLabel.Text = "0" Or MinutesLabel.Text = "0" And SecondsLabel.Text = "0" Or MinutesLabel.Text = "00" And SecondsLabel.Text = "00" Then
            SettingsForm.Show()
        ElseIf MinutesLabel.Text <> "00" Or SecondsLabel.Text <> "00" Then
            MissedPlus.Text = "0"
            ClickedPlus.Text = "0"
            StartButton.Enabled = False
            RandomTimer.Start()
            CountdownTimer.Start()
            StartButton.Enabled = False
            CheckValue = True
            MissedClick = True
        End If
    End Sub
    Private Sub SwapTimer_Tick(sender As Object, e As EventArgs) Handles SwapTimer.Tick
        'Hiding plus if it is not clicked
        If MissedClick = True Then
            array(RandomMaker).Enabled = False
            MissedPlus.Text += 1
        Else : ClickedPlus.Text += 1
        End If
        CheckValue = True
        SwapTimer.Stop()
        array(RandomMaker).BackgroundImage = My.Resources.images
    End Sub
    'Hoover effect for the Start button
    Private Sub StartButton_MouseEnter(sender As Object, e As EventArgs) Handles StartButton.MouseEnter
        StartButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub StartButton_MouseLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave
        StartButton.BackgroundImage = My.Resources.Button2
    End Sub
    Private Sub ContdownTimer_Tick(sender As Object, e As EventArgs) Handles CountdownTimer.Tick
        'Timer for the time of the test
        If SecondsLabel.Text = 0 Then
            MinutesLabel.Text -= 1
            SecondsLabel.Text = 60
        End If
        SecondsLabel.Text -= 1
        If (SecondsLabel.Text = "0" And MinutesLabel.Text = "0") Or (SecondsLabel.Text = "0" And MinutesLabel.Text = "00") Then
            SwapTimer.Stop()
            StartButton.Enabled = True
            RandomTimer.Stop()
            SecondsLabel.Text = "00"
            CountdownTimer.Stop()
            Dim s As Integer
            For s = 1 To 60 Step 1
                array(s).BackgroundImage = My.Resources.images
            Next
        End If
    End Sub
End Class
