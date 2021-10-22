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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.operationTextBox = New System.Windows.Forms.TextBox()
        Me.num1TextBox = New System.Windows.Forms.TextBox()
        Me.num2TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Enter A for Addition, or S for Subtraction:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number &1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Number &2:"
        '
        'answerLabel
        '
        Me.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.answerLabel.Location = New System.Drawing.Point(224, 143)
        Me.answerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(65, 33)
        Me.answerLabel.TabIndex = 9
        Me.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(307, 108)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(96, 32)
        Me.calcButton.TabIndex = 6
        Me.calcButton.Text = "&Calculate"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(307, 144)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(96, 32)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        '
        'operationTextBox
        '
        Me.operationTextBox.Location = New System.Drawing.Point(276, 27)
        Me.operationTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.operationTextBox.Name = "operationTextBox"
        Me.operationTextBox.Size = New System.Drawing.Size(37, 25)
        Me.operationTextBox.TabIndex = 1
        '
        'num1TextBox
        '
        Me.num1TextBox.Location = New System.Drawing.Point(244, 67)
        Me.num1TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.num1TextBox.Name = "num1TextBox"
        Me.num1TextBox.Size = New System.Drawing.Size(52, 25)
        Me.num1TextBox.TabIndex = 3
        '
        'num2TextBox
        '
        Me.num2TextBox.Location = New System.Drawing.Point(244, 102)
        Me.num2TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.num2TextBox.Name = "num2TextBox"
        Me.num2TextBox.Size = New System.Drawing.Size(52, 25)
        Me.num2TextBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Answer:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AddSub_Project.My.Resources.Resources.AddSub
        Me.PictureBox1.Location = New System.Drawing.Point(28, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 215)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.num2TextBox)
        Me.Controls.Add(Me.num1TextBox)
        Me.Controls.Add(Me.operationTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addition and Subtraction Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents answerLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents operationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents num1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents num2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
