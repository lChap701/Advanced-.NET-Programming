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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.averageLabel = New System.Windows.Forms.Label()
        Me.test1TextBox = New System.Windows.Forms.TextBox()
        Me.test2TextBox = New System.Windows.Forms.TextBox()
        Me.test3TextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Test &1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Test &2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Test &3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Average:"
        '
        'averageLabel
        '
        Me.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.averageLabel.Location = New System.Drawing.Point(82, 163)
        Me.averageLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.averageLabel.Name = "averageLabel"
        Me.averageLabel.Size = New System.Drawing.Size(78, 26)
        Me.averageLabel.TabIndex = 9
        Me.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'test1TextBox
        '
        Me.test1TextBox.Location = New System.Drawing.Point(72, 28)
        Me.test1TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.test1TextBox.Name = "test1TextBox"
        Me.test1TextBox.Size = New System.Drawing.Size(52, 25)
        Me.test1TextBox.TabIndex = 1
        '
        'test2TextBox
        '
        Me.test2TextBox.Location = New System.Drawing.Point(72, 68)
        Me.test2TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.test2TextBox.Name = "test2TextBox"
        Me.test2TextBox.Size = New System.Drawing.Size(52, 25)
        Me.test2TextBox.TabIndex = 3
        '
        'test3TextBox
        '
        Me.test3TextBox.Location = New System.Drawing.Point(72, 108)
        Me.test3TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.test3TextBox.Name = "test3TextBox"
        Me.test3TextBox.Size = New System.Drawing.Size(52, 25)
        Me.test3TextBox.TabIndex = 5
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(180, 20)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(95, 33)
        Me.calcButton.TabIndex = 6
        Me.calcButton.Text = "&Calculate"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(180, 60)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(95, 33)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 217)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.test3TextBox)
        Me.Controls.Add(Me.test2TextBox)
        Me.Controls.Add(Me.test1TextBox)
        Me.Controls.Add(Me.averageLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents averageLabel As System.Windows.Forms.Label
    Friend WithEvents test1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents test2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents test3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
