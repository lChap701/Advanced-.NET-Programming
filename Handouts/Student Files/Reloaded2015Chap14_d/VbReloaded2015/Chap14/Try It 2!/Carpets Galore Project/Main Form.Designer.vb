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
        Me.lengthListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.widthListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.priceListBox = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sqYardsLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.costLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Length (feet):"
        '
        'lengthListBox
        '
        Me.lengthListBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lengthListBox.FormattingEnabled = True
        Me.lengthListBox.ItemHeight = 15
        Me.lengthListBox.Location = New System.Drawing.Point(125, 48)
        Me.lengthListBox.Name = "lengthListBox"
        Me.lengthListBox.Size = New System.Drawing.Size(70, 79)
        Me.lengthListBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Width (feet):"
        '
        'widthListBox
        '
        Me.widthListBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.widthListBox.FormattingEnabled = True
        Me.widthListBox.ItemHeight = 15
        Me.widthListBox.Location = New System.Drawing.Point(230, 48)
        Me.widthListBox.Name = "widthListBox"
        Me.widthListBox.Size = New System.Drawing.Size(70, 79)
        Me.widthListBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Price (per square yard):"
        '
        'priceListBox
        '
        Me.priceListBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceListBox.FormattingEnabled = True
        Me.priceListBox.ItemHeight = 15
        Me.priceListBox.Location = New System.Drawing.Point(328, 48)
        Me.priceListBox.Name = "priceListBox"
        Me.priceListBox.Size = New System.Drawing.Size(70, 79)
        Me.priceListBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Square yards:"
        '
        'sqYardsLabel
        '
        Me.sqYardsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sqYardsLabel.Location = New System.Drawing.Point(67, 161)
        Me.sqYardsLabel.Name = "sqYardsLabel"
        Me.sqYardsLabel.Size = New System.Drawing.Size(93, 28)
        Me.sqYardsLabel.TabIndex = 9
        Me.sqYardsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(172, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cost:"
        '
        'costLabel
        '
        Me.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.costLabel.Location = New System.Drawing.Point(172, 161)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(93, 28)
        Me.costLabel.TabIndex = 11
        Me.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(270, 157)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(73, 32)
        Me.calcButton.TabIndex = 6
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(349, 157)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(73, 32)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Carpets_Galore_Project.My.Resources.Resources.Carpet
        Me.PictureBox1.Location = New System.Drawing.Point(13, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 221)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.costLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sqYardsLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.priceListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.widthListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lengthListBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carpets Galore"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lengthListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents widthListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents priceListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sqYardsLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents costLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
