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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.projected1Label = New System.Windows.Forms.Label()
        Me.projected2Label = New System.Windows.Forms.Label()
        Me.projected3Label = New System.Windows.Forms.Label()
        Me.sales1TextBox = New System.Windows.Forms.TextBox()
        Me.percent1TextBox = New System.Windows.Forms.TextBox()
        Me.sales2TextBox = New System.Windows.Forms.TextBox()
        Me.percent2TextBox = New System.Windows.Forms.TextBox()
        Me.sales3TextBox = New System.Windows.Forms.TextBox()
        Me.percent3TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Region &1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Region &2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Region &3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Increase Percentage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "(in decimal form)"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(250, 229)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(83, 35)
        Me.calcButton.TabIndex = 9
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(339, 229)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(83, 35)
        Me.clearButton.TabIndex = 10
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(428, 229)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(83, 35)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(401, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Projected Sales"
        '
        'projected1Label
        '
        Me.projected1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.projected1Label.Location = New System.Drawing.Point(401, 68)
        Me.projected1Label.Name = "projected1Label"
        Me.projected1Label.Size = New System.Drawing.Size(110, 26)
        Me.projected1Label.TabIndex = 16
        Me.projected1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'projected2Label
        '
        Me.projected2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.projected2Label.Location = New System.Drawing.Point(401, 113)
        Me.projected2Label.Name = "projected2Label"
        Me.projected2Label.Size = New System.Drawing.Size(110, 26)
        Me.projected2Label.TabIndex = 17
        Me.projected2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'projected3Label
        '
        Me.projected3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.projected3Label.Location = New System.Drawing.Point(401, 158)
        Me.projected3Label.Name = "projected3Label"
        Me.projected3Label.Size = New System.Drawing.Size(110, 26)
        Me.projected3Label.TabIndex = 18
        Me.projected3Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sales1TextBox
        '
        Me.sales1TextBox.Location = New System.Drawing.Point(127, 68)
        Me.sales1TextBox.Name = "sales1TextBox"
        Me.sales1TextBox.Size = New System.Drawing.Size(75, 27)
        Me.sales1TextBox.TabIndex = 1
        '
        'percent1TextBox
        '
        Me.percent1TextBox.Location = New System.Drawing.Point(257, 68)
        Me.percent1TextBox.Name = "percent1TextBox"
        Me.percent1TextBox.Size = New System.Drawing.Size(55, 27)
        Me.percent1TextBox.TabIndex = 2
        '
        'sales2TextBox
        '
        Me.sales2TextBox.Location = New System.Drawing.Point(127, 113)
        Me.sales2TextBox.Name = "sales2TextBox"
        Me.sales2TextBox.Size = New System.Drawing.Size(75, 27)
        Me.sales2TextBox.TabIndex = 4
        '
        'percent2TextBox
        '
        Me.percent2TextBox.Location = New System.Drawing.Point(257, 113)
        Me.percent2TextBox.Name = "percent2TextBox"
        Me.percent2TextBox.Size = New System.Drawing.Size(55, 27)
        Me.percent2TextBox.TabIndex = 5
        '
        'sales3TextBox
        '
        Me.sales3TextBox.Location = New System.Drawing.Point(127, 158)
        Me.sales3TextBox.Name = "sales3TextBox"
        Me.sales3TextBox.Size = New System.Drawing.Size(75, 27)
        Me.sales3TextBox.TabIndex = 7
        '
        'percent3TextBox
        '
        Me.percent3TextBox.Location = New System.Drawing.Point(257, 158)
        Me.percent3TextBox.Name = "percent3TextBox"
        Me.percent3TextBox.Size = New System.Drawing.Size(55, 27)
        Me.percent3TextBox.TabIndex = 8
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 294)
        Me.Controls.Add(Me.percent3TextBox)
        Me.Controls.Add(Me.sales3TextBox)
        Me.Controls.Add(Me.percent2TextBox)
        Me.Controls.Add(Me.sales2TextBox)
        Me.Controls.Add(Me.percent1TextBox)
        Me.Controls.Add(Me.sales1TextBox)
        Me.Controls.Add(Me.projected3Label)
        Me.Controls.Add(Me.projected2Label)
        Me.Controls.Add(Me.projected1Label)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mason Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents projected1Label As System.Windows.Forms.Label
    Friend WithEvents projected2Label As System.Windows.Forms.Label
    Friend WithEvents projected3Label As System.Windows.Forms.Label
    Friend WithEvents sales1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents percent1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents sales2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents percent2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents sales3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents percent3TextBox As System.Windows.Forms.TextBox

End Class
