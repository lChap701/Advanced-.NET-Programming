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
        Me.avgLabel = New System.Windows.Forms.Label()
        Me.forNextButton = New System.Windows.Forms.Button()
        Me.doLoopButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.forEachNextButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Average tip:"
        '
        'avgLabel
        '
        Me.avgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.avgLabel.Location = New System.Drawing.Point(33, 56)
        Me.avgLabel.Name = "avgLabel"
        Me.avgLabel.Size = New System.Drawing.Size(97, 28)
        Me.avgLabel.TabIndex = 5
        Me.avgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'forNextButton
        '
        Me.forNextButton.Location = New System.Drawing.Point(172, 43)
        Me.forNextButton.Name = "forNextButton"
        Me.forNextButton.Size = New System.Drawing.Size(111, 28)
        Me.forNextButton.TabIndex = 0
        Me.forNextButton.Text = "&For...Next"
        Me.forNextButton.UseVisualStyleBackColor = True
        '
        'doLoopButton
        '
        Me.doLoopButton.Location = New System.Drawing.Point(172, 77)
        Me.doLoopButton.Name = "doLoopButton"
        Me.doLoopButton.Size = New System.Drawing.Size(111, 28)
        Me.doLoopButton.TabIndex = 1
        Me.doLoopButton.Text = "&Do...Loop"
        Me.doLoopButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(172, 145)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(111, 28)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tips_Project.My.Resources.Resources.Waiter
        Me.PictureBox1.Location = New System.Drawing.Point(33, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'forEachNextButton
        '
        Me.forEachNextButton.Location = New System.Drawing.Point(172, 111)
        Me.forEachNextButton.Name = "forEachNextButton"
        Me.forEachNextButton.Size = New System.Drawing.Size(111, 28)
        Me.forEachNextButton.TabIndex = 2
        Me.forEachNextButton.Text = "For &Each...Next"
        Me.forEachNextButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 205)
        Me.Controls.Add(Me.forEachNextButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.doLoopButton)
        Me.Controls.Add(Me.forNextButton)
        Me.Controls.Add(Me.avgLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tips"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents avgLabel As System.Windows.Forms.Label
    Friend WithEvents forNextButton As System.Windows.Forms.Button
    Friend WithEvents doLoopButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents forEachNextButton As System.Windows.Forms.Button

End Class
