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

        'If code = 1 OrElse code = 2 Then
        '    locationLabel.Text = "California"
        'Else
        '    If code = 3 OrElse code = 4 Then
        '        locationLabel.Text = "Wisconsin"
        '    Else
        '        If code = 5 Then
        '            locationLabel.Text = "Florida"
        '        Else
        '            locationLabel.Text = "Invalid code"
        '        End If
        '    End If
        'End If

        If code = 1 OrElse code = 2 Then
            locationLabel.Text = "California"
        ElseIf code = 3 OrElse code = 4 Then
            locationLabel.Text = "Wisconsin"
        ElseIf code = 5 Then
            locationLabel.Text = "Florida"
        Else
            locationLabel.Text = "Invalid code"
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
