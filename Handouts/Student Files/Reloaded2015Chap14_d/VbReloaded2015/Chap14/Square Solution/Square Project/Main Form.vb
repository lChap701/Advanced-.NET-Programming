' Project name:         Square Project
' Project purpose:      Display the area and perimeter of a square
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub sideTextBox_TextChanged(sender As Object, e As EventArgs) Handles sideTextBox.TextChanged
        areaLabel.Text = String.Empty
        perimeterLabel.Text = String.Empty
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays the area and perimeter of a square

        ' instantiate a Square object

        ' declare variables to store the area and perimeter

        ' assign input to the Square object's property

        ' use the Square object's methods to calculate the area and perimeter

        ' display the area and perimeter with two decimal places

        sideTextBox.Focus()
    End Sub
End Class
