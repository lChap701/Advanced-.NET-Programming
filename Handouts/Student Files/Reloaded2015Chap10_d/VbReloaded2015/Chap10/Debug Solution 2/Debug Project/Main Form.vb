' Project name:         Debug Project
' Project purpose:      Displays the total due
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with prices

        For price As Decimal = 5 To 10 Step 0.5D
            pricesListBox.Items.Add(price.ToString("C2"))
        Next price
        pricesListBox.SelectedIndex = 0
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the total due

        Dim quantity As Integer
        Dim price As Decimal
        Dim due As Decimal

        Integer.TryParse(quantityTextBox.Text, quantity)
        Decimal.TryParse(pricesListBox.SelectedItem.ToString, price)

        due = quantity * price
        dueLabel.Text = due.ToString("C2")
    End Sub

    Private Sub quantityTextBox_Enter(sender As Object, e As EventArgs) Handles quantityTextBox.Enter
        quantityTextBox.SelectAll()
    End Sub

    Private Sub quantityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantityTextBox.KeyPress
        ' accepts only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles quantityTextBox.TextChanged, pricesListBox.SelectedIndexChanged
        dueLabel.Text = String.Empty
    End Sub
End Class
