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
        Me.numTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.salaryIdLabel = New System.Windows.Forms.Label()
        Me.hoursIdLabel = New System.Windows.Forms.Label()
        Me.rateIdLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grossLabel = New System.Windows.Forms.Label()
        Me.hoursListBox = New System.Windows.Forms.ListBox()
        Me.rateListBox = New System.Windows.Forms.ListBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.salaryListBox = New System.Windows.Forms.ListBox()
        Me.salariedRadioButton = New System.Windows.Forms.RadioButton()
        Me.hourlyRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.reportTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Num&ber:"
        '
        'numTextBox
        '
        Me.numTextBox.Location = New System.Drawing.Point(185, 83)
        Me.numTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.numTextBox.Name = "numTextBox"
        Me.numTextBox.Size = New System.Drawing.Size(62, 25)
        Me.numTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Name:"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(269, 83)
        Me.nameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(253, 25)
        Me.nameTextBox.TabIndex = 3
        '
        'salaryIdLabel
        '
        Me.salaryIdLabel.AutoSize = True
        Me.salaryIdLabel.Location = New System.Drawing.Point(192, 59)
        Me.salaryIdLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.salaryIdLabel.Name = "salaryIdLabel"
        Me.salaryIdLabel.Size = New System.Drawing.Size(88, 17)
        Me.salaryIdLabel.TabIndex = 6
        Me.salaryIdLabel.Text = "&Annual salary:"
        Me.salaryIdLabel.Visible = False
        '
        'hoursIdLabel
        '
        Me.hoursIdLabel.AutoSize = True
        Me.hoursIdLabel.Location = New System.Drawing.Point(11, 59)
        Me.hoursIdLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.hoursIdLabel.Name = "hoursIdLabel"
        Me.hoursIdLabel.Size = New System.Drawing.Size(46, 17)
        Me.hoursIdLabel.TabIndex = 1
        Me.hoursIdLabel.Text = "&Hours:"
        '
        'rateIdLabel
        '
        Me.rateIdLabel.AutoSize = True
        Me.rateIdLabel.Location = New System.Drawing.Point(97, 59)
        Me.rateIdLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.rateIdLabel.Name = "rateIdLabel"
        Me.rateIdLabel.Size = New System.Drawing.Size(37, 17)
        Me.rateIdLabel.TabIndex = 3
        Me.rateIdLabel.Text = "&Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(552, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Gross pay:"
        '
        'grossLabel
        '
        Me.grossLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grossLabel.Location = New System.Drawing.Point(555, 83)
        Me.grossLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.grossLabel.Name = "grossLabel"
        Me.grossLabel.Size = New System.Drawing.Size(89, 25)
        Me.grossLabel.TabIndex = 8
        Me.grossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hoursListBox
        '
        Me.hoursListBox.FormattingEnabled = True
        Me.hoursListBox.ItemHeight = 17
        Me.hoursListBox.Location = New System.Drawing.Point(11, 80)
        Me.hoursListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.hoursListBox.Name = "hoursListBox"
        Me.hoursListBox.Size = New System.Drawing.Size(71, 140)
        Me.hoursListBox.TabIndex = 2
        '
        'rateListBox
        '
        Me.rateListBox.FormattingEnabled = True
        Me.rateListBox.ItemHeight = 17
        Me.rateListBox.Location = New System.Drawing.Point(101, 80)
        Me.rateListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.rateListBox.Name = "rateListBox"
        Me.rateListBox.Size = New System.Drawing.Size(71, 140)
        Me.rateListBox.TabIndex = 4
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(528, 383)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(89, 29)
        Me.calcButton.TabIndex = 5
        Me.calcButton.Text = "&Calculate"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(621, 383)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(89, 29)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "E&xit"
        '
        'salaryListBox
        '
        Me.salaryListBox.FormattingEnabled = True
        Me.salaryListBox.ItemHeight = 17
        Me.salaryListBox.Location = New System.Drawing.Point(192, 80)
        Me.salaryListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.salaryListBox.Name = "salaryListBox"
        Me.salaryListBox.Size = New System.Drawing.Size(100, 140)
        Me.salaryListBox.TabIndex = 7
        Me.salaryListBox.Visible = False
        '
        'salariedRadioButton
        '
        Me.salariedRadioButton.Location = New System.Drawing.Point(192, 22)
        Me.salariedRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.salariedRadioButton.Name = "salariedRadioButton"
        Me.salariedRadioButton.Size = New System.Drawing.Size(145, 31)
        Me.salariedRadioButton.TabIndex = 5
        Me.salariedRadioButton.Text = "&Salaried employee"
        '
        'hourlyRadioButton
        '
        Me.hourlyRadioButton.Checked = True
        Me.hourlyRadioButton.Location = New System.Drawing.Point(16, 22)
        Me.hourlyRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.hourlyRadioButton.Name = "hourlyRadioButton"
        Me.hourlyRadioButton.Size = New System.Drawing.Size(144, 31)
        Me.hourlyRadioButton.TabIndex = 0
        Me.hourlyRadioButton.TabStop = True
        Me.hourlyRadioButton.Text = "Hourl&y employee"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.salariedRadioButton)
        Me.GroupBox1.Controls.Add(Me.salaryIdLabel)
        Me.GroupBox1.Controls.Add(Me.hourlyRadioButton)
        Me.GroupBox1.Controls.Add(Me.salaryListBox)
        Me.GroupBox1.Controls.Add(Me.hoursIdLabel)
        Me.GroupBox1.Controls.Add(Me.rateIdLabel)
        Me.GroupBox1.Controls.Add(Me.hoursListBox)
        Me.GroupBox1.Controls.Add(Me.rateListBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(341, 241)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'reportTextBox
        '
        Me.reportTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportTextBox.Location = New System.Drawing.Point(390, 167)
        Me.reportTextBox.Multiline = True
        Me.reportTextBox.Name = "reportTextBox"
        Me.reportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.reportTextBox.Size = New System.Drawing.Size(320, 178)
        Me.reportTextBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(387, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Report:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Woods_Project.My.Resources.Resources.Woods
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 436)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.reportTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.grossLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Woods Manufacturing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents salaryIdLabel As System.Windows.Forms.Label
    Friend WithEvents hoursIdLabel As System.Windows.Forms.Label
    Friend WithEvents rateIdLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grossLabel As System.Windows.Forms.Label
    Friend WithEvents hoursListBox As System.Windows.Forms.ListBox
    Friend WithEvents rateListBox As System.Windows.Forms.ListBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents salaryListBox As System.Windows.Forms.ListBox
    Friend WithEvents salariedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents hourlyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents reportTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
