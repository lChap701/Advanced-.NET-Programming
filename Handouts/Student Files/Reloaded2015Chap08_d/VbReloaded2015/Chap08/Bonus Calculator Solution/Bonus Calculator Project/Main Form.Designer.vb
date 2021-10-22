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
        Me.bonusLabel = New System.Windows.Forms.Label()
        Me.reg1TextBox = New System.Windows.Forms.TextBox()
        Me.reg2TextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Region &1 sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Region &2 sales:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bonus amount:"
        '
        'bonusLabel
        '
        Me.bonusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bonusLabel.Location = New System.Drawing.Point(161, 132)
        Me.bonusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bonusLabel.Name = "bonusLabel"
        Me.bonusLabel.Size = New System.Drawing.Size(70, 26)
        Me.bonusLabel.TabIndex = 7
        Me.bonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'reg1TextBox
        '
        Me.reg1TextBox.Location = New System.Drawing.Point(161, 32)
        Me.reg1TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.reg1TextBox.Name = "reg1TextBox"
        Me.reg1TextBox.Size = New System.Drawing.Size(70, 25)
        Me.reg1TextBox.TabIndex = 1
        '
        'reg2TextBox
        '
        Me.reg2TextBox.Location = New System.Drawing.Point(161, 76)
        Me.reg2TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.reg2TextBox.Name = "reg2TextBox"
        Me.reg2TextBox.Size = New System.Drawing.Size(70, 25)
        Me.reg2TextBox.TabIndex = 3
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(64, 189)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(68, 31)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(154, 189)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(68, 31)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 246)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.reg2TextBox)
        Me.Controls.Add(Me.reg1TextBox)
        Me.Controls.Add(Me.bonusLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bonus Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bonusLabel As System.Windows.Forms.Label
    Friend WithEvents reg1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents reg2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
