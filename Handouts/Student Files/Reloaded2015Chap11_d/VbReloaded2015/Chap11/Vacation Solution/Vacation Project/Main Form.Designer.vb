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
        Me.locationListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.oneWeekLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.twoWeekLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Locations:"
        '
        'locationListBox
        '
        Me.locationListBox.FormattingEnabled = True
        Me.locationListBox.ItemHeight = 17
        Me.locationListBox.Location = New System.Drawing.Point(18, 38)
        Me.locationListBox.Name = "locationListBox"
        Me.locationListBox.Size = New System.Drawing.Size(161, 174)
        Me.locationListBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "One week:"
        '
        'oneWeekLabel
        '
        Me.oneWeekLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.oneWeekLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.oneWeekLabel.Location = New System.Drawing.Point(208, 38)
        Me.oneWeekLabel.Name = "oneWeekLabel"
        Me.oneWeekLabel.Size = New System.Drawing.Size(77, 28)
        Me.oneWeekLabel.TabIndex = 4
        Me.oneWeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Two weeks:"
        '
        'twoWeekLabel
        '
        Me.twoWeekLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.twoWeekLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.twoWeekLabel.Location = New System.Drawing.Point(208, 119)
        Me.twoWeekLabel.Name = "twoWeekLabel"
        Me.twoWeekLabel.Size = New System.Drawing.Size(77, 28)
        Me.twoWeekLabel.TabIndex = 6
        Me.twoWeekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(210, 183)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 29)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 243)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.twoWeekLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.oneWeekLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.locationListBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents locationListBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents oneWeekLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents twoWeekLabel As Label
    Friend WithEvents exitButton As Button
End Class
