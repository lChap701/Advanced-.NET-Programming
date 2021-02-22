' Project name:         Sales Project
' Project purpose:      Display the projected sales
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' display the projected sales

        Const GrowthRate As Double = 0.03
        Dim sales As Double
        Dim increase As Double
        Dim years As Integer

        Double.TryParse(currentTextBox.Text, sales)
        Do While sales > 0 AndAlso sales < 125000
            increase = sales * GrowthRate
            sales += increase
            years += 1
        Loop
        projectedLabel.Text = "Projected sales " &
            years.ToString & " years from now: " &
            sales.ToString("C0")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub currentTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles currentTextBox.KeyPress
        ' accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9'") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
