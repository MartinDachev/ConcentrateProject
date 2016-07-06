<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Test))
        Me.StartButton = New System.Windows.Forms.Button()
        Me.RandomTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SwapTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClickedPlus = New System.Windows.Forms.Label()
        Me.MissedPlus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MinutesLabel = New System.Windows.Forms.Label()
        Me.SecondsLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CountdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.BackgroundImage = Global.ReactionTest3_Var2.My.Resources.Resources.Button2
        Me.StartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton.FlatAppearance.BorderSize = 0
        Me.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.LightCyan
        Me.StartButton.Location = New System.Drawing.Point(300, 500)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(210, 55)
        Me.StartButton.TabIndex = 0
        Me.StartButton.TabStop = False
        Me.StartButton.Text = "Старт"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'RandomTimer
        '
        '
        'SwapTimer
        '
        Me.SwapTimer.Interval = 1300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(76, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Точки : "
        '
        'ClickedPlus
        '
        Me.ClickedPlus.AutoSize = True
        Me.ClickedPlus.BackColor = System.Drawing.Color.Transparent
        Me.ClickedPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ClickedPlus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ClickedPlus.Location = New System.Drawing.Point(155, 491)
        Me.ClickedPlus.Name = "ClickedPlus"
        Me.ClickedPlus.Size = New System.Drawing.Size(19, 20)
        Me.ClickedPlus.TabIndex = 2
        Me.ClickedPlus.Text = "0"
        '
        'MissedPlus
        '
        Me.MissedPlus.AutoSize = True
        Me.MissedPlus.BackColor = System.Drawing.Color.Transparent
        Me.MissedPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MissedPlus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MissedPlus.Location = New System.Drawing.Point(155, 517)
        Me.MissedPlus.Name = "MissedPlus"
        Me.MissedPlus.Size = New System.Drawing.Size(19, 20)
        Me.MissedPlus.TabIndex = 3
        Me.MissedPlus.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(31, 515)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Пропуснати : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(576, 518)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Време : "
        '
        'MinutesLabel
        '
        Me.MinutesLabel.AutoSize = True
        Me.MinutesLabel.BackColor = System.Drawing.Color.Transparent
        Me.MinutesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MinutesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MinutesLabel.Location = New System.Drawing.Point(655, 518)
        Me.MinutesLabel.Name = "MinutesLabel"
        Me.MinutesLabel.Size = New System.Drawing.Size(29, 20)
        Me.MinutesLabel.TabIndex = 6
        Me.MinutesLabel.Text = "00"
        '
        'SecondsLabel
        '
        Me.SecondsLabel.AutoSize = True
        Me.SecondsLabel.BackColor = System.Drawing.Color.Transparent
        Me.SecondsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SecondsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.SecondsLabel.Location = New System.Drawing.Point(699, 518)
        Me.SecondsLabel.Name = "SecondsLabel"
        Me.SecondsLabel.Size = New System.Drawing.Size(29, 20)
        Me.SecondsLabel.TabIndex = 7
        Me.SecondsLabel.Text = "00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(682, 518)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = ":"
        '
        'CountdownTimer
        '
        Me.CountdownTimer.Interval = 1000
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SecondsLabel)
        Me.Controls.Add(Me.MinutesLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MissedPlus)
        Me.Controls.Add(Me.ClickedPlus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concentrate! "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents RandomTimer As System.Windows.Forms.Timer
    Friend WithEvents SwapTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClickedPlus As System.Windows.Forms.Label
    Friend WithEvents MissedPlus As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MinutesLabel As System.Windows.Forms.Label
    Friend WithEvents SecondsLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CountdownTimer As System.Windows.Forms.Timer

End Class
