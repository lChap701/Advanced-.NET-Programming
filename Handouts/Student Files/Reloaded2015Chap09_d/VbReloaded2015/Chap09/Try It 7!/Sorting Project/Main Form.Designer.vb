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
        Me.paysListBox = New System.Windows.Forms.ListBox()
        Me.ascendButton = New System.Windows.Forms.Button()
        Me.reverseButton = New System.Windows.Forms.Button()
        Me.descendButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'paysListBox
        '
        Me.paysListBox.FormattingEnabled = True
        Me.paysListBox.ItemHeight = 17
        Me.paysListBox.Location = New System.Drawing.Point(29, 31)
        Me.paysListBox.Name = "paysListBox"
        Me.paysListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.paysListBox.Size = New System.Drawing.Size(60, 89)
        Me.paysListBox.TabIndex = 4
        '
        'ascendButton
        '
        Me.ascendButton.Location = New System.Drawing.Point(156, 31)
        Me.ascendButton.Name = "ascendButton"
        Me.ascendButton.Size = New System.Drawing.Size(90, 28)
        Me.ascendButton.TabIndex = 0
        Me.ascendButton.Text = "&Ascending"
        Me.ascendButton.UseVisualStyleBackColor = True
        '
        'reverseButton
        '
        Me.reverseButton.Location = New System.Drawing.Point(156, 65)
        Me.reverseButton.Name = "reverseButton"
        Me.reverseButton.Size = New System.Drawing.Size(90, 28)
        Me.reverseButton.TabIndex = 1
        Me.reverseButton.Text = "&Reversed"
        Me.reverseButton.UseVisualStyleBackColor = True
        '
        'descendButton
        '
        Me.descendButton.Location = New System.Drawing.Point(156, 99)
        Me.descendButton.Name = "descendButton"
        Me.descendButton.Size = New System.Drawing.Size(90, 28)
        Me.descendButton.TabIndex = 2
        Me.descendButton.Text = "&Descending"
        Me.descendButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(156, 133)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(90, 28)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 192)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.descendButton)
        Me.Controls.Add(Me.reverseButton)
        Me.Controls.Add(Me.ascendButton)
        Me.Controls.Add(Me.paysListBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sorting Examples"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents paysListBox As System.Windows.Forms.ListBox
    Friend WithEvents ascendButton As System.Windows.Forms.Button
    Friend WithEvents reverseButton As System.Windows.Forms.Button
    Friend WithEvents descendButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
