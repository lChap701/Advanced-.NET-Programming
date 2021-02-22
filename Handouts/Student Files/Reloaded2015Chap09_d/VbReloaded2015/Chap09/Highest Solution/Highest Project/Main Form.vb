' Project name:         Highest Project
' Project purpose:      Displays the highest score earned on the midterm exam and the highest score 
'                       earned on the final exam
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    ' midterm scores are in the first column
    ' final scores are in the second column
    Private scores(,) As Integer = {{89, 98}, {78, 45}, {67, 89},
                                    {90, 99}, {91, 70}, {75, 76}}

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
