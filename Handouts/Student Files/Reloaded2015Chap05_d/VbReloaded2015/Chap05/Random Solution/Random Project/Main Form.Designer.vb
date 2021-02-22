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
        Me.firstLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.secondLabel = New System.Windows.Forms.Label()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First integer:"
        '
        'firstLabel
        '
        Me.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstLabel.Location = New System.Drawing.Point(32, 44)
        Me.firstLabel.Name = "firstLabel"
        Me.firstLabel.Size = New System.Drawing.Size(74, 25)
        Me.firstLabel.TabIndex = 4
        Me.firstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Second integer:"
        '
        'secondLabel
        '
        Me.secondLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.secondLabel.Location = New System.Drawing.Point(163, 44)
        Me.secondLabel.Name = "secondLabel"
        Me.secondLabel.Size = New System.Drawing.Size(74, 25)
        Me.secondLabel.TabIndex = 5
        Me.secondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(32, 146)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(141, 37)
        Me.generateButton.TabIndex = 0
        Me.generateButton.Text = "&Generate Integers"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(183, 146)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 37)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'messageLabel
        '
        Me.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.messageLabel.Location = New System.Drawing.Point(32, 95)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(226, 30)
        Me.messageLabel.TabIndex = 6
        Me.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 216)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.secondLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.firstLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random Integers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents firstLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents secondLabel As System.Windows.Forms.Label
    Friend WithEvents generateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents messageLabel As System.Windows.Forms.Label

End Class
