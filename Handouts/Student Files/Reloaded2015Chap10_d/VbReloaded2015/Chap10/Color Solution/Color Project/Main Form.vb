' Project name:         Color Project
' Project purpose:      Displays an item's color 
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the color of the item whose number is entered by the user



        itemTextBox.Focus()
        itemTextBox.SelectAll()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub itemTexBox_TextChanged(sender As Object, e As EventArgs) Handles itemTextBox.TextChanged
        colorLabel.Text = String.Empty
    End Sub

    Private Sub itemTextBox_Enter(sender As Object, e As EventArgs) Handles itemTextBox.Enter
        itemTextBox.SelectAll()
    End Sub
End Class
