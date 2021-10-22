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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.revenueTextBox = New System.Windows.Forms.TextBox()
        Me.beginTextBox = New System.Windows.Forms.TextBox()
        Me.purchasesTextBox = New System.Windows.Forms.TextBox()
        Me.endingTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.costGoodsSoldLabel = New System.Windows.Forms.Label()
        Me.grossProfitLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Painters_Project.My.Resources.Resources.Painters
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Revenue:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Beginning inventory ($):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Purchases ($):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&Ending inventory ($):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cost of goods sold:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(399, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Gross profit:"
        '
        'revenueTextBox
        '
        Me.revenueTextBox.Location = New System.Drawing.Point(102, 43)
        Me.revenueTextBox.Name = "revenueTextBox"
        Me.revenueTextBox.Size = New System.Drawing.Size(80, 25)
        Me.revenueTextBox.TabIndex = 1
        '
        'beginTextBox
        '
        Me.beginTextBox.Location = New System.Drawing.Point(16, 30)
        Me.beginTextBox.Name = "beginTextBox"
        Me.beginTextBox.Size = New System.Drawing.Size(64, 25)
        Me.beginTextBox.TabIndex = 1
        '
        'purchasesTextBox
        '
        Me.purchasesTextBox.Location = New System.Drawing.Point(16, 87)
        Me.purchasesTextBox.Name = "purchasesTextBox"
        Me.purchasesTextBox.Size = New System.Drawing.Size(64, 25)
        Me.purchasesTextBox.TabIndex = 3
        '
        'endingTextBox
        '
        Me.endingTextBox.Location = New System.Drawing.Point(16, 141)
        Me.endingTextBox.Name = "endingTextBox"
        Me.endingTextBox.Size = New System.Drawing.Size(64, 25)
        Me.endingTextBox.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.costGoodsSoldLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.endingTextBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.purchasesTextBox)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.beginTextBox)
        Me.Panel1.Location = New System.Drawing.Point(188, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 243)
        Me.Panel1.TabIndex = 2
        '
        'costGoodsSoldLabel
        '
        Me.costGoodsSoldLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.costGoodsSoldLabel.Location = New System.Drawing.Point(16, 202)
        Me.costGoodsSoldLabel.Name = "costGoodsSoldLabel"
        Me.costGoodsSoldLabel.Size = New System.Drawing.Size(85, 25)
        Me.costGoodsSoldLabel.TabIndex = 7
        Me.costGoodsSoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grossProfitLabel
        '
        Me.grossProfitLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grossProfitLabel.Location = New System.Drawing.Point(399, 43)
        Me.grossProfitLabel.Name = "grossProfitLabel"
        Me.grossProfitLabel.Size = New System.Drawing.Size(78, 25)
        Me.grossProfitLabel.TabIndex = 6
        Me.grossProfitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(399, 80)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(78, 28)
        Me.calcButton.TabIndex = 3
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(399, 114)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(78, 28)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 268)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.grossProfitLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.revenueTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Painters Paradise"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents revenueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents beginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents purchasesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents endingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents costGoodsSoldLabel As System.Windows.Forms.Label
    Friend WithEvents grossProfitLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
