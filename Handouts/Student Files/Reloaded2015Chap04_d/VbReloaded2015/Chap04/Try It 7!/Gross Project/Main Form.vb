' Project name:         Gross Project
' Project purpose:      Displays the gross pay
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the gross pay

        Const RatePerHour As Double = 10.65
        Dim hours As Double
        Dim gross As Double

        Double.TryParse(hoursTextBox.Text, hours)
        ' Version 1 - using the AndAlso operator
        If hours >= 0 AndAlso hours <= 40 Then
            gross = hours * RatePerHour
            grossLabel.Text = gross.ToString("C2")
        Else
            grossLabel.Text = "Incorrect number of hours"
        End If

        ' Version 2 - using the OrElse operator
        'If hours < 0 OrElse hours > 40 Then
        '    grossLabel.Text = "Incorrect number of hours"
        'Else
        '    gross = hours * RatePerHour
        '    grossLabel.Text = gross.ToString("C2")
        'End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
