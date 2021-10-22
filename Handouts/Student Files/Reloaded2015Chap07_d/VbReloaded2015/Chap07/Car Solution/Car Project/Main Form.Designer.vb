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
        Me.clickMeButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.msgLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Car_Project.My.Resources.Resources.Car
        Me.PictureBox1.Location = New System.Drawing.Point(48, 100)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(487, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'clickMeButton
        '
        Me.clickMeButton.Location = New System.Drawing.Point(357, 252)
        Me.clickMeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.clickMeButton.Name = "clickMeButton"
        Me.clickMeButton.Size = New System.Drawing.Size(85, 31)
        Me.clickMeButton.TabIndex = 0
        Me.clickMeButton.Text = "&Click Me"
        Me.clickMeButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(450, 252)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(85, 31)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'msgLabel
        '
        Me.msgLabel.AutoSize = True
        Me.msgLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgLabel.Location = New System.Drawing.Point(150, 45)
        Me.msgLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.msgLabel.Name = "msgLabel"
        Me.msgLabel.Size = New System.Drawing.Size(282, 45)
        Me.msgLabel.TabIndex = 2
        Me.msgLabel.Text = "I WANT THIS CAR!"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 331)
        Me.Controls.Add(Me.msgLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clickMeButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sports Car"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents clickMeButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents msgLabel As System.Windows.Forms.Label

End Class
