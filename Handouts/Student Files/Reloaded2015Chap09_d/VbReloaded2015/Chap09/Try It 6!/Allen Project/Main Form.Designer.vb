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
        Me.cookieListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.soldTextBox = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chunkyChocLabel = New System.Windows.Forms.Label()
        Me.macadamiaLabel = New System.Windows.Forms.Label()
        Me.peanutButLabel = New System.Windows.Forms.Label()
        Me.snickerLabel = New System.Windows.Forms.Label()
        Me.sugarLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cookie Fund Raiser"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Cookie:"
        '
        'cookieListBox
        '
        Me.cookieListBox.FormattingEnabled = True
        Me.cookieListBox.ItemHeight = 17
        Me.cookieListBox.Location = New System.Drawing.Point(234, 77)
        Me.cookieListBox.Name = "cookieListBox"
        Me.cookieListBox.Size = New System.Drawing.Size(123, 89)
        Me.cookieListBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Sold:"
        '
        'soldTextBox
        '
        Me.soldTextBox.Location = New System.Drawing.Point(141, 77)
        Me.soldTextBox.Name = "soldTextBox"
        Me.soldTextBox.Size = New System.Drawing.Size(73, 25)
        Me.soldTextBox.TabIndex = 1
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(383, 74)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(90, 29)
        Me.addButton.TabIndex = 4
        Me.addButton.Text = "&Add to Total"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(383, 109)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(90, 29)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Chunky Chocolate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Macadamia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(231, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Peanut Butter:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(328, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Snickerdoodle:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(428, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Sugar:"
        '
        'chunkyChocLabel
        '
        Me.chunkyChocLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chunkyChocLabel.Location = New System.Drawing.Point(21, 248)
        Me.chunkyChocLabel.Name = "chunkyChocLabel"
        Me.chunkyChocLabel.Size = New System.Drawing.Size(43, 22)
        Me.chunkyChocLabel.TabIndex = 8
        Me.chunkyChocLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'macadamiaLabel
        '
        Me.macadamiaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.macadamiaLabel.Location = New System.Drawing.Point(142, 248)
        Me.macadamiaLabel.Name = "macadamiaLabel"
        Me.macadamiaLabel.Size = New System.Drawing.Size(43, 22)
        Me.macadamiaLabel.TabIndex = 10
        Me.macadamiaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'peanutButLabel
        '
        Me.peanutButLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.peanutButLabel.Location = New System.Drawing.Point(234, 248)
        Me.peanutButLabel.Name = "peanutButLabel"
        Me.peanutButLabel.Size = New System.Drawing.Size(43, 22)
        Me.peanutButLabel.TabIndex = 12
        Me.peanutButLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'snickerLabel
        '
        Me.snickerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.snickerLabel.Location = New System.Drawing.Point(331, 248)
        Me.snickerLabel.Name = "snickerLabel"
        Me.snickerLabel.Size = New System.Drawing.Size(43, 22)
        Me.snickerLabel.TabIndex = 14
        Me.snickerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sugarLabel
        '
        Me.sugarLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sugarLabel.Location = New System.Drawing.Point(431, 248)
        Me.sugarLabel.Name = "sugarLabel"
        Me.sugarLabel.Size = New System.Drawing.Size(43, 22)
        Me.sugarLabel.TabIndex = 16
        Me.sugarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Allen_Project.My.Resources.Resources.Cookie
        Me.PictureBox1.Location = New System.Drawing.Point(17, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AcceptButton = Me.addButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 292)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.sugarLabel)
        Me.Controls.Add(Me.snickerLabel)
        Me.Controls.Add(Me.peanutButLabel)
        Me.Controls.Add(Me.macadamiaLabel)
        Me.Controls.Add(Me.chunkyChocLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.soldTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cookieListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allen School"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cookieListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents soldTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chunkyChocLabel As System.Windows.Forms.Label
    Friend WithEvents macadamiaLabel As System.Windows.Forms.Label
    Friend WithEvents peanutButLabel As System.Windows.Forms.Label
    Friend WithEvents snickerLabel As System.Windows.Forms.Label
    Friend WithEvents sugarLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
