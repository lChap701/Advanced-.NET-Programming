' Project name:         Debug Project
' Project purpose:      Displays a bonus amount
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays a bonus amount

        Dim code As String
        Dim sales As Double
        Dim bonus As Double

        Double.TryParse(salesTextBox.Text, sales)
        code = codeTextBox.Text

        ' calculate the bonus as follows:
        ' code 1 and code 2 salespeople receive a 10% bonus
        ' if their sales are over 10,000; otherwise, they
        ' and all other salespeople receive a 5% bonus
        If code = "1" OrElse code = "2" AndAlso sales > 10000 Then
            bonus = sales * 0.1
        Else
            bonus = sales * 0.05
        End If

        bonusLabel.Text = bonus.ToString("C2")
        codeTextBox.Focus()
    End Sub
End Class
