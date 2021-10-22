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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.commercialRadioButton = New System.Windows.Forms.RadioButton()
        Me.residentialRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.previousTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.currentTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.usageLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 30)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "We keep the lights on!"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.commercialRadioButton)
        Me.GroupBox1.Controls.Add(Me.residentialRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rate codes"
        '
        'commercialRadioButton
        '
        Me.commercialRadioButton.AutoSize = True
        Me.commercialRadioButton.Location = New System.Drawing.Point(15, 54)
        Me.commercialRadioButton.Name = "commercialRadioButton"
        Me.commercialRadioButton.Size = New System.Drawing.Size(115, 21)
        Me.commercialRadioButton.TabIndex = 1
        Me.commercialRadioButton.Text = "&2 - Commercial"
        Me.commercialRadioButton.UseVisualStyleBackColor = True
        '
        'residentialRadioButton
        '
        Me.residentialRadioButton.AutoSize = True
        Me.residentialRadioButton.Checked = True
        Me.residentialRadioButton.Location = New System.Drawing.Point(15, 26)
        Me.residentialRadioButton.Name = "residentialRadioButton"
        Me.residentialRadioButton.Size = New System.Drawing.Size(109, 21)
        Me.residentialRadioButton.TabIndex = 0
        Me.residentialRadioButton.TabStop = True
        Me.residentialRadioButton.Text = "&1 - Residential"
        Me.residentialRadioButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Previous reading:"
        '
        'previousTextBox
        '
        Me.previousTextBox.Location = New System.Drawing.Point(202, 95)
        Me.previousTextBox.Name = "previousTextBox"
        Me.previousTextBox.Size = New System.Drawing.Size(106, 25)
        Me.previousTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(314, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " Cu&rrent reading:"
        '
        'currentTextBox
        '
        Me.currentTextBox.Location = New System.Drawing.Point(321, 94)
        Me.currentTextBox.Name = "currentTextBox"
        Me.currentTextBox.Size = New System.Drawing.Size(106, 25)
        Me.currentTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Monthly usage:"
        '
        'usageLabel
        '
        Me.usageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usageLabel.Location = New System.Drawing.Point(202, 162)
        Me.usageLabel.Name = "usageLabel"
        Me.usageLabel.Size = New System.Drawing.Size(106, 25)
        Me.usageLabel.TabIndex = 9
        Me.usageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(314, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total charge:"
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(321, 162)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(106, 25)
        Me.totalLabel.TabIndex = 11
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(448, 74)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 27)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(448, 107)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 27)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 224)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.usageLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.currentTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.previousTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sumner Electric"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents commercialRadioButton As RadioButton
    Friend WithEvents residentialRadioButton As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents previousTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents currentTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents usageLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents calcButton As Button
    Friend WithEvents exitButton As Button
End Class
