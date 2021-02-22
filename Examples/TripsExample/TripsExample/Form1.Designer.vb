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
        Me.dgvInfo = New System.Windows.Forms.DataGridView()
        Me.btnTrips = New System.Windows.Forms.Button()
        Me.btnCities = New System.Windows.Forms.Button()
        Me.btnChicago = New System.Windows.Forms.Button()
        Me.TblTripsTableAdapter1 = New TripsExample.TripsCopyDataSetTableAdapters.tblTripsTableAdapter()
        Me.TripsCopyDataSet = New TripsExample.TripsCopyDataSet()
        Me.TblCityTableAdapter1 = New TripsExample.TripsCopyDataSetTableAdapters.tblCityTableAdapter()
        Me.ChicagoTripsTableAdapter1 = New TripsExample.TripsCopyDataSetTableAdapters.ChicagoTripsTableAdapter()
        Me.btnSelectTrips = New System.Windows.Forms.Button()
        Me.btnCountByCity = New System.Windows.Forms.Button()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TripsCopyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInfo
        '
        Me.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfo.Location = New System.Drawing.Point(28, 95)
        Me.dgvInfo.Name = "dgvInfo"
        Me.dgvInfo.Size = New System.Drawing.Size(370, 150)
        Me.dgvInfo.TabIndex = 0
        '
        'btnTrips
        '
        Me.btnTrips.Location = New System.Drawing.Point(28, 23)
        Me.btnTrips.Name = "btnTrips"
        Me.btnTrips.Size = New System.Drawing.Size(75, 34)
        Me.btnTrips.TabIndex = 1
        Me.btnTrips.Text = "All" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trips"
        Me.btnTrips.UseVisualStyleBackColor = True
        '
        'btnCities
        '
        Me.btnCities.Location = New System.Drawing.Point(352, 23)
        Me.btnCities.Name = "btnCities"
        Me.btnCities.Size = New System.Drawing.Size(75, 34)
        Me.btnCities.TabIndex = 2
        Me.btnCities.Text = "Cities"
        Me.btnCities.UseVisualStyleBackColor = True
        '
        'btnChicago
        '
        Me.btnChicago.Location = New System.Drawing.Point(109, 23)
        Me.btnChicago.Name = "btnChicago"
        Me.btnChicago.Size = New System.Drawing.Size(75, 34)
        Me.btnChicago.TabIndex = 3
        Me.btnChicago.Text = "Chicago" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trips"
        Me.btnChicago.UseVisualStyleBackColor = True
        '
        'TblTripsTableAdapter1
        '
        Me.TblTripsTableAdapter1.ClearBeforeFill = True
        '
        'TripsCopyDataSet
        '
        Me.TripsCopyDataSet.DataSetName = "TripsCopyDataSet"
        Me.TripsCopyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCityTableAdapter1
        '
        Me.TblCityTableAdapter1.ClearBeforeFill = True
        '
        'ChicagoTripsTableAdapter1
        '
        Me.ChicagoTripsTableAdapter1.ClearBeforeFill = True
        '
        'btnSelectTrips
        '
        Me.btnSelectTrips.Location = New System.Drawing.Point(190, 23)
        Me.btnSelectTrips.Name = "btnSelectTrips"
        Me.btnSelectTrips.Size = New System.Drawing.Size(75, 34)
        Me.btnSelectTrips.TabIndex = 4
        Me.btnSelectTrips.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trips"
        Me.btnSelectTrips.UseVisualStyleBackColor = True
        '
        'btnCountByCity
        '
        Me.btnCountByCity.Location = New System.Drawing.Point(271, 23)
        Me.btnCountByCity.Name = "btnCountByCity"
        Me.btnCountByCity.Size = New System.Drawing.Size(75, 34)
        Me.btnCountByCity.TabIndex = 5
        Me.btnCountByCity.Text = "Count By" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "City"
        Me.btnCountByCity.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 316)
        Me.Controls.Add(Me.btnCountByCity)
        Me.Controls.Add(Me.btnSelectTrips)
        Me.Controls.Add(Me.btnChicago)
        Me.Controls.Add(Me.btnCities)
        Me.Controls.Add(Me.btnTrips)
        Me.Controls.Add(Me.dgvInfo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TripsCopyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvInfo As DataGridView
    Friend WithEvents btnTrips As Button
    Friend WithEvents btnCities As Button
    Friend WithEvents btnChicago As Button
    Friend WithEvents TblTripsTableAdapter1 As TripsCopyDataSetTableAdapters.tblTripsTableAdapter
    Friend WithEvents TripsCopyDataSet As TripsCopyDataSet
    Friend WithEvents TblCityTableAdapter1 As TripsCopyDataSetTableAdapters.tblCityTableAdapter
    Friend WithEvents ChicagoTripsTableAdapter1 As TripsCopyDataSetTableAdapters.ChicagoTripsTableAdapter
    Friend WithEvents btnSelectTrips As Button
    Friend WithEvents btnCountByCity As Button
End Class
