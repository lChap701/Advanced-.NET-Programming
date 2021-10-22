' Project name:         DoLoop Project
' Project purpose:      Display the numbers 1, 2, and 3
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the numbers 1, 2, and 3

        Dim num As Integer = 1
        Do While num <= 3
            numsLabel.Text = numsLabel.Text & num.ToString & "  "
            num += 1
        Loop

        'Do
        '    numsLabel.Text = numsLabel.Text & num.ToString & "  "
        '    num += 1
        'Loop Until num > 3
    End Sub
End Class
