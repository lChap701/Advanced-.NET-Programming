﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.highestLabel = New System.Windows.Forms.Label()
        Me.monthsLabel = New System.Windows.Forms.Label()
        Me.findButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Highest number sold:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of months:"
        '
        'highestLabel
        '
        Me.highestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.highestLabel.Location = New System.Drawing.Point(190, 34)
        Me.highestLabel.Name = "highestLabel"
        Me.highestLabel.Size = New System.Drawing.Size(52, 24)
        Me.highestLabel.TabIndex = 3
        Me.highestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'monthsLabel
        '
        Me.monthsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monthsLabel.Location = New System.Drawing.Point(190, 95)
        Me.monthsLabel.Name = "monthsLabel"
        Me.monthsLabel.Size = New System.Drawing.Size(52, 24)
        Me.monthsLabel.TabIndex = 5
        Me.monthsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'findButton
        '
        Me.findButton.Location = New System.Drawing.Point(350, 13)
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(115, 28)
        Me.findButton.TabIndex = 0
        Me.findButton.Text = "&Find Highest"
        Me.findButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(350, 47)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(115, 28)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Popcorn_Project.My.Resources.Resources.Popcorn
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 149)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.findButton)
        Me.Controls.Add(Me.monthsLabel)
        Me.Controls.Add(Me.highestLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Popcorn Factory"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents highestLabel As Label
    Friend WithEvents monthsLabel As Label
    Friend WithEvents findButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
