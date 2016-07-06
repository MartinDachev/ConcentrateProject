<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveMessageBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaveMessageBox))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.ExitTextLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.rsz_1warning_sign
        Me.PictureBox1.Location = New System.Drawing.Point(32, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.Transparent
        Me.NoButton.BackgroundImage = CType(resources.GetObject("NoButton.BackgroundImage"), System.Drawing.Image)
        Me.NoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NoButton.FlatAppearance.BorderSize = 0
        Me.NoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.NoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NoButton.ForeColor = System.Drawing.Color.LightCyan
        Me.NoButton.Location = New System.Drawing.Point(353, 85)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(210, 55)
        Me.NoButton.TabIndex = 7
        Me.NoButton.TabStop = False
        Me.NoButton.Text = "Не"
        Me.NoButton.UseVisualStyleBackColor = False
        '
        'YesButton
        '
        Me.YesButton.BackColor = System.Drawing.Color.Transparent
        Me.YesButton.BackgroundImage = CType(resources.GetObject("YesButton.BackgroundImage"), System.Drawing.Image)
        Me.YesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.YesButton.FlatAppearance.BorderSize = 0
        Me.YesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.YesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.YesButton.ForeColor = System.Drawing.Color.LightCyan
        Me.YesButton.Location = New System.Drawing.Point(129, 85)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(210, 55)
        Me.YesButton.TabIndex = 6
        Me.YesButton.TabStop = False
        Me.YesButton.Text = "Да"
        Me.YesButton.UseVisualStyleBackColor = False
        '
        'ExitTextLabel
        '
        Me.ExitTextLabel.AutoSize = True
        Me.ExitTextLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExitTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ExitTextLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExitTextLabel.Location = New System.Drawing.Point(101, 32)
        Me.ExitTextLabel.Name = "ExitTextLabel"
        Me.ExitTextLabel.Size = New System.Drawing.Size(519, 36)
        Me.ExitTextLabel.TabIndex = 5
        Me.ExitTextLabel.Text = "Сигурни ли сте, че искате да излезнете от --Запази резултат--? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ако не сте запаз" & _
    "или Вашите резултати, те ще бъдат изгубени."
        '
        'SaveMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(640, 150)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.ExitTextLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SaveMessageBox"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Запази резултат"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NoButton As System.Windows.Forms.Button
    Friend WithEvents YesButton As System.Windows.Forms.Button
    Friend WithEvents ExitTextLabel As System.Windows.Forms.Label
End Class
