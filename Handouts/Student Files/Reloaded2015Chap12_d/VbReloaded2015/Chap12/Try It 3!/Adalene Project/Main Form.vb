' Project name:         Adalene Project
' Project purpose:      Displays either all or specific records stored in a dataset
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class MainForm
    Private Sub ex1Button_Click(sender As Object, e As EventArgs) Handles ex1Button.Click
        ' selects all records from the dataset

        Dim records = From store In StoresDataSet.tblStores
                      Select store
        TblStoresBindingSource.DataSource = records.AsDataView
    End Sub

    Private Sub ex2Button_Click(sender As Object, e As EventArgs) Handles ex2Button.Click
        ' selects all records from the dataset and arranges them in ascending order by the Sales field

        Dim records = From store In StoresDataSet.tblStores
                      Order By store.Sales
                      Select store
        TblStoresBindingSource.DataSource = records.AsDataView
    End Sub

    Private Sub ex3Button_Click(sender As Object, e As EventArgs) Handles ex3Button.Click
        ' selects only the franchisees' records from the dataset

        Dim records = From store In StoresDataSet.tblStores
                      Where store.Ownership.ToUpper = "F"
                      Select store
        TblStoresBindingSource.DataSource = records.AsDataView
    End Sub

    Private Sub ex4Button_Click(sender As Object, e As EventArgs) Handles ex4Button.Click
        ' selects only the records for stores that have more than $100,000 in sales

        Dim records = From store In StoresDataSet.tblStores
                      Where store.Sales > 100000
                      Select store
        TblStoresBindingSource.DataSource = records.AsDataView
    End Sub

    Private Sub ex5Button_Click(sender As Object, e As EventArgs) Handles ex5Button.Click
        ' selects only the records whose State field begins with the letter C and 
        ' arranges them in descending order by the City field

        Dim records = From store In StoresDataSet.tblStores
                      Where store.State.ToUpper Like "C*"
                      Order By store.City Descending
                      Select store
        TblStoresBindingSource.DataSource = records.AsDataView
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StoresDataSet.tblStores' table. You can move, or remove it, as needed.
        Me.TblStoresTableAdapter.Fill(Me.StoresDataSet.tblStores)

    End Sub
End Class
