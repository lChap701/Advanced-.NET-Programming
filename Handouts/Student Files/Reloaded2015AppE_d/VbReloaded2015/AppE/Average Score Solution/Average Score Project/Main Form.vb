' Project name:         Average Score Project
' Project purpose:      Display the average score
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays the average of two test scores

        ' declare variables
        Dim score1 As Double
        Dim score2 As Double
        Dim average As Double

        ' assign input to variables
        Double.TryParse(score1TextBox.Text, score1)
        Double.TryParse(score2TextBox.Text, score2)

        ' calculate average score
        average = score1 + score2 / 2

        ' display average score
        avgLabel.Text = average
    End Sub

End Class
