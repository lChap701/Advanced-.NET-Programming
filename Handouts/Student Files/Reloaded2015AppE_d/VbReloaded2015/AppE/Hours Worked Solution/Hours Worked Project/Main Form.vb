' Project name:         Hours Worked Project
' Project purpose:      Display the total hours worked
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays the total number
        ' of hours worked during 4 weeks

        ' declare variables
        Dim week1 As Double
        Dim week2 As Double
        Dim week3 As Double
        Dim week4 As Double
        Dim total As Double

        ' assign input to variables
        Double.TryParse(week1TextBox.Text, week1)
        Double.TryParse(week2TextBox.Text, week2)
        Double.TryParse(week3TextBox.Text, week2)
        Double.TryParse(week4TextBox.Text, week4)

        ' calculate total hours worked
        total = week1 + week2 + week3 + week4

        ' display total hours worked
        totalLabel.Text = total.ToString("N1")
    End Sub
End Class
