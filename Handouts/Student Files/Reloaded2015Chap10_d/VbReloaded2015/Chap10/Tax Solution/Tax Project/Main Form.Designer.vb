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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.salesTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.ratesComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tax &rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sales tax:"
        '
        'taxLabel
        '
        Me.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taxLabel.Location = New System.Drawing.Point(86, 116)
        Me.taxLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(70, 26)
        Me.taxLabel.TabIndex = 7
        Me.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesTextBox
        '
        Me.salesTextBox.Location = New System.Drawing.Point(68, 22)
        Me.salesTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.salesTextBox.Name = "salesTextBox"
        Me.salesTextBox.Size = New System.Drawing.Size(87, 25)
        Me.salesTextBox.TabIndex = 1
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(177, 22)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(80, 33)
        Me.calcButton.TabIndex = 4
        Me.calcButton.Text = "&Calculate"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(177, 64)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(80, 33)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        '
        'ratesComboBox
        '
        Me.ratesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ratesComboBox.FormattingEnabled = True
        Me.ratesComboBox.Location = New System.Drawing.Point(86, 61)
        Me.ratesComboBox.Name = "ratesComboBox"
        Me.ratesComboBox.Size = New System.Drawing.Size(68, 25)
        Me.ratesComboBox.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 174)
        Me.Controls.Add(Me.ratesComboBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.salesTextBox)
        Me.Controls.Add(Me.taxLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Tax Calculator"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents taxLabel As System.Windows.Forms.Label
    Friend WithEvents salesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents ratesComboBox As ComboBox
End Class
