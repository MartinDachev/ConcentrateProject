Public Class SettingsForm
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        '1 minute setting
        If Minute1.Checked = True Then
            Test.MinutesLabel.Text = "01"
            TrainForm.MinutesLabel.Text = "01"
            Test.SecondsLabel.Text = "00"
            TrainForm.TimeLabel.Text = "00"
            Test.StartButton.Enabled = True
            TrainForm.StartButton.Enabled = True
        End If
        '30 seconds setting
        If Seconds30.Checked = True Then
            Test.SecondsLabel.Text = "30"
            TrainForm.TimeLabel.Text = "30"
            Test.StartButton.Enabled = True
            TrainForm.StartButton.Enabled = True
        End If
        '2 minutes setting
        If Minute2.Checked = True Then
            Test.MinutesLabel.Text = "02"
            TrainForm.MinutesLabel.Text = "02"
            Test.SecondsLabel.Text = "00"
            TrainForm.TimeLabel.Text = "00"
            Test.StartButton.Enabled = True
            TrainForm.StartButton.Enabled = True
        End If
        '3 minutes setting
        If Minute3.Checked = True Then
            Test.MinutesLabel.Text = "03"
            TrainForm.MinutesLabel.Text = "03"
            Test.SecondsLabel.Text = "00"
            TrainForm.TimeLabel.Text = "00"
            Test.StartButton.Enabled = True
            TrainForm.StartButton.Enabled = True
        End If
        Me.Close()
    End Sub
    'Hoover effect for the OK button
    Private Sub OKButton_MouseEnter(sender As Object, e As EventArgs) Handles OKButton.MouseEnter
        OKButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub OKButton_MouseLeave(sender As Object, e As EventArgs) Handles OKButton.MouseLeave
        OKButton.BackgroundImage = My.Resources.Button2
    End Sub
End Class