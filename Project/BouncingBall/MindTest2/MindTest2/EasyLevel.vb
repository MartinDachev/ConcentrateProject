Public Class EasyLevel
    'Random1 is for the saving the generated numbers
    Dim Random1 As Integer
    'Tick checks if RandomTimer ticked
    Dim Tick As Boolean = False
    'array(6) and array2(6) are arrays which are generating textboxes
    Dim array(6) As TextBox
    Dim array2(6) As TextBox
    'AddValue is used for the textboxes values.
    Dim AddValue As Integer = 1
    Dim gameScore As Integer = 0
    Sub GenerateRandomNumbers()
        'Generating Random numbers function
        Dim Number As Random
        Number = New Random
        Random1 = Number.Next(1, 100)
    End Sub
    Sub CreateTextBox()
        'Creating textboxes and setting their location from array(6)
        Dim horizontal As Integer = 40
        Dim vertical As Integer = 40
        Dim p As Integer
        For p = 1 To 6 Step 1
            array(p) = New TextBox
            array(p).Enabled = False
            array(p).BackColor = Color.LightBlue
            array(p).Multiline = True
            array(p).TextAlign = HorizontalAlignment.Center
            array(p).Font = New Font("Verdana", "12")
            array(p).Size = New Size(100, 30)
            array(p).Location = New Point(horizontal, vertical)
            If p = 3 Or p = 6 Then
                vertical = 40
                horizontal = horizontal + 110
            Else : vertical = vertical + 40
                Controls.Add(array(p))
            End If
            Controls.Add(array(3))
            Controls.Add(array(6))
        Next
    End Sub
    Sub CreateTextBox2()
        'Creating textboxes and setting their location from array2(6)
        Dim horizontal As Integer = 330
        Dim vertical As Integer = 40
        Dim p As Integer
        For p = 1 To 6 Step 1
            array2(p) = New TextBox
            array2(p).Multiline = True
            array2(p).TextAlign = HorizontalAlignment.Center
            array2(p).Font = New Font("Verdana", "12")
            array2(p).Size = New Size(100, 30)
            array2(p).Location = New Point(horizontal, vertical)
            If p = 3 Or p = 6 Then
                vertical = 40
                horizontal = horizontal + 110
            Else : vertical = vertical + 40
                Controls.Add(array2(p))
            End If
            Controls.Add(array2(3))
            Controls.Add(array2(6))
        Next
    End Sub
    Private Sub EasyLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateTextBox()
        CreateTextBox2()
        Dim Count As Integer
        For Count = 1 To 6 Step 1
            array2(Count).Enabled = False
        Next
        'Setting the color of the textboxes under the Legend label
        Example1.BackColor = Color.LightSkyBlue
        Example2.BackColor = Color.LightGreen
        Example3.BackColor = Color.Salmon
    End Sub
    Private Sub ShowTextBox_Tick(sender As Object, e As EventArgs) Handles ShowTextBox.Tick
        ShowTextBox.Stop()
    End Sub
    Private Sub RandomNumbers_Tick(sender As Object, e As EventArgs) Handles RandomNumbers.Tick
        'Setting values to the textboxes from array(6)
        Tick = True
        GenerateRandomNumbers()
        array(AddValue).Text = Random1.ToString
        AddValue += 1
        If AddValue = 7 Then
            RandomNumbers.Stop()
        End If
    End Sub
    Private Sub RememberTimer_Tick(sender As Object, e As EventArgs) Handles RememberTimer.Tick
        'Hiding the array(6) textboxes and showing array2(6) textboxes
        Dim Count As Integer
        For Count = 1 To 6 Step 1
            array2(Count).Enabled = True
            array(Count).Visible = False
        Next
    End Sub
    Private Sub StartButton_Click_1(sender As Object, e As EventArgs) Handles StartButton.Click
        'Starting the test
        ShowTextBox.Start()
        RandomNumbers.Start()
        RememberTimer.Start()
        StartButton.Enabled = False
    End Sub
    Private Sub ReadyButton_Click(sender As Object, e As EventArgs) Handles ReadyButton.Click
        'Comparing the answers with the values from the textboxes from array(6)
        Dim Check1 As Integer
        For Check1 = 1 To 6 Step 1
            If array(Check1).Text = array2(Check1).Text Then
                'If the answer is correct, the textbox backcolor is changing to green
                array2(Check1).BackColor = Color.LightGreen
                gameScore += 10
            End If
            If array(Check1).Text <> array2(Check1).Text Then
                'If the answer is wrong, the textbox backcolor is changing to red
                array2(Check1).BackColor = Color.Salmon
            End If
            If array2(Check1).Text = "" Then
                'If we don't have an answer - the textbox backcolor is painted in blue
                array2(Check1).BackColor = Color.LightSkyBlue
            End If
            array(Check1).Visible = True
            array(Check1).Enabled = False
            array2(Check1).Enabled = False
            ShowTextBox.Stop()
            RememberTimer.Stop()
            RandomNumbers.Stop()
        Next
        'Adding the result to database
        DatabaseContent.UpdateDatabase.AddMindTest2EasyScore(gameScore)
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    'Hover effect for the Start button
    Private Sub StartButton_MouseEnter(sender As Object, e As EventArgs) Handles StartButton.MouseEnter
        StartButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub StartButton_MouseLeave(sender As Object, e As EventArgs) Handles StartButton.MouseLeave
        StartButton.BackgroundImage = My.Resources.Button2
    End Sub
    'Hover effect for the Ready button 
    Private Sub ReadyButton_MouseEnter(sender As Object, e As EventArgs) Handles ReadyButton.MouseEnter
        ReadyButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub ReadyButton_MouseLeave(sender As Object, e As EventArgs) Handles ReadyButton.MouseLeave
        ReadyButton.BackgroundImage = My.Resources.Button2
    End Sub
    'Hover effect for the Ready button
    Private Sub ExitButton_MouseEnter(sender As Object, e As EventArgs) Handles ExitButton.MouseEnter
        ExitButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub ExitButton_MouseLeave(sender As Object, e As EventArgs) Handles ExitButton.MouseLeave
        ExitButton.BackgroundImage = My.Resources.Button2
    End Sub
End Class