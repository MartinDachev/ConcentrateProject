<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MediumLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MediumLevel))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RandomNumbers = New System.Windows.Forms.Timer(Me.components)
        Me.ShowTextBox = New System.Windows.Forms.Timer(Me.components)
        Me.RememberTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ReadyButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReadyLabel = New System.Windows.Forms.Label()
        Me.Legend = New System.Windows.Forms.Label()
        Me.Example1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Example2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Example3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(784, 515)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LineShape5.BorderWidth = 3
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 576
        Me.LineShape5.X2 = 575
        Me.LineShape5.Y1 = -1
        Me.LineShape5.Y2 = 392
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LineShape4.BorderWidth = 3
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = -1
        Me.LineShape4.X2 = 575
        Me.LineShape4.Y1 = 391
        Me.LineShape4.Y2 = 391
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 289
        Me.LineShape3.X2 = 288
        Me.LineShape3.Y1 = -1
        Me.LineShape3.Y2 = 391
        '
        'RandomNumbers
        '
        Me.RandomNumbers.Interval = 1
        '
        'RememberTimer
        '
        Me.RememberTimer.Interval = 20000
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.LightCyan
        Me.ExitButton.Location = New System.Drawing.Point(530, 448)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(210, 55)
        Me.ExitButton.TabIndex = 16
        Me.ExitButton.TabStop = False
        Me.ExitButton.Text = "Изход"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ReadyButton
        '
        Me.ReadyButton.BackColor = System.Drawing.Color.Transparent
        Me.ReadyButton.BackgroundImage = CType(resources.GetObject("ReadyButton.BackgroundImage"), System.Drawing.Image)
        Me.ReadyButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReadyButton.FlatAppearance.BorderSize = 0
        Me.ReadyButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.ReadyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ReadyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ReadyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReadyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ReadyButton.ForeColor = System.Drawing.Color.LightCyan
        Me.ReadyButton.Location = New System.Drawing.Point(282, 448)
        Me.ReadyButton.Name = "ReadyButton"
        Me.ReadyButton.Size = New System.Drawing.Size(210, 55)
        Me.ReadyButton.TabIndex = 15
        Me.ReadyButton.TabStop = False
        Me.ReadyButton.Text = "Готово"
        Me.ReadyButton.UseVisualStyleBackColor = False
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.BackgroundImage = CType(resources.GetObject("StartButton.BackgroundImage"), System.Drawing.Image)
        Me.StartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton.FlatAppearance.BorderSize = 0
        Me.StartButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.LightCyan
        Me.StartButton.Location = New System.Drawing.Point(32, 448)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(210, 55)
        Me.StartButton.TabIndex = 14
        Me.StartButton.TabStop = False
        Me.StartButton.Text = "Старт"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(316, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 60)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "     Въведете числата в тази " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "последователност, в която са" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           били пока" & _
    "зани!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 40)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Запомнете числата в същата " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         последователност!"
        '
        'ReadyLabel
        '
        Me.ReadyLabel.AutoSize = True
        Me.ReadyLabel.BackColor = System.Drawing.Color.Transparent
        Me.ReadyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ReadyLabel.Location = New System.Drawing.Point(39, 412)
        Me.ReadyLabel.Name = "ReadyLabel"
        Me.ReadyLabel.Size = New System.Drawing.Size(518, 20)
        Me.ReadyLabel.TabIndex = 22
        Me.ReadyLabel.Text = "Когато сте приключили с въвеждането - натиснете бутона Готово"
        '
        'Legend
        '
        Me.Legend.AutoSize = True
        Me.Legend.BackColor = System.Drawing.Color.Transparent
        Me.Legend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Legend.Location = New System.Drawing.Point(603, 28)
        Me.Legend.Name = "Legend"
        Me.Legend.Size = New System.Drawing.Size(87, 20)
        Me.Legend.TabIndex = 25
        Me.Legend.Text = "Легенда : "
        '
        'Example1
        '
        Me.Example1.Enabled = False
        Me.Example1.Location = New System.Drawing.Point(607, 63)
        Me.Example1.Multiline = True
        Me.Example1.Name = "Example1"
        Me.Example1.Size = New System.Drawing.Size(100, 30)
        Me.Example1.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(603, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Празно поле"
        '
        'Example2
        '
        Me.Example2.BackColor = System.Drawing.Color.White
        Me.Example2.Enabled = False
        Me.Example2.Location = New System.Drawing.Point(609, 168)
        Me.Example2.Multiline = True
        Me.Example2.Name = "Example2"
        Me.Example2.Size = New System.Drawing.Size(100, 30)
        Me.Example2.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(603, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Верен отговор"
        '
        'Example3
        '
        Me.Example3.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Example3.Enabled = False
        Me.Example3.Location = New System.Drawing.Point(609, 272)
        Me.Example3.Multiline = True
        Me.Example3.Name = "Example3"
        Me.Example3.Size = New System.Drawing.Size(100, 30)
        Me.Example3.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(605, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Грешен отговор"
        '
        'MediumLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 515)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Example3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Example2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Example1)
        Me.Controls.Add(Me.Legend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReadyLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ReadyButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MediumLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concentrate! Mind Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RandomNumbers As System.Windows.Forms.Timer
    Friend WithEvents ShowTextBox As System.Windows.Forms.Timer
    Friend WithEvents RememberTimer As System.Windows.Forms.Timer
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ReadyButton As System.Windows.Forms.Button
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReadyLabel As System.Windows.Forms.Label
    Friend WithEvents Legend As System.Windows.Forms.Label
    Friend WithEvents Example1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Example2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Example3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Private WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
