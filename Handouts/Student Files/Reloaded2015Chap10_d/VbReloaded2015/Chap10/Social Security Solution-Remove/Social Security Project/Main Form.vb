' Project name:         Social Security Project
' Project purpose:      Removes the dashes from a social security number
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub numberTextBox_Enter(sender As Object, e As System.EventArgs) Handles numberTextBox.Enter
        numberTextBox.SelectAll()
    End Sub

    Private Sub numberTextBox_TextChanged(sender As Object, e As System.EventArgs) Handles numberTextBox.TextChanged
        numberLabel.Text = String.Empty
    End Sub

End Class

