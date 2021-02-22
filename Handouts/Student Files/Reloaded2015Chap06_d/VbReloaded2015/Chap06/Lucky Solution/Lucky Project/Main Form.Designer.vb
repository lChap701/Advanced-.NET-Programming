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
        Me.firstDiePictureBox = New System.Windows.Forms.PictureBox()
        Me.secondDiePictureBox = New System.Windows.Forms.PictureBox()
        Me.rollButton = New System.Windows.Forms.Button()
        Me.startOverButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.dot1PictureBox = New System.Windows.Forms.PictureBox()
        Me.dot2PictureBox = New System.Windows.Forms.PictureBox()
        Me.dot3PictureBox = New System.Windows.Forms.PictureBox()
        Me.dot4PictureBox = New System.Windows.Forms.PictureBox()
        Me.dot5PictureBox = New System.Windows.Forms.PictureBox()
        Me.dot6PictureBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pointsLabel = New System.Windows.Forms.Label()
        Me.numberLabel = New System.Windows.Forms.Label()
        CType(Me.firstDiePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.secondDiePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot5PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dot6PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Click the Roll 'Em button"
        '
        'firstDiePictureBox
        '
        Me.firstDiePictureBox.Location = New System.Drawing.Point(20, 69)
        Me.firstDiePictureBox.Name = "firstDiePictureBox"
        Me.firstDiePictureBox.Size = New System.Drawing.Size(113, 113)
        Me.firstDiePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.firstDiePictureBox.TabIndex = 1
        Me.firstDiePictureBox.TabStop = False
        '
        'secondDiePictureBox
        '
        Me.secondDiePictureBox.Location = New System.Drawing.Point(156, 69)
        Me.secondDiePictureBox.Name = "secondDiePictureBox"
        Me.secondDiePictureBox.Size = New System.Drawing.Size(113, 113)
        Me.secondDiePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.secondDiePictureBox.TabIndex = 2
        Me.secondDiePictureBox.TabStop = False
        '
        'rollButton
        '
        Me.rollButton.Location = New System.Drawing.Point(381, 30)
        Me.rollButton.Name = "rollButton"
        Me.rollButton.Size = New System.Drawing.Size(75, 27)
        Me.rollButton.TabIndex = 0
        Me.rollButton.Text = "&Roll 'Em"
        Me.rollButton.UseVisualStyleBackColor = True
        '
        'startOverButton
        '
        Me.startOverButton.Location = New System.Drawing.Point(381, 60)
        Me.startOverButton.Name = "startOverButton"
        Me.startOverButton.Size = New System.Drawing.Size(75, 27)
        Me.startOverButton.TabIndex = 1
        Me.startOverButton.Text = "&Start Over"
        Me.startOverButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(381, 90)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 27)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'dot1PictureBox
        '
        Me.dot1PictureBox.Image = Global.Lucky_Project.My.Resources.Resources.Dot1
        Me.dot1PictureBox.Location = New System.Drawing.Point(20, 259)
        Me.dot1PictureBox.Name = "dot1PictureBox"
        Me.dot1PictureBox.Size = New System.Drawing.Size(47, 71)
        Me.dot1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot1PictureBox.TabIndex = 6
        Me.dot1PictureBox.TabStop = False
        '
        'dot2PictureBox
        '
        Me.dot2PictureBox.Image = Global.Lucky_Project.My.Resources.Resources.Dot2
        Me.dot2PictureBox.Location = New System.Drawing.Point(73, 259)
        Me.dot2PictureBox.Name = "dot2PictureBox"
        Me.dot2PictureBox.Size = New System.Drawing.Size(47, 71)
        Me.dot2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot2PictureBox.TabIndex = 7
        Me.dot2PictureBox.TabStop = False
        '
        'dot3PictureBox
        '
        Me.dot3PictureBox.Image = Global.Lucky_Project.My.Resources.Resources.Dot3
        Me.dot3PictureBox.Location = New System.Drawing.Point(126, 259)
        Me.dot3PictureBox.Name = "dot3PictureBox"
        Me.dot3PictureBox.Size = New System.Drawing.Size(47, 71)
        Me.dot3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot3PictureBox.TabIndex = 8
        Me.dot3PictureBox.TabStop = False
        '
        'dot4PictureBox
        '
        Me.dot4PictureBox.Image = Global.Lucky_Project.My.Resources.Resources.Dot4
        Me.dot4PictureBox.Location = New System.Drawing.Point(179, 259)
        Me.dot4PictureBox.Name = "dot4PictureBox"
        Me.dot4PictureBox.Size = New System.Drawing.Size(47, 71)
        Me.dot4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot4PictureBox.TabIndex = 9
        Me.dot4PictureBox.TabStop = False
        '
        'dot5PictureBox
        '
        Me.dot5PictureBox.Image = Global.Lucky_Project.My.Resources.Resources.Dot5
        Me.dot5PictureBox.Location = New System.Drawing.Point(232, 259)
        Me.dot5PictureBox.Name = "dot5PictureBox"
        Me.dot5PictureBox.Size = New System.Drawing.Size(47, 71)
        Me.dot5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot5PictureBox.TabIndex = 10
        Me.dot5PictureBox.TabStop = False
        '
        'dot6PictureBox
        '
        Me.dot6PictureBox.Image = Global.Lucky_Project.My.Resources.Resources.Dot6
        Me.dot6PictureBox.Location = New System.Drawing.Point(285, 259)
        Me.dot6PictureBox.Name = "dot6PictureBox"
        Me.dot6PictureBox.Size = New System.Drawing.Size(47, 71)
        Me.dot6PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dot6PictureBox.TabIndex = 11
        Me.dot6PictureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Points:"
        '
        'pointsLabel
        '
        Me.pointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pointsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointsLabel.Location = New System.Drawing.Point(301, 50)
        Me.pointsLabel.Name = "pointsLabel"
        Me.pointsLabel.Size = New System.Drawing.Size(59, 33)
        Me.pointsLabel.TabIndex = 5
        Me.pointsLabel.Text = "10"
        Me.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numberLabel
        '
        Me.numberLabel.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberLabel.ForeColor = System.Drawing.Color.Red
        Me.numberLabel.Location = New System.Drawing.Point(301, 93)
        Me.numberLabel.Name = "numberLabel"
        Me.numberLabel.Size = New System.Drawing.Size(59, 89)
        Me.numberLabel.TabIndex = 6
        Me.numberLabel.Text = "7"
        Me.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.numberLabel.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 351)
        Me.Controls.Add(Me.numberLabel)
        Me.Controls.Add(Me.pointsLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dot6PictureBox)
        Me.Controls.Add(Me.dot5PictureBox)
        Me.Controls.Add(Me.dot4PictureBox)
        Me.Controls.Add(Me.dot3PictureBox)
        Me.Controls.Add(Me.dot2PictureBox)
        Me.Controls.Add(Me.dot1PictureBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.startOverButton)
        Me.Controls.Add(Me.rollButton)
        Me.Controls.Add(Me.secondDiePictureBox)
        Me.Controls.Add(Me.firstDiePictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lucky Number Game"
        CType(Me.firstDiePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.secondDiePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot5PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dot6PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents firstDiePictureBox As PictureBox
    Friend WithEvents secondDiePictureBox As PictureBox
    Friend WithEvents rollButton As Button
    Friend WithEvents startOverButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents dot1PictureBox As PictureBox
    Friend WithEvents dot2PictureBox As PictureBox
    Friend WithEvents dot3PictureBox As PictureBox
    Friend WithEvents dot4PictureBox As PictureBox
    Friend WithEvents dot5PictureBox As PictureBox
    Friend WithEvents dot6PictureBox As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pointsLabel As Label
    Friend WithEvents numberLabel As Label
End Class
