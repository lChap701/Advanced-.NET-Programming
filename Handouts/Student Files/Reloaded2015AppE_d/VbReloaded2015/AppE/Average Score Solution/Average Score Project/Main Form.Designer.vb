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
        Me.score1TextBox = New System.Windows.Forms.TextBox()
        Me.score2TextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.avgLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Score &1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Score &2:"
        '
        'score1TextBox
        '
        Me.score1TextBox.Location = New System.Drawing.Point(85, 22)
        Me.score1TextBox.Name = "score1TextBox"
        Me.score1TextBox.Size = New System.Drawing.Size(51, 25)
        Me.score1TextBox.TabIndex = 1
        '
        'score2TextBox
        '
        Me.score2TextBox.Location = New System.Drawing.Point(85, 59)
        Me.score2TextBox.Name = "score2TextBox"
        Me.score2TextBox.Size = New System.Drawing.Size(51, 25)
        Me.score2TextBox.TabIndex = 3
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(213, 22)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(87, 36)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(213, 65)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(87, 36)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Average:"
        '
        'avgLabel
        '
        Me.avgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.avgLabel.Location = New System.Drawing.Point(85, 112)
        Me.avgLabel.Name = "avgLabel"
        Me.avgLabel.Size = New System.Drawing.Size(73, 29)
        Me.avgLabel.TabIndex = 7
        Me.avgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 170)
        Me.Controls.Add(Me.avgLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.score2TextBox)
        Me.Controls.Add(Me.score1TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Score Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents score1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents score2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents avgLabel As System.Windows.Forms.Label

End Class
