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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.length3Button = New System.Windows.Forms.Button()
        Me.length2Button = New System.Windows.Forms.Button()
        Me.length1Button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.firstTextBox = New System.Windows.Forms.TextBox()
        Me.lastTextBox = New System.Windows.Forms.TextBox()
        Me.remove4Button = New System.Windows.Forms.Button()
        Me.stateTextBox = New System.Windows.Forms.TextBox()
        Me.remove3Button = New System.Windows.Forms.Button()
        Me.remove2Button = New System.Windows.Forms.Button()
        Me.trim1Button = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.insert2Button = New System.Windows.Forms.Button()
        Me.insert1Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cityTextBox)
        Me.GroupBox1.Controls.Add(Me.length3Button)
        Me.GroupBox1.Controls.Add(Me.length2Button)
        Me.GroupBox1.Controls.Add(Me.length1Button)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Length property"
        '
        'cityTextBox
        '
        Me.cityTextBox.Location = New System.Drawing.Point(8, 53)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(100, 25)
        Me.cityTextBox.TabIndex = 0
        Me.cityTextBox.Text = "Las Vegas"
        '
        'length3Button
        '
        Me.length3Button.Location = New System.Drawing.Point(120, 84)
        Me.length3Button.Name = "length3Button"
        Me.length3Button.Size = New System.Drawing.Size(104, 26)
        Me.length3Button.TabIndex = 3
        Me.length3Button.Text = "Example &3"
        Me.length3Button.UseVisualStyleBackColor = True
        '
        'length2Button
        '
        Me.length2Button.Location = New System.Drawing.Point(120, 54)
        Me.length2Button.Name = "length2Button"
        Me.length2Button.Size = New System.Drawing.Size(104, 26)
        Me.length2Button.TabIndex = 2
        Me.length2Button.Text = "Example &2"
        Me.length2Button.UseVisualStyleBackColor = True
        '
        'length1Button
        '
        Me.length1Button.Location = New System.Drawing.Point(120, 24)
        Me.length1Button.Name = "length1Button"
        Me.length1Button.Size = New System.Drawing.Size(104, 26)
        Me.length1Button.TabIndex = 1
        Me.length1Button.Text = "Example &1"
        Me.length1Button.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.firstTextBox)
        Me.GroupBox2.Controls.Add(Me.lastTextBox)
        Me.GroupBox2.Controls.Add(Me.remove4Button)
        Me.GroupBox2.Controls.Add(Me.stateTextBox)
        Me.GroupBox2.Controls.Add(Me.remove3Button)
        Me.GroupBox2.Controls.Add(Me.remove2Button)
        Me.GroupBox2.Controls.Add(Me.trim1Button)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 161)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Trim and Remove methods"
        '
        'firstTextBox
        '
        Me.firstTextBox.Location = New System.Drawing.Point(8, 89)
        Me.firstTextBox.Name = "firstTextBox"
        Me.firstTextBox.Size = New System.Drawing.Size(100, 25)
        Me.firstTextBox.TabIndex = 4
        Me.firstTextBox.Text = "firstTextBox"
        '
        'lastTextBox
        '
        Me.lastTextBox.Location = New System.Drawing.Point(8, 57)
        Me.lastTextBox.Name = "lastTextBox"
        Me.lastTextBox.Size = New System.Drawing.Size(100, 25)
        Me.lastTextBox.TabIndex = 2
        Me.lastTextBox.Text = "lastTextBox"
        '
        'remove4Button
        '
        Me.remove4Button.Location = New System.Drawing.Point(120, 116)
        Me.remove4Button.Name = "remove4Button"
        Me.remove4Button.Size = New System.Drawing.Size(133, 26)
        Me.remove4Button.TabIndex = 6
        Me.remove4Button.Text = "Remove Example &4"
        Me.remove4Button.UseVisualStyleBackColor = True
        '
        'stateTextBox
        '
        Me.stateTextBox.Location = New System.Drawing.Point(8, 26)
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(100, 25)
        Me.stateTextBox.TabIndex = 0
        Me.stateTextBox.Text = "   New York  "
        '
        'remove3Button
        '
        Me.remove3Button.Location = New System.Drawing.Point(120, 84)
        Me.remove3Button.Name = "remove3Button"
        Me.remove3Button.Size = New System.Drawing.Size(133, 26)
        Me.remove3Button.TabIndex = 5
        Me.remove3Button.Text = "Remove &Example 3"
        Me.remove3Button.UseVisualStyleBackColor = True
        '
        'remove2Button
        '
        Me.remove2Button.Location = New System.Drawing.Point(120, 54)
        Me.remove2Button.Name = "remove2Button"
        Me.remove2Button.Size = New System.Drawing.Size(133, 26)
        Me.remove2Button.TabIndex = 3
        Me.remove2Button.Text = "&Remove Example 2"
        Me.remove2Button.UseVisualStyleBackColor = True
        '
        'trim1Button
        '
        Me.trim1Button.Location = New System.Drawing.Point(120, 24)
        Me.trim1Button.Name = "trim1Button"
        Me.trim1Button.Size = New System.Drawing.Size(133, 26)
        Me.trim1Button.TabIndex = 1
        Me.trim1Button.Text = "&Trim Example 1"
        Me.trim1Button.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.insert2Button)
        Me.GroupBox3.Controls.Add(Me.insert1Button)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 341)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(133, 103)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Insert method"
        '
        'insert2Button
        '
        Me.insert2Button.Location = New System.Drawing.Point(10, 56)
        Me.insert2Button.Name = "insert2Button"
        Me.insert2Button.Size = New System.Drawing.Size(104, 26)
        Me.insert2Button.TabIndex = 1
        Me.insert2Button.Text = "Exa&mple 2"
        Me.insert2Button.UseVisualStyleBackColor = True
        '
        'insert1Button
        '
        Me.insert1Button.Location = New System.Drawing.Point(10, 24)
        Me.insert1Button.Name = "insert1Button"
        Me.insert1Button.Size = New System.Drawing.Size(104, 26)
        Me.insert1Button.TabIndex = 0
        Me.insert1Button.Text = "Ex&ample 1"
        Me.insert1Button.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(179, 418)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(104, 26)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 466)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Try It 1!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents length3Button As System.Windows.Forms.Button
    Friend WithEvents length2Button As System.Windows.Forms.Button
    Friend WithEvents length1Button As System.Windows.Forms.Button
    Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents remove4Button As System.Windows.Forms.Button
    Friend WithEvents stateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents remove3Button As System.Windows.Forms.Button
    Friend WithEvents remove2Button As System.Windows.Forms.Button
    Friend WithEvents trim1Button As System.Windows.Forms.Button
    Friend WithEvents firstTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lastTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents insert2Button As System.Windows.Forms.Button
    Friend WithEvents insert1Button As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
