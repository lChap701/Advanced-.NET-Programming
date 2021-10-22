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
        Me.nextButton = New System.Windows.Forms.Button()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.songLabel = New System.Windows.Forms.Label()
        Me.sourceLabel = New System.Windows.Forms.Label()
        Me.shapeLabel = New System.Windows.Forms.Label()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(381, 129)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(2)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(129, 35)
        Me.nextButton.TabIndex = 1
        Me.nextButton.Text = "&Next Record"
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(232, 129)
        Me.previousButton.Margin = New System.Windows.Forms.Padding(2)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(145, 35)
        Me.previousButton.TabIndex = 0
        Me.previousButton.Text = "&Previous Record"
        '
        'songLabel
        '
        Me.songLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.songLabel.Location = New System.Drawing.Point(364, 65)
        Me.songLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.songLabel.Name = "songLabel"
        Me.songLabel.Size = New System.Drawing.Size(238, 27)
        Me.songLabel.TabIndex = 10
        Me.songLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sourceLabel
        '
        Me.sourceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sourceLabel.Location = New System.Drawing.Point(256, 65)
        Me.sourceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.sourceLabel.Name = "sourceLabel"
        Me.sourceLabel.Size = New System.Drawing.Size(87, 27)
        Me.sourceLabel.TabIndex = 8
        Me.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'shapeLabel
        '
        Me.shapeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shapeLabel.Location = New System.Drawing.Point(125, 65)
        Me.shapeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.shapeLabel.Name = "shapeLabel"
        Me.shapeLabel.Size = New System.Drawing.Size(105, 27)
        Me.shapeLabel.TabIndex = 6
        Me.shapeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'idLabel
        '
        Me.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idLabel.Location = New System.Drawing.Point(43, 65)
        Me.idLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(33, 27)
        Me.idLabel.TabIndex = 4
        Me.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Song:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Source:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Shape:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(536, 129)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(66, 35)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 200)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.songLabel)
        Me.Controls.Add(Me.sourceLabel)
        Me.Controls.Add(Me.shapeLabel)
        Me.Controls.Add(Me.idLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Music Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents songLabel As System.Windows.Forms.Label
    Friend WithEvents sourceLabel As System.Windows.Forms.Label
    Friend WithEvents shapeLabel As System.Windows.Forms.Label
    Friend WithEvents idLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
