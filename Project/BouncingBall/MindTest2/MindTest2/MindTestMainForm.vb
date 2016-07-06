Public Class MindTestMainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GoToTest.Click
        'Checking the level of difficulty
        If VeryHard.Checked = True Then
            VeryHardLevel.Show()
        End If
        If Hard.Checked = True Then
            LevelHard.Show()
        End If
        If Medium.Checked = True Then
            MediumLevel.Show()
        End If
        If Easy.Checked = True Then
            EasyLevel.Show()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Easy.Checked = True
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    'Hover effect for GoToTest button
    Private Sub GoToTest_MouseEnter(sender As Object, e As EventArgs) Handles GoToTest.MouseEnter
        GoToTest.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub GoToTest_MouseLeave(sender As Object, e As EventArgs) Handles GoToTest.MouseLeave
        GoToTest.BackgroundImage = My.Resources.Button2
    End Sub
    'Hover effect for the Exit button
    Private Sub ExitButton_MouseEnter(sender As Object, e As EventArgs) Handles ExitButton.MouseEnter
        ExitButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub ExitButton_MouseLeave(sender As Object, e As EventArgs) Handles ExitButton.MouseLeave
        ExitButton.BackgroundImage = My.Resources.Button2
    End Sub
    Private Sub AboutButton_Click_1(sender As Object, e As EventArgs) Handles AboutButton.Click
        AboutTheTestForm.Show()
    End Sub
    'Hover effect for the About button
    Private Sub AboutButton_MouseEnter(sender As Object, e As EventArgs) Handles AboutButton.MouseEnter
        AboutButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub AboutButton_MouseLeave(sender As Object, e As EventArgs) Handles AboutButton.MouseLeave
        AboutButton.BackgroundImage = My.Resources.Button2
    End Sub
End Class