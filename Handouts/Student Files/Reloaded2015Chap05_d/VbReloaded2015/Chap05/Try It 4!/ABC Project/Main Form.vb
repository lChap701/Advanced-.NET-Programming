' Project name:         ABC Project
' Project purpose:      Display the price per item
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the price per item

        Dim quantity As Integer
        Dim price As Integer

        Integer.TryParse(quantityTextBox.Text, quantity)

        ' determine the price per item 
        Select Case quantity
            Case 1 To 5
                price = 25
            Case 6 To 10
                price = 23
            Case Is > 10
                price = 20
            Case Else
                price = 0
        End Select
        priceLabel.Text = price.ToString("C2")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
