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
        Me.lastLabel = New System.Windows.Forms.Label()
        Me.firstLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lastLabel
        '
        Me.lastLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastLabel.Location = New System.Drawing.Point(158, 43)
        Me.lastLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lastLabel.Name = "lastLabel"
        Me.lastLabel.Size = New System.Drawing.Size(106, 121)
        Me.lastLabel.TabIndex = 5
        '
        'firstLabel
        '
        Me.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstLabel.Location = New System.Drawing.Point(24, 43)
        Me.firstLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.firstLabel.Name = "firstLabel"
        Me.firstLabel.Size = New System.Drawing.Size(106, 121)
        Me.firstLabel.TabIndex = 3
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(178, 190)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(86, 35)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(88, 190)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(86, 35)
        Me.displayButton.TabIndex = 0
        Me.displayButton.Text = "&Display"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last names:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First names:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 246)
        Me.Controls.Add(Me.lastLabel)
        Me.Controls.Add(Me.firstLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Debug Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lastLabel As System.Windows.Forms.Label
    Friend WithEvents firstLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
