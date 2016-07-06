<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LevelHard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LevelHard))
        Me.RememberTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ShowTextBoxTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RandomTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ReadyButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReadyLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Example3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Example2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Example1 = New System.Windows.Forms.TextBox()
        Me.Legend = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RememberTimer
        '
        Me.RememberTimer.Interval = 20000
        '
        'RandomTimer
        '
        Me.RandomTimer.Interval = 1
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
        Me.ExitButton.Location = New System.Drawing.Point(532, 451)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(210, 55)
        Me.ExitButton.TabIndex = 13
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
        Me.ReadyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ReadyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ReadyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReadyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ReadyButton.ForeColor = System.Drawing.Color.LightCyan
        Me.ReadyButton.Location = New System.Drawing.Point(289, 451)
        Me.ReadyButton.Name = "ReadyButton"
        Me.ReadyButton.Size = New System.Drawing.Size(210, 55)
        Me.ReadyButton.TabIndex = 12
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
        Me.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.LightCyan
        Me.StartButton.Location = New System.Drawing.Point(43, 451)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(210, 55)
        Me.StartButton.TabIndex = 11
        Me.StartButton.TabStop = False
        Me.StartButton.Text = "Старт"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 290
        Me.LineShape3.X2 = 290
        Me.LineShape3.Y1 = -1
        Me.LineShape3.Y2 = 391
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LineShape4.BorderWidth = 3
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 1
        Me.LineShape4.X2 = 577
        Me.LineShape4.Y1 = 391
        Me.LineShape4.Y2 = 391
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LineShape5.BorderWidth = 3
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 577
        Me.LineShape5.X2 = 577
        Me.LineShape5.Y1 = -1
        Me.LineShape5.Y2 = 391
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(784, 518)
        Me.ShapeContainer1.TabIndex = 14
        Me.ShapeContainer1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 60)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "     Въведете числата в тази " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "последователност, в която са" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            били пок" & _
    "азани!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 40)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Запомнете числата в същата " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         последователност!"
        '
        'ReadyLabel
        '
        Me.ReadyLabel.AutoSize = True
        Me.ReadyLabel.BackColor = System.Drawing.Color.Transparent
        Me.ReadyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ReadyLabel.Location = New System.Drawing.Point(27, 402)
        Me.ReadyLabel.Name = "ReadyLabel"
        Me.ReadyLabel.Size = New System.Drawing.Size(518, 20)
        Me.ReadyLabel.TabIndex = 28
        Me.ReadyLabel.Text = "Когато сте приключили с въвежданетo - натиснете бутона Готово"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(624, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Грешен отговор"
        '
        'Example3
        '
        Me.Example3.Enabled = False
        Me.Example3.Location = New System.Drawing.Point(628, 282)
        Me.Example3.Multiline = True
        Me.Example3.Name = "Example3"
        Me.Example3.Size = New System.Drawing.Size(100, 30)
        Me.Example3.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(622, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Верен отговор"
        '
        'Example2
        '
        Me.Example2.Enabled = False
        Me.Example2.Location = New System.Drawing.Point(628, 178)
        Me.Example2.Multiline = True
        Me.Example2.Name = "Example2"
        Me.Example2.Size = New System.Drawing.Size(100, 30)
        Me.Example2.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(622, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Празно поле"
        '
        'Example1
        '
        Me.Example1.Enabled = False
        Me.Example1.Location = New System.Drawing.Point(626, 73)
        Me.Example1.Multiline = True
        Me.Example1.Name = "Example1"
        Me.Example1.Size = New System.Drawing.Size(100, 30)
        Me.Example1.TabIndex = 40
        '
        'Legend
        '
        Me.Legend.AutoSize = True
        Me.Legend.BackColor = System.Drawing.Color.Transparent
        Me.Legend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Legend.Location = New System.Drawing.Point(622, 38)
        Me.Legend.Name = "Legend"
        Me.Legend.Size = New System.Drawing.Size(87, 20)
        Me.Legend.TabIndex = 39
        Me.Legend.Text = "Легенда : "
        '
        'LevelHard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 518)
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
        Me.Name = "LevelHard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concentrate! Mind Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShowTextBoxTimer As System.Windows.Forms.Timer
    Friend WithEvents RandomTimer As System.Windows.Forms.Timer
    Friend WithEvents RememberTimer As System.Windows.Forms.Timer
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ReadyButton As System.Windows.Forms.Button
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReadyLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Example3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Example2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Example1 As System.Windows.Forms.TextBox
    Friend WithEvents Legend As System.Windows.Forms.Label
    Private WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
