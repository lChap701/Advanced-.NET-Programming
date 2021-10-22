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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.streetTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.stateTextBox = New System.Windows.Forms.TextBox()
        Me.zipTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Street:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&City:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "St&ate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 109)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&ZIP:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(138, 150)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 27)
        Me.exitButton.TabIndex = 10
        Me.exitButton.Text = "E&xit"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(72, 12)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(135, 23)
        Me.nameTextBox.TabIndex = 1
        '
        'streetTextBox
        '
        Me.streetTextBox.Location = New System.Drawing.Point(72, 45)
        Me.streetTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.streetTextBox.Name = "streetTextBox"
        Me.streetTextBox.Size = New System.Drawing.Size(135, 23)
        Me.streetTextBox.TabIndex = 3
        '
        'cityTextBox
        '
        Me.cityTextBox.Location = New System.Drawing.Point(72, 78)
        Me.cityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(135, 23)
        Me.cityTextBox.TabIndex = 5
        '
        'stateTextBox
        '
        Me.stateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.stateTextBox.Location = New System.Drawing.Point(72, 110)
        Me.stateTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.stateTextBox.MaxLength = 2
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(32, 23)
        Me.stateTextBox.TabIndex = 7
        '
        'zipTextBox
        '
        Me.zipTextBox.Location = New System.Drawing.Point(149, 109)
        Me.zipTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.zipTextBox.Name = "zipTextBox"
        Me.zipTextBox.Size = New System.Drawing.Size(58, 23)
        Me.zipTextBox.TabIndex = 9
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 187)
        Me.Controls.Add(Me.zipTextBox)
        Me.Controls.Add(Me.stateTextBox)
        Me.Controls.Add(Me.cityTextBox)
        Me.Controls.Add(Me.streetTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Johnson's"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents streetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents zipTextBox As System.Windows.Forms.TextBox

End Class
