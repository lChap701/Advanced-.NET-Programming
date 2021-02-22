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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.indexOf6Button = New System.Windows.Forms.Button()
        Me.indexOf5Button = New System.Windows.Forms.Button()
        Me.indexOf4Button = New System.Windows.Forms.Button()
        Me.contains3Button = New System.Windows.Forms.Button()
        Me.contains2Button = New System.Windows.Forms.Button()
        Me.contains1Button = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.substring2Button = New System.Windows.Forms.Button()
        Me.substring1Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.indexOf6Button)
        Me.GroupBox2.Controls.Add(Me.indexOf5Button)
        Me.GroupBox2.Controls.Add(Me.indexOf4Button)
        Me.GroupBox2.Controls.Add(Me.contains3Button)
        Me.GroupBox2.Controls.Add(Me.contains2Button)
        Me.GroupBox2.Controls.Add(Me.contains1Button)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 217)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contains and InsertOf methods"
        '
        'indexOf6Button
        '
        Me.indexOf6Button.Location = New System.Drawing.Point(39, 180)
        Me.indexOf6Button.Name = "indexOf6Button"
        Me.indexOf6Button.Size = New System.Drawing.Size(133, 26)
        Me.indexOf6Button.TabIndex = 5
        Me.indexOf6Button.Text = "Example &6"
        Me.indexOf6Button.UseVisualStyleBackColor = True
        '
        'indexOf5Button
        '
        Me.indexOf5Button.Location = New System.Drawing.Point(39, 148)
        Me.indexOf5Button.Name = "indexOf5Button"
        Me.indexOf5Button.Size = New System.Drawing.Size(133, 26)
        Me.indexOf5Button.TabIndex = 4
        Me.indexOf5Button.Text = "Example &5"
        Me.indexOf5Button.UseVisualStyleBackColor = True
        '
        'indexOf4Button
        '
        Me.indexOf4Button.Location = New System.Drawing.Point(39, 116)
        Me.indexOf4Button.Name = "indexOf4Button"
        Me.indexOf4Button.Size = New System.Drawing.Size(133, 26)
        Me.indexOf4Button.TabIndex = 3
        Me.indexOf4Button.Text = "Example &4"
        Me.indexOf4Button.UseVisualStyleBackColor = True
        '
        'contains3Button
        '
        Me.contains3Button.Location = New System.Drawing.Point(39, 84)
        Me.contains3Button.Name = "contains3Button"
        Me.contains3Button.Size = New System.Drawing.Size(133, 26)
        Me.contains3Button.TabIndex = 2
        Me.contains3Button.Text = "Example &3"
        Me.contains3Button.UseVisualStyleBackColor = True
        '
        'contains2Button
        '
        Me.contains2Button.Location = New System.Drawing.Point(39, 54)
        Me.contains2Button.Name = "contains2Button"
        Me.contains2Button.Size = New System.Drawing.Size(133, 26)
        Me.contains2Button.TabIndex = 1
        Me.contains2Button.Text = "Example &2"
        Me.contains2Button.UseVisualStyleBackColor = True
        '
        'contains1Button
        '
        Me.contains1Button.Location = New System.Drawing.Point(39, 24)
        Me.contains1Button.Name = "contains1Button"
        Me.contains1Button.Size = New System.Drawing.Size(133, 26)
        Me.contains1Button.TabIndex = 0
        Me.contains1Button.Text = "Example &1"
        Me.contains1Button.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.substring2Button)
        Me.GroupBox3.Controls.Add(Me.substring1Button)
        Me.GroupBox3.Location = New System.Drawing.Point(238, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(133, 103)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Substring method"
        '
        'substring2Button
        '
        Me.substring2Button.Location = New System.Drawing.Point(10, 56)
        Me.substring2Button.Name = "substring2Button"
        Me.substring2Button.Size = New System.Drawing.Size(104, 26)
        Me.substring2Button.TabIndex = 1
        Me.substring2Button.Text = "Exa&mple 2"
        Me.substring2Button.UseVisualStyleBackColor = True
        '
        'substring1Button
        '
        Me.substring1Button.Location = New System.Drawing.Point(10, 24)
        Me.substring1Button.Name = "substring1Button"
        Me.substring1Button.Size = New System.Drawing.Size(104, 26)
        Me.substring1Button.TabIndex = 0
        Me.substring1Button.Text = "Ex&ample 1"
        Me.substring1Button.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(267, 203)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(104, 26)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 252)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Try It 3!"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents indexOf4Button As System.Windows.Forms.Button
    Friend WithEvents contains3Button As System.Windows.Forms.Button
    Friend WithEvents contains2Button As System.Windows.Forms.Button
    Friend WithEvents contains1Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents substring2Button As System.Windows.Forms.Button
    Friend WithEvents substring1Button As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents indexOf6Button As System.Windows.Forms.Button
    Friend WithEvents indexOf5Button As System.Windows.Forms.Button

End Class
