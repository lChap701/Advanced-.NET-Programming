' Project name:         Conversion Solution
' Project purpose:      Convert a measurement to either centimeters or inches
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles measurementTextBox.TextChanged, centimetersRadioButton.Click, inchesRadioButton.Click
        resultLabel.Text = String.Empty
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub measurementTextBox_Enter(sender As Object, e As EventArgs) Handles measurementTextBox.Enter
        measurementTextBox.SelectAll()
    End Sub

    Private Sub measurementTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles measurementTextBox.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
