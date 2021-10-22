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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.basicTextBox = New System.Windows.Forms.TextBox()
        Me.tireCheckBox = New System.Windows.Forms.CheckBox()
        Me.handDryCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.costLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bubbles_Project.My.Resources.Resources.Bubbles
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(169, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bubbles Car Wash"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Basic fee:"
        '
        'basicTextBox
        '
        Me.basicTextBox.Location = New System.Drawing.Point(169, 80)
        Me.basicTextBox.Name = "basicTextBox"
        Me.basicTextBox.Size = New System.Drawing.Size(75, 25)
        Me.basicTextBox.TabIndex = 1
        '
        'tireCheckBox
        '
        Me.tireCheckBox.AutoSize = True
        Me.tireCheckBox.Location = New System.Drawing.Point(279, 60)
        Me.tireCheckBox.Name = "tireCheckBox"
        Me.tireCheckBox.Size = New System.Drawing.Size(126, 21)
        Me.tireCheckBox.TabIndex = 2
        Me.tireCheckBox.Text = "&Tire shine ($2.50)"
        Me.tireCheckBox.UseVisualStyleBackColor = True
        '
        'handDryCheckBox
        '
        Me.handDryCheckBox.AutoSize = True
        Me.handDryCheckBox.Location = New System.Drawing.Point(279, 88)
        Me.handDryCheckBox.Name = "handDryCheckBox"
        Me.handDryCheckBox.Size = New System.Drawing.Size(124, 21)
        Me.handDryCheckBox.TabIndex = 3
        Me.handDryCheckBox.Text = "&Hand dry ($3.50)"
        Me.handDryCheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 140)
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
        Me.costLabel.Location = New System.Drawing.Point(169, 157)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(91, 34)
        Me.costLabel.TabIndex = 7
        Me.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(274, 157)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 34)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(355, 157)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 34)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 220)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.costLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.handDryCheckBox)
        Me.Controls.Add(Me.tireCheckBox)
        Me.Controls.Add(Me.basicTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bubbles Car Wash"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents basicTextBox As TextBox
    Friend WithEvents tireCheckBox As CheckBox
    Friend WithEvents handDryCheckBox As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents costLabel As Label
    Friend WithEvents calcButton As Button
    Friend WithEvents exitButton As Button
End Class
