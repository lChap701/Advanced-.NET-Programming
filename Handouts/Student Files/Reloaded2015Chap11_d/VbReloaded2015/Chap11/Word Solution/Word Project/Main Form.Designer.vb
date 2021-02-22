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
        Me.checkButton = New System.Windows.Forms.Button()
        Me.letterTextBox = New System.Windows.Forms.TextBox()
        Me.incorrectLabel = New System.Windows.Forms.Label()
        Me.wordLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.remainingLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileMenuTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.fileNewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.fileExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'checkButton
        '
        Me.checkButton.Enabled = False
        Me.checkButton.Location = New System.Drawing.Point(375, 144)
        Me.checkButton.Margin = New System.Windows.Forms.Padding(5)
        Me.checkButton.Name = "checkButton"
        Me.checkButton.Size = New System.Drawing.Size(95, 32)
        Me.checkButton.TabIndex = 2
        Me.checkButton.Text = "&Check"
        Me.checkButton.UseVisualStyleBackColor = True
        '
        'letterTextBox
        '
        Me.letterTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.letterTextBox.Location = New System.Drawing.Point(318, 147)
        Me.letterTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.letterTextBox.MaxLength = 1
        Me.letterTextBox.Name = "letterTextBox"
        Me.letterTextBox.Size = New System.Drawing.Size(41, 27)
        Me.letterTextBox.TabIndex = 1
        '
        'incorrectLabel
        '
        Me.incorrectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.incorrectLabel.Location = New System.Drawing.Point(514, 89)
        Me.incorrectLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.incorrectLabel.Name = "incorrectLabel"
        Me.incorrectLabel.Size = New System.Drawing.Size(183, 26)
        Me.incorrectLabel.TabIndex = 6
        Me.incorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'wordLabel
        '
        Me.wordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wordLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wordLabel.Location = New System.Drawing.Point(217, 89)
        Me.wordLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.wordLabel.Name = "wordLabel"
        Me.wordLabel.Size = New System.Drawing.Size(178, 26)
        Me.wordLabel.TabIndex = 4
        Me.wordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 150)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Enter a letter:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(508, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Incorrect letters:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Guess this word:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Word_Project.My.Resources.Resources.Word
        Me.PictureBox1.Location = New System.Drawing.Point(13, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Guesses remaining:"
        '
        'remainingLabel
        '
        Me.remainingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.remainingLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remainingLabel.ForeColor = System.Drawing.Color.Red
        Me.remainingLabel.Location = New System.Drawing.Point(514, 150)
        Me.remainingLabel.Name = "remainingLabel"
        Me.remainingLabel.Size = New System.Drawing.Size(39, 26)
        Me.remainingLabel.TabIndex = 8
        Me.remainingLabel.Text = "7"
        Me.remainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileMenuTitle})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(715, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'fileMenuTitle
        '
        Me.fileMenuTitle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileNewMenuItem, Me.ToolStripSeparator1, Me.fileExitMenuItem})
        Me.fileMenuTitle.Name = "fileMenuTitle"
        Me.fileMenuTitle.Size = New System.Drawing.Size(37, 20)
        Me.fileMenuTitle.Text = "&File"
        '
        'fileNewMenuItem
        '
        Me.fileNewMenuItem.Name = "fileNewMenuItem"
        Me.fileNewMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.fileNewMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.fileNewMenuItem.Text = "&New Game"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(172, 6)
        '
        'fileExitMenuItem
        '
        Me.fileExitMenuItem.Name = "fileExitMenuItem"
        Me.fileExitMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.fileExitMenuItem.Text = "E&xit"
        '
        'MainForm
        '
        Me.AcceptButton = Me.checkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 232)
        Me.Controls.Add(Me.remainingLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.checkButton)
        Me.Controls.Add(Me.letterTextBox)
        Me.Controls.Add(Me.incorrectLabel)
        Me.Controls.Add(Me.wordLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guess the Word Game"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkButton As Button
    Friend WithEvents letterTextBox As TextBox
    Friend WithEvents incorrectLabel As Label
    Friend WithEvents wordLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents remainingLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents fileMenuTitle As ToolStripMenuItem
    Friend WithEvents fileNewMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents fileExitMenuItem As ToolStripMenuItem
End Class
