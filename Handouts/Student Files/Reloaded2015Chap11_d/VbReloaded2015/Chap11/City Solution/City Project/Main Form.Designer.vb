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
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.locationsListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(206, 66)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(75, 31)
        Me.displayButton.TabIndex = 0
        Me.displayButton.Text = "&Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(206, 100)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 31)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Cities and states:"
        '
        'locationsListBox
        '
        Me.locationsListBox.FormattingEnabled = True
        Me.locationsListBox.ItemHeight = 17
        Me.locationsListBox.Location = New System.Drawing.Point(26, 66)
        Me.locationsListBox.Name = "locationsListBox"
        Me.locationsListBox.Size = New System.Drawing.Size(150, 157)
        Me.locationsListBox.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 271)
        Me.Controls.Add(Me.locationsListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cities and States"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents displayButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents locationsListBox As ListBox
End Class
