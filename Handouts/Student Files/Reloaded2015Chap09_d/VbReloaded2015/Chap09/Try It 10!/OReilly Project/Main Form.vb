' Project name:         OReilly Project
' Project purpose:      Display the total cost
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private priceChart(,) As Integer = {{11, 75},
                                        {6, 90},
                                        {1, 100}}

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' display the total cost

        Dim quantity As Integer
        Dim pricePerPainting As Integer
        Dim totalCost As Integer
        Dim row As Integer
        Dim highRow As Integer = priceChart.GetUpperBound(0)
        Dim found As Boolean

        Integer.TryParse(quantityTextBox.Text, quantity)

        ' search the first column in each row
        Do While row <= highRow AndAlso found = False
            If priceChart(row, 0) <= quantity Then
                pricePerPainting = priceChart(row, 1)
                found = True
            Else
                row += 1
            End If
        Loop

        totalCost = quantity * pricePerPainting
        totalLabel.Text = totalCost.ToString("C0")
        quantityTextBox.Focus()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub quantityTextBox_Enter(sender As Object, e As EventArgs) Handles quantityTextBox.Enter
        quantityTextBox.SelectAll()
    End Sub

    Private Sub quantityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantityTextBox.KeyPress
        ' allow numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub quantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles quantityTextBox.TextChanged
        totalLabel.Text = String.Empty
    End Sub
End Class
