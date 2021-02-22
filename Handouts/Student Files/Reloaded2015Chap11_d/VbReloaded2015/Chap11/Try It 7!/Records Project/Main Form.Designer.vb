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
        Me.ex1Button = New System.Windows.Forms.Button()
        Me.ex2Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cityLabel = New System.Windows.Forms.Label()
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.salespersonLabel = New System.Windows.Forms.Label()
        Me.salesLabel = New System.Windows.Forms.Label()
        Me.bonusLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ex1Button
        '
        Me.ex1Button.Location = New System.Drawing.Point(308, 13)
        Me.ex1Button.Name = "ex1Button"
        Me.ex1Button.Size = New System.Drawing.Size(88, 28)
        Me.ex1Button.TabIndex = 0
        Me.ex1Button.Text = "Example &1"
        Me.ex1Button.UseVisualStyleBackColor = True
        '
        'ex2Button
        '
        Me.ex2Button.Location = New System.Drawing.Point(308, 18)
        Me.ex2Button.Name = "ex2Button"
        Me.ex2Button.Size = New System.Drawing.Size(88, 28)
        Me.ex2Button.TabIndex = 0
        Me.ex2Button.Text = "Example &2"
        Me.ex2Button.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(349, 211)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 28)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "City:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Salesperson:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Bonus:"
        '
        'cityLabel
        '
        Me.cityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cityLabel.Location = New System.Drawing.Point(37, 16)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(78, 23)
        Me.cityLabel.TabIndex = 2
        Me.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'stateLabel
        '
        Me.stateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stateLabel.Location = New System.Drawing.Point(179, 16)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(111, 23)
        Me.stateLabel.TabIndex = 4
        Me.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salespersonLabel
        '
        Me.salespersonLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salespersonLabel.Location = New System.Drawing.Point(90, 18)
        Me.salespersonLabel.Name = "salespersonLabel"
        Me.salespersonLabel.Size = New System.Drawing.Size(178, 23)
        Me.salespersonLabel.TabIndex = 2
        Me.salespersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesLabel
        '
        Me.salesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salesLabel.Location = New System.Drawing.Point(42, 51)
        Me.salesLabel.Name = "salesLabel"
        Me.salesLabel.Size = New System.Drawing.Size(71, 23)
        Me.salesLabel.TabIndex = 4
        Me.salesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bonusLabel
        '
        Me.bonusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bonusLabel.Location = New System.Drawing.Point(194, 51)
        Me.bonusLabel.Name = "bonusLabel"
        Me.bonusLabel.Size = New System.Drawing.Size(71, 23)
        Me.bonusLabel.TabIndex = 6
        Me.bonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.salespersonLabel)
        Me.Panel1.Controls.Add(Me.bonusLabel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.salesLabel)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ex2Button)
        Me.Panel1.Location = New System.Drawing.Point(16, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 96)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.stateLabel)
        Me.Panel2.Controls.Add(Me.ex1Button)
        Me.Panel2.Controls.Add(Me.cityLabel)
        Me.Panel2.Location = New System.Drawing.Point(16, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(408, 60)
        Me.Panel2.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 254)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.exitButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reading and Writing Records"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ex1Button As System.Windows.Forms.Button
    Friend WithEvents ex2Button As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cityLabel As System.Windows.Forms.Label
    Friend WithEvents stateLabel As System.Windows.Forms.Label
    Friend WithEvents salespersonLabel As System.Windows.Forms.Label
    Friend WithEvents salesLabel As System.Windows.Forms.Label
    Friend WithEvents bonusLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
