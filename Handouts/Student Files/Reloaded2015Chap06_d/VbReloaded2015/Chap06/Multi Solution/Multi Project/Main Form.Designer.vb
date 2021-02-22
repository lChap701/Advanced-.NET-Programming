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
        Me.singleButton = New System.Windows.Forms.Button()
        Me.multiButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.namesListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Names:"
        '
        'singleButton
        '
        Me.singleButton.Location = New System.Drawing.Point(319, 41)
        Me.singleButton.Margin = New System.Windows.Forms.Padding(2)
        Me.singleButton.Name = "singleButton"
        Me.singleButton.Size = New System.Drawing.Size(122, 36)
        Me.singleButton.TabIndex = 2
        Me.singleButton.Text = "&Single Selection"
        '
        'multiButton
        '
        Me.multiButton.Location = New System.Drawing.Point(319, 82)
        Me.multiButton.Margin = New System.Windows.Forms.Padding(2)
        Me.multiButton.Name = "multiButton"
        Me.multiButton.Size = New System.Drawing.Size(122, 36)
        Me.multiButton.TabIndex = 3
        Me.multiButton.Text = "&Multi-Selection"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(319, 121)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(122, 36)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Result:"
        '
        'resultLabel
        '
        Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.resultLabel.Location = New System.Drawing.Point(207, 50)
        Me.resultLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(85, 118)
        Me.resultLabel.TabIndex = 6
        '
        'namesListBox
        '
        Me.namesListBox.FormattingEnabled = True
        Me.namesListBox.ItemHeight = 17
        Me.namesListBox.Location = New System.Drawing.Point(73, 50)
        Me.namesListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.namesListBox.Name = "namesListBox"
        Me.namesListBox.Size = New System.Drawing.Size(85, 106)
        Me.namesListBox.Sorted = True
        Me.namesListBox.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 195)
        Me.Controls.Add(Me.namesListBox)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.multiButton)
        Me.Controls.Add(Me.singleButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Single Selection and Multi-Selection List Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents singleButton As System.Windows.Forms.Button
    Friend WithEvents multiButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents resultLabel As System.Windows.Forms.Label
    Friend WithEvents namesListBox As System.Windows.Forms.ListBox

End Class
