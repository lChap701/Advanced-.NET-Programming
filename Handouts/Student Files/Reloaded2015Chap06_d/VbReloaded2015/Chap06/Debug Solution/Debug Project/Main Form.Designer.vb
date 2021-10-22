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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.positiveLabel = New System.Windows.Forms.Label()
        Me.negativeLabel = New System.Windows.Forms.Label()
        Me.zeroLabel = New System.Windows.Forms.Label()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Positive integers:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Negative integers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Zeros:"
        '
        'positiveLabel
        '
        Me.positiveLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.positiveLabel.Location = New System.Drawing.Point(24, 51)
        Me.positiveLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.positiveLabel.Name = "positiveLabel"
        Me.positiveLabel.Size = New System.Drawing.Size(99, 29)
        Me.positiveLabel.TabIndex = 3
        Me.positiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'negativeLabel
        '
        Me.negativeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.negativeLabel.Location = New System.Drawing.Point(24, 118)
        Me.negativeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.negativeLabel.Name = "negativeLabel"
        Me.negativeLabel.Size = New System.Drawing.Size(99, 29)
        Me.negativeLabel.TabIndex = 5
        Me.negativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'zeroLabel
        '
        Me.zeroLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.zeroLabel.Location = New System.Drawing.Point(24, 186)
        Me.zeroLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.zeroLabel.Name = "zeroLabel"
        Me.zeroLabel.Size = New System.Drawing.Size(99, 29)
        Me.zeroLabel.TabIndex = 7
        Me.zeroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(162, 147)
        Me.enterButton.Margin = New System.Windows.Forms.Padding(2)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(116, 34)
        Me.enterButton.TabIndex = 0
        Me.enterButton.Text = "&Enter Integers"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(162, 186)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(116, 34)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 257)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.zeroLabel)
        Me.Controls.Add(Me.negativeLabel)
        Me.Controls.Add(Me.positiveLabel)
        Me.Controls.Add(Me.Label3)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents positiveLabel As System.Windows.Forms.Label
    Friend WithEvents negativeLabel As System.Windows.Forms.Label
    Friend WithEvents zeroLabel As System.Windows.Forms.Label
    Friend WithEvents enterButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
