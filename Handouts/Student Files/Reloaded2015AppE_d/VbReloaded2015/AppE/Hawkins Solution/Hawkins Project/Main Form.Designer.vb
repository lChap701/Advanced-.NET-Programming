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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.spentTextBox = New System.Windows.Forms.TextBox()
        Me.earnedTextBox = New System.Windows.Forms.TextBox()
        Me.beginTextBox = New System.Windows.Forms.TextBox()
        Me.endingLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(186, 222)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(103, 34)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(186, 183)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(103, 34)
        Me.calcButton.TabIndex = 6
        Me.calcButton.Text = "&Calculate"
        '
        'spentTextBox
        '
        Me.spentTextBox.Location = New System.Drawing.Point(33, 158)
        Me.spentTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.spentTextBox.Name = "spentTextBox"
        Me.spentTextBox.Size = New System.Drawing.Size(131, 25)
        Me.spentTextBox.TabIndex = 5
        '
        'earnedTextBox
        '
        Me.earnedTextBox.Location = New System.Drawing.Point(33, 96)
        Me.earnedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.earnedTextBox.Name = "earnedTextBox"
        Me.earnedTextBox.Size = New System.Drawing.Size(131, 25)
        Me.earnedTextBox.TabIndex = 3
        '
        'beginTextBox
        '
        Me.beginTextBox.Location = New System.Drawing.Point(33, 39)
        Me.beginTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.beginTextBox.Name = "beginTextBox"
        Me.beginTextBox.Size = New System.Drawing.Size(131, 25)
        Me.beginTextBox.TabIndex = 1
        '
        'endingLabel
        '
        Me.endingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.endingLabel.Location = New System.Drawing.Point(33, 222)
        Me.endingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.endingLabel.Name = "endingLabel"
        Me.endingLabel.Size = New System.Drawing.Size(131, 30)
        Me.endingLabel.TabIndex = 9
        Me.endingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 202)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Ending balance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Money &spent:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Money &earned:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Beginning balance:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 280)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.spentTextBox)
        Me.Controls.Add(Me.earnedTextBox)
        Me.Controls.Add(Me.beginTextBox)
        Me.Controls.Add(Me.endingLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ending Balance Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents spentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents earnedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents beginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents endingLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
