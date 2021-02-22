<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.totalPriceLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.totalOrderedLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.strawberryTextBox = New System.Windows.Forms.TextBox()
        Me.vanillaTextBox = New System.Windows.Forms.TextBox()
        Me.zipTextBox = New System.Windows.Forms.TextBox()
        Me.stateTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(174, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 40)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Order Form"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(319, 244)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(99, 41)
        Me.exitButton.TabIndex = 11
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(319, 195)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(99, 41)
        Me.clearButton.TabIndex = 10
        Me.clearButton.Text = "Clea&r"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(319, 146)
        Me.printButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(99, 41)
        Me.printButton.TabIndex = 9
        Me.printButton.Text = "&Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(319, 97)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(99, 41)
        Me.calcButton.TabIndex = 8
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'totalPriceLabel
        '
        Me.totalPriceLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalPriceLabel.Location = New System.Drawing.Point(319, 391)
        Me.totalPriceLabel.Name = "totalPriceLabel"
        Me.totalPriceLabel.Size = New System.Drawing.Size(106, 33)
        Me.totalPriceLabel.TabIndex = 22
        Me.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(315, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 21)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Total price:"
        '
        'totalOrderedLabel
        '
        Me.totalOrderedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalOrderedLabel.Location = New System.Drawing.Point(319, 321)
        Me.totalOrderedLabel.Name = "totalOrderedLabel"
        Me.totalOrderedLabel.Size = New System.Drawing.Size(53, 33)
        Me.totalOrderedLabel.TabIndex = 21
        Me.totalOrderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(315, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 21)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Total ordered:"
        '
        'strawberryTextBox
        '
        Me.strawberryTextBox.Location = New System.Drawing.Point(163, 382)
        Me.strawberryTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.strawberryTextBox.Name = "strawberryTextBox"
        Me.strawberryTextBox.Size = New System.Drawing.Size(42, 29)
        Me.strawberryTextBox.TabIndex = 16
        '
        'vanillaTextBox
        '
        Me.vanillaTextBox.Location = New System.Drawing.Point(44, 382)
        Me.vanillaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.vanillaTextBox.Name = "vanillaTextBox"
        Me.vanillaTextBox.Size = New System.Drawing.Size(42, 29)
        Me.vanillaTextBox.TabIndex = 18
        '
        'zipTextBox
        '
        Me.zipTextBox.Location = New System.Drawing.Point(142, 310)
        Me.zipTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.zipTextBox.Name = "zipTextBox"
        Me.zipTextBox.Size = New System.Drawing.Size(106, 29)
        Me.zipTextBox.TabIndex = 15
        '
        'stateTextBox
        '
        Me.stateTextBox.Location = New System.Drawing.Point(44, 310)
        Me.stateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(48, 29)
        Me.stateTextBox.TabIndex = 17
        '
        'cityTextBox
        '
        Me.cityTextBox.Location = New System.Drawing.Point(44, 245)
        Me.cityTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(204, 29)
        Me.cityTextBox.TabIndex = 14
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(44, 181)
        Me.addressTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(204, 29)
        Me.addressTextBox.TabIndex = 13
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(44, 121)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(204, 29)
        Me.nameTextBox.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(159, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Straw&berry:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "&Vanilla bean:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "&ZIP:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ci&ty:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cheese_Project.My.Resources.Resources.Cheese
        Me.PictureBox1.Location = New System.Drawing.Point(44, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 453)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.totalPriceLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.totalOrderedLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.strawberryTextBox)
        Me.Controls.Add(Me.vanillaTextBox)
        Me.Controls.Add(Me.zipTextBox)
        Me.Controls.Add(Me.stateTextBox)
        Me.Controls.Add(Me.cityTextBox)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Say Cheese!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents printButton As Button
    Friend WithEvents calcButton As Button
    Friend WithEvents totalPriceLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents totalOrderedLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents strawberryTextBox As TextBox
    Friend WithEvents vanillaTextBox As TextBox
    Friend WithEvents zipTextBox As TextBox
    Friend WithEvents stateTextBox As TextBox
    Friend WithEvents cityTextBox As TextBox
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
