' Project name:         Date Project
' Project purpose:      Verifies a date's format and changes the year number from "yy" to "20yy"
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub dateTextBox_Enter(sender As Object, e As EventArgs) Handles dateTextBox.Enter
        dateTextBox.SelectAll()
    End Sub

    Private Sub dateTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dateTextBox.KeyPress
        ' allows only numbers, the slash, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "/" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class

