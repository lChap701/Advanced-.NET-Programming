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
        Me.memoTextBox = New System.Windows.Forms.TextBox()
        Me.writeButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Enter your memo:"
        '
        'memoTextBox
        '
        Me.memoTextBox.Location = New System.Drawing.Point(23, 54)
        Me.memoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.memoTextBox.Multiline = True
        Me.memoTextBox.Name = "memoTextBox"
        Me.memoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.memoTextBox.Size = New System.Drawing.Size(380, 124)
        Me.memoTextBox.TabIndex = 1
        '
        'writeButton
        '
        Me.writeButton.Location = New System.Drawing.Point(221, 202)
        Me.writeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.writeButton.Name = "writeButton"
        Me.writeButton.Size = New System.Drawing.Size(89, 36)
        Me.writeButton.TabIndex = 2
        Me.writeButton.Text = "&Write"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(314, 202)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(89, 36)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 260)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.writeButton)
        Me.Controls.Add(Me.memoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents memoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents writeButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
