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
        Me.saveButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.scoreTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.namesListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(256, 27)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(63, 34)
        Me.saveButton.TabIndex = 4
        Me.saveButton.Text = "Sa&ve"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Score:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(256, 133)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(63, 34)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(169, 133)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(63, 34)
        Me.displayButton.TabIndex = 5
        Me.displayButton.Text = "&Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name:"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(15, 35)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(159, 25)
        Me.nameTextBox.TabIndex = 1
        '
        'scoreTextBox
        '
        Me.scoreTextBox.Location = New System.Drawing.Point(188, 35)
        Me.scoreTextBox.Name = "scoreTextBox"
        Me.scoreTextBox.Size = New System.Drawing.Size(36, 25)
        Me.scoreTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Student names:"
        '
        'namesListBox
        '
        Me.namesListBox.FormattingEnabled = True
        Me.namesListBox.ItemHeight = 17
        Me.namesListBox.Location = New System.Drawing.Point(15, 133)
        Me.namesListBox.Name = "namesListBox"
        Me.namesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.namesListBox.Size = New System.Drawing.Size(138, 106)
        Me.namesListBox.Sorted = True
        Me.namesListBox.TabIndex = 8
        Me.namesListBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 263)
        Me.Controls.Add(Me.namesListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.scoreTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents scoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents namesListBox As System.Windows.Forms.ListBox

End Class
