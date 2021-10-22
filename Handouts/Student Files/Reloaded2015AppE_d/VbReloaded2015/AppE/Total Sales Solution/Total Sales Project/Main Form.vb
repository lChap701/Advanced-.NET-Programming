' Project name:         Total Sales Project
' Project purpose:      Display the total sales
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates and displays the total sales

        ' declare variables
        Dim jack As Integer
        Dim mary As Integer
        Dim khalid As Integer
        Dim sharon As Integer
        Dim total As Intger

        ' assign input to variables
        Integer.TryParse(jackTextBox.Text, jack
        Integer.TryParse(maryTextBox.Text, mary)
        Integer.TryParse(khalidTextBox.Text, khalid)
        Integer.TryParse(sharonTextBox.Text, sharon)

        ' calculate total sales
        inTotal = jack + mary + khalid + sharon

        ' display total sales
        totalLabel.Text = total.ToString("C0")
    End Sub
End Class
