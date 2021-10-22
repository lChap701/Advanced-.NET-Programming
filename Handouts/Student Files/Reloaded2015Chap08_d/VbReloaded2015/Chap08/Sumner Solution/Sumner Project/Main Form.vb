' Project name:         Sumner Project
' Project purpose:      Displays a monthly electric bill
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm


    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles currentTextBox.KeyPress, previousTextBox.KeyPress
        ' allow only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
