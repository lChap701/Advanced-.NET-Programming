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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.storeLabel = New System.Windows.Forms.Label()
        Me.TblStoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoresDataSet = New Adalene_Project.StoresDataSet()
        Me.salesLabel = New System.Windows.Forms.Label()
        Me.ownerLabel = New System.Windows.Forms.Label()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.TblStoresTableAdapter = New Adalene_Project.StoresDataSetTableAdapters.tblStoresTableAdapter()
        Me.TableAdapterManager = New Adalene_Project.StoresDataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TblStoresBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.StoresDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Adalene_Project.My.Resources.Resources.Fashion
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(208, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Store:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(276, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sales:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(382, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ownership:"
        '
        'storeLabel
        '
        Me.storeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.storeLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStoresBindingSource, "StoreNum", True))
        Me.storeLabel.Location = New System.Drawing.Point(212, 53)
        Me.storeLabel.Name = "storeLabel"
        Me.storeLabel.Size = New System.Drawing.Size(43, 33)
        Me.storeLabel.TabIndex = 6
        Me.storeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblStoresBindingSource
        '
        Me.TblStoresBindingSource.DataMember = "tblStores"
        Me.TblStoresBindingSource.DataSource = Me.StoresDataSet
        '
        'StoresDataSet
        '
        Me.StoresDataSet.DataSetName = "StoresDataSet"
        Me.StoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'salesLabel
        '
        Me.salesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salesLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStoresBindingSource, "Sales", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.salesLabel.Location = New System.Drawing.Point(280, 53)
        Me.salesLabel.Name = "salesLabel"
        Me.salesLabel.Size = New System.Drawing.Size(82, 33)
        Me.salesLabel.TabIndex = 7
        Me.salesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ownerLabel
        '
        Me.ownerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ownerLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStoresBindingSource, "Ownership", True))
        Me.ownerLabel.Location = New System.Drawing.Point(386, 53)
        Me.ownerLabel.Name = "ownerLabel"
        Me.ownerLabel.Size = New System.Drawing.Size(39, 33)
        Me.ownerLabel.TabIndex = 8
        Me.ownerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(161, 144)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(124, 33)
        Me.previousButton.TabIndex = 0
        Me.previousButton.Text = "&Previous Record"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(291, 145)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(124, 33)
        Me.nextButton.TabIndex = 1
        Me.nextButton.Text = "&Next Record"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(421, 144)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 33)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'TblStoresTableAdapter
        '
        Me.TblStoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblStoresTableAdapter = Me.TblStoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = Adalene_Project.StoresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 210)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.ownerLabel)
        Me.Controls.Add(Me.salesLabel)
        Me.Controls.Add(Me.storeLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adalene Fashions"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TblStoresBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.StoresDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents storeLabel As Label
    Friend WithEvents salesLabel As Label
    Friend WithEvents ownerLabel As Label
    Friend WithEvents previousButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents StoresDataSet As StoresDataSet
    Friend WithEvents TblStoresBindingSource As BindingSource
    Friend WithEvents TblStoresTableAdapter As StoresDataSetTableAdapters.tblStoresTableAdapter
    Friend WithEvents TableAdapterManager As StoresDataSetTableAdapters.TableAdapterManager
End Class
