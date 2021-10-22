' Project name:         Cookie Project
' Project purpose:      Display the total owed
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the total owed

        Const PricePerBasket As Double = 35.99
        Dim baskets As Integer
        Dim subtotal As Double
        Dim discountRate As Double
        Dim discount As Double
        Dim total As Double

        Integer.TryParse(basketsTextBox.Text, baskets)
        subtotal = baskets * PricePerBasket

        ' determine discount rate
        'If baskets >= 3 Then
        '    discountRate = 0.2
        'Else
        '    If memberCheckBox.Checked Then
        '        discountRate = 0.15
        '    Else
        '        discountRate = 0.05
        '    End If
        'End If

        If baskets < 3 Then
            If memberCheckBox.Checked Then
                discountRate = 0.15
            Else
                discountRate = 0.05
            End If
        Else
            discountRate = 0.2
        End If
        discount = subtotal * discountRate
        total = subtotal - discount
        totalLabel.Text = total.ToString("C2")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
