' Project name:         OddEven Project
' Project purpose:      Displays the sum of the odd and even numbers between two integers
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub integer1TextBox_Enter(sender As Object, e As EventArgs) Handles integer1TextBox.Enter
        integer1TextBox.SelectAll()
    End Sub

    Private Sub integer2TextBox_Enter(sender As Object, e As EventArgs) Handles integer2TextBox.Enter
        integer2TextBox.SelectAll()
    End Sub

    Private Sub integer1TextBox_TextChanged(sender As Object, e As EventArgs) Handles integer1TextBox.TextChanged
        oddLabel.Text = String.Empty
        evenLabel.Text = String.Empty
    End Sub

    Private Sub integer2TextBox_TextChanged(sender As Object, e As EventArgs) Handles integer2TextBox.TextChanged
        oddLabel.Text = String.Empty
        evenLabel.Text = String.Empty
    End Sub
End Class
