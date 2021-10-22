' Project name:         Monthly Payment Project
' Project purpose:      Displays the monthly payments on a loan
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the termListBox

        For term As Integer = 2 To 5
            termListBox.Items.Add(term.ToString)
        Next term
        termListBox.SelectedItem = "4"
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the monthly payments on a loan using
        ' interest rates of 3% to 6% in increments of 0.5%

        Dim loan As Double
        Dim term As Integer
        Dim monthlyPayment As Double

        ' assign input to variables
        Double.TryParse(loanTextBox.Text, loan)
        term = Convert.ToInt32(termListBox.SelectedItem)

        paymentsListBox.Items.Clear()
        ' calculate and display monthly payments
        For rate As Double = 0.03 To 0.06 Step 0.005
            monthlyPayment =
                -Financial.Pmt(rate / 12, term * 12, loan)
            paymentsListBox.Items.Add(rate.ToString("P1") &
                                      ":  " & monthlyPayment.ToString("C2"))
        Next rate
        loanTextBox.Focus()
    End Sub

    Private Sub loanTextBox_Enter(sender As Object, e As EventArgs) Handles loanTextBox.Enter
        ' select existing text when text box receives the focus

        loanTextBox.SelectAll()
    End Sub

    Private Sub loanTextBox_TextChanged(sender As Object, e As EventArgs) Handles loanTextBox.TextChanged
        ' clears the list box

        paymentsListBox.Items.Clear()
    End Sub

    Private Sub termListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles termListBox.SelectedIndexChanged
        ' clears the list box

        paymentsListBox.Items.Clear()
    End Sub

    'Private Sub termListBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles termListBox.SelectedValueChanged
    '    ' clears the list box

    '    paymentsListBox.Items.Clear()
    'End Sub

    Private Sub loanTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles loanTextBox.KeyPress
        ' accept only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
