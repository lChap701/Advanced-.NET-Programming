' Project name:         Tax Project
' Project purpose:      Displays a sales tax amount
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub salesTextBox_Enter(sender As Object, e As EventArgs) Handles salesTextBox.Enter
        salesTextBox.SelectAll()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles salesTextBox.TextChanged, ratesComboBox.TextChanged
        taxLabel.Text = String.Empty
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        For rate As Double = 0.02 To 0.1 Step 0.005
            ratesComboBox.Items.Add(rate.ToString("P1"))
        Next rate
        ratesComboBox.SelectedIndex = 6
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates a sales tax amount

        ' declare variables

        ' remove the space and percent sign from the rate

        ' assign input to variables

        ' calculate and display tax

        salesTextBox.Focus()
    End Sub
End Class

