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
        Me.oddLabel = New System.Windows.Forms.Label()
        Me.evenLabel = New System.Windows.Forms.Label()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.integer1TextBox = New System.Windows.Forms.TextBox()
        Me.integer2TextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Integer &1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Integer &2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Odd integer sum:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Even integer sum:"
        '
        'oddLabel
        '
        Me.oddLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.oddLabel.Location = New System.Drawing.Point(39, 146)
        Me.oddLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.oddLabel.Name = "oddLabel"
        Me.oddLabel.Size = New System.Drawing.Size(107, 24)
        Me.oddLabel.TabIndex = 2
        Me.oddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'evenLabel
        '
        Me.evenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.evenLabel.Location = New System.Drawing.Point(170, 146)
        Me.evenLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.evenLabel.Name = "evenLabel"
        Me.evenLabel.Size = New System.Drawing.Size(107, 24)
        Me.evenLabel.TabIndex = 4
        Me.evenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(153, 10)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(70, 26)
        Me.displayButton.TabIndex = 4
        Me.displayButton.Text = "&Display"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(153, 50)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(70, 26)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        '
        'integer1TextBox
        '
        Me.integer1TextBox.Location = New System.Drawing.Point(79, 10)
        Me.integer1TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.integer1TextBox.Name = "integer1TextBox"
        Me.integer1TextBox.Size = New System.Drawing.Size(40, 25)
        Me.integer1TextBox.TabIndex = 1
        '
        'integer2TextBox
        '
        Me.integer2TextBox.Location = New System.Drawing.Point(79, 52)
        Me.integer2TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.integer2TextBox.Name = "integer2TextBox"
        Me.integer2TextBox.Size = New System.Drawing.Size(40, 25)
        Me.integer2TextBox.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.displayButton)
        Me.Panel1.Controls.Add(Me.integer2TextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.integer1TextBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.exitButton)
        Me.Panel1.Location = New System.Drawing.Point(39, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 95)
        Me.Panel1.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 194)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.evenLabel)
        Me.Controls.Add(Me.oddLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Odd and Even Integers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents oddLabel As System.Windows.Forms.Label
    Friend WithEvents evenLabel As System.Windows.Forms.Label
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents integer1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents integer2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
