' Project name:         Debug Project
' Project purpose:      Calculates the bonus and then saves the name and 
'                       bonus amount to a sequential access file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub nameTextBox_Enter(sender As Object, e As EventArgs) Handles nameTextBox.Enter
        nameTextBox.SelectAll()
    End Sub

    Private Sub nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles nameTextBox.TextChanged
        bonusLabel.Text = String.Empty
    End Sub

    Private Sub salesTextBox_Enter(sender As Object, e As EventArgs) Handles salesTextBox.Enter
        salesTextBox.SelectAll()
    End Sub

    Private Sub salesTextBox_TextChanged(sender As Object, e As EventArgs) Handles salesTextBox.TextChanged
        bonusLabel.Text = String.Empty
    End Sub

    Private Sub calcAndSaveButton_Click(sender As Object, e As EventArgs) Handles calcAndSaveButton.Click
        ' writes the name and a 5% bonus amount to a sequential access file

        Dim outFile As IO.StreamWriter
        Dim sales As Double
        Dim bonus As Double

        Double.TryParse(salesTextBox.Text, sales)
        bonus = sales * 0.005
        bonusLabel.Text = bonus.ToString("N2")

        outFile = IO.File.AppendText("bonus.txt")
        outFile.WriteLine(nameTextBox.Text)
        outFile.WriteLine(bonusLabel.Text)

        nameTextBox.Focus()
    End Sub
End Class
