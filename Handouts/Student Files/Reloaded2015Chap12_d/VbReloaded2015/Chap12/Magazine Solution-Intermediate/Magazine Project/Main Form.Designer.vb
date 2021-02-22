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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MagazinesDataSet = New Magazine_Project.MagazinesDataSet()
        Me.TblMagazineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMagazineTableAdapter = New Magazine_Project.MagazinesDataSetTableAdapters.tblMagazineTableAdapter()
        Me.TableAdapterManager = New Magazine_Project.MagazinesDataSetTableAdapters.TableAdapterManager()
        Me.TblMagazineDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costButton = New System.Windows.Forms.Button()
        Me.allButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.avgButton = New System.Windows.Forms.Button()
        CType(Me.MagazinesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMagazineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMagazineDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MagazinesDataSet
        '
        Me.MagazinesDataSet.DataSetName = "MagazinesDataSet"
        Me.MagazinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMagazineBindingSource
        '
        Me.TblMagazineBindingSource.DataMember = "tblMagazine"
        Me.TblMagazineBindingSource.DataSource = Me.MagazinesDataSet
        '
        'TblMagazineTableAdapter
        '
        Me.TblMagazineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblMagazineTableAdapter = Me.TblMagazineTableAdapter
        Me.TableAdapterManager.UpdateOrder = Magazine_Project.MagazinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblMagazineDataGridView
        '
        Me.TblMagazineDataGridView.AllowUserToAddRows = False
        Me.TblMagazineDataGridView.AllowUserToDeleteRows = False
        Me.TblMagazineDataGridView.AutoGenerateColumns = False
        Me.TblMagazineDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblMagazineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblMagazineDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblMagazineDataGridView.DataSource = Me.TblMagazineBindingSource
        Me.TblMagazineDataGridView.Location = New System.Drawing.Point(14, 14)
        Me.TblMagazineDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TblMagazineDataGridView.Name = "TblMagazineDataGridView"
        Me.TblMagazineDataGridView.ReadOnly = True
        Me.TblMagazineDataGridView.RowHeadersVisible = False
        Me.TblMagazineDataGridView.Size = New System.Drawing.Size(410, 280)
        Me.TblMagazineDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 69
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MagName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Magazine Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cost"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 63
        '
        'costButton
        '
        Me.costButton.Location = New System.Drawing.Point(447, 52)
        Me.costButton.Name = "costButton"
        Me.costButton.Size = New System.Drawing.Size(137, 32)
        Me.costButton.TabIndex = 1
        Me.costButton.Text = "Magazine &Cost"
        Me.costButton.UseVisualStyleBackColor = True
        '
        'allButton
        '
        Me.allButton.Location = New System.Drawing.Point(447, 14)
        Me.allButton.Name = "allButton"
        Me.allButton.Size = New System.Drawing.Size(137, 32)
        Me.allButton.TabIndex = 0
        Me.allButton.Text = "&All Records"
        Me.allButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(447, 128)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(133, 32)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'avgButton
        '
        Me.avgButton.Location = New System.Drawing.Point(447, 90)
        Me.avgButton.Name = "avgButton"
        Me.avgButton.Size = New System.Drawing.Size(133, 32)
        Me.avgButton.TabIndex = 2
        Me.avgButton.Text = "A&verage Cost"
        Me.avgButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 322)
        Me.Controls.Add(Me.avgButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.allButton)
        Me.Controls.Add(Me.costButton)
        Me.Controls.Add(Me.TblMagazineDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magazines"
        CType(Me.MagazinesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMagazineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMagazineDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MagazinesDataSet As Magazine_Project.MagazinesDataSet
    Friend WithEvents TblMagazineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMagazineTableAdapter As Magazine_Project.MagazinesDataSetTableAdapters.tblMagazineTableAdapter
    Friend WithEvents TableAdapterManager As Magazine_Project.MagazinesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblMagazineDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costButton As System.Windows.Forms.Button
    Friend WithEvents allButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents avgButton As System.Windows.Forms.Button

End Class
