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
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.reverseButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name (First Last):"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(28, 42)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(295, 25)
        Me.nameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name (Last, First):"
        '
        'nameLabel
        '
        Me.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nameLabel.Location = New System.Drawing.Point(28, 103)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(295, 26)
        Me.nameLabel.TabIndex = 5
        '
        'reverseButton
        '
        Me.reverseButton.Location = New System.Drawing.Point(148, 152)
        Me.reverseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.reverseButton.Name = "reverseButton"
        Me.reverseButton.Size = New System.Drawing.Size(112, 31)
        Me.reverseButton.TabIndex = 2
        Me.reverseButton.Text = "&Reverse Name"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(264, 152)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(63, 31)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 212)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.reverseButton)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reverse Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents reverseButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
