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
        Me.StoresDataSet = New Adalene_Project.StoresDataSet()
        Me.TblStoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStoresTableAdapter = New Adalene_Project.StoresDataSetTableAdapters.tblStoresTableAdapter()
        Me.TableAdapterManager = New Adalene_Project.StoresDataSetTableAdapters.TableAdapterManager()
        Me.TblStoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ex1Button = New System.Windows.Forms.Button()
        Me.ex2Button = New System.Windows.Forms.Button()
        Me.ex3Button = New System.Windows.Forms.Button()
        Me.ex4Button = New System.Windows.Forms.Button()
        Me.ex5Button = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.StoresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StoresDataSet
        '
        Me.StoresDataSet.DataSetName = "StoresDataSet"
        Me.StoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblStoresBindingSource
        '
        Me.TblStoresBindingSource.DataMember = "tblStores"
        Me.TblStoresBindingSource.DataSource = Me.StoresDataSet
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
        'TblStoresDataGridView
        '
        Me.TblStoresDataGridView.AutoGenerateColumns = False
        Me.TblStoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblStoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblStoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblStoresDataGridView.DataSource = Me.TblStoresBindingSource
        Me.TblStoresDataGridView.Location = New System.Drawing.Point(0, 2)
        Me.TblStoresDataGridView.Name = "TblStoresDataGridView"
        Me.TblStoresDataGridView.RowHeadersVisible = False
        Me.TblStoresDataGridView.Size = New System.Drawing.Size(569, 243)
        Me.TblStoresDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StoreNum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Store"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn2.HeaderText = "City"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn3.HeaderText = "State"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sales"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sales"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ownership"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ownership"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'ex1Button
        '
        Me.ex1Button.Location = New System.Drawing.Point(13, 266)
        Me.ex1Button.Name = "ex1Button"
        Me.ex1Button.Size = New System.Drawing.Size(88, 32)
        Me.ex1Button.TabIndex = 0
        Me.ex1Button.Text = "Example &1"
        Me.ex1Button.UseVisualStyleBackColor = True
        '
        'ex2Button
        '
        Me.ex2Button.Location = New System.Drawing.Point(106, 266)
        Me.ex2Button.Name = "ex2Button"
        Me.ex2Button.Size = New System.Drawing.Size(88, 32)
        Me.ex2Button.TabIndex = 1
        Me.ex2Button.Text = "Example &2"
        Me.ex2Button.UseVisualStyleBackColor = True
        '
        'ex3Button
        '
        Me.ex3Button.Location = New System.Drawing.Point(199, 266)
        Me.ex3Button.Name = "ex3Button"
        Me.ex3Button.Size = New System.Drawing.Size(88, 32)
        Me.ex3Button.TabIndex = 2
        Me.ex3Button.Text = "Example &3"
        Me.ex3Button.UseVisualStyleBackColor = True
        '
        'ex4Button
        '
        Me.ex4Button.Location = New System.Drawing.Point(292, 266)
        Me.ex4Button.Name = "ex4Button"
        Me.ex4Button.Size = New System.Drawing.Size(88, 32)
        Me.ex4Button.TabIndex = 3
        Me.ex4Button.Text = "Example &4"
        Me.ex4Button.UseVisualStyleBackColor = True
        '
        'ex5Button
        '
        Me.ex5Button.Location = New System.Drawing.Point(385, 266)
        Me.ex5Button.Name = "ex5Button"
        Me.ex5Button.Size = New System.Drawing.Size(88, 32)
        Me.ex5Button.TabIndex = 4
        Me.ex5Button.Text = "Example &5"
        Me.ex5Button.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(478, 266)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 32)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 327)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.ex5Button)
        Me.Controls.Add(Me.ex4Button)
        Me.Controls.Add(Me.ex3Button)
        Me.Controls.Add(Me.ex2Button)
        Me.Controls.Add(Me.ex1Button)
        Me.Controls.Add(Me.TblStoresDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Adalene Fashions"
        CType(Me.StoresDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StoresDataSet As StoresDataSet
    Friend WithEvents TblStoresBindingSource As BindingSource
    Friend WithEvents TblStoresTableAdapter As StoresDataSetTableAdapters.tblStoresTableAdapter
    Friend WithEvents TableAdapterManager As StoresDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblStoresDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ex1Button As Button
    Friend WithEvents ex2Button As Button
    Friend WithEvents ex3Button As Button
    Friend WithEvents ex4Button As Button
    Friend WithEvents ex5Button As Button
    Friend WithEvents exitButton As Button
End Class
