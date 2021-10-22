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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.nameComboBox = New System.Windows.Forms.ComboBox()
        Me.cityComboBox = New System.Windows.Forms.ComboBox()
        Me.stateComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Names:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 160)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Cities:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(507, 160)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&States:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(622, 244)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(78, 32)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        '
        'nameComboBox
        '
        Me.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.nameComboBox.FormattingEnabled = True
        Me.nameComboBox.Location = New System.Drawing.Point(20, 185)
        Me.nameComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nameComboBox.Name = "nameComboBox"
        Me.nameComboBox.Size = New System.Drawing.Size(189, 110)
        Me.nameComboBox.TabIndex = 2
        '
        'cityComboBox
        '
        Me.cityComboBox.FormattingEnabled = True
        Me.cityComboBox.Location = New System.Drawing.Point(255, 185)
        Me.cityComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cityComboBox.Name = "cityComboBox"
        Me.cityComboBox.Size = New System.Drawing.Size(205, 29)
        Me.cityComboBox.TabIndex = 4
        '
        'stateComboBox
        '
        Me.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stateComboBox.FormattingEnabled = True
        Me.stateComboBox.Location = New System.Drawing.Point(507, 185)
        Me.stateComboBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.stateComboBox.Name = "stateComboBox"
        Me.stateComboBox.Size = New System.Drawing.Size(189, 29)
        Me.stateComboBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 115)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Simple combo: The text portion is editable, and the list portion is always displa" & _
    "yed." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(255, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 115)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DropDown combo: The text portion is editable, and the user must click the arrow t" & _
    "o view the list portion."
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(507, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 115)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "DropDownList combo: The text portion is not editable, and the user must click the" & _
    " arrow to view the list portion." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 302)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.stateComboBox)
        Me.Controls.Add(Me.cityComboBox)
        Me.Controls.Add(Me.nameComboBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combo Box Styles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents nameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents cityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents stateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
