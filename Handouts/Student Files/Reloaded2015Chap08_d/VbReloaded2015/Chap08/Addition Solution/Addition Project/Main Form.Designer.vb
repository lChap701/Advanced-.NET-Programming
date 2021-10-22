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
        Me.firstLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.secondLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.answerTextBox = New System.Windows.Forms.TextBox()
        Me.newButton = New System.Windows.Forms.Button()
        Me.checkButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'firstLabel
        '
        Me.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstLabel.Location = New System.Drawing.Point(26, 81)
        Me.firstLabel.Name = "firstLabel"
        Me.firstLabel.Size = New System.Drawing.Size(39, 53)
        Me.firstLabel.TabIndex = 4
        Me.firstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Addition_Project.My.Resources.Resources.Plus
        Me.PictureBox1.Location = New System.Drawing.Point(90, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'secondLabel
        '
        Me.secondLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.secondLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondLabel.Location = New System.Drawing.Point(156, 81)
        Me.secondLabel.Name = "secondLabel"
        Me.secondLabel.Size = New System.Drawing.Size(39, 53)
        Me.secondLabel.TabIndex = 5
        Me.secondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Addition_Project.My.Resources.Resources.Equal
        Me.PictureBox2.Location = New System.Drawing.Point(220, 74)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 67)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'answerTextBox
        '
        Me.answerTextBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerTextBox.Location = New System.Drawing.Point(271, 89)
        Me.answerTextBox.Name = "answerTextBox"
        Me.answerTextBox.Size = New System.Drawing.Size(49, 35)
        Me.answerTextBox.TabIndex = 0
        '
        'newButton
        '
        Me.newButton.Location = New System.Drawing.Point(381, 92)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(100, 31)
        Me.newButton.TabIndex = 2
        Me.newButton.Text = "&New Problem"
        Me.newButton.UseVisualStyleBackColor = True
        '
        'checkButton
        '
        Me.checkButton.Location = New System.Drawing.Point(381, 55)
        Me.checkButton.Name = "checkButton"
        Me.checkButton.Size = New System.Drawing.Size(100, 31)
        Me.checkButton.TabIndex = 1
        Me.checkButton.Text = "&Check Answer"
        Me.checkButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(381, 129)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(100, 31)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.checkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 215)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.checkButton)
        Me.Controls.Add(Me.newButton)
        Me.Controls.Add(Me.answerTextBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.secondLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.firstLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addition Practice"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents secondLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents answerTextBox As TextBox
    Friend WithEvents newButton As Button
    Friend WithEvents checkButton As Button
    Friend WithEvents exitButton As Button
End Class
