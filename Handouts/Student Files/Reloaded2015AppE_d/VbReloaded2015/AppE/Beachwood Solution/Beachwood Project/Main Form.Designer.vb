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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.decafTextBox = New System.Windows.Forms.TextBox()
        Me.regularTextBox = New System.Windows.Forms.TextBox()
        Me.totalPriceLabel = New System.Windows.Forms.Label()
        Me.poundsLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shippingLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(173, 177)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(113, 32)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(173, 141)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(113, 32)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate Order"
        '
        'decafTextBox
        '
        Me.decafTextBox.Location = New System.Drawing.Point(99, 79)
        Me.decafTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.decafTextBox.Name = "decafTextBox"
        Me.decafTextBox.Size = New System.Drawing.Size(46, 25)
        Me.decafTextBox.TabIndex = 3
        '
        'regularTextBox
        '
        Me.regularTextBox.Location = New System.Drawing.Point(25, 79)
        Me.regularTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.regularTextBox.Name = "regularTextBox"
        Me.regularTextBox.Size = New System.Drawing.Size(46, 25)
        Me.regularTextBox.TabIndex = 1
        '
        'totalPriceLabel
        '
        Me.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalPriceLabel.Location = New System.Drawing.Point(25, 210)
        Me.totalPriceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalPriceLabel.Name = "totalPriceLabel"
        Me.totalPriceLabel.Size = New System.Drawing.Size(114, 26)
        Me.totalPriceLabel.TabIndex = 12
        Me.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'poundsLabel
        '
        Me.poundsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.poundsLabel.Location = New System.Drawing.Point(173, 80)
        Me.poundsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.poundsLabel.Name = "poundsLabel"
        Me.poundsLabel.Size = New System.Drawing.Size(46, 25)
        Me.poundsLabel.TabIndex = 8
        Me.poundsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 193)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Total price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(173, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Pounds ordered:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 61)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "&Decaf:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Regular:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Order Form"
        '
        'shippingLabel
        '
        Me.shippingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shippingLabel.Location = New System.Drawing.Point(25, 158)
        Me.shippingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.shippingLabel.Name = "shippingLabel"
        Me.shippingLabel.Size = New System.Drawing.Size(114, 26)
        Me.shippingLabel.TabIndex = 10
        Me.shippingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Shipping:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 258)
        Me.Controls.Add(Me.shippingLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.decafTextBox)
        Me.Controls.Add(Me.regularTextBox)
        Me.Controls.Add(Me.totalPriceLabel)
        Me.Controls.Add(Me.poundsLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beachwood Coffee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents decafTextBox As System.Windows.Forms.TextBox
    Friend WithEvents regularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents totalPriceLabel As System.Windows.Forms.Label
    Friend WithEvents poundsLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents shippingLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
