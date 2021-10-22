' Project name:         Framington Project
' Project purpose:      Display the number of tables needed to seat guests at a party
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' calculates the number of tables needed to seat guests at a party; each table can seat up to 10 guests
        ' example: 67 guests need 7 tables
        Dim guests As Integer
        Dim tables As Double

        ' assign input to a variable
        Integer.TryParse(guestsTextBox.Text, guests)

        ' calculate and display number of tables
        tables = guests / 10 + 0.5
        tablesLabel.Text = tables.ToString("N0")

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
