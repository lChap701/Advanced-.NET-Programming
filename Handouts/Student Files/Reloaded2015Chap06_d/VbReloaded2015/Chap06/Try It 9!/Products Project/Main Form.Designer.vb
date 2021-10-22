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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idsListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Products_Project.My.Resources.Resources.Detective
        Me.PictureBox1.Location = New System.Drawing.Point(2, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Enter product ID:"
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(146, 39)
        Me.idTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(116, 25)
        Me.idTextBox.TabIndex = 1
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(290, 17)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(101, 30)
        Me.displayButton.TabIndex = 2
        Me.displayButton.Text = "&Display Price"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(290, 55)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(101, 30)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Product IDs:"
        '
        'idsListBox
        '
        Me.idsListBox.FormattingEnabled = True
        Me.idsListBox.ItemHeight = 17
        Me.idsListBox.Location = New System.Drawing.Point(145, 155)
        Me.idsListBox.Name = "idsListBox"
        Me.idsListBox.Size = New System.Drawing.Size(75, 89)
        Me.idsListBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price:"
        '
        'priceLabel
        '
        Me.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.priceLabel.Location = New System.Drawing.Point(146, 95)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(116, 25)
        Me.priceLabel.TabIndex = 7
        Me.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 277)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.idsListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.idTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Finder"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents displayButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents idsListBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents priceLabel As Label
End Class
