<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sideTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.areaLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.perimeterLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Side measurement:"
        '
        'sideTextBox
        '
        Me.sideTextBox.Location = New System.Drawing.Point(170, 45)
        Me.sideTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.sideTextBox.Name = "sideTextBox"
        Me.sideTextBox.Size = New System.Drawing.Size(53, 27)
        Me.sideTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Area:"
        '
        'areaLabel
        '
        Me.areaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.areaLabel.Location = New System.Drawing.Point(126, 105)
        Me.areaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.areaLabel.Name = "areaLabel"
        Me.areaLabel.Size = New System.Drawing.Size(93, 29)
        Me.areaLabel.TabIndex = 5
        Me.areaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(355, 31)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(96, 31)
        Me.calcButton.TabIndex = 2
        Me.calcButton.Text = "&Calculate"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(355, 103)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(96, 31)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        '
        'perimeterLabel
        '
        Me.perimeterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.perimeterLabel.Location = New System.Drawing.Point(235, 105)
        Me.perimeterLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.perimeterLabel.Name = "perimeterLabel"
        Me.perimeterLabel.Size = New System.Drawing.Size(93, 29)
        Me.perimeterLabel.TabIndex = 7
        Me.perimeterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Perimeter:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Square_Project.My.Resources.Resources.Square
        Me.PictureBox1.Location = New System.Drawing.Point(12, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 168)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.perimeterLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.areaLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sideTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area and Perimeter -Square "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sideTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents areaLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents perimeterLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
