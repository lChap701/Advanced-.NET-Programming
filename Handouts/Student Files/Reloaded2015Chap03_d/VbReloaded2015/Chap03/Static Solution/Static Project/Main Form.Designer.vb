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
        Me.countButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'countButton
        '
        Me.countButton.Location = New System.Drawing.Point(214, 112)
        Me.countButton.Margin = New System.Windows.Forms.Padding(2)
        Me.countButton.Name = "countButton"
        Me.countButton.Size = New System.Drawing.Size(73, 27)
        Me.countButton.TabIndex = 0
        Me.countButton.Text = "&Count"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(291, 112)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(73, 27)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'messageLabel
        '
        Me.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.messageLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messageLabel.ForeColor = System.Drawing.Color.Red
        Me.messageLabel.Location = New System.Drawing.Point(32, 57)
        Me.messageLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(332, 34)
        Me.messageLabel.TabIndex = 2
        Me.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 188)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.countButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Counting Clicks"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents countButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents messageLabel As System.Windows.Forms.Label

End Class
