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
        Me.sunTextBox = New System.Windows.Forms.TextBox()
        Me.satTextBox = New System.Windows.Forms.TextBox()
        Me.friTextBox = New System.Windows.Forms.TextBox()
        Me.thursTextBox = New System.Windows.Forms.TextBox()
        Me.wedTextBox = New System.Windows.Forms.TextBox()
        Me.tuesTextBox = New System.Windows.Forms.TextBox()
        Me.monTextBox = New System.Windows.Forms.TextBox()
        Me.totalWeekendLabel = New System.Windows.Forms.Label()
        Me.totalWeekdayLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(134, 11)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(55, 38)
        Me.exitButton.TabIndex = 39
        Me.exitButton.Text = "e&xit"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(11, 11)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(119, 38)
        Me.calcButton.TabIndex = 38
        Me.calcButton.Text = "Calculate Hours"
        '
        'sunTextBox
        '
        Me.sunTextBox.Location = New System.Drawing.Point(101, 227)
        Me.sunTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.sunTextBox.Name = "sunTextBox"
        Me.sunTextBox.Size = New System.Drawing.Size(29, 25)
        Me.sunTextBox.TabIndex = 37
        '
        'satTextBox
        '
        Me.satTextBox.Location = New System.Drawing.Point(101, 197)
        Me.satTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.satTextBox.Name = "satTextBox"
        Me.satTextBox.Size = New System.Drawing.Size(29, 25)
        Me.satTextBox.TabIndex = 36
        '
        'friTextBox
        '
        Me.friTextBox.Location = New System.Drawing.Point(101, 169)
        Me.friTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.friTextBox.Name = "friTextBox"
        Me.friTextBox.Size = New System.Drawing.Size(29, 25)
        Me.friTextBox.TabIndex = 35
        '
        'thursTextBox
        '
        Me.thursTextBox.Location = New System.Drawing.Point(101, 142)
        Me.thursTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.thursTextBox.Name = "thursTextBox"
        Me.thursTextBox.Size = New System.Drawing.Size(29, 25)
        Me.thursTextBox.TabIndex = 34
        '
        'wedTextBox
        '
        Me.wedTextBox.Location = New System.Drawing.Point(101, 114)
        Me.wedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.wedTextBox.Name = "wedTextBox"
        Me.wedTextBox.Size = New System.Drawing.Size(29, 25)
        Me.wedTextBox.TabIndex = 33
        '
        'tuesTextBox
        '
        Me.tuesTextBox.Location = New System.Drawing.Point(101, 87)
        Me.tuesTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.tuesTextBox.Name = "tuesTextBox"
        Me.tuesTextBox.Size = New System.Drawing.Size(29, 25)
        Me.tuesTextBox.TabIndex = 32
        '
        'monTextBox
        '
        Me.monTextBox.Location = New System.Drawing.Point(101, 63)
        Me.monTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.monTextBox.Name = "monTextBox"
        Me.monTextBox.Size = New System.Drawing.Size(29, 25)
        Me.monTextBox.TabIndex = 31
        '
        'totalWeekendLabel
        '
        Me.totalWeekendLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalWeekendLabel.Location = New System.Drawing.Point(302, 90)
        Me.totalWeekendLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalWeekendLabel.Name = "totalWeekendLabel"
        Me.totalWeekendLabel.Size = New System.Drawing.Size(46, 21)
        Me.totalWeekendLabel.TabIndex = 30
        '
        'totalWeekdayLabel
        '
        Me.totalWeekdayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalWeekdayLabel.Location = New System.Drawing.Point(286, 63)
        Me.totalWeekdayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalWeekdayLabel.Name = "totalWeekdayLabel"
        Me.totalWeekdayLabel.Size = New System.Drawing.Size(46, 21)
        Me.totalWeekdayLabel.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(134, 87)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 17)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "&Total Weekend Hours:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(134, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Total weekday hours:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 220)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "&Sunday"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 194)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "&saturday:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 159)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "&Friday"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Thu&rsday:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Wednesday:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "&Tuesday"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Monday:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 274)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.sunTextBox)
        Me.Controls.Add(Me.satTextBox)
        Me.Controls.Add(Me.friTextBox)
        Me.Controls.Add(Me.thursTextBox)
        Me.Controls.Add(Me.wedTextBox)
        Me.Controls.Add(Me.tuesTextBox)
        Me.Controls.Add(Me.monTextBox)
        Me.Controls.Add(Me.totalWeekendLabel)
        Me.Controls.Add(Me.totalWeekdayLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hours Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents sunTextBox As System.Windows.Forms.TextBox
    Friend WithEvents satTextBox As System.Windows.Forms.TextBox
    Friend WithEvents friTextBox As System.Windows.Forms.TextBox
    Friend WithEvents thursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents wedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tuesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents monTextBox As System.Windows.Forms.TextBox
    Friend WithEvents totalWeekendLabel As System.Windows.Forms.Label
    Friend WithEvents totalWeekdayLabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
