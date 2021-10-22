<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.shippingLabel = New System.Windows.Forms.Label()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(25, 97)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(151, 35)
        Me.displayButton.TabIndex = 2
        Me.displayButton.Text = "&Display Shipping"
        '
        'shippingLabel
        '
        Me.shippingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shippingLabel.Location = New System.Drawing.Point(140, 42)
        Me.shippingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.shippingLabel.Name = "shippingLabel"
        Me.shippingLabel.Size = New System.Drawing.Size(117, 26)
        Me.shippingLabel.TabIndex = 5
        Me.shippingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalTextBox
        '
        Me.totalTextBox.Location = New System.Drawing.Point(25, 42)
        Me.totalTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.Size = New System.Drawing.Size(87, 25)
        Me.totalTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Shipping charge:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Total price:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(180, 97)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(77, 35)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AcceptButton = Me.displayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 159)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.shippingLabel)
        Me.Controls.Add(Me.totalTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping Charge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents shippingLabel As System.Windows.Forms.Label
    Friend WithEvents totalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
