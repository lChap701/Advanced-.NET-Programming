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
        Me.ex1Button = New System.Windows.Forms.Button()
        Me.ex2Button = New System.Windows.Forms.Button()
        Me.ex3Button = New System.Windows.Forms.Button()
        Me.ex4Button = New System.Windows.Forms.Button()
        Me.ex5Button = New System.Windows.Forms.Button()
        Me.ex6Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 63)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Use the comments entered in the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Code Editor window to write the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "appropriate as" & _
    "signment statements."
        '
        'ex1Button
        '
        Me.ex1Button.Location = New System.Drawing.Point(335, 40)
        Me.ex1Button.Name = "ex1Button"
        Me.ex1Button.Size = New System.Drawing.Size(93, 26)
        Me.ex1Button.TabIndex = 0
        Me.ex1Button.Text = "Example &1"
        Me.ex1Button.UseVisualStyleBackColor = True
        '
        'ex2Button
        '
        Me.ex2Button.Location = New System.Drawing.Point(335, 74)
        Me.ex2Button.Name = "ex2Button"
        Me.ex2Button.Size = New System.Drawing.Size(93, 26)
        Me.ex2Button.TabIndex = 1
        Me.ex2Button.Text = "Example &2"
        Me.ex2Button.UseVisualStyleBackColor = True
        '
        'ex3Button
        '
        Me.ex3Button.Location = New System.Drawing.Point(335, 108)
        Me.ex3Button.Name = "ex3Button"
        Me.ex3Button.Size = New System.Drawing.Size(93, 26)
        Me.ex3Button.TabIndex = 2
        Me.ex3Button.Text = "Example &3"
        Me.ex3Button.UseVisualStyleBackColor = True
        '
        'ex4Button
        '
        Me.ex4Button.Location = New System.Drawing.Point(335, 142)
        Me.ex4Button.Name = "ex4Button"
        Me.ex4Button.Size = New System.Drawing.Size(93, 26)
        Me.ex4Button.TabIndex = 3
        Me.ex4Button.Text = "Example &4"
        Me.ex4Button.UseVisualStyleBackColor = True
        '
        'ex5Button
        '
        Me.ex5Button.Location = New System.Drawing.Point(335, 176)
        Me.ex5Button.Name = "ex5Button"
        Me.ex5Button.Size = New System.Drawing.Size(93, 26)
        Me.ex5Button.TabIndex = 4
        Me.ex5Button.Text = "Example &5"
        Me.ex5Button.UseVisualStyleBackColor = True
        '
        'ex6Button
        '
        Me.ex6Button.Location = New System.Drawing.Point(335, 210)
        Me.ex6Button.Name = "ex6Button"
        Me.ex6Button.Size = New System.Drawing.Size(93, 26)
        Me.ex6Button.TabIndex = 5
        Me.ex6Button.Text = "Example &6"
        Me.ex6Button.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(335, 244)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(93, 26)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Answer:"
        '
        'answerLabel
        '
        Me.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.answerLabel.Location = New System.Drawing.Point(111, 147)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(83, 39)
        Me.answerLabel.TabIndex = 9
        Me.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 301)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.ex6Button)
        Me.Controls.Add(Me.ex5Button)
        Me.Controls.Add(Me.ex4Button)
        Me.Controls.Add(Me.ex3Button)
        Me.Controls.Add(Me.ex2Button)
        Me.Controls.Add(Me.ex1Button)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arithmetic Expressions in Assignment Statements"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ex1Button As System.Windows.Forms.Button
    Friend WithEvents ex2Button As System.Windows.Forms.Button
    Friend WithEvents ex3Button As System.Windows.Forms.Button
    Friend WithEvents ex4Button As System.Windows.Forms.Button
    Friend WithEvents ex5Button As System.Windows.Forms.Button
    Friend WithEvents ex6Button As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents answerLabel As System.Windows.Forms.Label

End Class
