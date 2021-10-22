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
        Me.pricesListBox = New System.Windows.Forms.ListBox()
        Me.ex1Button = New System.Windows.Forms.Button()
        Me.ex2Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "&Prices:"
        '
        'pricesListBox
        '
        Me.pricesListBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricesListBox.FormattingEnabled = True
        Me.pricesListBox.ItemHeight = 16
        Me.pricesListBox.Location = New System.Drawing.Point(83, 44)
        Me.pricesListBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pricesListBox.Name = "pricesListBox"
        Me.pricesListBox.Size = New System.Drawing.Size(50, 100)
        Me.pricesListBox.TabIndex = 4
        '
        'ex1Button
        '
        Me.ex1Button.Location = New System.Drawing.Point(158, 19)
        Me.ex1Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ex1Button.Name = "ex1Button"
        Me.ex1Button.Size = New System.Drawing.Size(109, 32)
        Me.ex1Button.TabIndex = 0
        Me.ex1Button.Text = "Example &1"
        Me.ex1Button.UseVisualStyleBackColor = True
        '
        'ex2Button
        '
        Me.ex2Button.Location = New System.Drawing.Point(158, 59)
        Me.ex2Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ex2Button.Name = "ex2Button"
        Me.ex2Button.Size = New System.Drawing.Size(109, 32)
        Me.ex2Button.TabIndex = 1
        Me.ex2Button.Text = "Example &2"
        Me.ex2Button.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(158, 99)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(109, 32)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 166)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.ex2Button)
        Me.Controls.Add(Me.ex1Button)
        Me.Controls.Add(Me.pricesListBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aligning Columns of Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pricesListBox As System.Windows.Forms.ListBox
    Friend WithEvents ex1Button As System.Windows.Forms.Button
    Friend WithEvents ex2Button As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
