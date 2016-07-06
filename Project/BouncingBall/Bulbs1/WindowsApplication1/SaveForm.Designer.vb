<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaveForm))
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.SecondNameLabel = New System.Windows.Forms.Label()
        Me.SecondName = New System.Windows.Forms.TextBox()
        Me.ThirdNameLabel = New System.Windows.Forms.Label()
        Me.ThirdName = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.NewLine = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameLabel.Location = New System.Drawing.Point(79, 29)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(56, 18)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Име : "
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(141, 29)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(310, 20)
        Me.FirstName.TabIndex = 1
        '
        'SecondNameLabel
        '
        Me.SecondNameLabel.AutoSize = True
        Me.SecondNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.SecondNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SecondNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SecondNameLabel.Location = New System.Drawing.Point(21, 74)
        Me.SecondNameLabel.Name = "SecondNameLabel"
        Me.SecondNameLabel.Size = New System.Drawing.Size(118, 18)
        Me.SecondNameLabel.TabIndex = 2
        Me.SecondNameLabel.Text = "Бащино име : "
        '
        'SecondName
        '
        Me.SecondName.Location = New System.Drawing.Point(141, 75)
        Me.SecondName.Name = "SecondName"
        Me.SecondName.Size = New System.Drawing.Size(310, 20)
        Me.SecondName.TabIndex = 3
        '
        'ThirdNameLabel
        '
        Me.ThirdNameLabel.AutoSize = True
        Me.ThirdNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.ThirdNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ThirdNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ThirdNameLabel.Location = New System.Drawing.Point(43, 123)
        Me.ThirdNameLabel.Name = "ThirdNameLabel"
        Me.ThirdNameLabel.Size = New System.Drawing.Size(95, 18)
        Me.ThirdNameLabel.TabIndex = 4
        Me.ThirdNameLabel.Text = "Фамилия : "
        '
        'ThirdName
        '
        Me.ThirdName.Location = New System.Drawing.Point(141, 124)
        Me.ThirdName.Name = "ThirdName"
        Me.ThirdName.Size = New System.Drawing.Size(310, 20)
        Me.ThirdName.TabIndex = 5
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.BackgroundImage = CType(resources.GetObject("SaveButton.BackgroundImage"), System.Drawing.Image)
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.LightCyan
        Me.SaveButton.Location = New System.Drawing.Point(24, 161)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(210, 55)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.TabStop = False
        Me.SaveButton.Text = "Запази"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'CancelButton1
        '
        Me.CancelButton1.BackColor = System.Drawing.Color.Transparent
        Me.CancelButton1.BackgroundImage = CType(resources.GetObject("CancelButton1.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton1.FlatAppearance.BorderSize = 0
        Me.CancelButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CancelButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CancelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton1.ForeColor = System.Drawing.Color.LightCyan
        Me.CancelButton1.Location = New System.Drawing.Point(242, 161)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(210, 55)
        Me.CancelButton1.TabIndex = 7
        Me.CancelButton1.TabStop = False
        Me.CancelButton1.Text = "Отмяна"
        Me.CancelButton1.UseVisualStyleBackColor = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Лампички |*.txt"
        '
        'NewLine
        '
        Me.NewLine.Location = New System.Drawing.Point(452, 1)
        Me.NewLine.Name = "NewLine"
        Me.NewLine.Size = New System.Drawing.Size(10, 20)
        Me.NewLine.TabIndex = 9
        Me.NewLine.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.NewLine.Visible = False
        '
        'SaveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(463, 225)
        Me.Controls.Add(Me.NewLine)
        Me.Controls.Add(Me.CancelButton1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ThirdName)
        Me.Controls.Add(Me.ThirdNameLabel)
        Me.Controls.Add(Me.SecondName)
        Me.Controls.Add(Me.SecondNameLabel)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.NameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SaveForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Запази резултат"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents FirstName As System.Windows.Forms.TextBox
    Friend WithEvents SecondNameLabel As System.Windows.Forms.Label
    Friend WithEvents SecondName As System.Windows.Forms.TextBox
    Friend WithEvents ThirdNameLabel As System.Windows.Forms.Label
    Friend WithEvents ThirdName As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents NewLine As System.Windows.Forms.TextBox
End Class
