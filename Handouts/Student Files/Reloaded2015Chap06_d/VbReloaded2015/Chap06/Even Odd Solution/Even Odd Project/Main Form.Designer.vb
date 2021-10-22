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
        Me.pretestButton = New System.Windows.Forms.Button()
        Me.posttestButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pretestListBox = New System.Windows.Forms.ListBox()
        Me.posttestListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'pretestButton
        '
        Me.pretestButton.Location = New System.Drawing.Point(32, 195)
        Me.pretestButton.Margin = New System.Windows.Forms.Padding(2)
        Me.pretestButton.Name = "pretestButton"
        Me.pretestButton.Size = New System.Drawing.Size(128, 40)
        Me.pretestButton.TabIndex = 0
        Me.pretestButton.Text = "&Do...Loop Pretest"
        '
        'posttestButton
        '
        Me.posttestButton.Location = New System.Drawing.Point(164, 195)
        Me.posttestButton.Margin = New System.Windows.Forms.Padding(2)
        Me.posttestButton.Name = "posttestButton"
        Me.posttestButton.Size = New System.Drawing.Size(128, 40)
        Me.posttestButton.TabIndex = 1
        Me.posttestButton.Text = "Do...&Loop Posttest"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(296, 195)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(87, 40)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "&Even integers from 2 - 10:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Odd integers from 21 - 39:"
        '
        'pretestListBox
        '
        Me.pretestListBox.FormattingEnabled = True
        Me.pretestListBox.ItemHeight = 17
        Me.pretestListBox.Location = New System.Drawing.Point(32, 37)
        Me.pretestListBox.Name = "pretestListBox"
        Me.pretestListBox.Size = New System.Drawing.Size(41, 106)
        Me.pretestListBox.TabIndex = 4
        '
        'posttestListBox
        '
        Me.posttestListBox.FormattingEnabled = True
        Me.posttestListBox.ItemHeight = 17
        Me.posttestListBox.Location = New System.Drawing.Point(224, 36)
        Me.posttestListBox.Name = "posttestListBox"
        Me.posttestListBox.Size = New System.Drawing.Size(41, 140)
        Me.posttestListBox.TabIndex = 6
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 259)
        Me.Controls.Add(Me.posttestListBox)
        Me.Controls.Add(Me.pretestListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.posttestButton)
        Me.Controls.Add(Me.pretestButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Even Odd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pretestButton As System.Windows.Forms.Button
    Friend WithEvents posttestButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pretestListBox As System.Windows.Forms.ListBox
    Friend WithEvents posttestListBox As System.Windows.Forms.ListBox

End Class
