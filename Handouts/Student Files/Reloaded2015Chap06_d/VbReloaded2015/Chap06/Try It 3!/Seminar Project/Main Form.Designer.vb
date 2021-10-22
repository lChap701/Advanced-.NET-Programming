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
        Me.registrantsTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.averageLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of registrants:"
        '
        'registrantsTextBox
        '
        Me.registrantsTextBox.Location = New System.Drawing.Point(16, 43)
        Me.registrantsTextBox.Multiline = True
        Me.registrantsTextBox.Name = "registrantsTextBox"
        Me.registrantsTextBox.ReadOnly = True
        Me.registrantsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.registrantsTextBox.Size = New System.Drawing.Size(66, 149)
        Me.registrantsTextBox.TabIndex = 3
        Me.registrantsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Average number of registrants:"
        '
        'averageLabel
        '
        Me.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.averageLabel.Location = New System.Drawing.Point(172, 80)
        Me.averageLabel.Name = "averageLabel"
        Me.averageLabel.Size = New System.Drawing.Size(101, 25)
        Me.averageLabel.TabIndex = 5
        Me.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(149, 157)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(140, 35)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "&Calculate Average"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(295, 157)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(64, 35)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 213)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.averageLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.registrantsTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Seminar Registrants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents registrantsTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents averageLabel As Label
    Friend WithEvents calcButton As Button
    Friend WithEvents exitButton As Button
End Class
