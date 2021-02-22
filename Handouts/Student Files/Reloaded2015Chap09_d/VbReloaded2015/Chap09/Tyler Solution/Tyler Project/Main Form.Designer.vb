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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usedButton = New System.Windows.Forms.Button()
        Me.newButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usedLabel = New System.Windows.Forms.Label()
        Me.newLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.totalButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "New cars sold:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Used cars sold:"
        '
        'usedButton
        '
        Me.usedButton.Location = New System.Drawing.Point(106, 159)
        Me.usedButton.Name = "usedButton"
        Me.usedButton.Size = New System.Drawing.Size(88, 28)
        Me.usedButton.TabIndex = 1
        Me.usedButton.Text = "&Used Cars"
        Me.usedButton.UseVisualStyleBackColor = True
        '
        'newButton
        '
        Me.newButton.Location = New System.Drawing.Point(13, 159)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(88, 28)
        Me.newButton.TabIndex = 0
        Me.newButton.Text = "&New Cars"
        Me.newButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total cars sold:"
        '
        'usedLabel
        '
        Me.usedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usedLabel.Location = New System.Drawing.Point(244, 57)
        Me.usedLabel.Name = "usedLabel"
        Me.usedLabel.Size = New System.Drawing.Size(54, 21)
        Me.usedLabel.TabIndex = 7
        Me.usedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'newLabel
        '
        Me.newLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.newLabel.Location = New System.Drawing.Point(244, 24)
        Me.newLabel.Name = "newLabel"
        Me.newLabel.Size = New System.Drawing.Size(54, 21)
        Me.newLabel.TabIndex = 5
        Me.newLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(244, 92)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(54, 21)
        Me.totalLabel.TabIndex = 9
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalButton
        '
        Me.totalButton.Location = New System.Drawing.Point(200, 159)
        Me.totalButton.Name = "totalButton"
        Me.totalButton.Size = New System.Drawing.Size(88, 28)
        Me.totalButton.TabIndex = 2
        Me.totalButton.Text = "&Total Cars"
        Me.totalButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(294, 159)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(66, 28)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tyler_Project.My.Resources.Resources.Tyler
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 208)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.totalButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.newLabel)
        Me.Controls.Add(Me.usedLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.newButton)
        Me.Controls.Add(Me.usedButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tyler Motors"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents usedButton As System.Windows.Forms.Button
    Friend WithEvents newButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents usedLabel As System.Windows.Forms.Label
    Friend WithEvents newLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents totalButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
