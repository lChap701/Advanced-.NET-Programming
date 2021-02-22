' Project name:         Trivia Project
' Project purpose:      Displays trivia questions and
'                       answers and the number of incorrect
'                       answers made by the user
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
