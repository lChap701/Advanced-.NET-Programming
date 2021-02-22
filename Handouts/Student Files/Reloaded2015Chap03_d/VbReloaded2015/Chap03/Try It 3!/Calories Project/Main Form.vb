' Project name:         Calories Project
' Project purpose:      Displays the total calories entered by the user
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm

    ' class-level variable
    Private totalCalories As Decimal

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ' totals the calories entered by the user 

        Dim dailyCalories As Decimal

        ' calculate and display the total calories
        Decimal.TryParse(dailyTextBox.Text, dailyCalories)
        totalCalories = totalCalories + dailyCalories
        totalLabel.Text = Convert.ToString(totalCalories)
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
