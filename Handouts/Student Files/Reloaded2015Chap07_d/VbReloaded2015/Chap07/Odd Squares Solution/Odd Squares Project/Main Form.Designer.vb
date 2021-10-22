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
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.squaresLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(88, 25)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(117, 37)
        Me.displayButton.TabIndex = 0
        Me.displayButton.Text = "&Display"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(88, 67)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(117, 37)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'squaresLabel
        '
        Me.squaresLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.squaresLabel.Location = New System.Drawing.Point(27, 25)
        Me.squaresLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.squaresLabel.Name = "squaresLabel"
        Me.squaresLabel.Size = New System.Drawing.Size(46, 127)
        Me.squaresLabel.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 190)
        Me.Controls.Add(Me.squaresLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Odd Squares"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents squaresLabel As System.Windows.Forms.Label

End Class
