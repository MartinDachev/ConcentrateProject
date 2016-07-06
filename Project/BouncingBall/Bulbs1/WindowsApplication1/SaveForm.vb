Public Class SaveForm
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        'Showing SaveMessageBox form
        Beep()
        SaveMessageBox.Show()
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Check whether we have entered our names
        If FirstName.Text = "" Then
            MessageBox.Show("Не сте записали Вашето име", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If SecondName.Text = "" Then
            MessageBox.Show("Не сте записали Вашето бащино име", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ThirdName.Text = "" Then
            MessageBox.Show("Не сте записали Вашата фамилия", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'If we have entered our names, SaveFileDialog will be shown
        If FirstName.Text <> "" And SecondName.Text <> "" And ThirdName.Text <> "" Then
            SaveFileDialog1.ShowDialog()
        End If
    End Sub
    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        'Creating the file with our result.
        SaveFileDialog1.Filter = "Rich Text Files|*.rtf|Text Files|*.txt"
        Dim writer As New IO.StreamWriter(SaveFileDialog1.FileName)
        writer.Write(NameLabel.Text)
        writer.Write(FirstName.Text)
        'New line in the created file
        writer.Write(NewLine.Text)
        writer.Write(NewLine.Text)
        writer.Write(SecondNameLabel.Text)
        writer.Write(SecondName.Text)
        writer.Write(NewLine.Text)
        writer.Write(NewLine.Text)
        writer.Write(ThirdNameLabel.Text)
        writer.Write(ThirdName.Text)
        writer.Write(NewLine.Text)
        writer.Write(NewLine.Text)
        writer.Write(BulbForm.TrueLabel.Text)
        writer.Write(BulbForm.NumberOfCorrectAnswers.Text)
        writer.Write(NewLine.Text)
        writer.Write(NewLine.Text)
        writer.Write(BulbForm.IncorrectLabel.Text)
        writer.Write(BulbForm.NumberOfWrongAnswers.Text)
        writer.Write(NewLine.Text)
        writer.Write(NewLine.Text)
        writer.Write(BulbForm.PropusnatiLabel.Text)
        writer.Write(BulbForm.NumberOfMissed.Text)
        writer.Write(NewLine.Text)
        writer.Write(NewLine.Text)
        writer.Write("Резултат за интервал от време : ")
        writer.Write(BulbForm.TimeLabel.Text)
        writer.Write(NewLine.Text)
        writer.Write(NewLine.Text)
        If BulbForm.NumberOfCorrectAnswers.Text < BulbForm.NumberOfWrongAnswers.Text And BulbForm.NumberOfCorrectAnswers.Text <> "0" Then
            writer.Write("Вашият резултат е лош")
            writer.Write(NewLine.Text)
            writer.Write(NewLine.Text)
        End If
        If BulbForm.NumberOfCorrectAnswers.Text = "0" And BulbForm.NumberOfWrongAnswers.Text <> "0" Then
            writer.Write("Вашият резултат е много лош")
            writer.Write(NewLine.Text)
            writer.Write(NewLine.Text)
        End If
        If BulbForm.NumberOfCorrectAnswers.Text = BulbForm.NumberOfWrongAnswers.Text Then
            writer.Write("Вашият резултат не е много добър")
            writer.Write(NewLine.Text)
            writer.Write(NewLine.Text)
        End If
        If BulbForm.NumberOfCorrectAnswers.Text > BulbForm.NumberOfWrongAnswers.Text And BulbForm.NumberOfWrongAnswers.Text <> "0" Then
            writer.Write("Вашият резултат е задоволителен")
            writer.Write(NewLine.Text)
            writer.Write(NewLine.Text)
        End If
        If BulbForm.NumberOfWrongAnswers.Text = "0" And BulbForm.NumberOfCorrectAnswers.Text <> "0" Then
            writer.Write("Вашият резултат е отличен")
            writer.Write(NewLine.Text)
            writer.Write(NewLine.Text)
        End If
        writer.Close()
    End Sub
    'Hoover effect for the Save button
    Private Sub SaveButton_MouseEnter(sender As Object, e As EventArgs) Handles SaveButton.MouseEnter
        SaveButton.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub SaveButton_MouseLeave(sender As Object, e As EventArgs) Handles SaveButton.MouseLeave
        SaveButton.BackgroundImage = My.Resources.Button2
    End Sub
    'Hoover effect for the Cancel button
    Private Sub CancelButton_MouseEnter(sender As Object, e As EventArgs) Handles CancelButton1.MouseEnter
        CancelButton1.BackgroundImage = My.Resources.Button3
    End Sub
    Private Sub CancelButton_MouseLeave(sender As Object, e As EventArgs) Handles CancelButton1.MouseLeave
        CancelButton1.BackgroundImage = My.Resources.Button2
    End Sub
End Class