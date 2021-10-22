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
        Me.addButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.workerListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Employee name:"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(13, 48)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(154, 25)
        Me.nameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Today's &workers:"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(196, 47)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(95, 25)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "&Add to List"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(196, 78)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(95, 25)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'workerListBox
        '
        Me.workerListBox.FormattingEnabled = True
        Me.workerListBox.ItemHeight = 17
        Me.workerListBox.Location = New System.Drawing.Point(16, 122)
        Me.workerListBox.Name = "workerListBox"
        Me.workerListBox.Size = New System.Drawing.Size(151, 89)
        Me.workerListBox.TabIndex = 5
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 233)
        Me.Controls.Add(Me.workerListBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jasper's Food Hut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents addButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents workerListBox As ListBox
End Class
