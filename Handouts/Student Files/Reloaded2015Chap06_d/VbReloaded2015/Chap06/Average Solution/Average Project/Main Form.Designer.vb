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
        Me.calcButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.avgLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.scoresListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(257, 21)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(103, 33)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Average score:"
        '
        'avgLabel
        '
        Me.avgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.avgLabel.Location = New System.Drawing.Point(104, 58)
        Me.avgLabel.Name = "avgLabel"
        Me.avgLabel.Size = New System.Drawing.Size(104, 31)
        Me.avgLabel.TabIndex = 3
        Me.avgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(257, 62)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(103, 33)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Scores:"
        '
        'scoresListBox
        '
        Me.scoresListBox.FormattingEnabled = True
        Me.scoresListBox.ItemHeight = 20
        Me.scoresListBox.Location = New System.Drawing.Point(17, 34)
        Me.scoresListBox.Name = "scoresListBox"
        Me.scoresListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.scoresListBox.Size = New System.Drawing.Size(51, 104)
        Me.scoresListBox.TabIndex = 5
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 160)
        Me.Controls.Add(Me.scoresListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.avgLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calcButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents avgLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents scoresListBox As System.Windows.Forms.ListBox

End Class
