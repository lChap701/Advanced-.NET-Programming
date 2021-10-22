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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.jumpPictureBox = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.jumpButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.jumpPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jumpPictureBox
        '
        Me.jumpPictureBox.Location = New System.Drawing.Point(26, 25)
        Me.jumpPictureBox.Name = "jumpPictureBox"
        Me.jumpPictureBox.Size = New System.Drawing.Size(200, 200)
        Me.jumpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.jumpPictureBox.TabIndex = 0
        Me.jumpPictureBox.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "PixelGuy1.png")
        Me.ImageList1.Images.SetKeyName(1, "PixelGuy2.png")
        Me.ImageList1.Images.SetKeyName(2, "PixelGuy3.png")
        '
        'jumpButton
        '
        Me.jumpButton.Location = New System.Drawing.Point(243, 25)
        Me.jumpButton.Name = "jumpButton"
        Me.jumpButton.Size = New System.Drawing.Size(75, 27)
        Me.jumpButton.TabIndex = 0
        Me.jumpButton.Text = "&Jump"
        Me.jumpButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(243, 58)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 27)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 258)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.jumpButton)
        Me.Controls.Add(Me.jumpPictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jumping Pixel Man"
        CType(Me.jumpPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents jumpPictureBox As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents jumpButton As Button
    Friend WithEvents exitButton As Button
End Class
