' Project name:         Trim Methods Project
' Project purpose:      Examples of the Trim, TrimStart, and TrimEnd methods
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub entryTextBox_TextChanged(sender As Object, e As EventArgs) Handles entryTextBox.TextChanged
        resultLabel.Text = String.Empty
    End Sub

    Private Sub trimButton_Click(sender As Object, e As EventArgs) Handles trimButton.Click
        ' code this procedure so that it removes any leading or trailing dollar signs, spaces, or percent signs


    End Sub

    Private Sub trimStartButton_Click(sender As Object, e As EventArgs) Handles trimStartButton.Click
        ' code this procedure so that it removes any leading dollar signs or spaces


    End Sub

    Private Sub trimEndButton_Click(sender As Object, e As EventArgs) Handles trimEndButton.Click
        ' code this procedure so that it removes any trailing percent signs or spaces


    End Sub
End Class
