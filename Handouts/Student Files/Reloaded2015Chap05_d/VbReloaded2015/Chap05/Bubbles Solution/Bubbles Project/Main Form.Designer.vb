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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.costLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.basicRadioButton = New System.Windows.Forms.RadioButton()
        Me.silverRadioButton = New System.Windows.Forms.RadioButton()
        Me.ultimateRadioButton = New System.Windows.Forms.RadioButton()
        Me.exteriorRadioButton = New System.Windows.Forms.RadioButton()
        Me.interiorExteriorRadioButton = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bubbles_Project.My.Resources.Resources.Bubbles
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(123, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bubbles Car Wash"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total cost:"
        '
        'costLabel
        '
        Me.costLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.costLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costLabel.Location = New System.Drawing.Point(98, 208)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(116, 34)
        Me.costLabel.TabIndex = 7
        Me.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(228, 208)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 34)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(309, 208)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 34)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ultimateRadioButton)
        Me.GroupBox1.Controls.Add(Me.silverRadioButton)
        Me.GroupBox1.Controls.Add(Me.basicRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(91, 117)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Package"
        '
        'basicRadioButton
        '
        Me.basicRadioButton.AutoSize = True
        Me.basicRadioButton.Checked = True
        Me.basicRadioButton.Location = New System.Drawing.Point(8, 25)
        Me.basicRadioButton.Name = "basicRadioButton"
        Me.basicRadioButton.Size = New System.Drawing.Size(55, 21)
        Me.basicRadioButton.TabIndex = 0
        Me.basicRadioButton.TabStop = True
        Me.basicRadioButton.Text = "&Basic"
        Me.basicRadioButton.UseVisualStyleBackColor = True
        '
        'silverRadioButton
        '
        Me.silverRadioButton.AutoSize = True
        Me.silverRadioButton.Location = New System.Drawing.Point(8, 53)
        Me.silverRadioButton.Name = "silverRadioButton"
        Me.silverRadioButton.Size = New System.Drawing.Size(57, 21)
        Me.silverRadioButton.TabIndex = 1
        Me.silverRadioButton.Text = "&Silver"
        Me.silverRadioButton.UseVisualStyleBackColor = True
        '
        'ultimateRadioButton
        '
        Me.ultimateRadioButton.AutoSize = True
        Me.ultimateRadioButton.Location = New System.Drawing.Point(8, 81)
        Me.ultimateRadioButton.Name = "ultimateRadioButton"
        Me.ultimateRadioButton.Size = New System.Drawing.Size(74, 21)
        Me.ultimateRadioButton.TabIndex = 2
        Me.ultimateRadioButton.Text = "&Ultimate"
        Me.ultimateRadioButton.UseVisualStyleBackColor = True
        '
        'exteriorRadioButton
        '
        Me.exteriorRadioButton.AutoSize = True
        Me.exteriorRadioButton.Checked = True
        Me.exteriorRadioButton.Location = New System.Drawing.Point(254, 57)
        Me.exteriorRadioButton.Name = "exteriorRadioButton"
        Me.exteriorRadioButton.Size = New System.Drawing.Size(99, 21)
        Me.exteriorRadioButton.TabIndex = 3
        Me.exteriorRadioButton.TabStop = True
        Me.exteriorRadioButton.Text = "&Exterior only"
        Me.exteriorRadioButton.UseVisualStyleBackColor = True
        '
        'interiorExteriorRadioButton
        '
        Me.interiorExteriorRadioButton.AutoSize = True
        Me.interiorExteriorRadioButton.Location = New System.Drawing.Point(254, 86)
        Me.interiorExteriorRadioButton.Name = "interiorExteriorRadioButton"
        Me.interiorExteriorRadioButton.Size = New System.Drawing.Size(143, 21)
        Me.interiorExteriorRadioButton.TabIndex = 4
        Me.interiorExteriorRadioButton.Text = "&Interior and exterior"
        Me.interiorExteriorRadioButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 265)
        Me.Controls.Add(Me.interiorExteriorRadioButton)
        Me.Controls.Add(Me.exteriorRadioButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.costLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bubbles Car Wash"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents costLabel As Label
    Friend WithEvents calcButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ultimateRadioButton As RadioButton
    Friend WithEvents silverRadioButton As RadioButton
    Friend WithEvents basicRadioButton As RadioButton
    Friend WithEvents exteriorRadioButton As RadioButton
    Friend WithEvents interiorExteriorRadioButton As RadioButton
End Class
