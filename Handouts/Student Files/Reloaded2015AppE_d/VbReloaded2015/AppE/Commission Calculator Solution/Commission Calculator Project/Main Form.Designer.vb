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
        Me.commLabel = New System.Windows.Forms.Label()
        Me.sales1TextBox = New System.Windows.Forms.TextBox()
        Me.sales2TextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sales3TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'commLabel
        '
        Me.commLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.commLabel.Location = New System.Drawing.Point(21, 118)
        Me.commLabel.Name = "commLabel"
        Me.commLabel.Size = New System.Drawing.Size(109, 29)
        Me.commLabel.TabIndex = 9
        Me.commLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sales1TextBox
        '
        Me.sales1TextBox.Location = New System.Drawing.Point(21, 46)
        Me.sales1TextBox.Name = "sales1TextBox"
        Me.sales1TextBox.Size = New System.Drawing.Size(76, 25)
        Me.sales1TextBox.TabIndex = 1
        '
        'sales2TextBox
        '
        Me.sales2TextBox.Location = New System.Drawing.Point(159, 46)
        Me.sales2TextBox.Name = "sales2TextBox"
        Me.sales2TextBox.Size = New System.Drawing.Size(76, 25)
        Me.sales2TextBox.TabIndex = 3
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(159, 110)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(144, 37)
        Me.calcButton.TabIndex = 6
        Me.calcButton.Text = "&Calculate Commission"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(319, 110)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(82, 37)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&First month:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Second month:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "10% commission:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&Third month:"
        '
        'sales3TextBox
        '
        Me.sales3TextBox.Location = New System.Drawing.Point(319, 46)
        Me.sales3TextBox.Name = "sales3TextBox"
        Me.sales3TextBox.Size = New System.Drawing.Size(76, 25)
        Me.sales3TextBox.TabIndex = 5
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 182)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sales3TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.sales2TextBox)
        Me.Controls.Add(Me.sales1TextBox)
        Me.Controls.Add(Me.commLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quarterly Commission Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents commLabel As System.Windows.Forms.Label
    Friend WithEvents sales1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents sales2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sales3TextBox As System.Windows.Forms.TextBox

End Class
