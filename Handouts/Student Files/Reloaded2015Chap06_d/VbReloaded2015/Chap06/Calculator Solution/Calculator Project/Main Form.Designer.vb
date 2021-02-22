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
        Me.numTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sumLabel = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.startOverButton = New System.Windows.Forms.Button()
        Me.numbersTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "List:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Number:"
        '
        'numTextBox
        '
        Me.numTextBox.Location = New System.Drawing.Point(29, 60)
        Me.numTextBox.Name = "numTextBox"
        Me.numTextBox.Size = New System.Drawing.Size(75, 27)
        Me.numTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sum:"
        '
        'sumLabel
        '
        Me.sumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sumLabel.Location = New System.Drawing.Point(129, 60)
        Me.sumLabel.Name = "sumLabel"
        Me.sumLabel.Size = New System.Drawing.Size(75, 27)
        Me.sumLabel.TabIndex = 6
        Me.sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(27, 183)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(77, 30)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "&Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(242, 183)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(77, 30)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'startOverButton
        '
        Me.startOverButton.Location = New System.Drawing.Point(110, 183)
        Me.startOverButton.Name = "startOverButton"
        Me.startOverButton.Size = New System.Drawing.Size(107, 30)
        Me.startOverButton.TabIndex = 3
        Me.startOverButton.Text = "&Start Over"
        Me.startOverButton.UseVisualStyleBackColor = True
        '
        'numbersTextBox
        '
        Me.numbersTextBox.Location = New System.Drawing.Point(244, 60)
        Me.numbersTextBox.Multiline = True
        Me.numbersTextBox.Name = "numbersTextBox"
        Me.numbersTextBox.ReadOnly = True
        Me.numbersTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.numbersTextBox.Size = New System.Drawing.Size(75, 99)
        Me.numbersTextBox.TabIndex = 8
        Me.numbersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MainForm
        '
        Me.AcceptButton = Me.addButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 240)
        Me.Controls.Add(Me.numbersTextBox)
        Me.Controls.Add(Me.startOverButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.sumLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sumLabel As System.Windows.Forms.Label
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents startOverButton As System.Windows.Forms.Button
    Friend WithEvents numbersTextBox As System.Windows.Forms.TextBox

End Class
