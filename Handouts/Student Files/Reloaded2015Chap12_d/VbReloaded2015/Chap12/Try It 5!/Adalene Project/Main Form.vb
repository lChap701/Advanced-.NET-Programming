' Project name:         Adalene Project
' Project purpose:      Displays the records stored in a dataset
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub TblStoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblStoresBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TblStoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StoresDataSet)
            MessageBox.Show("Changes saved", "Adalene Fashions",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Adalene Fashions",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StoresDataSet.tblStores' table. You can move, or remove it, as needed.
        Me.TblStoresTableAdapter.Fill(Me.StoresDataSet.tblStores)

    End Sub

    Private Sub allMenuItem_Click(sender As Object, e As EventArgs) Handles allMenuItem.Click
        ' displays the total sales for all stores

        Dim total As Integer =
            Aggregate store In StoresDataSet.tblStores
                Select store.Sales Into Sum

        MessageBox.Show("Total sales for all stores: " &
                        total.ToString("C0"), "Adalene Fashions",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub companyMenuItem_Click(sender As Object, e As EventArgs) Handles companyMenuItem.Click
        ' displays the total sales for company-owned stores

        Dim total As Integer =
            Aggregate store In StoresDataSet.tblStores
                Where store.Ownership.ToUpper = "C"
                Select store.Sales Into Sum

        MessageBox.Show("Total sales for company-owned stores: " &
                        total.ToString("C0"), "Adalene Fashions",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub franchiseeMenuItem_Click(sender As Object, e As EventArgs) Handles franchiseeMenuItem.Click
        ' displays the total sales for franchisees

        Dim total As Integer =
            Aggregate store In StoresDataSet.tblStores
                Where store.Ownership.ToUpper = "F"
                Select store.Sales Into Sum

        MessageBox.Show("Total sales for franchisees: " &
                        total.ToString("C0"), "Adalene Fashions",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class
