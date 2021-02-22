' Project name:         Commission Project
' Project purpose:      Display the number of salespeople earning a specific commission
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private commission() As Integer = {300, 500, 1000, 150, 600, 750, 900, 150, 100, 200,
                                       250, 650, 300, 775, 900, 350, 250, 150, 100, 300}

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the number of salespeople earning a specific commission


    End Sub
End Class
