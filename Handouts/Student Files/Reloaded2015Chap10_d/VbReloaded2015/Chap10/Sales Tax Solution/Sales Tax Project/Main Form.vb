' Project name:         Sales Tax Project
' Project purpose:      Displays a sales tax amount
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub salesTextBox_Enter(sender As Object, e As EventArgs) Handles salesTextBox.Enter
        salesTextBox.SelectAll()
    End Sub

    Private Sub rateTextBox_Enter(sender As Object, e As EventArgs) Handles rateTextBox.Enter
        rateTextBox.SelectAll()
    End Sub

    Private Sub salesTextBox_TextChanged(sender As Object, e As EventArgs) Handles salesTextBox.TextChanged
        taxLabel.Text = String.Empty
    End Sub

    Private Sub rateTextBox_TextChanged(sender As Object, e As EventArgs) Handles rateTextBox.TextChanged
        taxLabel.Text = String.Empty
    End Sub

    Private Sub rateTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rateTextBox.KeyPress
        ' allow only numbers and the period

         If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
