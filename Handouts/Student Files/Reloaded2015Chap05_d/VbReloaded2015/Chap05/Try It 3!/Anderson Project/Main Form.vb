' Project name:         Anderson Project
' Project purpose:      Display a warehouse's location 
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' display the location of a warehouse

        Dim code As Integer
        Integer.TryParse(codeTextBox.Text, code)

        Select Case code
            Case 1, 2
                locationLabel.Text = "California"
            Case 3, 4
                locationLabel.Text = "Wisconsin"
            Case 5
                locationLabel.Text = "Florida"
            Case Else
                locationLabel.Text = "Invalid code"
        End Select
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
