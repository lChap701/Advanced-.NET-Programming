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
        Me.titlesListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.regionsListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.standsForLabel = New System.Windows.Forms.Label()
        Me.shippingLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "&Titles:"
        '
        'titlesListBox
        '
        Me.titlesListBox.FormattingEnabled = True
        Me.titlesListBox.ItemHeight = 17
        Me.titlesListBox.Location = New System.Drawing.Point(234, 45)
        Me.titlesListBox.Name = "titlesListBox"
        Me.titlesListBox.Size = New System.Drawing.Size(51, 72)
        Me.titlesListBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Regions:"
        '
        'regionsListBox
        '
        Me.regionsListBox.FormattingEnabled = True
        Me.regionsListBox.ItemHeight = 17
        Me.regionsListBox.Location = New System.Drawing.Point(24, 45)
        Me.regionsListBox.Name = "regionsListBox"
        Me.regionsListBox.Size = New System.Drawing.Size(34, 72)
        Me.regionsListBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Stands for:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Shipping:"
        '
        'standsForLabel
        '
        Me.standsForLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.standsForLabel.Location = New System.Drawing.Point(319, 45)
        Me.standsForLabel.Name = "standsForLabel"
        Me.standsForLabel.Size = New System.Drawing.Size(179, 26)
        Me.standsForLabel.TabIndex = 8
        Me.standsForLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'shippingLabel
        '
        Me.shippingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shippingLabel.Location = New System.Drawing.Point(103, 45)
        Me.shippingLabel.Name = "shippingLabel"
        Me.shippingLabel.Size = New System.Drawing.Size(78, 25)
        Me.shippingLabel.TabIndex = 6
        Me.shippingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(423, 102)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 32)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 169)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.shippingLabel)
        Me.Controls.Add(Me.standsForLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.regionsListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.titlesListBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListBox Events"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents titlesListBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents regionsListBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents standsForLabel As Label
    Friend WithEvents shippingLabel As Label
    Friend WithEvents exitButton As Button
End Class
