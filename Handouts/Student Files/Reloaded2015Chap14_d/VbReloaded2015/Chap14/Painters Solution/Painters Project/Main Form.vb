' Project name:         Painters Project
' Project purpose:      Display gross profit
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Function GetCostOfGoodsSold(
                ByVal cOfGS As CostOfGoodsSold) As Double

        Return cOfGS.BeginValue + cOfGS.PurchaseValue - cOfGS.EndValue
    End Function

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculate the gross profit

        Dim revenue As Double
        Dim ourCOfGS As New CostOfGoodsSold
        Dim costGoodsSold As Double
        Dim grossProfit As Double

        Double.TryParse(revenueTextBox.Text, revenue)
        Double.TryParse(beginTextBox.Text, ourCOfGS.BeginValue)
        Double.TryParse(purchasesTextBox.Text, ourCOfGS.PurchaseValue)
        Double.TryParse(endingTextBox.Text, ourCOfGS.EndValue)

        ' calculate cost of goods sold
        costGoodsSold = GetCostOfGoodsSold(ourCOfGS)

        ' calculate gross profit
        grossProfit = revenue - costGoodsSold

        costGoodsSoldLabel.Text = costGoodsSold.ToString("N2")
        grossProfitLabel.Text = grossProfit.ToString("C2")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub SelectText(sender As Object, e As EventArgs) Handles beginTextBox.Enter,
        endingTextBox.Enter, purchasesTextBox.Enter, revenueTextBox.Enter
        Dim currentTextBox As TextBox
        currentTextBox = TryCast(sender, TextBox)
        currentTextBox.SelectAll()
    End Sub

    Private Sub beginTextBox_TextChanged(sender As Object, e As EventArgs) Handles beginTextBox.TextChanged,
        endingTextBox.TextChanged, purchasesTextBox.TextChanged, revenueTextBox.TextChanged
        costGoodsSoldLabel.Text = String.Empty
        grossProfitLabel.Text = String.Empty
    End Sub
End Class
