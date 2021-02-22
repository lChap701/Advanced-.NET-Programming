' Project name:         Chang Project
' Project purpose:      Displays a grade based on the number of points the user enters
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub pointsTextBox_Enter(sender As Object, e As EventArgs) Handles pointsTextBox.Enter
        pointsTextBox.SelectAll()
    End Sub

    Private Sub pointsTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pointsTextBox.KeyPress
        ' accepts only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub pointsTextBox_TextChanged(sender As Object, e As EventArgs) Handles pointsTextBox.TextChanged
        gradeLabel.Text = String.Empty
    End Sub
End Class
