' Project name:         Birthday Project
' Project purpose:      Displays the total charge
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub guestsTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles guestsTextBox.KeyPress
        ' allows only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

End Class
