<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrainForm))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MinutesLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Points = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StartTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SwapTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(683, 512)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 20)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = ":"
        '
        'MinutesLabel
        '
        Me.MinutesLabel.AutoSize = True
        Me.MinutesLabel.BackColor = System.Drawing.Color.Transparent
        Me.MinutesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MinutesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MinutesLabel.Location = New System.Drawing.Point(657, 512)
        Me.MinutesLabel.Name = "MinutesLabel"
        Me.MinutesLabel.Size = New System.Drawing.Size(29, 20)
        Me.MinutesLabel.TabIndex = 133
        Me.MinutesLabel.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(573, 512)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Време : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(63, 512)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Точки : "
        '
        'Points
        '
        Me.Points.AutoSize = True
        Me.Points.BackColor = System.Drawing.Color.Transparent
        Me.Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Points.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Points.Location = New System.Drawing.Point(139, 512)
        Me.Points.Name = "Points"
        Me.Points.Size = New System.Drawing.Size(19, 20)
        Me.Points.TabIndex = 130
        Me.Points.Text = "0"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.TimeLabel.Location = New System.Drawing.Point(699, 512)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(29, 20)
        Me.TimeLabel.TabIndex = 129
        Me.TimeLabel.Text = "00"
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
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.LightCyan
        Me.StartButton.Location = New System.Drawing.Point(273, 494)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(210, 55)
        Me.StartButton.TabIndex = 128
        Me.StartButton.TabStop = False
        Me.StartButton.Text = "Старт"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'StartTimer
        '
        Me.StartTimer.Interval = 10
        '
        'StopTimer
        '
        Me.StopTimer.Interval = 1000
        '
        'SwapTimer
        '
        Me.SwapTimer.Interval = 1
        '
        'TrainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MinutesLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Points)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.StartButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TrainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concentrate!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MinutesLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Points As System.Windows.Forms.Label
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents StartTimer As System.Windows.Forms.Timer
    Friend WithEvents StopTimer As System.Windows.Forms.Timer
    Friend WithEvents SwapTimer As System.Windows.Forms.Timer
End Class
