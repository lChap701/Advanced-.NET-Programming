' Project name:         Shipping Project
' Project purpose:      Displays a shipping charge based on the number of items ordered
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub orderedTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles orderedTextBox.KeyPress
        ' allows the text box to accept numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub orderedTextBox_TextChanged(sender As Object, e As EventArgs) Handles orderedTextBox.TextChanged
        shipLabel.Text = String.Empty
    End Sub
End Class
