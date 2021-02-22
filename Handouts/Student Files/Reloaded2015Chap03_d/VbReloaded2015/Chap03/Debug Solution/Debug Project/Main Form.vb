' Project name:         Debug Project
' Project purpose:      Calculates the average of three test scores.
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the average of three test scores

        Dim test1 As Decimal
        Dim test2 As Decimal
        Dim test3 As Decimal
        Dim average As Decimal

        ' convert input to numbers
        Decimal.TryParse(test1TextBox.Text, test1)
        Decimal.TryParse(test2TextBox.Text, test2)
        Decimal.TryParse(test3TextBox.Text, test3)

        ' calculate and display the average
        average = test1 + test2 + test3 / 3
        averageLabel.Text = average.ToString("N2")
    End Sub
End Class
