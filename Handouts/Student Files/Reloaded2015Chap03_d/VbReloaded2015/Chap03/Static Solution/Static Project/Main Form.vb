' Project name:         Static Project
' Project purpose:      Keeps track of the number of times a button is clicked
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    ' class-level variable
    Private numClicks As Integer

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub countButton_Click(sender As Object, e As EventArgs) Handles countButton.Click
        ' displays the number of times the button was clicked

        ' add 1 to the numClicks variable each time the button is clicked
        numClicks += 1
        messageLabel.Text = "You have clicked the Count button " & numClicks.ToString & " time(s)."
    End Sub
End Class
