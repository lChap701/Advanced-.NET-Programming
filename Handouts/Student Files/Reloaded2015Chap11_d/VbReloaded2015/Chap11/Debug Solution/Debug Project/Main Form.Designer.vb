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
        Me.bonusLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.salesTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.calcAndSaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(187, 151)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 34)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'bonusLabel
        '
        Me.bonusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bonusLabel.Location = New System.Drawing.Point(73, 100)
        Me.bonusLabel.Name = "bonusLabel"
        Me.bonusLabel.Size = New System.Drawing.Size(71, 26)
        Me.bonusLabel.TabIndex = 7
        Me.bonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bonus:"
        '
        'salesTextBox
        '
        Me.salesTextBox.Location = New System.Drawing.Point(72, 60)
        Me.salesTextBox.Name = "salesTextBox"
        Me.salesTextBox.Size = New System.Drawing.Size(72, 25)
        Me.salesTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Sales:"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(72, 24)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(160, 25)
        Me.nameTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name:"
        '
        'calcAndSaveButton
        '
        Me.calcAndSaveButton.Location = New System.Drawing.Point(27, 151)
        Me.calcAndSaveButton.Name = "calcAndSaveButton"
        Me.calcAndSaveButton.Size = New System.Drawing.Size(154, 34)
        Me.calcAndSaveButton.TabIndex = 4
        Me.calcAndSaveButton.Text = "&Calculate and Save"
        Me.calcAndSaveButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 213)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.bonusLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.salesTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calcAndSaveButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bonus Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents bonusLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents salesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents calcAndSaveButton As System.Windows.Forms.Button

End Class
