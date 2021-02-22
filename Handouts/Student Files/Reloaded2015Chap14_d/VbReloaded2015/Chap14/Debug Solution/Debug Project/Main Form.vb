' Project name:         Degug Project
' Project purpose:      Display the new price of a computer
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the new price for a computer

        Dim computerPurchased As Computer
        Dim rate As Decimal
        Dim newPrice As Decimal

        Computer.Id = modelTextBox.Text
        Decimal.TryParse(originalTextBox.Text, Computer.CurrentPrice)
        Decimal.TryParse(discRateTextBox.Text, rate)

        newPrice = Computer.GetNewPrice(rate)
        newPriceTextBox.Text = newPrice.ToString("C2")
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles discRateTextBox.KeyPress, originalTextBox.KeyPress
        ' accept numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles modelTextBox.TextChanged, originalTextBox.TextChanged, discRateTextBox.TextChanged
        newPriceTextBox.Text = String.Empty
    End Sub
End Class
