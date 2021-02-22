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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gainLossLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.sharesTextBox = New System.Windows.Forms.TextBox()
        Me.openTextBox = New System.Windows.Forms.TextBox()
        Me.closeTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock &name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Shares:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Opening price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Closing price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gain (Loss):"
        '
        'gainLossLabel
        '
        Me.gainLossLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gainLossLabel.Location = New System.Drawing.Point(29, 160)
        Me.gainLossLabel.Name = "gainLossLabel"
        Me.gainLossLabel.Size = New System.Drawing.Size(100, 30)
        Me.gainLossLabel.TabIndex = 11
        Me.gainLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(84, 39)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(87, 25)
        Me.nameTextBox.TabIndex = 1
        '
        'sharesTextBox
        '
        Me.sharesTextBox.Location = New System.Drawing.Point(222, 39)
        Me.sharesTextBox.Name = "sharesTextBox"
        Me.sharesTextBox.Size = New System.Drawing.Size(87, 25)
        Me.sharesTextBox.TabIndex = 3
        '
        'openTextBox
        '
        Me.openTextBox.Location = New System.Drawing.Point(84, 100)
        Me.openTextBox.Name = "openTextBox"
        Me.openTextBox.Size = New System.Drawing.Size(87, 25)
        Me.openTextBox.TabIndex = 5
        '
        'closeTextBox
        '
        Me.closeTextBox.Location = New System.Drawing.Point(218, 100)
        Me.closeTextBox.Name = "closeTextBox"
        Me.closeTextBox.Size = New System.Drawing.Size(87, 25)
        Me.closeTextBox.TabIndex = 7
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(145, 152)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(157, 41)
        Me.calcButton.TabIndex = 8
        Me.calcButton.Text = "Calculate &Gain/(Loss)"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(308, 152)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 41)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 224)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.closeTextBox)
        Me.Controls.Add(Me.openTextBox)
        Me.Controls.Add(Me.sharesTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.gainLossLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Martins Gain/Loss Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gainLossLabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents sharesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents openTextBox As System.Windows.Forms.TextBox
    Friend WithEvents closeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
