' Project name:         Sales Project
' Project purpose:      Display the projected sales
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' display the projected sales

        Dim beginSales As Double
        Dim sales As Double
        Dim increase As Double

        Double.TryParse(currentTextBox.Text, beginSales)
        projectedListBox.Items.Clear()
        projectedListBox.Items.Add("Rate   Year     Sales")

        For growthRate As Double = 0.03 To 0.05 Step 0.01
            sales = beginSales
            projectedListBox.Items.Add(growthRate.ToString("P0"))
            For year As Integer = 2017 To 2020
                increase = sales * growthRate
                sales += increase
                projectedListBox.Items.Add("          " & year.ToString &
                                           "     " & sales.ToString("C0"))
            Next year
        Next growthRate
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
