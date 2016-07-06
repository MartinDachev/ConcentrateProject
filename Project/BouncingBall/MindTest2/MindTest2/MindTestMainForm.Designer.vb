<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MindTestMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MindTestMainForm))
        Me.VeryHard = New System.Windows.Forms.RadioButton()
        Me.Hard = New System.Windows.Forms.RadioButton()
        Me.Medium = New System.Windows.Forms.RadioButton()
        Me.Easy = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GoToTest = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AboutButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VeryHard
        '
        Me.VeryHard.AutoSize = True
        Me.VeryHard.BackColor = System.Drawing.Color.Transparent
        Me.VeryHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.VeryHard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VeryHard.Location = New System.Drawing.Point(156, 192)
        Me.VeryHard.Name = "VeryHard"
        Me.VeryHard.Size = New System.Drawing.Size(144, 24)
        Me.VeryHard.TabIndex = 1
        Me.VeryHard.TabStop = True
        Me.VeryHard.Text = "Много трудно"
        Me.VeryHard.UseVisualStyleBackColor = False
        '
        'Hard
        '
        Me.Hard.AutoSize = True
        Me.Hard.BackColor = System.Drawing.Color.Transparent
        Me.Hard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Hard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Hard.Location = New System.Drawing.Point(22, 192)
        Me.Hard.Name = "Hard"
        Me.Hard.Size = New System.Drawing.Size(87, 24)
        Me.Hard.TabIndex = 2
        Me.Hard.TabStop = True
        Me.Hard.Text = "Трудно"
        Me.Hard.UseVisualStyleBackColor = False
        '
        'Medium
        '
        Me.Medium.AutoSize = True
        Me.Medium.BackColor = System.Drawing.Color.Transparent
        Me.Medium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Medium.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Medium.Location = New System.Drawing.Point(156, 122)
        Me.Medium.Name = "Medium"
        Me.Medium.Size = New System.Drawing.Size(91, 24)
        Me.Medium.TabIndex = 3
        Me.Medium.TabStop = True
        Me.Medium.Text = "Средно"
        Me.Medium.UseVisualStyleBackColor = False
        '
        'Easy
        '
        Me.Easy.AutoSize = True
        Me.Easy.BackColor = System.Drawing.Color.Transparent
        Me.Easy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Easy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Easy.Location = New System.Drawing.Point(22, 122)
        Me.Easy.Name = "Easy"
        Me.Easy.Size = New System.Drawing.Size(79, 24)
        Me.Easy.TabIndex = 4
        Me.Easy.TabStop = True
        Me.Easy.Text = "Лесно"
        Me.Easy.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Изберете степен на трудност"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.LightCyan
        Me.ExitButton.Location = New System.Drawing.Point(578, 300)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(210, 55)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.TabStop = False
        Me.ExitButton.Text = "Изход"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'GoToTest
        '
        Me.GoToTest.BackColor = System.Drawing.Color.Transparent
        Me.GoToTest.BackgroundImage = Global.MindTest2.My.Resources.Resources.Button2
        Me.GoToTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GoToTest.FlatAppearance.BorderSize = 0
        Me.GoToTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.GoToTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.GoToTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoToTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GoToTest.ForeColor = System.Drawing.Color.LightCyan
        Me.GoToTest.Location = New System.Drawing.Point(37, 300)
        Me.GoToTest.Name = "GoToTest"
        Me.GoToTest.Size = New System.Drawing.Size(210, 55)
        Me.GoToTest.TabIndex = 0
        Me.GoToTest.TabStop = False
        Me.GoToTest.Text = "Към теста"
        Me.GoToTest.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(308, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(480, 250)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'AboutButton
        '
        Me.AboutButton.BackColor = System.Drawing.Color.Transparent
        Me.AboutButton.BackgroundImage = CType(resources.GetObject("AboutButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutButton.FlatAppearance.BorderSize = 0
        Me.AboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.AboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AboutButton.ForeColor = System.Drawing.Color.LightCyan
        Me.AboutButton.Location = New System.Drawing.Point(308, 300)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(210, 55)
        Me.AboutButton.TabIndex = 13
        Me.AboutButton.TabStop = False
        Me.AboutButton.Text = "Инструкции"
        Me.AboutButton.UseVisualStyleBackColor = False
        '
        'MindTestMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 387)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Easy)
        Me.Controls.Add(Me.Medium)
        Me.Controls.Add(Me.Hard)
        Me.Controls.Add(Me.VeryHard)
        Me.Controls.Add(Me.GoToTest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MindTestMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concentrate! Mind Test"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GoToTest As System.Windows.Forms.Button
    Friend WithEvents VeryHard As System.Windows.Forms.RadioButton
    Friend WithEvents Hard As System.Windows.Forms.RadioButton
    Friend WithEvents Medium As System.Windows.Forms.RadioButton
    Friend WithEvents Easy As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents AboutButton As System.Windows.Forms.Button
End Class
