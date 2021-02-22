' Project name:         Cheese Project
' Project purpose:      Displays total ordered and total price
' Created/revised by:	<your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' determine total ordered and total price

        Const Price As Integer = 25
        Const TaxRate As Double = 0.03
        Dim vanillaBean As Integer
        Dim strawberry As Integer
        Dim totalOrdered As Integer
        Dim subtotal As Integer
        Dim salesTax As Double
        Dim totalPrice As Double

        ' store numbers ordered in variables
        Integer.TryParse(vanillaTextBox.Text, vanillaBean)
        Integer.TryParse(strawberryTextBox.Text, strawberry)

        ' perform calculations
        totalOrdered = vanillaBean + strawberry
        subtotal = totalOrdered * Price
        salesTax = subtotal * TaxRate
        totalPrice = subtotal + salesTax

        ' display total ordered and total price
        totalOrderedLabel.Text = Convert.ToString(totalOrdered)
        totalPriceLabel.Text = totalPrice.ToString("C2")
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' prepare screen for next order

        nameTextBox.Text = String.Empty
        addressTextBox.Text = String.Empty
        cityTextBox.Text = String.Empty
        stateTextBox.Text = String.Empty
        zipTextBox.Text = String.Empty
        vanillaTextBox.Text = String.Empty
        strawberryTextBox.Text = String.Empty
        totalOrderedLabel.Text = String.Empty
        totalPriceLabel.Text = String.Empty
        nameTextBox.Focus()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click
        ' send printout to Print preview window
        PrintForm1.Print()
    End Sub
End Class
