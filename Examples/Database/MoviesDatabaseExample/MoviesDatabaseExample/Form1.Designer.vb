<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TblGamesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TblGamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GamesRevisedDataSet = New MoviesDatabaseExample.GamesRevisedDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtPriceSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbSearch = New System.Windows.Forms.ToolStripButton()
        Me.tsbXBGames = New System.Windows.Forms.ToolStripButton()
        Me.tsbNewGames = New System.Windows.Forms.ToolStripButton()
        Me.TblGamesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatingDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.justNewGamesDataGridView = New System.Windows.Forms.DataGridView()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblJustNewGamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGamesTableAdapter = New MoviesDatabaseExample.GamesRevisedDataSetTableAdapters.tblGamesTableAdapter()
        Me.TableAdapterManager = New MoviesDatabaseExample.GamesRevisedDataSetTableAdapters.TableAdapterManager()
        Me.TblRatingTableAdapter = New MoviesDatabaseExample.GamesRevisedDataSetTableAdapters.tblRatingTableAdapter()
        Me.TblRatingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblJustNewGamesTableAdapter = New MoviesDatabaseExample.GamesRevisedDataSetTableAdapters.tblJustNewGamesTableAdapter()
        Me.tsbViewRatings = New System.Windows.Forms.ToolStripButton()
        CType(Me.TblGamesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblGamesBindingNavigator.SuspendLayout()
        CType(Me.TblGamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GamesRevisedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGamesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.justNewGamesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblJustNewGamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRatingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblGamesBindingNavigator
        '
        Me.TblGamesBindingNavigator.AddNewItem = Nothing
        Me.TblGamesBindingNavigator.BindingSource = Me.TblGamesBindingSource
        Me.TblGamesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblGamesBindingNavigator.DeleteItem = Nothing
        Me.TblGamesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.txtPriceSearch, Me.tsbSearch, Me.tsbXBGames, Me.tsbNewGames, Me.tsbViewRatings})
        Me.TblGamesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblGamesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblGamesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblGamesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblGamesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblGamesBindingNavigator.Name = "TblGamesBindingNavigator"
        Me.TblGamesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblGamesBindingNavigator.Size = New System.Drawing.Size(1106, 25)
        Me.TblGamesBindingNavigator.TabIndex = 0
        Me.TblGamesBindingNavigator.Text = "BindingNavigator1"
        '
        'TblGamesBindingSource
        '
        Me.TblGamesBindingSource.DataMember = "tblGames"
        Me.TblGamesBindingSource.DataSource = Me.GamesRevisedDataSet
        '
        'GamesRevisedDataSet
        '
        Me.GamesRevisedDataSet.DataSetName = "GamesRevisedDataSet"
        Me.GamesRevisedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'txtPriceSearch
        '
        Me.txtPriceSearch.Name = "txtPriceSearch"
        Me.txtPriceSearch.Size = New System.Drawing.Size(100, 25)
        Me.txtPriceSearch.ToolTipText = "Enter a price, and click Search to retrieve games " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "at or above that price. To re" &
    "turn all games, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "remove the price and click Search again."
        '
        'tsbSearch
        '
        Me.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSearch.Image = CType(resources.GetObject("tsbSearch.Image"), System.Drawing.Image)
        Me.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSearch.Name = "tsbSearch"
        Me.tsbSearch.Size = New System.Drawing.Size(46, 22)
        Me.tsbSearch.Text = "Search"
        '
        'tsbXBGames
        '
        Me.tsbXBGames.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbXBGames.Image = CType(resources.GetObject("tsbXBGames.Image"), System.Drawing.Image)
        Me.tsbXBGames.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbXBGames.Name = "tsbXBGames"
        Me.tsbXBGames.Size = New System.Drawing.Size(64, 22)
        Me.tsbXBGames.Text = "XB Games"
        '
        'tsbNewGames
        '
        Me.tsbNewGames.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbNewGames.Image = CType(resources.GetObject("tsbNewGames.Image"), System.Drawing.Image)
        Me.tsbNewGames.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNewGames.Name = "tsbNewGames"
        Me.tsbNewGames.Size = New System.Drawing.Size(74, 22)
        Me.tsbNewGames.Text = "New Games"
        '
        'TblGamesDataGridView
        '
        Me.TblGamesDataGridView.AllowUserToAddRows = False
        Me.TblGamesDataGridView.AllowUserToDeleteRows = False
        Me.TblGamesDataGridView.AutoGenerateColumns = False
        Me.TblGamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblGamesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.RatingDesc})
        Me.TblGamesDataGridView.DataSource = Me.TblGamesBindingSource
        Me.TblGamesDataGridView.Location = New System.Drawing.Point(12, 50)
        Me.TblGamesDataGridView.Name = "TblGamesDataGridView"
        Me.TblGamesDataGridView.ReadOnly = True
        Me.TblGamesDataGridView.Size = New System.Drawing.Size(848, 220)
        Me.TblGamesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Platform"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Platform"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Rating"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RatingID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NewUsed"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NewUsed"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'RatingDesc
        '
        Me.RatingDesc.HeaderText = "Rating Description"
        Me.RatingDesc.Name = "RatingDesc"
        Me.RatingDesc.ReadOnly = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Price Search"
        '
        'justNewGamesDataGridView
        '
        Me.justNewGamesDataGridView.AllowUserToAddRows = False
        Me.justNewGamesDataGridView.AllowUserToDeleteRows = False
        Me.justNewGamesDataGridView.AutoGenerateColumns = False
        Me.justNewGamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.justNewGamesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TitleDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.justNewGamesDataGridView.DataSource = Me.TblJustNewGamesBindingSource
        Me.justNewGamesDataGridView.Location = New System.Drawing.Point(12, 183)
        Me.justNewGamesDataGridView.Name = "justNewGamesDataGridView"
        Me.justNewGamesDataGridView.ReadOnly = True
        Me.justNewGamesDataGridView.Size = New System.Drawing.Size(352, 150)
        Me.justNewGamesDataGridView.TabIndex = 2
        Me.justNewGamesDataGridView.Visible = False
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblJustNewGamesBindingSource
        '
        Me.TblJustNewGamesBindingSource.DataMember = "tblJustNewGames"
        Me.TblJustNewGamesBindingSource.DataSource = Me.GamesRevisedDataSet
        '
        'TblGamesTableAdapter
        '
        Me.TblGamesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblGames1TableAdapter = Nothing
        Me.TableAdapterManager.tblGamesTableAdapter = Me.TblGamesTableAdapter
        Me.TableAdapterManager.tblJustNewGamesTableAdapter = Nothing
        Me.TableAdapterManager.tblRatingTableAdapter = Me.TblRatingTableAdapter
        Me.TableAdapterManager.UpdateOrder = MoviesDatabaseExample.GamesRevisedDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblRatingTableAdapter
        '
        Me.TblRatingTableAdapter.ClearBeforeFill = True
        '
        'TblRatingBindingSource
        '
        Me.TblRatingBindingSource.DataMember = "tblRating"
        Me.TblRatingBindingSource.DataSource = Me.GamesRevisedDataSet
        '
        'TblJustNewGamesTableAdapter
        '
        Me.TblJustNewGamesTableAdapter.ClearBeforeFill = True
        '
        'tsbViewRatings
        '
        Me.tsbViewRatings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbViewRatings.Image = CType(resources.GetObject("tsbViewRatings.Image"), System.Drawing.Image)
        Me.tsbViewRatings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbViewRatings.Name = "tsbViewRatings"
        Me.tsbViewRatings.Size = New System.Drawing.Size(78, 22)
        Me.tsbViewRatings.Text = "View Ratings"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 486)
        Me.Controls.Add(Me.justNewGamesDataGridView)
        Me.Controls.Add(Me.TblGamesDataGridView)
        Me.Controls.Add(Me.TblGamesBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TblGamesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblGamesBindingNavigator.ResumeLayout(False)
        Me.TblGamesBindingNavigator.PerformLayout()
        CType(Me.TblGamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GamesRevisedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGamesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.justNewGamesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblJustNewGamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRatingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GamesRevisedDataSet As GamesRevisedDataSet
    Friend WithEvents TblGamesBindingSource As BindingSource
    Friend WithEvents TblGamesTableAdapter As GamesRevisedDataSetTableAdapters.tblGamesTableAdapter
    Friend WithEvents TableAdapterManager As GamesRevisedDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblGamesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblGamesDataGridView As DataGridView
    Friend WithEvents TblRatingTableAdapter As GamesRevisedDataSetTableAdapters.tblRatingTableAdapter
    Friend WithEvents TblRatingBindingSource As BindingSource
    Friend WithEvents txtPriceSearch As ToolStripTextBox
    Friend WithEvents tsbSearch As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RatingDesc As DataGridViewTextBoxColumn
    Friend WithEvents tsbXBGames As ToolStripButton
    Friend WithEvents tsbNewGames As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents TblJustNewGamesTableAdapter As GamesRevisedDataSetTableAdapters.tblJustNewGamesTableAdapter
    Friend WithEvents justNewGamesDataGridView As DataGridView
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblJustNewGamesBindingSource As BindingSource
    Friend WithEvents tsbViewRatings As ToolStripButton
End Class
