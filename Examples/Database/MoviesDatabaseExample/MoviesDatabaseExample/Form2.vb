Public Class Form2
    Private Sub TblRatingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.TblRatingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GamesRevisedDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GamesRevisedDataSet.tblRating' table. You can move, or remove it, as needed.
        Me.TblRatingTableAdapter.Fill(Me.GamesRevisedDataSet.tblRating)

    End Sub
End Class