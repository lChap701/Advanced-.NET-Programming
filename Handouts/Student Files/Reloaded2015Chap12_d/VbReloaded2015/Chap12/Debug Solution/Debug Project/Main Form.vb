' Project name:         Debug Project
' Project purpose:      Display the contents of a dataset
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub fillButton_Click(sender As Object, e As EventArgs) Handles fillButton.Click
        ' fill the dataset with data

        Me.TblFriendsTableAdapter.Fill(Me.FriendsDataSet)
    End Sub

    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click
        ' move to the previous record

        TblFriendsBindingSource.MovePrevious()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        ' move to the next record

        TblFriendsBindingSource.MoveLast()
    End Sub
End Class
