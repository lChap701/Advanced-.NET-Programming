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
        Me.modelTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newPriceTextBox = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.originalTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.discRateTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'modelTextBox
        '
        Me.modelTextBox.Location = New System.Drawing.Point(22, 41)
        Me.modelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.modelTextBox.Name = "modelTextBox"
        Me.modelTextBox.Size = New System.Drawing.Size(101, 25)
        Me.modelTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Model:"
        '
        'newPriceTextBox
        '
        Me.newPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.newPriceTextBox.Location = New System.Drawing.Point(464, 41)
        Me.newPriceTextBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.newPriceTextBox.Name = "newPriceTextBox"
        Me.newPriceTextBox.Size = New System.Drawing.Size(101, 25)
        Me.newPriceTextBox.TabIndex = 9
        Me.newPriceTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(464, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "New price:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(486, 97)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(79, 33)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(351, 97)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(131, 33)
        Me.calcButton.TabIndex = 6
        Me.calcButton.Text = "&Calculate New Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Discount rate (for example, .05):"
        '
        'originalTextBox
        '
        Me.originalTextBox.Location = New System.Drawing.Point(138, 41)
        Me.originalTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.originalTextBox.Name = "originalTextBox"
        Me.originalTextBox.Size = New System.Drawing.Size(65, 25)
        Me.originalTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Original price:"
        '
        'discRateTextBox
        '
        Me.discRateTextBox.Location = New System.Drawing.Point(248, 41)
        Me.discRateTextBox.Name = "discRateTextBox"
        Me.discRateTextBox.Size = New System.Drawing.Size(65, 25)
        Me.discRateTextBox.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Debug_Project.My.Resources.Resources.computer
        Me.PictureBox1.Location = New System.Drawing.Point(22, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 157)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.discRateTextBox)
        Me.Controls.Add(Me.modelTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newPriceTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.originalTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer Haven"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents modelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newPriceTextBox As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents originalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents discRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
