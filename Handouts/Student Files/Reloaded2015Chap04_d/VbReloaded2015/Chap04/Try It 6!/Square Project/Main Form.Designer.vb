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
        Me.sideTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.areaCheckBox = New System.Windows.Forms.CheckBox()
        Me.perimeterCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'sideTextBox
        '
        Me.sideTextBox.Location = New System.Drawing.Point(15, 79)
        Me.sideTextBox.Name = "sideTextBox"
        Me.sideTextBox.Size = New System.Drawing.Size(49, 25)
        Me.sideTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Side measurement:"
        '
        'answerLabel
        '
        Me.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.answerLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerLabel.Location = New System.Drawing.Point(189, 13)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(176, 98)
        Me.answerLabel.TabIndex = 6
        Me.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(209, 131)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 30)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(290, 131)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 30)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'areaCheckBox
        '
        Me.areaCheckBox.AutoSize = True
        Me.areaCheckBox.Location = New System.Drawing.Point(13, 13)
        Me.areaCheckBox.Name = "areaCheckBox"
        Me.areaCheckBox.Size = New System.Drawing.Size(54, 21)
        Me.areaCheckBox.TabIndex = 2
        Me.areaCheckBox.Text = "&Area"
        Me.areaCheckBox.UseVisualStyleBackColor = True
        '
        'perimeterCheckBox
        '
        Me.perimeterCheckBox.AutoSize = True
        Me.perimeterCheckBox.Location = New System.Drawing.Point(88, 13)
        Me.perimeterCheckBox.Name = "perimeterCheckBox"
        Me.perimeterCheckBox.Size = New System.Drawing.Size(83, 21)
        Me.perimeterCheckBox.TabIndex = 3
        Me.perimeterCheckBox.Text = "&Perimeter"
        Me.perimeterCheckBox.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 184)
        Me.Controls.Add(Me.perimeterCheckBox)
        Me.Controls.Add(Me.areaCheckBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.sideTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Square Calculations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sideTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents answerLabel As Label
    Friend WithEvents calcButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents areaCheckBox As CheckBox
    Friend WithEvents perimeterCheckBox As CheckBox
End Class
