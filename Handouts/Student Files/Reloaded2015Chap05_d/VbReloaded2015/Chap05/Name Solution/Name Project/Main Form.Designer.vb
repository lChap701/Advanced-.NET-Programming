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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fullNameLabel = New System.Windows.Forms.Label()
        Me.firstTextBox = New System.Windows.Forms.TextBox()
        Me.lastTextBox = New System.Windows.Forms.TextBox()
        Me.concatenateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&First:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Last:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Full name:"
        '
        'fullNameLabel
        '
        Me.fullNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fullNameLabel.Location = New System.Drawing.Point(20, 181)
        Me.fullNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.fullNameLabel.Name = "fullNameLabel"
        Me.fullNameLabel.Size = New System.Drawing.Size(257, 26)
        Me.fullNameLabel.TabIndex = 7
        Me.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'firstTextBox
        '
        Me.firstTextBox.Location = New System.Drawing.Point(20, 49)
        Me.firstTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.firstTextBox.Name = "firstTextBox"
        Me.firstTextBox.Size = New System.Drawing.Size(169, 25)
        Me.firstTextBox.TabIndex = 1
        '
        'lastTextBox
        '
        Me.lastTextBox.Location = New System.Drawing.Point(20, 108)
        Me.lastTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.lastTextBox.Name = "lastTextBox"
        Me.lastTextBox.Size = New System.Drawing.Size(169, 25)
        Me.lastTextBox.TabIndex = 3
        '
        'concatenateButton
        '
        Me.concatenateButton.Location = New System.Drawing.Point(20, 241)
        Me.concatenateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.concatenateButton.Name = "concatenateButton"
        Me.concatenateButton.Size = New System.Drawing.Size(157, 31)
        Me.concatenateButton.TabIndex = 4
        Me.concatenateButton.Text = "&Concatenate Names"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(181, 241)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(96, 31)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 293)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.concatenateButton)
        Me.Controls.Add(Me.lastTextBox)
        Me.Controls.Add(Me.firstTextBox)
        Me.Controls.Add(Me.fullNameLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Names"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fullNameLabel As System.Windows.Forms.Label
    Friend WithEvents firstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lastTextBox As System.Windows.Forms.TextBox
    Friend WithEvents concatenateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
