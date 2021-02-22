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
        Me.numTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.roundedLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.decimalComboBox = New System.Windows.Forms.ComboBox()
        Me.roundButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Number:"
        '
        'numTextBox
        '
        Me.numTextBox.Location = New System.Drawing.Point(18, 53)
        Me.numTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numTextBox.Name = "numTextBox"
        Me.numTextBox.Size = New System.Drawing.Size(81, 27)
        Me.numTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Rounded number:"
        '
        'roundedLabel
        '
        Me.roundedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.roundedLabel.Location = New System.Drawing.Point(293, 49)
        Me.roundedLabel.Name = "roundedLabel"
        Me.roundedLabel.Size = New System.Drawing.Size(129, 33)
        Me.roundedLabel.TabIndex = 7
        Me.roundedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Decimal places:"
        '
        'decimalComboBox
        '
        Me.decimalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.decimalComboBox.FormattingEnabled = True
        Me.decimalComboBox.Location = New System.Drawing.Point(153, 53)
        Me.decimalComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.decimalComboBox.Name = "decimalComboBox"
        Me.decimalComboBox.Size = New System.Drawing.Size(57, 28)
        Me.decimalComboBox.TabIndex = 3
        '
        'roundButton
        '
        Me.roundButton.Location = New System.Drawing.Point(450, 29)
        Me.roundButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.roundButton.Name = "roundButton"
        Me.roundButton.Size = New System.Drawing.Size(86, 34)
        Me.roundButton.TabIndex = 4
        Me.roundButton.Text = "&Round"
        Me.roundButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(450, 71)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(86, 34)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 131)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.roundButton)
        Me.Controls.Add(Me.decimalComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.roundedLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rounding Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents roundedLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents decimalComboBox As ComboBox
    Friend WithEvents roundButton As Button
    Friend WithEvents exitButton As Button
End Class
