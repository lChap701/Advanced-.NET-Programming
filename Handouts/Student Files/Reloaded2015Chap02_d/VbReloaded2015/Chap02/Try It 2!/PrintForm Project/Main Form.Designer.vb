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
        Me.previewButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'previewButton
        '
        Me.previewButton.Location = New System.Drawing.Point(44, 215)
        Me.previewButton.Name = "previewButton"
        Me.previewButton.Size = New System.Drawing.Size(110, 31)
        Me.previewButton.TabIndex = 0
        Me.previewButton.Text = "Print Pre&view"
        Me.previewButton.UseVisualStyleBackColor = True
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(160, 215)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 31)
        Me.printButton.TabIndex = 1
        Me.printButton.Text = "&Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(241, 215)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 31)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PrintForm_Project.My.Resources.Resources.Dog
        Me.PictureBox1.Location = New System.Drawing.Point(89, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 278)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.previewButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrintForm Example"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents previewButton As Button
    Friend WithEvents printButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
