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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.colorOvalShape = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.viewButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.colorOvalShape})
        Me.ShapeContainer1.Size = New System.Drawing.Size(331, 319)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'colorOvalShape
        '
        Me.colorOvalShape.FillColor = System.Drawing.Color.White
        Me.colorOvalShape.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.colorOvalShape.Location = New System.Drawing.Point(39, 30)
        Me.colorOvalShape.Name = "colorOvalShape"
        Me.colorOvalShape.Size = New System.Drawing.Size(254, 157)
        '
        'viewButton
        '
        Me.viewButton.Location = New System.Drawing.Point(76, 251)
        Me.viewButton.Name = "viewButton"
        Me.viewButton.Size = New System.Drawing.Size(98, 32)
        Me.viewButton.TabIndex = 0
        Me.viewButton.Text = "&View Colors"
        Me.viewButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(180, 251)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 32)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 319)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.viewButton)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Viewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents colorOvalShape As PowerPacks.OvalShape
    Friend WithEvents viewButton As Button
    Friend WithEvents exitButton As Button
End Class
