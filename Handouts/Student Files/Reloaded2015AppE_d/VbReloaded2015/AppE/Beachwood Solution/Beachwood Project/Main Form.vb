' Project name:         Beachwood Project
' Project purpose:      Display the total pounds of coffee ordered and the total price of the order, including sales tax and shipping
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays the total pounds of coffee ordered and the total price of the order, including sales tax and shipping

        ' declare constants and variables
        Const PricePerPound As Decimal = 11.15
        Const TaxRate As Decimal = 0.02
        Const shipping As Decimal = 5.0

        Dim regular As Integer
        Dim decaf As Integer
        Dim totalPounds As Integer
        Dim subTotal As Decimal
        Dim salesTax As Decimal
        Dim totalPrice As Decimal

        ' assign input to variables
        Integer.TryParse(regularTextBox.Text, regular)
        Integer.TryParse(decafTextBox.Text, decaf

        ' perform calculations
        subTotal = totalPounds * PricePerPound
        salesTax = subTotal * TaxRate
        totalPrice = subTotal + salesTax

        ' display shipping and calculated results
        poundsLabel.Text = totalPounds
        totalPriceLabel.Text = totalPrice.ToString("C2")
    End Sub
End Class
