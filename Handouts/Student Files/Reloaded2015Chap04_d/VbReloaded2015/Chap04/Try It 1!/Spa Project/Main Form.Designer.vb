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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalCostLabel = New System.Windows.Forms.Label()
        Me.numberTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(90, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Number in party:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(90, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total cost:"
        '
        'totalCostLabel
        '
        Me.totalCostLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalCostLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCostLabel.Location = New System.Drawing.Point(178, 132)
        Me.totalCostLabel.Name = "totalCostLabel"
        Me.totalCostLabel.Size = New System.Drawing.Size(90, 34)
        Me.totalCostLabel.TabIndex = 5
        Me.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numberTextBox
        '
        Me.numberTextBox.Location = New System.Drawing.Point(216, 86)
        Me.numberTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numberTextBox.Name = "numberTextBox"
        Me.numberTextBox.Size = New System.Drawing.Size(52, 27)
        Me.numberTextBox.TabIndex = 1
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(94, 191)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(90, 36)
        Me.calcButton.TabIndex = 2
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(193, 191)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 36)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Spa_Project.My.Resources.Resources.Spa
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(359, 253)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.numberTextBox)
        Me.Controls.Add(Me.totalCostLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somerset Day Spa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents totalCostLabel As Label
    Friend WithEvents numberTextBox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents exitButton As Button
End Class
