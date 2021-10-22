' Project name:         Circle  Project
' Project purpose:      Displays the area or diameter of a circle
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub radiusTextBox_Enter(sender As Object, e As EventArgs) Handles radiusTextBox.Enter
        radiusTextBox.SelectAll()
    End Sub

    Private Sub radiusTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles radiusTextBox.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearAnswer(sender As Object, e As EventArgs) Handles radiusTextBox.TextChanged, areaRadioButton.CheckedChanged, diameterRadioButton.CheckedChanged
        answerLabel.Text = String.Empty
    End Sub
End Class
