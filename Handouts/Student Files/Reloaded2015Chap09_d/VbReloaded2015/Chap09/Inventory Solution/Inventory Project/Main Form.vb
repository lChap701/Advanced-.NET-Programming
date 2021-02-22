' Project name:         Inventory Project
' Project purpose:      Displays the sum of the values stored in a two-dimensional array
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private inventory(,) As Integer = {{500, 600}, {320, 415}, {570, 380}}

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the sum of the values stored in the inventory array


    End Sub
End Class
