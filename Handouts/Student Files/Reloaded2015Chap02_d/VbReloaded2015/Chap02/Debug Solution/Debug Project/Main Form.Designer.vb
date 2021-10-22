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
        Me.dept1TextBox = New System.Windows.Forms.TextBox()
        Me.dept2TextBox = New System.Windows.Forms.TextBox()
        Me.dept3TextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalSalesLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department &1 sales:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department &2 sales:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Department &3 sales:"
        '
        'dept1TextBox
        '
        Me.dept1TextBox.Location = New System.Drawing.Point(138, 23)
        Me.dept1TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.dept1TextBox.Name = "dept1TextBox"
        Me.dept1TextBox.Size = New System.Drawing.Size(53, 23)
        Me.dept1TextBox.TabIndex = 6
        '
        'dept2TextBox
        '
        Me.dept2TextBox.Location = New System.Drawing.Point(138, 56)
        Me.dept2TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.dept2TextBox.Name = "dept2TextBox"
        Me.dept2TextBox.Size = New System.Drawing.Size(53, 23)
        Me.dept2TextBox.TabIndex = 2
        '
        'dept3TextBox
        '
        Me.dept3TextBox.Location = New System.Drawing.Point(138, 88)
        Me.dept3TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.dept3TextBox.Name = "dept3TextBox"
        Me.dept3TextBox.Size = New System.Drawing.Size(53, 23)
        Me.dept3TextBox.TabIndex = 7
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(243, 48)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(107, 31)
        Me.calcButton.TabIndex = 5
        Me.calcButton.Text = "&Calculate Total"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(243, 83)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(107, 31)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total sales:"
        '
        'totalSalesLabel
        '
        Me.totalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalSalesLabel.Location = New System.Drawing.Point(274, 19)
        Me.totalSalesLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalSalesLabel.Name = "totalSalesLabel"
        Me.totalSalesLabel.Size = New System.Drawing.Size(76, 23)
        Me.totalSalesLabel.TabIndex = 8
        Me.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 136)
        Me.Controls.Add(Me.totalSalesLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.dept3TextBox)
        Me.Controls.Add(Me.dept2TextBox)
        Me.Controls.Add(Me.dept1TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carolyn's Department Store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dept1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents dept2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents dept3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents totalSalesLabel As System.Windows.Forms.Label

End Class
