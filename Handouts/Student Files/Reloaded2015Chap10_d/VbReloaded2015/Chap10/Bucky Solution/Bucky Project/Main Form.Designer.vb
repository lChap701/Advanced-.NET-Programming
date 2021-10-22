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
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.namesListBox = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.addButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name (first and last only):"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(116, 58)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(188, 25)
        Me.nameTextBox.TabIndex = 1
        '
        'namesListBox
        '
        Me.namesListBox.FormattingEnabled = True
        Me.namesListBox.ItemHeight = 17
        Me.namesListBox.Location = New System.Drawing.Point(116, 99)
        Me.namesListBox.Name = "namesListBox"
        Me.namesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.namesListBox.Size = New System.Drawing.Size(188, 140)
        Me.namesListBox.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bucky_Project.My.Resources.Resources.Hamburger
        Me.PictureBox1.Location = New System.Drawing.Point(11, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(323, 56)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(143, 27)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "&Add Name to List"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.addButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 268)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.namesListBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bucky's Burgers"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents namesListBox As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents addButton As Button
End Class
