' Project name:         Passing Project
' Project purpose:      Demonstrates passing variables by value and by reference
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub GetName(ByVal nameEntry As String)
        nameEntry = InputBox("Enter your name", "Name")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        Dim myName As String = String.Empty

        GetName(myName)
        nameLabel.Text = myName
    End Sub
End Class
