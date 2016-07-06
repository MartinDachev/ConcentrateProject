<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChooseForm))
        Me.TestButton = New System.Windows.Forms.Button()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.TrainButton = New System.Windows.Forms.Button()
        Me.Screenshot = New System.Windows.Forms.PictureBox()
        Me.AboutButton = New System.Windows.Forms.Button()
        CType(Me.Screenshot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestButton
        '
        Me.TestButton.BackColor = System.Drawing.Color.Transparent
        Me.TestButton.BackgroundImage = CType(resources.GetObject("TestButton.BackgroundImage"), System.Drawing.Image)
        Me.TestButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TestButton.FlatAppearance.BorderSize = 0
        Me.TestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.TestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.TestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TestButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TestButton.ForeColor = System.Drawing.Color.LightCyan
        Me.TestButton.Location = New System.Drawing.Point(519, 81)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(210, 55)
        Me.TestButton.TabIndex = 66
        Me.TestButton.TabStop = False
        Me.TestButton.Text = "Към теста"
        Me.TestButton.UseVisualStyleBackColor = False
        '
        'SettingsButton
        '
        Me.SettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.SettingsButton.BackgroundImage = CType(resources.GetObject("SettingsButton.BackgroundImage"), System.Drawing.Image)
        Me.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsButton.FlatAppearance.BorderSize = 0
        Me.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SettingsButton.ForeColor = System.Drawing.Color.LightCyan
        Me.SettingsButton.Location = New System.Drawing.Point(160, 413)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(210, 55)
        Me.SettingsButton.TabIndex = 65
        Me.SettingsButton.TabStop = False
        Me.SettingsButton.Text = "Настройки на теста"
        Me.SettingsButton.UseVisualStyleBackColor = False
        '
        'TrainButton
        '
        Me.TrainButton.BackColor = System.Drawing.Color.Transparent
        Me.TrainButton.BackgroundImage = CType(resources.GetObject("TrainButton.BackgroundImage"), System.Drawing.Image)
        Me.TrainButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrainButton.FlatAppearance.BorderSize = 0
        Me.TrainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.TrainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.TrainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrainButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TrainButton.ForeColor = System.Drawing.Color.LightCyan
        Me.TrainButton.Location = New System.Drawing.Point(519, 142)
        Me.TrainButton.Name = "TrainButton"
        Me.TrainButton.Size = New System.Drawing.Size(210, 55)
        Me.TrainButton.TabIndex = 64
        Me.TrainButton.TabStop = False
        Me.TrainButton.Text = "Тренировка"
        Me.TrainButton.UseVisualStyleBackColor = False
        '
        'Screenshot
        '
        Me.Screenshot.BackgroundImage = CType(resources.GetObject("Screenshot.BackgroundImage"), System.Drawing.Image)
        Me.Screenshot.Location = New System.Drawing.Point(13, 25)
        Me.Screenshot.Name = "Screenshot"
        Me.Screenshot.Size = New System.Drawing.Size(500, 362)
        Me.Screenshot.TabIndex = 67
        Me.Screenshot.TabStop = False
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
        Me.AboutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AboutButton.ForeColor = System.Drawing.Color.LightCyan
        Me.AboutButton.Location = New System.Drawing.Point(519, 203)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(210, 55)
        Me.AboutButton.TabIndex = 68
        Me.AboutButton.TabStop = False
        Me.AboutButton.Text = "Инструкции"
        Me.AboutButton.UseVisualStyleBackColor = False
        '
        'ChooseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(732, 480)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.Screenshot)
        Me.Controls.Add(Me.TestButton)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.TrainButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ChooseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concentrate! Плюсове"
        CType(Me.Screenshot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TestButton As System.Windows.Forms.Button
    Friend WithEvents SettingsButton As System.Windows.Forms.Button
    Friend WithEvents TrainButton As System.Windows.Forms.Button
    Friend WithEvents Screenshot As System.Windows.Forms.PictureBox
    Friend WithEvents AboutButton As System.Windows.Forms.Button
End Class
