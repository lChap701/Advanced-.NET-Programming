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
        Me.startsWithButton = New System.Windows.Forms.Button()
        Me.endsWithButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'startsWithButton
        '
        Me.startsWithButton.Location = New System.Drawing.Point(54, 28)
        Me.startsWithButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.startsWithButton.Name = "startsWithButton"
        Me.startsWithButton.Size = New System.Drawing.Size(87, 32)
        Me.startsWithButton.TabIndex = 0
        Me.startsWithButton.Text = "&StartsWith"
        Me.startsWithButton.UseVisualStyleBackColor = True
        '
        'endsWithButton
        '
        Me.endsWithButton.Location = New System.Drawing.Point(146, 28)
        Me.endsWithButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.endsWithButton.Name = "endsWithButton"
        Me.endsWithButton.Size = New System.Drawing.Size(87, 32)
        Me.endsWithButton.TabIndex = 1
        Me.endsWithButton.Text = "&EndsWith"
        Me.endsWithButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(240, 28)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(87, 32)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 88)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.endsWithButton)
        Me.Controls.Add(Me.startsWithButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartsWith and EndsWith Examples"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents startsWithButton As System.Windows.Forms.Button
    Friend WithEvents endsWithButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
