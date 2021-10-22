' Project name:         Friends Project
' Project purpose:      Allows the user to add and delete names from a combo box; also reads names from and
'                       writes names to a sequential access file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
