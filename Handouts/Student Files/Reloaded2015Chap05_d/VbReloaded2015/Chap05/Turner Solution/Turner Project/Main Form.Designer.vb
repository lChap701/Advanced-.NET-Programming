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
        Me.codeTextBox = New System.Windows.Forms.TextBox()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.displayPictureBox = New System.Windows.Forms.PictureBox()
        Me.house1PictureBox = New System.Windows.Forms.PictureBox()
        Me.house2PictureBox = New System.Windows.Forms.PictureBox()
        Me.house3PictureBox = New System.Windows.Forms.PictureBox()
        Me.house4PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.house1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.house2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.house3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.house4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Code:"
        '
        'codeTextBox
        '
        Me.codeTextBox.Location = New System.Drawing.Point(71, 29)
        Me.codeTextBox.Name = "codeTextBox"
        Me.codeTextBox.Size = New System.Drawing.Size(37, 25)
        Me.codeTextBox.TabIndex = 1
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(242, 32)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(75, 28)
        Me.displayButton.TabIndex = 2
        Me.displayButton.Text = "&Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(242, 73)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 28)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'displayPictureBox
        '
        Me.displayPictureBox.Location = New System.Drawing.Point(26, 60)
        Me.displayPictureBox.Name = "displayPictureBox"
        Me.displayPictureBox.Size = New System.Drawing.Size(201, 179)
        Me.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox.TabIndex = 4
        Me.displayPictureBox.TabStop = False
        '
        'house1PictureBox
        '
        Me.house1PictureBox.Image = Global.Turner_Project.My.Resources.Resources.House1
        Me.house1PictureBox.Location = New System.Drawing.Point(380, 32)
        Me.house1PictureBox.Name = "house1PictureBox"
        Me.house1PictureBox.Size = New System.Drawing.Size(93, 64)
        Me.house1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.house1PictureBox.TabIndex = 5
        Me.house1PictureBox.TabStop = False
        '
        'house2PictureBox
        '
        Me.house2PictureBox.Image = Global.Turner_Project.My.Resources.Resources.House2
        Me.house2PictureBox.Location = New System.Drawing.Point(380, 102)
        Me.house2PictureBox.Name = "house2PictureBox"
        Me.house2PictureBox.Size = New System.Drawing.Size(100, 50)
        Me.house2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.house2PictureBox.TabIndex = 6
        Me.house2PictureBox.TabStop = False
        '
        'house3PictureBox
        '
        Me.house3PictureBox.Image = Global.Turner_Project.My.Resources.Resources.House3
        Me.house3PictureBox.Location = New System.Drawing.Point(380, 158)
        Me.house3PictureBox.Name = "house3PictureBox"
        Me.house3PictureBox.Size = New System.Drawing.Size(100, 50)
        Me.house3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.house3PictureBox.TabIndex = 7
        Me.house3PictureBox.TabStop = False
        '
        'house4PictureBox
        '
        Me.house4PictureBox.Image = Global.Turner_Project.My.Resources.Resources.House4
        Me.house4PictureBox.Location = New System.Drawing.Point(380, 214)
        Me.house4PictureBox.Name = "house4PictureBox"
        Me.house4PictureBox.Size = New System.Drawing.Size(100, 50)
        Me.house4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.house4PictureBox.TabIndex = 8
        Me.house4PictureBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 275)
        Me.Controls.Add(Me.house4PictureBox)
        Me.Controls.Add(Me.house3PictureBox)
        Me.Controls.Add(Me.house2PictureBox)
        Me.Controls.Add(Me.house1PictureBox)
        Me.Controls.Add(Me.displayPictureBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.codeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turner Realty"
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.house1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.house2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.house3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.house4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents codeTextBox As TextBox
    Friend WithEvents displayButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents displayPictureBox As PictureBox
    Friend WithEvents house1PictureBox As PictureBox
    Friend WithEvents house2PictureBox As PictureBox
    Friend WithEvents house3PictureBox As PictureBox
    Friend WithEvents house4PictureBox As PictureBox
End Class
