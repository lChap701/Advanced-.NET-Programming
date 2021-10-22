' Project name:         Pizzeria Project
' Project purpose:      Display the number of square pizza slices that can be cut from a square pizza
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' displays the number of square pizza slices

        Dim entirePizza As New Rectangle
        Dim pizzaSlice As New Rectangle
        Dim entireArea As Double
        Dim sliceArea As Double
        Dim numSlices As Double

        Double.TryParse(entireTextBox.Text, entirePizza.Length)
        Double.TryParse(entireTextBox.Text, entirePizza.Width)
        Double.TryParse(sliceTextBox.Text, pizzaSlice.Length)
        Double.TryParse(sliceTextBox.Text, pizzaSlice.Width)

        ' calculate areas
        entireArea = entirePizza.GetArea
        sliceArea = pizzaSlice.GetArea
        ' calculate number of slices
        If sliceArea > 0 Then
            numSlices = entireArea / sliceArea
        Else
            numSlices = 0
        End If
        ' display number of slices
        numSlicesLabel.Text = numSlices.ToString("N1")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub entireTextBox_Enter(sender As Object, e As EventArgs) Handles entireTextBox.Enter
        entireTextBox.SelectAll()
    End Sub

    Private Sub sliceTextBox_Enter(sender As Object, e As EventArgs) Handles sliceTextBox.Enter
        sliceTextBox.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles entireTextBox.KeyPress, sliceTextBox.KeyPress
        ' allows only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles entireTextBox.TextChanged, sliceTextBox.TextChanged
        numSlicesLabel.Text = String.Empty
    End Sub
End Class
