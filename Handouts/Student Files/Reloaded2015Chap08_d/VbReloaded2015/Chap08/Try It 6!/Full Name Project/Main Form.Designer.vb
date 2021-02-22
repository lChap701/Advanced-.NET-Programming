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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.firstTextBox = New System.Windows.Forms.TextBox()
        Me.initialTextBox = New System.Windows.Forms.TextBox()
        Me.lastTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fullLabel = New System.Windows.Forms.Label()
        Me.concatenateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&First name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Middle initial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Last name:"
        '
        'firstTextBox
        '
        Me.firstTextBox.Location = New System.Drawing.Point(26, 45)
        Me.firstTextBox.Name = "firstTextBox"
        Me.firstTextBox.Size = New System.Drawing.Size(170, 25)
        Me.firstTextBox.TabIndex = 1
        '
        'initialTextBox
        '
        Me.initialTextBox.Location = New System.Drawing.Point(220, 44)
        Me.initialTextBox.Name = "initialTextBox"
        Me.initialTextBox.Size = New System.Drawing.Size(37, 25)
        Me.initialTextBox.TabIndex = 3
        '
        'lastTextBox
        '
        Me.lastTextBox.Location = New System.Drawing.Point(326, 44)
        Me.lastTextBox.Name = "lastTextBox"
        Me.lastTextBox.Size = New System.Drawing.Size(170, 25)
        Me.lastTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Full name:"
        '
        'fullLabel
        '
        Me.fullLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fullLabel.Location = New System.Drawing.Point(26, 125)
        Me.fullLabel.Name = "fullLabel"
        Me.fullLabel.Size = New System.Drawing.Size(339, 47)
        Me.fullLabel.TabIndex = 9
        Me.fullLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'concatenateButton
        '
        Me.concatenateButton.Location = New System.Drawing.Point(385, 108)
        Me.concatenateButton.Name = "concatenateButton"
        Me.concatenateButton.Size = New System.Drawing.Size(111, 29)
        Me.concatenateButton.TabIndex = 6
        Me.concatenateButton.Text = "&Concatenate"
        Me.concatenateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(385, 143)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(111, 29)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 208)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.concatenateButton)
        Me.Controls.Add(Me.fullLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lastTextBox)
        Me.Controls.Add(Me.initialTextBox)
        Me.Controls.Add(Me.firstTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Full Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents firstTextBox As TextBox
    Friend WithEvents initialTextBox As TextBox
    Friend WithEvents lastTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents fullLabel As Label
    Friend WithEvents concatenateButton As Button
    Friend WithEvents exitButton As Button
End Class
