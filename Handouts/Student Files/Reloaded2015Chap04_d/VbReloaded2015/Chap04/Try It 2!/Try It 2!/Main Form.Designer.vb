<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ex1Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.ex2Button = New System.Windows.Forms.Button()
        Me.ex3Button = New System.Windows.Forms.Button()
        Me.ex4Button = New System.Windows.Forms.Button()
        Me.ex5Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ex1Button
        '
        Me.ex1Button.Location = New System.Drawing.Point(146, 28)
        Me.ex1Button.Name = "ex1Button"
        Me.ex1Button.Size = New System.Drawing.Size(89, 26)
        Me.ex1Button.TabIndex = 0
        Me.ex1Button.Text = "Example &1"
        Me.ex1Button.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(146, 188)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(89, 26)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'answerLabel
        '
        Me.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.answerLabel.Location = New System.Drawing.Point(36, 76)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(74, 42)
        Me.answerLabel.TabIndex = 6
        Me.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ex2Button
        '
        Me.ex2Button.Location = New System.Drawing.Point(146, 60)
        Me.ex2Button.Name = "ex2Button"
        Me.ex2Button.Size = New System.Drawing.Size(89, 26)
        Me.ex2Button.TabIndex = 1
        Me.ex2Button.Text = "Example &2"
        Me.ex2Button.UseVisualStyleBackColor = True
        '
        'ex3Button
        '
        Me.ex3Button.Location = New System.Drawing.Point(146, 92)
        Me.ex3Button.Name = "ex3Button"
        Me.ex3Button.Size = New System.Drawing.Size(89, 26)
        Me.ex3Button.TabIndex = 2
        Me.ex3Button.Text = "Example &3"
        Me.ex3Button.UseVisualStyleBackColor = True
        '
        'ex4Button
        '
        Me.ex4Button.Location = New System.Drawing.Point(146, 124)
        Me.ex4Button.Name = "ex4Button"
        Me.ex4Button.Size = New System.Drawing.Size(89, 26)
        Me.ex4Button.TabIndex = 3
        Me.ex4Button.Text = "Example &4"
        Me.ex4Button.UseVisualStyleBackColor = True
        '
        'ex5Button
        '
        Me.ex5Button.Location = New System.Drawing.Point(146, 156)
        Me.ex5Button.Name = "ex5Button"
        Me.ex5Button.Size = New System.Drawing.Size(89, 26)
        Me.ex5Button.TabIndex = 4
        Me.ex5Button.Text = "Example &5"
        Me.ex5Button.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 236)
        Me.Controls.Add(Me.ex5Button)
        Me.Controls.Add(Me.ex4Button)
        Me.Controls.Add(Me.ex3Button)
        Me.Controls.Add(Me.ex2Button)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.ex1Button)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Division by Zero"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ex1Button As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents answerLabel As Label
    Friend WithEvents ex2Button As Button
    Friend WithEvents ex3Button As Button
    Friend WithEvents ex4Button As Button
    Friend WithEvents ex5Button As Button
End Class
