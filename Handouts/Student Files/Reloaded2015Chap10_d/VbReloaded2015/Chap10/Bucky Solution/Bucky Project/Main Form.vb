' Project name:         Bucky Project
' Project purpose:      Add names in proper case to a list
'                       box and print the interface
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub nameTextBox_Enter(sender As Object, e As EventArgs) Handles nameTextBox.Enter
        nameTextBox.SelectAll()
    End Sub
End Class
