<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minute3 = New System.Windows.Forms.RadioButton()
        Me.Minute2 = New System.Windows.Forms.RadioButton()
        Me.Minute1 = New System.Windows.Forms.RadioButton()
        Me.Seconds30 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.BackColor = System.Drawing.Color.Transparent
        Me.OKButton.BackgroundImage = CType(resources.GetObject("OKButton.BackgroundImage"), System.Drawing.Image)
        Me.OKButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OKButton.FlatAppearance.BorderSize = 0
        Me.OKButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.OKButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.OKButton.ForeColor = System.Drawing.Color.LightCyan
        Me.OKButton.Location = New System.Drawing.Point(39, 194)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(210, 55)
        Me.OKButton.TabIndex = 64
        Me.OKButton.TabStop = False
        Me.OKButton.Text = "ОК"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(47, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Времетраене на теста"
        '
        'Minute3
        '
        Me.Minute3.AutoSize = True
        Me.Minute3.BackColor = System.Drawing.Color.Transparent
        Me.Minute3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Minute3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Minute3.Location = New System.Drawing.Point(156, 148)
        Me.Minute3.Name = "Minute3"
        Me.Minute3.Size = New System.Drawing.Size(102, 24)
        Me.Minute3.TabIndex = 71
        Me.Minute3.TabStop = True
        Me.Minute3.Text = "3 минути"
        Me.Minute3.UseVisualStyleBackColor = False
        '
        'Minute2
        '
        Me.Minute2.AutoSize = True
        Me.Minute2.BackColor = System.Drawing.Color.Transparent
        Me.Minute2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Minute2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Minute2.Location = New System.Drawing.Point(156, 94)
        Me.Minute2.Name = "Minute2"
        Me.Minute2.Size = New System.Drawing.Size(102, 24)
        Me.Minute2.TabIndex = 70
        Me.Minute2.TabStop = True
        Me.Minute2.Text = "2 минути"
        Me.Minute2.UseVisualStyleBackColor = False
        '
        'Minute1
        '
        Me.Minute1.AutoSize = True
        Me.Minute1.BackColor = System.Drawing.Color.Transparent
        Me.Minute1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Minute1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Minute1.Location = New System.Drawing.Point(36, 148)
        Me.Minute1.Name = "Minute1"
        Me.Minute1.Size = New System.Drawing.Size(102, 24)
        Me.Minute1.TabIndex = 69
        Me.Minute1.TabStop = True
        Me.Minute1.Text = "1 минута"
        Me.Minute1.UseVisualStyleBackColor = False
        '
        'Seconds30
        '
        Me.Seconds30.AutoSize = True
        Me.Seconds30.BackColor = System.Drawing.Color.Transparent
        Me.Seconds30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Seconds30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Seconds30.Location = New System.Drawing.Point(36, 93)
        Me.Seconds30.Name = "Seconds30"
        Me.Seconds30.Size = New System.Drawing.Size(120, 24)
        Me.Seconds30.TabIndex = 68
        Me.Seconds30.TabStop = True
        Me.Seconds30.Text = "30 секунди"
        Me.Seconds30.UseVisualStyleBackColor = False
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Minute3)
        Me.Controls.Add(Me.Minute2)
        Me.Controls.Add(Me.Minute1)
        Me.Controls.Add(Me.Seconds30)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OKButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Настройки"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Minute3 As System.Windows.Forms.RadioButton
    Friend WithEvents Minute2 As System.Windows.Forms.RadioButton
    Friend WithEvents Minute1 As System.Windows.Forms.RadioButton
    Friend WithEvents Seconds30 As System.Windows.Forms.RadioButton
End Class
