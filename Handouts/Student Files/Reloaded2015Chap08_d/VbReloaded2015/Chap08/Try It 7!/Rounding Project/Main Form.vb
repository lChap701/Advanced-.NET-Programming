' Project name:	        Rounding Project
' Project purpose:      Displays rounded numbers
' Created/revised by:	<your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub roundButton_Click(sender As Object, e As EventArgs) Handles roundButton.Click
        ' round a number

        Dim num As Double
        Dim decimalPlaces As Integer
        Dim roundedNum As Double

        Double.TryParse(numTextBox.Text, num)
        Integer.TryParse(decimalComboBox.SelectedItem.ToString, decimalPlaces)
        roundedNum = Math.Round(num, decimalPlaces)
        roundedLabel.Text = roundedNum.ToString
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub numTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numTextBox.KeyPress
        ' allow only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub numTextBox_Enter(sender As Object, e As EventArgs) Handles numTextBox.Enter
        numTextBox.SelectAll()
    End Sub

    Private Sub decimalComboBox_Enter(sender As Object, e As EventArgs) Handles decimalComboBox.Enter
        decimalComboBox.SelectAll()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles numTextBox.TextChanged, decimalComboBox.TextChanged
        roundedLabel.Text = String.Empty
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill combo box

        For decimalPlaces As Integer = 1 To 10
            decimalComboBox.Items.Add(decimalPlaces.ToString)
        Next decimalPlaces
    End Sub
End Class
