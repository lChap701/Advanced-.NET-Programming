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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Me.fillButton = New System.Windows.Forms.Button()
        Me.numberLabel = New System.Windows.Forms.Label()
        Me.TblFriendsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FriendsDataSet = New Debug_Project.FriendsDataSet()
        Me.lastLabel = New System.Windows.Forms.Label()
        Me.firstLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.cityLabel = New System.Windows.Forms.Label()
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.zipLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.TblFriendsTableAdapter = New Debug_Project.FriendsDataSetTableAdapters.tblFriendsTableAdapter()
        Me.TableAdapterManager = New Debug_Project.FriendsDataSetTableAdapters.TableAdapterManager()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.TblFriendsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FriendsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(24, 26)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(59, 17)
        Label1.TabIndex = 40
        Label1.Text = "Number:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(24, 62)
        Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(34, 17)
        Label2.TabIndex = 42
        Label2.Text = "Last:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(24, 93)
        Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(35, 17)
        Label3.TabIndex = 44
        Label3.Text = "First:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(24, 124)
        Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(59, 17)
        Label4.TabIndex = 46
        Label4.Text = "Address:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(24, 155)
        Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(32, 17)
        Label5.TabIndex = 48
        Label5.Text = "City:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(24, 184)
        Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(40, 17)
        Label6.TabIndex = 50
        Label6.Text = "State:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(172, 185)
        Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(28, 17)
        Label7.TabIndex = 52
        Label7.Text = "ZIP:"
        '
        'fillButton
        '
        Me.fillButton.Location = New System.Drawing.Point(323, 22)
        Me.fillButton.Margin = New System.Windows.Forms.Padding(2)
        Me.fillButton.Name = "fillButton"
        Me.fillButton.Size = New System.Drawing.Size(111, 29)
        Me.fillButton.TabIndex = 36
        Me.fillButton.Text = "&Fill"
        '
        'numberLabel
        '
        Me.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numberLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "Number", True))
        Me.numberLabel.Location = New System.Drawing.Point(88, 26)
        Me.numberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.numberLabel.Name = "numberLabel"
        Me.numberLabel.Size = New System.Drawing.Size(70, 20)
        Me.numberLabel.TabIndex = 41
        '
        'TblFriendsBindingSource
        '
        Me.TblFriendsBindingSource.DataMember = "tblFriends"
        Me.TblFriendsBindingSource.DataSource = Me.FriendsDataSet
        '
        'FriendsDataSet
        '
        Me.FriendsDataSet.DataSetName = "FriendsDataSet"
        Me.FriendsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lastLabel
        '
        Me.lastLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "Last", True))
        Me.lastLabel.Location = New System.Drawing.Point(88, 63)
        Me.lastLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lastLabel.Name = "lastLabel"
        Me.lastLabel.Size = New System.Drawing.Size(199, 20)
        Me.lastLabel.TabIndex = 43
        '
        'firstLabel
        '
        Me.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "First", True))
        Me.firstLabel.Location = New System.Drawing.Point(88, 94)
        Me.firstLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.firstLabel.Name = "firstLabel"
        Me.firstLabel.Size = New System.Drawing.Size(199, 20)
        Me.firstLabel.TabIndex = 45
        '
        'addressLabel
        '
        Me.addressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addressLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "Address", True))
        Me.addressLabel.Location = New System.Drawing.Point(88, 125)
        Me.addressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(199, 20)
        Me.addressLabel.TabIndex = 47
        '
        'cityLabel
        '
        Me.cityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cityLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "City", True))
        Me.cityLabel.Location = New System.Drawing.Point(88, 155)
        Me.cityLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(199, 20)
        Me.cityLabel.TabIndex = 49
        '
        'stateLabel
        '
        Me.stateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stateLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "State", True))
        Me.stateLabel.Location = New System.Drawing.Point(88, 183)
        Me.stateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(49, 20)
        Me.stateLabel.TabIndex = 51
        '
        'zipLabel
        '
        Me.zipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.zipLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblFriendsBindingSource, "ZIP", True))
        Me.zipLabel.Location = New System.Drawing.Point(204, 184)
        Me.zipLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.zipLabel.Name = "zipLabel"
        Me.zipLabel.Size = New System.Drawing.Size(83, 20)
        Me.zipLabel.TabIndex = 53
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(323, 115)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(111, 29)
        Me.exitButton.TabIndex = 39
        Me.exitButton.Text = "E&xit"
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(323, 84)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(2)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(111, 29)
        Me.nextButton.TabIndex = 38
        Me.nextButton.Text = "&Next"
        '
        'previousButton
        '
        Me.previousButton.Location = New System.Drawing.Point(323, 53)
        Me.previousButton.Margin = New System.Windows.Forms.Padding(2)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(111, 29)
        Me.previousButton.TabIndex = 37
        Me.previousButton.Text = "&Previous"
        '
        'TblFriendsTableAdapter
        '
        Me.TblFriendsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblFriendsTableAdapter = Me.TblFriendsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Debug_Project.FriendsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 240)
        Me.Controls.Add(Me.fillButton)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.numberLabel)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.lastLabel)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.firstLabel)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.cityLabel)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.stateLabel)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.zipLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.previousButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Swat the Bugs"
        CType(Me.TblFriendsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FriendsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fillButton As System.Windows.Forms.Button
    Friend WithEvents numberLabel As System.Windows.Forms.Label
    Friend WithEvents lastLabel As System.Windows.Forms.Label
    Friend WithEvents firstLabel As System.Windows.Forms.Label
    Friend WithEvents addressLabel As System.Windows.Forms.Label
    Friend WithEvents cityLabel As System.Windows.Forms.Label
    Friend WithEvents stateLabel As System.Windows.Forms.Label
    Friend WithEvents zipLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents previousButton As System.Windows.Forms.Button
    Friend WithEvents FriendsDataSet As Debug_Project.FriendsDataSet
    Friend WithEvents TblFriendsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblFriendsTableAdapter As Debug_Project.FriendsDataSetTableAdapters.tblFriendsTableAdapter
    Friend WithEvents TableAdapterManager As Debug_Project.FriendsDataSetTableAdapters.TableAdapterManager

End Class
