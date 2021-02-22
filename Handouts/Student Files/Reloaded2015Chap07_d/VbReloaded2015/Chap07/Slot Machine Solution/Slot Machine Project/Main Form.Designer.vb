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
        Me.leftPictureBox = New System.Windows.Forms.PictureBox()
        Me.centerPictureBox = New System.Windows.Forms.PictureBox()
        Me.rightPictureBox = New System.Windows.Forms.PictureBox()
        Me.clickHereButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.leftPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.centerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftPictureBox
        '
        Me.leftPictureBox.Location = New System.Drawing.Point(24, 34)
        Me.leftPictureBox.Name = "leftPictureBox"
        Me.leftPictureBox.Size = New System.Drawing.Size(126, 150)
        Me.leftPictureBox.TabIndex = 0
        Me.leftPictureBox.TabStop = False
        '
        'centerPictureBox
        '
        Me.centerPictureBox.Location = New System.Drawing.Point(156, 34)
        Me.centerPictureBox.Name = "centerPictureBox"
        Me.centerPictureBox.Size = New System.Drawing.Size(126, 150)
        Me.centerPictureBox.TabIndex = 1
        Me.centerPictureBox.TabStop = False
        '
        'rightPictureBox
        '
        Me.rightPictureBox.Location = New System.Drawing.Point(288, 34)
        Me.rightPictureBox.Name = "rightPictureBox"
        Me.rightPictureBox.Size = New System.Drawing.Size(126, 150)
        Me.rightPictureBox.TabIndex = 2
        Me.rightPictureBox.TabStop = False
        '
        'clickHereButton
        '
        Me.clickHereButton.BackgroundImage = Global.Slot_Machine_Project.My.Resources.Resources.ClickHere
        Me.clickHereButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.clickHereButton.Location = New System.Drawing.Point(435, 34)
        Me.clickHereButton.Name = "clickHereButton"
        Me.clickHereButton.Size = New System.Drawing.Size(98, 94)
        Me.clickHereButton.TabIndex = 0
        Me.clickHereButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(435, 148)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(98, 36)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 230)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clickHereButton)
        Me.Controls.Add(Me.rightPictureBox)
        Me.Controls.Add(Me.centerPictureBox)
        Me.Controls.Add(Me.leftPictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slot Machine"
        CType(Me.leftPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.centerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftPictureBox As PictureBox
    Friend WithEvents centerPictureBox As PictureBox
    Friend WithEvents rightPictureBox As PictureBox
    Friend WithEvents clickHereButton As Button
    Friend WithEvents exitButton As Button
End Class
