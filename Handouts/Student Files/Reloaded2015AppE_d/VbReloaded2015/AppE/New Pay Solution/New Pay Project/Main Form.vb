' Project name:         New Pay Project
' Project purpose:      Display the new weekly pay
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays the new weekly pay using a raise rate of 3%

        Const RaiseRate As Double = 0.3
        Dim newPay As Decimal
        Dim currentPay As Decimal

        Double.TryParse(currentTextBox.Text, currentPay)

        newPay = currentPay + RaiseRate * newPay
        newTextBox.Text = newPay.ToString("C2")
    End Sub

End Class
