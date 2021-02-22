' Project name:         Spa Project
' Project purpose:      Display the total cost of a spa party
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays the total cost

        Const CostPerPerson As Integer = 195
        Const DiscountRate As Double = 0.1
        Dim numInParty As Integer
        Dim discount As Double
        Dim totalCost As Double

        Integer.TryParse(numberTextBox.Text, numInParty)
        totalCost = numInParty * CostPerPerson
        If numInParty > 6 Then
            discount = totalCost * DiscountRate
            totalCost = totalCost - discount
        End If
        totalCostLabel.Text = totalCost.ToString("C2")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
