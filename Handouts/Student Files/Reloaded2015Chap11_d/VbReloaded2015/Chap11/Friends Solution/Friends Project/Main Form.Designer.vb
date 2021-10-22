<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.friendsComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(215, 116)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(96, 34)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(215, 75)
        Me.removeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(96, 34)
        Me.removeButton.TabIndex = 3
        Me.removeButton.Text = "&Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(215, 35)
        Me.addButton.Margin = New System.Windows.Forms.Padding(2)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(96, 34)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "&Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'friendsComboBox
        '
        Me.friendsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.friendsComboBox.FormattingEnabled = True
        Me.friendsComboBox.Location = New System.Drawing.Point(21, 43)
        Me.friendsComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.friendsComboBox.Name = "friendsComboBox"
        Me.friendsComboBox.Size = New System.Drawing.Size(173, 188)
        Me.friendsComboBox.Sorted = True
        Me.friendsComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Friends:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 256)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.friendsComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Friends"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents friendsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
