Public Class SaveMessageBox
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        SaveForm.Close()
        Me.Close()
        BulbForm.Show()
    End Sub
    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        SaveForm.Show()
        Me.Close()
    End Sub
    'Hoover effect for the Yes button
    Private Sub YesButton_MouseEnter(sender As Object, e As EventArgs) Handles YesButton.MouseEnter
        YesButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub YesButton_MouseLeave(sender As Object, e As EventArgs) Handles YesButton.MouseLeave
        YesButton.BackgroundImage = My.Resources.Button2
    End Sub
    'Hoover effect for the No button
    Private Sub NoButton_MouseEnter(sender As Object, e As EventArgs) Handles NoButton.MouseEnter
        NoButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub NoButton_MouseLeave(sender As Object, e As EventArgs) Handles NoButton.MouseLeave
        NoButton.BackgroundImage = My.Resources.Button2
    End Sub
End Class