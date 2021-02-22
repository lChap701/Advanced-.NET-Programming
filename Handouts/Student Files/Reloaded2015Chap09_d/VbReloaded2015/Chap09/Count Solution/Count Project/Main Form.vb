' Project name:         Count Project
' Project purpose:      Displays the number of times the numbers 1 through 9 appear in a two-dimensional array
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the number of times a value appears in a two-dimensional array

        Dim numbers(,) As Integer = {{1, 2}, {6, 5}, {7, 9}, {3, 1}, {2, 7},
                                     {5, 9}, {8, 8}, {9, 9}, {6, 3}, {2, 3}, {5, 4}}

    End Sub
End Class
