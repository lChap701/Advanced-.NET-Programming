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
        Me.exitButton = New System.Windows.Forms.Button()
        Me.leftComboBox = New System.Windows.Forms.ComboBox()
        Me.rightComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prices-&left-aligned:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(242, 210)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(74, 31)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        '
        'leftComboBox
        '
        Me.leftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.leftComboBox.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leftComboBox.FormattingEnabled = True
        Me.leftComboBox.Location = New System.Drawing.Point(20, 35)
        Me.leftComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.leftComboBox.Name = "leftComboBox"
        Me.leftComboBox.Size = New System.Drawing.Size(69, 222)
        Me.leftComboBox.TabIndex = 1
        '
        'rightComboBox
        '
        Me.rightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.rightComboBox.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rightComboBox.FormattingEnabled = True
        Me.rightComboBox.Location = New System.Drawing.Point(154, 35)
        Me.rightComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.rightComboBox.Name = "rightComboBox"
        Me.rightComboBox.Size = New System.Drawing.Size(69, 222)
        Me.rightComboBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prices &right-aligned:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 280)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rightComboBox)
        Me.Controls.Add(Me.leftComboBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Prices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents leftComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents rightComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
