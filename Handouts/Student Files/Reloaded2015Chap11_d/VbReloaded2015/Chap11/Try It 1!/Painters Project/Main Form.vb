' Project name:         Painters Project
' Project purpose:      Display gross profit
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Function GetCostOfGoodsSold(ByVal beginVal As Double,
                                        ByVal purchVal As Double,
                                        ByVal endVal As Double) As Double

        Return beginVal + purchVal - endVal
    End Function

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

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculate the gross profit

        Dim revenue As Double
        Dim costBegin As Double
        Dim costPurch As Double
        Dim costEnd As Double
        Dim costGoodsSold As Double
        Dim grossProfit As Double

        Double.TryParse(revenueTextBox.Text, revenue)
        Double.TryParse(beginTextBox.Text, costBegin)
        Double.TryParse(purchasesTextBox.Text, costPurch)
        Double.TryParse(endingTextBox.Text, costEnd)

        ' calculate cost of goods sold
        costGoodsSold = GetCostOfGoodsSold(costBegin, costPurch, costEnd)

        ' calculate gross profit
        grossProfit = revenue - costGoodsSold

        costGoodsSoldLabel.Text = costGoodsSold.ToString("N2")
        grossProfitLabel.Text = grossProfit.ToString("C2")
    End Sub
End Class
