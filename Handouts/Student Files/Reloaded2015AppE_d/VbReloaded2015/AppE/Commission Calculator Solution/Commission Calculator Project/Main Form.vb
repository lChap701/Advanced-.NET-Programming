' Project name:         Commission Calculator Project
' Project purpose:      Display the quarterly commission
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays the quarterly commission

        ' declare named constant
        Const CommRate As Decimal = 0.1

        ' declare variables
        Dim sales1 As Decimal
        Dim sales2 As Decimal
        Dim sales3 As Decimal
        Dim commission As Decimal

        ' assign input to variables
        Decimal.TryParse(sales1TextBox, sales1)
        Decimal.TryParse(sales2TextBox, sales2)
        Decimal.TryParse(sales3TextBox, sales3)

        ' calculate and display commission
        commission = sales1 + sales2 + sales3 * CommRate
        commLabel.Text = commission.ToString("C2")
    End Sub

End Class
