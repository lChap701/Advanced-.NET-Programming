' Project name:         Discount Project
' Project purpose:      Display three discount amounts
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays a 10%, 20%, and
        ' 30% discount on an item's price

        ' declare variables
        Dim price As Decimal
        Dim discount10 As Decimal
        Dim discount20 As Decimal
        Dim discount30 As Decimal

        ' calculate discounts
        discount10 = price * 0.1D
        discount20 = price * 0.2D
        discount30 = price * 0.3D

        ' display discounts
        disc10Label.Text = discount10.ToString("N2")
        disc20Label.Text = discount20.ToString("N2")
        disc30Label.Text = discount30.ToString("N2")
    End Sub
End Class
