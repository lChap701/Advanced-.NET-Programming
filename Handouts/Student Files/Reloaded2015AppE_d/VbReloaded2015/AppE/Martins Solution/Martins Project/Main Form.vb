' Project name:         Martins Project
' Project purpose:      Display the gain or loss on a stock
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays the gain or loss on a stock

        Dim shares As Integer
        Dim openPrice As Decimal
        Dim closePrice As Decimal
        Dim gainLoss As Decimal

        ' assign input to variables
        Integer.TryParse(sharesTextBox.Text, shares)
        Decimal.TryParse(openTextBox.Text, closePrice)
        Decimal.TryParse(closeTextBox.Text, closePrice)

        ' calculate and display gain or loss
        gainLoss = closePrice - openPrice * shares
        gainLossLabel.Text = gainLoss.ToString("C2")

    End Sub
End Class
