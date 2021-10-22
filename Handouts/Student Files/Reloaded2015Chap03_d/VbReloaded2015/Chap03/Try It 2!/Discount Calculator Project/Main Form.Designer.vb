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
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.disc15Button = New System.Windows.Forms.Button()
        Me.disc20Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.salesTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Discount:"
        '
        'discountLabel
        '
        Me.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discountLabel.Location = New System.Drawing.Point(311, 52)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(100, 27)
        Me.discountLabel.TabIndex = 6
        Me.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'disc15Button
        '
        Me.disc15Button.Location = New System.Drawing.Point(123, 98)
        Me.disc15Button.Name = "disc15Button"
        Me.disc15Button.Size = New System.Drawing.Size(122, 30)
        Me.disc15Button.TabIndex = 2
        Me.disc15Button.Text = "&15% Discount"
        Me.disc15Button.UseVisualStyleBackColor = True
        '
        'disc20Button
        '
        Me.disc20Button.Location = New System.Drawing.Point(251, 98)
        Me.disc20Button.Name = "disc20Button"
        Me.disc20Button.Size = New System.Drawing.Size(122, 30)
        Me.disc20Button.TabIndex = 3
        Me.disc20Button.Text = "&20% Discount"
        Me.disc20Button.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(379, 98)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 30)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'salesTextBox
        '
        Me.salesTextBox.Location = New System.Drawing.Point(163, 52)
        Me.salesTextBox.Name = "salesTextBox"
        Me.salesTextBox.Size = New System.Drawing.Size(100, 27)
        Me.salesTextBox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Discount_Calculator_Project.My.Resources.Resources.Calculator
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 167)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.salesTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.disc20Button)
        Me.Controls.Add(Me.disc15Button)
        Me.Controls.Add(Me.discountLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discount Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents discountLabel As System.Windows.Forms.Label
    Friend WithEvents disc15Button As System.Windows.Forms.Button
    Friend WithEvents disc20Button As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents salesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
