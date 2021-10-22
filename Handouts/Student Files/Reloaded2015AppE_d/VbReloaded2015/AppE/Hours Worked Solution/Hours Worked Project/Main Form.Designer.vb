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
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.week1TextBox = New System.Windows.Forms.TextBox()
        Me.week2TextBox = New System.Windows.Forms.TextBox()
        Me.week3TextBox = New System.Windows.Forms.TextBox()
        Me.week4TextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Week &1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Week &2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Week &3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Week &4:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total:"
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(185, 224)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(67, 32)
        Me.totalLabel.TabIndex = 11
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'week1TextBox
        '
        Me.week1TextBox.Location = New System.Drawing.Point(200, 34)
        Me.week1TextBox.Name = "week1TextBox"
        Me.week1TextBox.Size = New System.Drawing.Size(52, 27)
        Me.week1TextBox.TabIndex = 1
        '
        'week2TextBox
        '
        Me.week2TextBox.Location = New System.Drawing.Point(200, 81)
        Me.week2TextBox.Name = "week2TextBox"
        Me.week2TextBox.Size = New System.Drawing.Size(52, 27)
        Me.week2TextBox.TabIndex = 3
        '
        'week3TextBox
        '
        Me.week3TextBox.Location = New System.Drawing.Point(200, 128)
        Me.week3TextBox.Name = "week3TextBox"
        Me.week3TextBox.Size = New System.Drawing.Size(52, 27)
        Me.week3TextBox.TabIndex = 5
        '
        'week4TextBox
        '
        Me.week4TextBox.Location = New System.Drawing.Point(200, 175)
        Me.week4TextBox.Name = "week4TextBox"
        Me.week4TextBox.Size = New System.Drawing.Size(52, 27)
        Me.week4TextBox.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hours_Worked_Project.My.Resources.Resources.Clock
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(277, 33)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(90, 29)
        Me.calcButton.TabIndex = 8
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(277, 68)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(90, 29)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 279)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.week4TextBox)
        Me.Controls.Add(Me.week3TextBox)
        Me.Controls.Add(Me.week2TextBox)
        Me.Controls.Add(Me.week1TextBox)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hours Worked"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents week1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents week2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents week3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents week4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
