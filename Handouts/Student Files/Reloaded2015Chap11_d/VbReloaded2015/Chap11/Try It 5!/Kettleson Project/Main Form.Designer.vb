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
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.membersListBox = New System.Windows.Forms.ListBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name:"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(22, 34)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(156, 25)
        Me.nameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Members:"
        '
        'membersListBox
        '
        Me.membersListBox.FormattingEnabled = True
        Me.membersListBox.ItemHeight = 17
        Me.membersListBox.Location = New System.Drawing.Point(22, 124)
        Me.membersListBox.Name = "membersListBox"
        Me.membersListBox.Size = New System.Drawing.Size(156, 106)
        Me.membersListBox.Sorted = True
        Me.membersListBox.TabIndex = 6
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(209, 34)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(156, 26)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "&Add Name to List"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(209, 124)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(156, 26)
        Me.deleteButton.TabIndex = 3
        Me.deleteButton.Text = "&Delete Selected Name"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(209, 156)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(156, 26)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.addButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 259)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.membersListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kettleson Club"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents membersListBox As System.Windows.Forms.ListBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
