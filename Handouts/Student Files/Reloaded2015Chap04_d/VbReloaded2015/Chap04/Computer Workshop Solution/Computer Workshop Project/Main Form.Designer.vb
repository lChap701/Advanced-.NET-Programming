<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numberTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(225, 61)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(77, 29)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(225, 26)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(77, 29)
        Me.calcButton.TabIndex = 2
        Me.calcButton.Text = "&Calculate"
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(93, 65)
        Me.totalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(110, 27)
        Me.totalLabel.TabIndex = 5
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total owed:"
        '
        'numberTextBox
        '
        Me.numberTextBox.Location = New System.Drawing.Point(141, 26)
        Me.numberTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.numberTextBox.Name = "numberTextBox"
        Me.numberTextBox.Size = New System.Drawing.Size(45, 25)
        Me.numberTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Number registered:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 124)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numberTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer Workshop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents calcButton As Button
    Friend WithEvents totalLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numberTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
