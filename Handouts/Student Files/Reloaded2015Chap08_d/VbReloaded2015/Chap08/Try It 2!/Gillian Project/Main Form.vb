' Project name:	        Gillian Project
' Project purpose:      Displays net income or net loss
' Created/revised by:	<your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub ClearNet()
        netLabel.Text = String.Empty
    End Sub

    Private Sub ChangeColor(ByVal incomeOrLoss As Integer)
        ' change the font color

        If incomeOrLoss < 0 Then
            netLabel.ForeColor = Color.Red
        Else
            netLabel.ForeColor = Color.Black
        End If
    End Sub

    Private Sub incomeTextBox_TextChanged(sender As Object, e As EventArgs) Handles incomeTextBox.TextChanged
        ClearNet()
    End Sub

    Private Sub expensesTextBox_TextChanged(sender As Object, e As EventArgs) Handles expensesTextBox.TextChanged
        ClearNet()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates net income or net loss

        Dim income As Integer
        Dim expenses As Integer
        Dim net As Integer

        Integer.TryParse(incomeTextBox.Text, income)
        Integer.TryParse(expensesTextBox.Text, expenses)

        net = income - expenses
        ChangeColor(net)
        netLabel.Text = net.ToString("C0")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub incomeTextBox_Enter(sender As Object, e As EventArgs) Handles incomeTextBox.Enter
        incomeTextBox.SelectAll()
    End Sub

    Private Sub expensesTextBox_Enter(sender As Object, e As EventArgs) Handles expensesTextBox.Enter
        expensesTextBox.SelectAll()
    End Sub

    Private Sub incomeTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles incomeTextBox.KeyPress
        ' allow only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub expensesTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles expensesTextBox.KeyPress
        ' allow only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
