' Project name:         Circle Area Project
' Project purpose:      Display the area of a circle
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

    Private Sub radiusTextBox_TextChanged(sender As Object, e As EventArgs) Handles radiusTextBox.TextChanged
        areaLabel.Text = String.Empty
    End Sub

End Class
