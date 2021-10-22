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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numberLabel = New System.Windows.Forms.Label()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Random floating-point number:"
        '
        'numberLabel
        '
        Me.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numberLabel.Location = New System.Drawing.Point(67, 57)
        Me.numberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.numberLabel.Name = "numberLabel"
        Me.numberLabel.Size = New System.Drawing.Size(251, 30)
        Me.numberLabel.TabIndex = 3
        Me.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(67, 121)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(231, 36)
        Me.displayButton.TabIndex = 0
        Me.displayButton.Text = "&Display Random Number"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(303, 121)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(63, 36)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 188)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.numberLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random Floating-Point Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numberLabel As System.Windows.Forms.Label
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
