' Project name:         Quotient Project
' Project purpose:      Divide two numbers and display the quotient
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' display the result of dividing two numbers

        Dim numerator As Decimal
        Dim denominator As Decimal
        Dim quotient As Decimal

        Decimal.TryParse(numeratorTextBox.Text, numerator)
        Decimal.TryParse(denominatorTextBox.Text, denominator)

        quotient = numerator / denominator
        quotientLabel.Text = quotient.ToString("N2")
    End Sub
End Class
