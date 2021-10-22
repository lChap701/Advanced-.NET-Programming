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
        Me.formulaTextBox = New System.Windows.Forms.TextBox()
        Me.sideTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.decimalTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Enter A for area or P for perimeter:"
        '
        'formulaTextBox
        '
        Me.formulaTextBox.Location = New System.Drawing.Point(16, 46)
        Me.formulaTextBox.Name = "formulaTextBox"
        Me.formulaTextBox.Size = New System.Drawing.Size(30, 25)
        Me.formulaTextBox.TabIndex = 1
        '
        'sideTextBox
        '
        Me.sideTextBox.Location = New System.Drawing.Point(16, 187)
        Me.sideTextBox.Name = "sideTextBox"
        Me.sideTextBox.Size = New System.Drawing.Size(49, 25)
        Me.sideTextBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Side measurement:"
        '
        'decimalTextBox
        '
        Me.decimalTextBox.Location = New System.Drawing.Point(16, 116)
        Me.decimalTextBox.Name = "decimalTextBox"
        Me.decimalTextBox.Size = New System.Drawing.Size(30, 25)
        Me.decimalTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Number of decimal places to display (1 or 2):"
        '
        'answerLabel
        '
        Me.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.answerLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerLabel.Location = New System.Drawing.Point(310, 24)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(176, 158)
        Me.answerLabel.TabIndex = 8
        Me.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(320, 220)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 30)
        Me.calcButton.TabIndex = 6
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(411, 220)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 30)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 273)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.decimalTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sideTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.formulaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Square Calculations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents formulaTextBox As TextBox
    Friend WithEvents sideTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents decimalTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents answerLabel As Label
    Friend WithEvents calcButton As Button
    Friend WithEvents exitButton As Button
End Class
