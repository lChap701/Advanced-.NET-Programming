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
        Me.membershipListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.month12Label = New System.Windows.Forms.Label()
        Me.month6Label = New System.Windows.Forms.Label()
        Me.month3Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Memberships:"
        '
        'membershipListBox
        '
        Me.membershipListBox.FormattingEnabled = True
        Me.membershipListBox.ItemHeight = 17
        Me.membershipListBox.Location = New System.Drawing.Point(16, 34)
        Me.membershipListBox.Name = "membershipListBox"
        Me.membershipListBox.Size = New System.Drawing.Size(88, 72)
        Me.membershipListBox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.month12Label)
        Me.GroupBox1.Controls.Add(Me.month6Label)
        Me.GroupBox1.Controls.Add(Me.month3Label)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(119, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 94)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fees"
        '
        'month12Label
        '
        Me.month12Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.month12Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.month12Label.Location = New System.Drawing.Point(165, 45)
        Me.month12Label.Name = "month12Label"
        Me.month12Label.Size = New System.Drawing.Size(62, 28)
        Me.month12Label.TabIndex = 5
        Me.month12Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'month6Label
        '
        Me.month6Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.month6Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.month6Label.Location = New System.Drawing.Point(92, 45)
        Me.month6Label.Name = "month6Label"
        Me.month6Label.Size = New System.Drawing.Size(62, 28)
        Me.month6Label.TabIndex = 4
        Me.month6Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'month3Label
        '
        Me.month3Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.month3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.month3Label.Location = New System.Drawing.Point(19, 45)
        Me.month3Label.Name = "month3Label"
        Me.month3Label.Size = New System.Drawing.Size(62, 28)
        Me.month3Label.TabIndex = 3
        Me.month3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(162, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "12 months:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "6 months:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "3 months:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(288, 140)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 28)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 190)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.membershipListBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jenkins Gym"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents membershipListBox As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents month12Label As Label
    Friend WithEvents month6Label As Label
    Friend WithEvents month3Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents exitButton As Button
End Class
