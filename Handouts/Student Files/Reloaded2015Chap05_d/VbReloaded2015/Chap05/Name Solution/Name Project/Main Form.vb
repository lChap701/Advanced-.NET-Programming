' Project name:         Name Project
' Project purpose:      Demonstrates the SelectAll method and a text box's Enter event
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub concatenateButton_Click(sender As Object, e As EventArgs) Handles concatenateButton.Click
        ' concatenates the first and last names

        fullNameLabel.Text = firstTextBox.Text & " " & lastTextBox.Text
    End Sub
End Class
