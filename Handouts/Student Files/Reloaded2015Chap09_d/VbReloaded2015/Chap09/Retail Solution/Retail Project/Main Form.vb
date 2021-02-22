' Project name:         Retail Project
' Project purpose:      Increases each array value and displays the results
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private wholesale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}

    Private Sub retailButton_Click(sender As Object, e As EventArgs) Handles retailButton.Click
        ' updates each array value and displays the updated values in the retailListBox


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
