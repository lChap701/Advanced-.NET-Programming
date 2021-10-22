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
        Me.totalDueLabel = New System.Windows.Forms.Label()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.newButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.btnPersist = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Quantity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total due:"
        '
        'totalDueLabel
        '
        Me.totalDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalDueLabel.Location = New System.Drawing.Point(29, 190)
        Me.totalDueLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalDueLabel.Name = "totalDueLabel"
        Me.totalDueLabel.Size = New System.Drawing.Size(106, 40)
        Me.totalDueLabel.TabIndex = 8
        Me.totalDueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(29, 51)
        Me.quantityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(66, 27)
        Me.quantityTextBox.TabIndex = 1
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(29, 122)
        Me.priceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(66, 27)
        Me.priceTextBox.TabIndex = 3
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(169, 29)
        Me.addButton.Margin = New System.Windows.Forms.Padding(2)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(110, 39)
        Me.addButton.TabIndex = 4
        Me.addButton.Text = "&Add to Sale"
        '
        'newButton
        '
        Me.newButton.Location = New System.Drawing.Point(169, 74)
        Me.newButton.Margin = New System.Windows.Forms.Padding(2)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(110, 39)
        Me.newButton.TabIndex = 5
        Me.newButton.Text = "&New Order"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(169, 120)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(110, 39)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        '
        'btnPersist
        '
        Me.btnPersist.Location = New System.Drawing.Point(197, 190)
        Me.btnPersist.Name = "btnPersist"
        Me.btnPersist.Size = New System.Drawing.Size(82, 49)
        Me.btnPersist.TabIndex = 9
        Me.btnPersist.Text = "Add Sale to File"
        Me.btnPersist.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(285, 190)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(82, 49)
        Me.btnDisplay.TabIndex = 10
        Me.btnDisplay.Text = "Display Orders"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 297)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnPersist)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.newButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.quantityTextBox)
        Me.Controls.Add(Me.totalDueLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pennington Book Store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents totalDueLabel As System.Windows.Forms.Label
    Friend WithEvents quantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents newButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents btnPersist As Button
    Friend WithEvents btnDisplay As Button
End Class
