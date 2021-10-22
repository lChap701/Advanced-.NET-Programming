' Project name:         Try It 2! Project
' Project purpose:      Examples of the PadLeft and PadRight methods
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub padLeft1Button_Click(sender As Object, e As EventArgs) Handles padLeft1Button.Click
        Dim num As String = "100"
        numLabel.Text = num.PadLeft(5)
    End Sub

    Private Sub padRight2Button_Click(sender As Object, e As EventArgs) Handles padRight2Button.Click
        Dim first As String = "Pat"
        first = first.PadRight(10)
        MessageBox.Show("The string is now '" & first & "'", "PadRight Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub padLeft3Button_Click(sender As Object, e As EventArgs) Handles padLeft3Button.Click
        Dim netPay As Double = 325.75
        Dim formattedPay As String
        formattedPay = netPay.ToString("C2").PadLeft(10, "*"c)
        MessageBox.Show("The formatted pay is " & formattedPay, "PadLeft Example 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
