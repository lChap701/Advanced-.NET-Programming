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
        Me.entryTextBox = New System.Windows.Forms.TextBox()
        Me.trimButton = New System.Windows.Forms.Button()
        Me.trimStartButton = New System.Windows.Forms.Button()
        Me.trimEndButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&User entry:"
        '
        'entryTextBox
        '
        Me.entryTextBox.Location = New System.Drawing.Point(47, 37)
        Me.entryTextBox.Name = "entryTextBox"
        Me.entryTextBox.Size = New System.Drawing.Size(88, 25)
        Me.entryTextBox.TabIndex = 1
        '
        'trimButton
        '
        Me.trimButton.Location = New System.Drawing.Point(159, 17)
        Me.trimButton.Name = "trimButton"
        Me.trimButton.Size = New System.Drawing.Size(83, 27)
        Me.trimButton.TabIndex = 2
        Me.trimButton.Text = "&Trim"
        Me.trimButton.UseVisualStyleBackColor = True
        '
        'trimStartButton
        '
        Me.trimStartButton.Location = New System.Drawing.Point(159, 50)
        Me.trimStartButton.Name = "trimStartButton"
        Me.trimStartButton.Size = New System.Drawing.Size(83, 27)
        Me.trimStartButton.TabIndex = 3
        Me.trimStartButton.Text = "Trim&Start"
        Me.trimStartButton.UseVisualStyleBackColor = True
        '
        'trimEndButton
        '
        Me.trimEndButton.Location = New System.Drawing.Point(159, 83)
        Me.trimEndButton.Name = "trimEndButton"
        Me.trimEndButton.Size = New System.Drawing.Size(83, 27)
        Me.trimEndButton.TabIndex = 4
        Me.trimEndButton.Text = "Trim&End"
        Me.trimEndButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(159, 116)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(83, 27)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Result:"
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resultLabel.Location = New System.Drawing.Point(47, 94)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(88, 25)
        Me.resultLabel.TabIndex = 7
        Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 160)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.trimEndButton)
        Me.Controls.Add(Me.trimStartButton)
        Me.Controls.Add(Me.trimButton)
        Me.Controls.Add(Me.entryTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trim Methods"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents entryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents trimButton As System.Windows.Forms.Button
    Friend WithEvents trimStartButton As System.Windows.Forms.Button
    Friend WithEvents trimEndButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents resultLabel As System.Windows.Forms.Label

End Class
