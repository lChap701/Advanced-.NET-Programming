' Project name:        Memo Project
' Project purpose:     Writes the contents of a text box to a sequential access file
' Created/revised by   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub memoTextBox_Enter(sender As Object, e As EventArgs) Handles memoTextBox.Enter
        memoTextBox.SelectAll()
    End Sub

End Class
