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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.profitLossLabel = New System.Windows.Forms.Label()
        Me.soldForTextBox = New System.Windows.Forms.TextBox()
        Me.dealerCostsTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.commissionLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car &sold for:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Dealer costs:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Profit (loss):"
        '
        'profitLossLabel
        '
        Me.profitLossLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.profitLossLabel.Location = New System.Drawing.Point(119, 109)
        Me.profitLossLabel.Name = "profitLossLabel"
        Me.profitLossLabel.Size = New System.Drawing.Size(81, 25)
        Me.profitLossLabel.TabIndex = 7
        Me.profitLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'soldForTextBox
        '
        Me.soldForTextBox.Location = New System.Drawing.Point(119, 22)
        Me.soldForTextBox.Name = "soldForTextBox"
        Me.soldForTextBox.Size = New System.Drawing.Size(81, 25)
        Me.soldForTextBox.TabIndex = 1
        '
        'dealerCostsTextBox
        '
        Me.dealerCostsTextBox.Location = New System.Drawing.Point(119, 67)
        Me.dealerCostsTextBox.Name = "dealerCostsTextBox"
        Me.dealerCostsTextBox.Size = New System.Drawing.Size(81, 25)
        Me.dealerCostsTextBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Commission:"
        '
        'commissionLabel
        '
        Me.commissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.commissionLabel.Location = New System.Drawing.Point(119, 156)
        Me.commissionLabel.Name = "commissionLabel"
        Me.commissionLabel.Size = New System.Drawing.Size(81, 25)
        Me.commissionLabel.TabIndex = 9
        Me.commissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(245, 113)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 27)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(245, 150)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 27)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 212)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.commissionLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dealerCostsTextBox)
        Me.Controls.Add(Me.soldForTextBox)
        Me.Controls.Add(Me.profitLossLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carley Auto-Mart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents profitLossLabel As Label
    Friend WithEvents soldForTextBox As TextBox
    Friend WithEvents dealerCostsTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents commissionLabel As Label
    Friend WithEvents calcButton As Button
    Friend WithEvents exitButton As Button
End Class
