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
        Me.lowLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.highLabel = New System.Windows.Forms.Label()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lowest number:"
        '
        'lowLabel
        '
        Me.lowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lowLabel.Location = New System.Drawing.Point(144, 33)
        Me.lowLabel.Name = "lowLabel"
        Me.lowLabel.Size = New System.Drawing.Size(57, 29)
        Me.lowLabel.TabIndex = 4
        Me.lowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Highest number:"
        '
        'highLabel
        '
        Me.highLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.highLabel.Location = New System.Drawing.Point(359, 33)
        Me.highLabel.Name = "highLabel"
        Me.highLabel.Size = New System.Drawing.Size(57, 29)
        Me.highLabel.TabIndex = 5
        Me.highLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'generateButton
        '
        Me.generateButton.Location = New System.Drawing.Point(26, 96)
        Me.generateButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(223, 44)
        Me.generateButton.TabIndex = 0
        Me.generateButton.Text = "&Generate Random Integers"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(330, 96)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(86, 44)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 175)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.highLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lowLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random Swap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lowLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents highLabel As System.Windows.Forms.Label
    Friend WithEvents generateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
