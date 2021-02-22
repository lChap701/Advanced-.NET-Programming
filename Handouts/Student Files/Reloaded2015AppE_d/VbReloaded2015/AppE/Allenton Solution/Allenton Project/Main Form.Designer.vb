<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.earthTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jupiterLabel = New System.Windows.Forms.Label()
        Me.venusLabel = New System.Windows.Forms.Label()
        Me.marsLabel = New System.Windows.Forms.Label()
        Me.moonLabel = New System.Windows.Forms.Label()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your earth &weight:"
        '
        'earthTextBox
        '
        Me.earthTextBox.Location = New System.Drawing.Point(148, 31)
        Me.earthTextBox.Name = "earthTextBox"
        Me.earthTextBox.Size = New System.Drawing.Size(49, 25)
        Me.earthTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jupiter:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Venus:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Mars:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Moon:"
        '
        'jupiterLabel
        '
        Me.jupiterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jupiterLabel.Location = New System.Drawing.Point(83, 101)
        Me.jupiterLabel.Name = "jupiterLabel"
        Me.jupiterLabel.Size = New System.Drawing.Size(70, 30)
        Me.jupiterLabel.TabIndex = 6
        Me.jupiterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'venusLabel
        '
        Me.venusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.venusLabel.Location = New System.Drawing.Point(83, 139)
        Me.venusLabel.Name = "venusLabel"
        Me.venusLabel.Size = New System.Drawing.Size(70, 30)
        Me.venusLabel.TabIndex = 8
        Me.venusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marsLabel
        '
        Me.marsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.marsLabel.Location = New System.Drawing.Point(83, 177)
        Me.marsLabel.Name = "marsLabel"
        Me.marsLabel.Size = New System.Drawing.Size(70, 30)
        Me.marsLabel.TabIndex = 10
        Me.marsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'moonLabel
        '
        Me.moonLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.moonLabel.Location = New System.Drawing.Point(83, 217)
        Me.moonLabel.Name = "moonLabel"
        Me.moonLabel.Size = New System.Drawing.Size(70, 30)
        Me.moonLabel.TabIndex = 12
        Me.moonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(167, 92)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(111, 36)
        Me.displayButton.TabIndex = 2
        Me.displayButton.Text = "&Display Weights"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(167, 134)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(111, 36)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Your weight on:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 280)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.moonLabel)
        Me.Controls.Add(Me.marsLabel)
        Me.Controls.Add(Me.venusLabel)
        Me.Controls.Add(Me.jupiterLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.earthTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allenton Observatory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents earthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents jupiterLabel As System.Windows.Forms.Label
    Friend WithEvents venusLabel As System.Windows.Forms.Label
    Friend WithEvents marsLabel As System.Windows.Forms.Label
    Friend WithEvents moonLabel As System.Windows.Forms.Label
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
