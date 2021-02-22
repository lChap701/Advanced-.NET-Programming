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
        Me.minutesLabel = New System.Windows.Forms.Label()
        Me.secondsLabel = New System.Windows.Forms.Label()
        Me.version1Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.version2Button = New System.Windows.Forms.Button()
        Me.version3Button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Minutes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Seconds:"
        '
        'minutesLabel
        '
        Me.minutesLabel.AutoSize = True
        Me.minutesLabel.ForeColor = System.Drawing.Color.Red
        Me.minutesLabel.Location = New System.Drawing.Point(56, 213)
        Me.minutesLabel.Name = "minutesLabel"
        Me.minutesLabel.Size = New System.Drawing.Size(17, 20)
        Me.minutesLabel.TabIndex = 7
        Me.minutesLabel.Text = "0"
        Me.minutesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'secondsLabel
        '
        Me.secondsLabel.AutoSize = True
        Me.secondsLabel.ForeColor = System.Drawing.Color.Blue
        Me.secondsLabel.Location = New System.Drawing.Point(157, 213)
        Me.secondsLabel.Name = "secondsLabel"
        Me.secondsLabel.Size = New System.Drawing.Size(17, 20)
        Me.secondsLabel.TabIndex = 8
        Me.secondsLabel.Text = "0"
        Me.secondsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'version1Button
        '
        Me.version1Button.Location = New System.Drawing.Point(230, 25)
        Me.version1Button.Name = "version1Button"
        Me.version1Button.Size = New System.Drawing.Size(97, 32)
        Me.version1Button.TabIndex = 0
        Me.version1Button.Text = "Version &1"
        Me.version1Button.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(230, 139)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(97, 32)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'version2Button
        '
        Me.version2Button.Location = New System.Drawing.Point(230, 63)
        Me.version2Button.Name = "version2Button"
        Me.version2Button.Size = New System.Drawing.Size(97, 32)
        Me.version2Button.TabIndex = 1
        Me.version2Button.Text = "Version &2"
        Me.version2Button.UseVisualStyleBackColor = True
        '
        'version3Button
        '
        Me.version3Button.Location = New System.Drawing.Point(230, 101)
        Me.version3Button.Name = "version3Button"
        Me.version3Button.Size = New System.Drawing.Size(97, 32)
        Me.version3Button.TabIndex = 2
        Me.version3Button.Text = "Version &3"
        Me.version3Button.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Clock_Project.My.Resources.Resources.Clock
        Me.PictureBox1.Location = New System.Drawing.Point(23, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Image courtesy of openclipart.org"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 254)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.version3Button)
        Me.Controls.Add(Me.version2Button)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.version1Button)
        Me.Controls.Add(Me.secondsLabel)
        Me.Controls.Add(Me.minutesLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents minutesLabel As System.Windows.Forms.Label
    Friend WithEvents secondsLabel As System.Windows.Forms.Label
    Friend WithEvents version1Button As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents version2Button As System.Windows.Forms.Button
    Friend WithEvents version3Button As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
