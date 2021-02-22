' Project name:         Tyler Project
' Project purpose:      Displays the number of new cars sold, the number of used cars sold, and the total number of cars sold
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private carsSold(,) As Integer = {{100, 50},
                                     {84, 35},
                                     {87, 22}}

    Private Sub newButton_Click(sender As Object, e As EventArgs) Handles newButton.Click
        ' calculates the number of new cars sold

        Dim highRow As Integer = carsSold.GetUpperBound(0)
        Dim totalNew As Integer

        For row As Integer = 0 To highRow
            totalNew += carsSold(row, 0)
        Next row
        newLabel.Text = totalNew.ToString
    End Sub

    Private Sub usedButton_Click(sender As Object, e As EventArgs) Handles usedButton.Click
        ' calculates the number of used cars sold

        Dim highRow As Integer = carsSold.GetUpperBound(0)
        Dim totalUsed As Integer

        For row As Integer = 0 To highRow
            totalUsed += carsSold(row, 1)
        Next row
        usedLabel.Text = totalUsed.ToString
    End Sub

    Private Sub totalButton_Click(sender As Object, e As EventArgs) Handles totalButton.Click
        ' calculates the total number of cars sold

        Dim highRow As Integer = carsSold.GetUpperBound(0)
        Dim totalCars As Integer

        For Each element As Integer In carsSold
            totalCars += element
        Next element
        totalLabel.Text = totalCars.ToString
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
