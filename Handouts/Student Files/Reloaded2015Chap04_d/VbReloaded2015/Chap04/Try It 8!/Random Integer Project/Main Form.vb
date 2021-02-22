' Project name:         Random Integer Project
' Project purpose:      Displays a random integer from 1 through 10
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub generateButton_Click(sender As Object, e As EventArgs) Handles generateButton.Click
        ' displays a random integer from 1 through 10

        Dim number As Integer
        Dim randGen As New Random

        number = randGen.Next(1, 11)
        randomLabel.Text = number.ToString
    End Sub
End Class
