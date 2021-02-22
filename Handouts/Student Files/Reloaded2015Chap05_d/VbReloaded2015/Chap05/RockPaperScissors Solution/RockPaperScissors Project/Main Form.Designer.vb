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
        Me.playerRockPictureBox = New System.Windows.Forms.PictureBox()
        Me.playerPaperPictureBox = New System.Windows.Forms.PictureBox()
        Me.playerScissorsPictureBox = New System.Windows.Forms.PictureBox()
        Me.computerRockPictureBox = New System.Windows.Forms.PictureBox()
        Me.computerPaperPictureBox = New System.Windows.Forms.PictureBox()
        Me.computerScissorsPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.playerPictureBox = New System.Windows.Forms.PictureBox()
        Me.computerPictureBox = New System.Windows.Forms.PictureBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.winnerLabel = New System.Windows.Forms.Label()
        CType(Me.playerRockPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerPaperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerScissorsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.computerRockPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.computerPaperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.computerScissorsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.computerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Click the Rock, Paper, or Scissors image."
        '
        'playerRockPictureBox
        '
        Me.playerRockPictureBox.Image = Global.RockPaperScissors_Project.My.Resources.Resources.PlayerRock
        Me.playerRockPictureBox.Location = New System.Drawing.Point(41, 72)
        Me.playerRockPictureBox.Name = "playerRockPictureBox"
        Me.playerRockPictureBox.Size = New System.Drawing.Size(100, 77)
        Me.playerRockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerRockPictureBox.TabIndex = 1
        Me.playerRockPictureBox.TabStop = False
        '
        'playerPaperPictureBox
        '
        Me.playerPaperPictureBox.Image = Global.RockPaperScissors_Project.My.Resources.Resources.PlayerPaper
        Me.playerPaperPictureBox.Location = New System.Drawing.Point(165, 72)
        Me.playerPaperPictureBox.Name = "playerPaperPictureBox"
        Me.playerPaperPictureBox.Size = New System.Drawing.Size(100, 77)
        Me.playerPaperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerPaperPictureBox.TabIndex = 2
        Me.playerPaperPictureBox.TabStop = False
        '
        'playerScissorsPictureBox
        '
        Me.playerScissorsPictureBox.Image = Global.RockPaperScissors_Project.My.Resources.Resources.PlayerScissors
        Me.playerScissorsPictureBox.Location = New System.Drawing.Point(294, 72)
        Me.playerScissorsPictureBox.Name = "playerScissorsPictureBox"
        Me.playerScissorsPictureBox.Size = New System.Drawing.Size(100, 77)
        Me.playerScissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerScissorsPictureBox.TabIndex = 3
        Me.playerScissorsPictureBox.TabStop = False
        '
        'computerRockPictureBox
        '
        Me.computerRockPictureBox.Image = Global.RockPaperScissors_Project.My.Resources.Resources.ComputerRock
        Me.computerRockPictureBox.Location = New System.Drawing.Point(514, 23)
        Me.computerRockPictureBox.Name = "computerRockPictureBox"
        Me.computerRockPictureBox.Size = New System.Drawing.Size(100, 77)
        Me.computerRockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.computerRockPictureBox.TabIndex = 7
        Me.computerRockPictureBox.TabStop = False
        '
        'computerPaperPictureBox
        '
        Me.computerPaperPictureBox.Image = Global.RockPaperScissors_Project.My.Resources.Resources.ComputerPaper
        Me.computerPaperPictureBox.Location = New System.Drawing.Point(514, 107)
        Me.computerPaperPictureBox.Name = "computerPaperPictureBox"
        Me.computerPaperPictureBox.Size = New System.Drawing.Size(100, 77)
        Me.computerPaperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.computerPaperPictureBox.TabIndex = 8
        Me.computerPaperPictureBox.TabStop = False
        '
        'computerScissorsPictureBox
        '
        Me.computerScissorsPictureBox.Image = Global.RockPaperScissors_Project.My.Resources.Resources.ComputerScissors
        Me.computerScissorsPictureBox.Location = New System.Drawing.Point(514, 191)
        Me.computerScissorsPictureBox.Name = "computerScissorsPictureBox"
        Me.computerScissorsPictureBox.Size = New System.Drawing.Size(100, 77)
        Me.computerScissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.computerScissorsPictureBox.TabIndex = 9
        Me.computerScissorsPictureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Player:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(225, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Computer:"
        '
        'playerPictureBox
        '
        Me.playerPictureBox.Location = New System.Drawing.Point(110, 206)
        Me.playerPictureBox.Name = "playerPictureBox"
        Me.playerPictureBox.Size = New System.Drawing.Size(100, 77)
        Me.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerPictureBox.TabIndex = 12
        Me.playerPictureBox.TabStop = False
        '
        'computerPictureBox
        '
        Me.computerPictureBox.Location = New System.Drawing.Point(228, 206)
        Me.computerPictureBox.Name = "computerPictureBox"
        Me.computerPictureBox.Size = New System.Drawing.Size(100, 77)
        Me.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.computerPictureBox.TabIndex = 13
        Me.computerPictureBox.TabStop = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(330, 303)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 35)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'winnerLabel
        '
        Me.winnerLabel.BackColor = System.Drawing.SystemColors.Info
        Me.winnerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.winnerLabel.Location = New System.Drawing.Point(30, 303)
        Me.winnerLabel.Name = "winnerLabel"
        Me.winnerLabel.Size = New System.Drawing.Size(294, 35)
        Me.winnerLabel.TabIndex = 4
        Me.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 368)
        Me.Controls.Add(Me.winnerLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.computerPictureBox)
        Me.Controls.Add(Me.playerPictureBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.computerScissorsPictureBox)
        Me.Controls.Add(Me.computerPaperPictureBox)
        Me.Controls.Add(Me.computerRockPictureBox)
        Me.Controls.Add(Me.playerScissorsPictureBox)
        Me.Controls.Add(Me.playerPaperPictureBox)
        Me.Controls.Add(Me.playerRockPictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rock, Paper, Scissors Game"
        CType(Me.playerRockPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerPaperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerScissorsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.computerRockPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.computerPaperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.computerScissorsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.computerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents playerRockPictureBox As PictureBox
    Friend WithEvents playerPaperPictureBox As PictureBox
    Friend WithEvents playerScissorsPictureBox As PictureBox
    Friend WithEvents computerRockPictureBox As PictureBox
    Friend WithEvents computerPaperPictureBox As PictureBox
    Friend WithEvents computerScissorsPictureBox As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents playerPictureBox As PictureBox
    Friend WithEvents computerPictureBox As PictureBox
    Friend WithEvents exitButton As Button
    Friend WithEvents winnerLabel As Label
End Class
