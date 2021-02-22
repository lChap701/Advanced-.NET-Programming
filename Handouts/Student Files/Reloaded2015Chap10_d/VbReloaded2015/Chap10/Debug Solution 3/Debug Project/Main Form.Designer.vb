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
        Me.lettersTextBox = New System.Windows.Forms.TextBox()
        Me.lettersWithSpacesLabel = New System.Windows.Forms.Label()
        Me.insertButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Enter 5 letters:"
        '
        'lettersTextBox
        '
        Me.lettersTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lettersTextBox.Location = New System.Drawing.Point(34, 49)
        Me.lettersTextBox.MaxLength = 5
        Me.lettersTextBox.Name = "lettersTextBox"
        Me.lettersTextBox.Size = New System.Drawing.Size(77, 25)
        Me.lettersTextBox.TabIndex = 1
        '
        'lettersWithSpacesLabel
        '
        Me.lettersWithSpacesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lettersWithSpacesLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lettersWithSpacesLabel.Location = New System.Drawing.Point(34, 92)
        Me.lettersWithSpacesLabel.Name = "lettersWithSpacesLabel"
        Me.lettersWithSpacesLabel.Size = New System.Drawing.Size(124, 33)
        Me.lettersWithSpacesLabel.TabIndex = 4
        '
        'insertButton
        '
        Me.insertButton.Location = New System.Drawing.Point(139, 46)
        Me.insertButton.Name = "insertButton"
        Me.insertButton.Size = New System.Drawing.Size(108, 28)
        Me.insertButton.TabIndex = 2
        Me.insertButton.Text = "&Insert Spaces"
        Me.insertButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(253, 46)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(60, 28)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 154)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.insertButton)
        Me.Controls.Add(Me.lettersWithSpacesLabel)
        Me.Controls.Add(Me.lettersTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Debugging Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lettersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lettersWithSpacesLabel As System.Windows.Forms.Label
    Friend WithEvents insertButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
