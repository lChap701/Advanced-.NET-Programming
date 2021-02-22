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
        Me.basketsTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.memberCheckBox = New System.Windows.Forms.CheckBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(29, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Baskets ordered:"
        '
        'basketsTextBox
        '
        Me.basketsTextBox.Location = New System.Drawing.Point(32, 54)
        Me.basketsTextBox.Name = "basketsTextBox"
        Me.basketsTextBox.Size = New System.Drawing.Size(39, 25)
        Me.basketsTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(29, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total owed:"
        '
        'totalLabel
        '
        Me.totalLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Location = New System.Drawing.Point(32, 118)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(103, 25)
        Me.totalLabel.TabIndex = 6
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'memberCheckBox
        '
        Me.memberCheckBox.AutoSize = True
        Me.memberCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.memberCheckBox.Location = New System.Drawing.Point(184, 34)
        Me.memberCheckBox.Name = "memberCheckBox"
        Me.memberCheckBox.Size = New System.Drawing.Size(150, 21)
        Me.memberCheckBox.TabIndex = 2
        Me.memberCheckBox.Text = "Cookie Club &member"
        Me.memberCheckBox.UseVisualStyleBackColor = False
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(184, 80)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(89, 28)
        Me.calcButton.TabIndex = 3
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(184, 114)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(89, 28)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cookie_Project.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(348, 172)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.memberCheckBox)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.basketsTextBox)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cookie Palace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents basketsTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents memberCheckBox As CheckBox
    Friend WithEvents calcButton As Button
    Friend WithEvents exitButton As Button
End Class
