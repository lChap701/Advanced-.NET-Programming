<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.shippingLabel = New System.Windows.Forms.Label()
        Me.zipTextBox = New System.Windows.Forms.TextBox()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&ZIP code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Shipping charge:"
        '
        'shippingLabel
        '
        Me.shippingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shippingLabel.Location = New System.Drawing.Point(148, 54)
        Me.shippingLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.shippingLabel.Name = "shippingLabel"
        Me.shippingLabel.Size = New System.Drawing.Size(119, 26)
        Me.shippingLabel.TabIndex = 5
        Me.shippingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'zipTextBox
        '
        Me.zipTextBox.Location = New System.Drawing.Point(34, 54)
        Me.zipTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.zipTextBox.Name = "zipTextBox"
        Me.zipTextBox.Size = New System.Drawing.Size(90, 25)
        Me.zipTextBox.TabIndex = 1
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(22, 110)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(188, 37)
        Me.displayButton.TabIndex = 2
        Me.displayButton.Text = "&Display Shipping Charge"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(214, 110)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(55, 37)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 184)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.zipTextBox)
        Me.Controls.Add(Me.shippingLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping Charge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents shippingLabel As System.Windows.Forms.Label
    Friend WithEvents zipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
