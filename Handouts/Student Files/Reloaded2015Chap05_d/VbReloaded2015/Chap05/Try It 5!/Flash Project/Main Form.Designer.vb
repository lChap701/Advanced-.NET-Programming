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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gb16RadioButton = New System.Windows.Forms.RadioButton()
        Me.gb8RadioButton = New System.Windows.Forms.RadioButton()
        Me.gb4RadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.twoRadioButton = New System.Windows.Forms.RadioButton()
        Me.oneRadioButton = New System.Windows.Forms.RadioButton()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customized Silicone Wristband Flash Drives"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Price for 100:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gb16RadioButton)
        Me.GroupBox1.Controls.Add(Me.gb8RadioButton)
        Me.GroupBox1.Controls.Add(Me.gb4RadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(93, 126)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Capacity"
        '
        'gb16RadioButton
        '
        Me.gb16RadioButton.AutoSize = True
        Me.gb16RadioButton.Location = New System.Drawing.Point(14, 85)
        Me.gb16RadioButton.Name = "gb16RadioButton"
        Me.gb16RadioButton.Size = New System.Drawing.Size(60, 21)
        Me.gb16RadioButton.TabIndex = 2
        Me.gb16RadioButton.TabStop = True
        Me.gb16RadioButton.Text = "&16 GB"
        Me.gb16RadioButton.UseVisualStyleBackColor = True
        '
        'gb8RadioButton
        '
        Me.gb8RadioButton.AutoSize = True
        Me.gb8RadioButton.Location = New System.Drawing.Point(14, 55)
        Me.gb8RadioButton.Name = "gb8RadioButton"
        Me.gb8RadioButton.Size = New System.Drawing.Size(53, 21)
        Me.gb8RadioButton.TabIndex = 1
        Me.gb8RadioButton.TabStop = True
        Me.gb8RadioButton.Text = "&8 GB"
        Me.gb8RadioButton.UseVisualStyleBackColor = True
        '
        'gb4RadioButton
        '
        Me.gb4RadioButton.AutoSize = True
        Me.gb4RadioButton.Checked = True
        Me.gb4RadioButton.Location = New System.Drawing.Point(14, 25)
        Me.gb4RadioButton.Name = "gb4RadioButton"
        Me.gb4RadioButton.Size = New System.Drawing.Size(53, 21)
        Me.gb4RadioButton.TabIndex = 0
        Me.gb4RadioButton.TabStop = True
        Me.gb4RadioButton.Text = "&4 GB"
        Me.gb4RadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.twoRadioButton)
        Me.GroupBox2.Controls.Add(Me.oneRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(187, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(124, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Screen printing"
        '
        'twoRadioButton
        '
        Me.twoRadioButton.AutoSize = True
        Me.twoRadioButton.Location = New System.Drawing.Point(11, 59)
        Me.twoRadioButton.Name = "twoRadioButton"
        Me.twoRadioButton.Size = New System.Drawing.Size(83, 21)
        Me.twoRadioButton.TabIndex = 1
        Me.twoRadioButton.TabStop = True
        Me.twoRadioButton.Text = "&Two sides"
        Me.twoRadioButton.UseVisualStyleBackColor = True
        '
        'oneRadioButton
        '
        Me.oneRadioButton.AutoSize = True
        Me.oneRadioButton.Checked = True
        Me.oneRadioButton.Location = New System.Drawing.Point(11, 29)
        Me.oneRadioButton.Name = "oneRadioButton"
        Me.oneRadioButton.Size = New System.Drawing.Size(78, 21)
        Me.oneRadioButton.TabIndex = 0
        Me.oneRadioButton.TabStop = True
        Me.oneRadioButton.Text = "&One side"
        Me.oneRadioButton.UseVisualStyleBackColor = True
        '
        'priceLabel
        '
        Me.priceLabel.BackColor = System.Drawing.Color.LightYellow
        Me.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.priceLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.Location = New System.Drawing.Point(34, 250)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(87, 26)
        Me.priceLabel.TabIndex = 6
        Me.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(146, 243)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(107, 33)
        Me.displayButton.TabIndex = 0
        Me.displayButton.Text = "&Display Price"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(259, 243)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 33)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 318)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In a Flash"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gb16RadioButton As RadioButton
    Friend WithEvents gb8RadioButton As RadioButton
    Friend WithEvents gb4RadioButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents twoRadioButton As RadioButton
    Friend WithEvents oneRadioButton As RadioButton
    Friend WithEvents priceLabel As Label
    Friend WithEvents displayButton As Button
    Friend WithEvents exitButton As Button
End Class
