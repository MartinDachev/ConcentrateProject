<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VeryHardLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VeryHardLevel))
        Me.RandomNumbers = New System.Windows.Forms.Timer(Me.components)
        Me.ShowTextBox = New System.Windows.Forms.Timer(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RememberTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ReadyLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ReadyButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Example3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Example2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Example1 = New System.Windows.Forms.TextBox()
        Me.Legend = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RandomNumbers
        '
        Me.RandomNumbers.Interval = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(784, 561)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 579
        Me.LineShape3.X2 = 578
        Me.LineShape3.Y1 = 0
        Me.LineShape3.Y2 = 434
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 2
        Me.LineShape2.X2 = 579
        Me.LineShape2.Y1 = 435
        Me.LineShape2.Y2 = 435
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 287
        Me.LineShape1.X2 = 289
        Me.LineShape1.Y1 = -1
        Me.LineShape1.Y2 = 434
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Запомнете числата в същата " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         последователност!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 362)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 60)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "     Въведете числата в тази " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "последователност, в която са" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         били показа" & _
    "ни!"
        '
        'RememberTimer
        '
        Me.RememberTimer.Interval = 20000
        '
        'ReadyLabel
        '
        Me.ReadyLabel.AutoSize = True
        Me.ReadyLabel.BackColor = System.Drawing.Color.Transparent
        Me.ReadyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ReadyLabel.Location = New System.Drawing.Point(48, 448)
        Me.ReadyLabel.Name = "ReadyLabel"
        Me.ReadyLabel.Size = New System.Drawing.Size(518, 20)
        Me.ReadyLabel.TabIndex = 10
        Me.ReadyLabel.Text = "Когато сте приключили с въвеждането - натиснете бутона Готово"
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
        Me.ExitButton.Location = New System.Drawing.Point(527, 485)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(210, 55)
        Me.ExitButton.TabIndex = 9
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
        Me.ReadyButton.Location = New System.Drawing.Point(287, 485)
        Me.ReadyButton.Name = "ReadyButton"
        Me.ReadyButton.Size = New System.Drawing.Size(210, 55)
        Me.ReadyButton.TabIndex = 1
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
        Me.StartButton.Location = New System.Drawing.Point(52, 485)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(210, 55)
        Me.StartButton.TabIndex = 0
        Me.StartButton.TabStop = False
        Me.StartButton.Text = "Старт"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(618, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Грешен отговор"
        '
        'Example3
        '
        Me.Example3.Enabled = False
        Me.Example3.Location = New System.Drawing.Point(622, 290)
        Me.Example3.Multiline = True
        Me.Example3.Name = "Example3"
        Me.Example3.Size = New System.Drawing.Size(100, 30)
        Me.Example3.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(616, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Верен отговор"
        '
        'Example2
        '
        Me.Example2.Enabled = False
        Me.Example2.Location = New System.Drawing.Point(622, 186)
        Me.Example2.Multiline = True
        Me.Example2.Name = "Example2"
        Me.Example2.Size = New System.Drawing.Size(100, 30)
        Me.Example2.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(616, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Празно поле"
        '
        'Example1
        '
        Me.Example1.Enabled = False
        Me.Example1.Location = New System.Drawing.Point(620, 81)
        Me.Example1.Multiline = True
        Me.Example1.Name = "Example1"
        Me.Example1.Size = New System.Drawing.Size(100, 30)
        Me.Example1.TabIndex = 33
        '
        'Legend
        '
        Me.Legend.AutoSize = True
        Me.Legend.BackColor = System.Drawing.Color.Transparent
        Me.Legend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Legend.Location = New System.Drawing.Point(616, 46)
        Me.Legend.Name = "Legend"
        Me.Legend.Size = New System.Drawing.Size(87, 20)
        Me.Legend.TabIndex = 32
        Me.Legend.Text = "Легенда : "
        '
        'VeryHardLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Example3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Example2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Example1)
        Me.Controls.Add(Me.Legend)
        Me.Controls.Add(Me.ReadyLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReadyButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VeryHardLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concentrate! Mind Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RandomNumbers As System.Windows.Forms.Timer
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents ShowTextBox As System.Windows.Forms.Timer
    Friend WithEvents ReadyButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RememberTimer As System.Windows.Forms.Timer
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ReadyLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Example3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Example2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Example1 As System.Windows.Forms.TextBox
    Friend WithEvents Legend As System.Windows.Forms.Label
    Private WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Private WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Private WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
