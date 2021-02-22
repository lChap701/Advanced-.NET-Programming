' Project name:         Zip Project
' Project purpose:      Displays a shipping charge
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub zipTextBox_Enter(sender As Object, e As EventArgs) Handles zipTextBox.Enter
        zipTextBox.SelectAll()
    End Sub

    Private Sub zipTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles zipTextBox.KeyPress
        ' allows only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub zipTextBox_TextChanged(sender As Object, e As EventArgs) Handles zipTextBox.TextChanged
        shippingLabel.Text = String.Empty
    End Sub

End Class
