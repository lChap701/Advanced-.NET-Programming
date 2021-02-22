' Project name:         Adalene Project
' Project purpose:      Use the LINQ aggregate operators
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub ex1Button_Click(sender As Object, e As EventArgs) Handles ex1Button.Click
        ' displays the total sales

        Dim total As Integer =
            Aggregate store In StoresDataSet.tblStores
                Select store.Sales Into Sum
        MessageBox.Show("Total sales: " & total.ToString("C0"),
                        "Adalene Fashions", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ex2Button_Click(sender As Object, e As EventArgs) Handles ex2Button.Click
        ' displays the highest amount sold by a company-owned store

        Dim highCompanyOwned As Integer
        highCompanyOwned =
            Aggregate store In StoresDataSet.tblStores
                Where store.Ownership.ToUpper = "C"
                    Select store.Sales Into Max
        MessageBox.Show("Highest sales for a company-owned store: " & highCompanyOwned.ToString("C0"),
                        "Adalene Fashions", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ex3Button_Click(sender As Object, e As EventArgs) Handles ex3Button.Click
        ' displays the average sales amount for stores in Georgia

        Dim avg As Double =
            Aggregate store In StoresDataSet.tblStores
                Where store.State.ToUpper = "GA"
                    Select store.Sales Into Average
        MessageBox.Show("Average sales made in Georgia: " & avg.ToString("C2"),
                        "Adalene Fashions", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ex4Button_Click(sender As Object, e As EventArgs) Handles ex4Button.Click
        ' displays the number of stores in the city of Chicago

        Dim counter As Integer =
            Aggregate store In StoresDataSet.tblStores
                Where store.City.ToUpper = "CHICAGO"
                    Into Count
        MessageBox.Show("Number of stores in Chicago: " & counter.ToString,
                        "Adalene Fashions", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StoresDataSet.tblStores' table. You can move, or remove it, as needed.
        Me.TblStoresTableAdapter.Fill(Me.StoresDataSet.tblStores)

    End Sub
End Class
