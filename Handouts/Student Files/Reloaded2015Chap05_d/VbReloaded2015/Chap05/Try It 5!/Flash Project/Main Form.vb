' Project name:         Flash Project
' Project purpose:      Display the price for 100 flash drives
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the price for 100 flash drives

        Dim price As Integer

        ' determine capacity
        'If gb4RadioButton.Checked Then
        '    price = 459
        'ElseIf gb8RadioButton.Checked Then
        '    price = 499
        'Else
        '    price = 725
        'End If
        Select Case True
            Case gb4RadioButton.Checked
                price = 459
            Case gb8RadioButton.Checked
                price = 499
            Case Else
                price = 725
        End Select

        ' if necessary, add additional printing charge
        If twoRadioButton.Checked Then
            price += 50
        End If

        priceLabel.Text = price.ToString("C0")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
