Public Class ChooseForm
    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        SettingsForm.Show()
    End Sub
    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click
        Test.Show()
    End Sub
    Private Sub TrainButton_Click(sender As Object, e As EventArgs) Handles TrainButton.Click
        TrainForm.Show()
    End Sub
    'Hover effect for the Settings button
    Private Sub SettingsButton_MouseEnter(sender As Object, e As EventArgs) Handles SettingsButton.MouseEnter
        SettingsButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub SettingsButton_MouseLeave(sender As Object, e As EventArgs) Handles SettingsButton.MouseLeave
        SettingsButton.BackgroundImage = My.Resources.Button2
    End Sub
    'Hover effect for the Test button
    Private Sub TestButton_MouseEnter(sender As Object, e As EventArgs) Handles TestButton.MouseEnter
        TestButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub TestButton_MouseLeave(sender As Object, e As EventArgs) Handles TestButton.MouseLeave
        TestButton.BackgroundImage = My.Resources.Button2
    End Sub
    'Hover effect for the Train button
    Private Sub TrainButton_MouseEnter(sender As Object, e As EventArgs) Handles TrainButton.MouseEnter
        TrainButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub TrainButton_MouseLeave(sender As Object, e As EventArgs) Handles TrainButton.MouseLeave
        TrainButton.BackgroundImage = My.Resources.Button2
    End Sub
    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
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