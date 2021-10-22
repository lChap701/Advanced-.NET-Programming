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
        Me.MusicBoxDataSet = New MusicBox_Project.MusicBoxDataSet()
        Me.TblBoxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblBoxTableAdapter = New MusicBox_Project.MusicBoxDataSetTableAdapters.tblBoxTableAdapter()
        Me.TableAdapterManager = New MusicBox_Project.MusicBoxDataSetTableAdapters.TableAdapterManager()
        Me.TblBoxDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allButton = New System.Windows.Forms.Button()
        Me.shapeButton = New System.Windows.Forms.Button()
        Me.sourceButton = New System.Windows.Forms.Button()
        Me.giftRadioButton = New System.Windows.Forms.RadioButton()
        Me.purchasedRadioButton = New System.Windows.Forms.RadioButton()
        Me.octagonRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.roundRadioButton = New System.Windows.Forms.RadioButton()
        Me.rectangleRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.countButton = New System.Windows.Forms.Button()
        CType(Me.MusicBoxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBoxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBoxDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MusicBoxDataSet
        '
        Me.MusicBoxDataSet.DataSetName = "MusicBoxDataSet"
        Me.MusicBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBoxBindingSource
        '
        Me.TblBoxBindingSource.DataMember = "tblBox"
        Me.TblBoxBindingSource.DataSource = Me.MusicBoxDataSet
        '
        'TblBoxTableAdapter
        '
        Me.TblBoxTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBoxTableAdapter = Me.TblBoxTableAdapter
        Me.TableAdapterManager.UpdateOrder = MusicBox_Project.MusicBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblBoxDataGridView
        '
        Me.TblBoxDataGridView.AllowUserToAddRows = False
        Me.TblBoxDataGridView.AllowUserToDeleteRows = False
        Me.TblBoxDataGridView.AutoGenerateColumns = False
        Me.TblBoxDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblBoxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblBoxDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TblBoxDataGridView.DataSource = Me.TblBoxBindingSource
        Me.TblBoxDataGridView.Location = New System.Drawing.Point(22, 15)
        Me.TblBoxDataGridView.Name = "TblBoxDataGridView"
        Me.TblBoxDataGridView.ReadOnly = True
        Me.TblBoxDataGridView.RowHeadersVisible = False
        Me.TblBoxDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblBoxDataGridView.Size = New System.Drawing.Size(563, 271)
        Me.TblBoxDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 45
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Shape"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Shape"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Source"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Source"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Song"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Song"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'allButton
        '
        Me.allButton.Location = New System.Drawing.Point(614, 23)
        Me.allButton.Name = "allButton"
        Me.allButton.Size = New System.Drawing.Size(111, 30)
        Me.allButton.TabIndex = 0
        Me.allButton.Text = "&All Records"
        Me.allButton.UseVisualStyleBackColor = True
        '
        'shapeButton
        '
        Me.shapeButton.Location = New System.Drawing.Point(15, 105)
        Me.shapeButton.Name = "shapeButton"
        Me.shapeButton.Size = New System.Drawing.Size(111, 30)
        Me.shapeButton.TabIndex = 3
        Me.shapeButton.Text = "S&hape"
        Me.shapeButton.UseVisualStyleBackColor = True
        '
        'sourceButton
        '
        Me.sourceButton.Location = New System.Drawing.Point(6, 87)
        Me.sourceButton.Name = "sourceButton"
        Me.sourceButton.Size = New System.Drawing.Size(111, 30)
        Me.sourceButton.TabIndex = 2
        Me.sourceButton.Text = "&Source"
        Me.sourceButton.UseVisualStyleBackColor = True
        '
        'giftRadioButton
        '
        Me.giftRadioButton.AutoSize = True
        Me.giftRadioButton.Checked = True
        Me.giftRadioButton.Location = New System.Drawing.Point(11, 24)
        Me.giftRadioButton.Name = "giftRadioButton"
        Me.giftRadioButton.Size = New System.Drawing.Size(46, 21)
        Me.giftRadioButton.TabIndex = 0
        Me.giftRadioButton.TabStop = True
        Me.giftRadioButton.Text = "&Gift"
        Me.giftRadioButton.UseVisualStyleBackColor = True
        '
        'purchasedRadioButton
        '
        Me.purchasedRadioButton.AutoSize = True
        Me.purchasedRadioButton.Location = New System.Drawing.Point(11, 51)
        Me.purchasedRadioButton.Name = "purchasedRadioButton"
        Me.purchasedRadioButton.Size = New System.Drawing.Size(86, 21)
        Me.purchasedRadioButton.TabIndex = 1
        Me.purchasedRadioButton.Text = "&Purchased"
        Me.purchasedRadioButton.UseVisualStyleBackColor = True
        '
        'octagonRadioButton
        '
        Me.octagonRadioButton.AutoSize = True
        Me.octagonRadioButton.Checked = True
        Me.octagonRadioButton.Location = New System.Drawing.Point(15, 19)
        Me.octagonRadioButton.Name = "octagonRadioButton"
        Me.octagonRadioButton.Size = New System.Drawing.Size(76, 21)
        Me.octagonRadioButton.TabIndex = 0
        Me.octagonRadioButton.TabStop = True
        Me.octagonRadioButton.Text = "&Octagon"
        Me.octagonRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.roundRadioButton)
        Me.GroupBox1.Controls.Add(Me.rectangleRadioButton)
        Me.GroupBox1.Controls.Add(Me.octagonRadioButton)
        Me.GroupBox1.Controls.Add(Me.shapeButton)
        Me.GroupBox1.Location = New System.Drawing.Point(614, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 148)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'roundRadioButton
        '
        Me.roundRadioButton.AutoSize = True
        Me.roundRadioButton.Location = New System.Drawing.Point(15, 73)
        Me.roundRadioButton.Name = "roundRadioButton"
        Me.roundRadioButton.Size = New System.Drawing.Size(64, 21)
        Me.roundRadioButton.TabIndex = 2
        Me.roundRadioButton.Text = "Roun&d"
        Me.roundRadioButton.UseVisualStyleBackColor = True
        '
        'rectangleRadioButton
        '
        Me.rectangleRadioButton.AutoSize = True
        Me.rectangleRadioButton.Location = New System.Drawing.Point(15, 46)
        Me.rectangleRadioButton.Name = "rectangleRadioButton"
        Me.rectangleRadioButton.Size = New System.Drawing.Size(83, 21)
        Me.rectangleRadioButton.TabIndex = 1
        Me.rectangleRadioButton.Text = "&Rectangle"
        Me.rectangleRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.giftRadioButton)
        Me.GroupBox2.Controls.Add(Me.purchasedRadioButton)
        Me.GroupBox2.Controls.Add(Me.sourceButton)
        Me.GroupBox2.Location = New System.Drawing.Point(786, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 137)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(792, 228)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(111, 30)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'countButton
        '
        Me.countButton.Location = New System.Drawing.Point(792, 23)
        Me.countButton.Name = "countButton"
        Me.countButton.Size = New System.Drawing.Size(111, 30)
        Me.countButton.TabIndex = 1
        Me.countButton.Text = "&Count"
        Me.countButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 311)
        Me.Controls.Add(Me.countButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.allButton)
        Me.Controls.Add(Me.TblBoxDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Music Box"
        CType(Me.MusicBoxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBoxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBoxDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MusicBoxDataSet As MusicBox_Project.MusicBoxDataSet
    Friend WithEvents TblBoxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblBoxTableAdapter As MusicBox_Project.MusicBoxDataSetTableAdapters.tblBoxTableAdapter
    Friend WithEvents TableAdapterManager As MusicBox_Project.MusicBoxDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblBoxDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allButton As System.Windows.Forms.Button
    Friend WithEvents shapeButton As System.Windows.Forms.Button
    Friend WithEvents sourceButton As System.Windows.Forms.Button
    Friend WithEvents giftRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents purchasedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents octagonRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents roundRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents rectangleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents countButton As System.Windows.Forms.Button

End Class
