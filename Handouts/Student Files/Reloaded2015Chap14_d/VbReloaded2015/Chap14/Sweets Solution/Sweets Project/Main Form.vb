' Project name:         Sweets Project
' Project purpose:      Writes the salesperson's ID and sales amount to a sequential access file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        ' writes the ID and sales amount to a file

        Const title As String = "Sweets Unlimited"
        Dim outFile As IO.StreamWriter

        ' instantiate a Salesperson object


        If idTextBox.Text <> String.Empty AndAlso salesTextBox.Text <> String.Empty Then
            ' if both text boxes contain data, assign the 
            ' ID and sales amount to the Salesperson object


            ' save the information
            outFile = IO.File.AppendText("sales.txt")

            outFile.Close()
            MessageBox.Show("Sales information saved.", title,
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please enter a name and a sales amount.",
                            title, MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If

        idTextBox.Text = String.Empty
        salesTextBox.Text = String.Empty
        idTextBox.Focus()
    End Sub

    Private Sub salesTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles salesTextBox.KeyPress
        ' accept only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
