<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.centimetersRadioButton = New System.Windows.Forms.RadioButton()
        Me.inchesRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.measurementTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.convertButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'centimetersRadioButton
        '
        Me.centimetersRadioButton.Checked = True
        Me.centimetersRadioButton.Location = New System.Drawing.Point(191, 47)
        Me.centimetersRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.centimetersRadioButton.Name = "centimetersRadioButton"
        Me.centimetersRadioButton.Size = New System.Drawing.Size(185, 26)
        Me.centimetersRadioButton.TabIndex = 2
        Me.centimetersRadioButton.TabStop = True
        Me.centimetersRadioButton.Text = "Inches to &Centimeters"
        '
        'inchesRadioButton
        '
        Me.inchesRadioButton.Location = New System.Drawing.Point(191, 84)
        Me.inchesRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.inchesRadioButton.Name = "inchesRadioButton"
        Me.inchesRadioButton.Size = New System.Drawing.Size(185, 26)
        Me.inchesRadioButton.TabIndex = 3
        Me.inchesRadioButton.Text = "Centimeters to &Inches"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Measurement:"
        '
        'measurementTextBox
        '
        Me.measurementTextBox.Location = New System.Drawing.Point(57, 72)
        Me.measurementTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.measurementTextBox.Name = "measurementTextBox"
        Me.measurementTextBox.Size = New System.Drawing.Size(55, 27)
        Me.measurementTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Result:"
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resultLabel.Location = New System.Drawing.Point(57, 148)
        Me.resultLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(81, 30)
        Me.resultLabel.TabIndex = 7
        Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'convertButton
        '
        Me.convertButton.Location = New System.Drawing.Point(167, 148)
        Me.convertButton.Margin = New System.Windows.Forms.Padding(2)
        Me.convertButton.Name = "convertButton"
        Me.convertButton.Size = New System.Drawing.Size(83, 30)
        Me.convertButton.TabIndex = 4
        Me.convertButton.Text = "Con&vert"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(254, 148)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(72, 30)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 226)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.convertButton)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.measurementTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inchesRadioButton)
        Me.Controls.Add(Me.centimetersRadioButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Measurement Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents centimetersRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents inchesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents measurementTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents resultLabel As System.Windows.Forms.Label
    Friend WithEvents convertButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
