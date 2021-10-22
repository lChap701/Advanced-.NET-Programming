' Project name:         Debug Project
' Project purpose:      Displays a shipping charge based on a total price
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub totalTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles totalTextBox.KeyPress
        ' accept only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        'displays a shipping charge

        Dim totalPrice As Double
        Dim shipping As Integer

        Double.TryParse(totalTextBox.Text, totalPrice)

        Select Case totalPrice
            Case Is < 100
                shipping = 13
            Case 100 To 500
                shipping = 10
            Case 501 To 1000
                shipping = 7
            Case Else
                shipping = 5
        End Select

        shippingLabel.Text = shipping.ToString("C2")
    End Sub
End Class
