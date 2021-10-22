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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.salaryLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(163, 72)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(113, 36)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(163, 31)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(113, 36)
        Me.displayButton.TabIndex = 0
        Me.displayButton.Text = "&Display Salary"
        '
        'salaryLabel
        '
        Me.salaryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salaryLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salaryLabel.Location = New System.Drawing.Point(33, 56)
        Me.salaryLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.salaryLabel.Name = "salaryLabel"
        Me.salaryLabel.Size = New System.Drawing.Size(113, 45)
        Me.salaryLabel.TabIndex = 3
        Me.salaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "My salary:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 135)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.salaryLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Debugging Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents salaryLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
