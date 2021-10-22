' Project name:         Sales Bonus Project
' Project purpose:      Displays a bonus amount
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

    Private Sub salesTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles salesTextBox.KeyPress
        ' allows numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub salesTextBox_TextChanged(sender As Object, e As EventArgs) Handles salesTextBox.TextChanged
        bonusLabel.Text = String.Empty
    End Sub

End Class
