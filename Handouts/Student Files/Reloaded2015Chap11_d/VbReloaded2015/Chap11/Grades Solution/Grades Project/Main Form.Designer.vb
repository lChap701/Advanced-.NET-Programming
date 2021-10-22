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
        Me.reportLabel = New System.Windows.Forms.Label()
        Me.getButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'reportLabel
        '
        Me.reportLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportLabel.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportLabel.Location = New System.Drawing.Point(11, 44)
        Me.reportLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.reportLabel.Name = "reportLabel"
        Me.reportLabel.Size = New System.Drawing.Size(288, 36)
        Me.reportLabel.TabIndex = 2
        Me.reportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'getButton
        '
        Me.getButton.Location = New System.Drawing.Point(117, 105)
        Me.getButton.Margin = New System.Windows.Forms.Padding(2)
        Me.getButton.Name = "getButton"
        Me.getButton.Size = New System.Drawing.Size(130, 35)
        Me.getButton.TabIndex = 0
        Me.getButton.Text = "&Get Student Info"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(251, 105)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(48, 35)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name and grades:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 170)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.getButton)
        Me.Controls.Add(Me.reportLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Name and Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents reportLabel As System.Windows.Forms.Label
    Friend WithEvents getButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
