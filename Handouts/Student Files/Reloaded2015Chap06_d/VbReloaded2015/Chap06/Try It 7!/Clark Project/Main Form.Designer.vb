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
        Me.workerListBox = New System.Windows.Forms.ListBox()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Today's &workers:"
        '
        'workerListBox
        '
        Me.workerListBox.FormattingEnabled = True
        Me.workerListBox.ItemHeight = 17
        Me.workerListBox.Location = New System.Drawing.Point(16, 45)
        Me.workerListBox.Name = "workerListBox"
        Me.workerListBox.Size = New System.Drawing.Size(239, 106)
        Me.workerListBox.TabIndex = 3
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(16, 165)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(158, 33)
        Me.enterButton.TabIndex = 0
        Me.enterButton.Text = "&Enter Employee Names"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(180, 165)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 33)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 224)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.workerListBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clark's Chicken"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents workerListBox As ListBox
    Friend WithEvents enterButton As Button
    Friend WithEvents exitButton As Button
End Class
