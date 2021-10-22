' Project name:         Full Name Project
' Project purpose:      Displays the full name
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub SelectText(sender As Object, e As EventArgs
                           ) Handles firstTextBox.Enter,
                           initialTextBox.Enter, lastTextBox.Enter
        ' selects the existing text

        Dim thisTextBox As TextBox
        thisTextBox = TryCast(sender, TextBox)
        thisTextBox.SelectAll()
    End Sub

    Private Sub concatenateButton_Click(sender As Object, e As EventArgs) Handles concatenateButton.Click
        ' concatenate first name, middle initial, and last name

        fullLabel.Text = firstTextBox.Text & " " & initialTextBox.Text & " " & lastTextBox.Text
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearFullName(sender As Object, e As EventArgs) Handles firstTextBox.TextChanged, initialTextBox.TextChanged, lastTextBox.TextChanged
        fullLabel.Text = String.Empty
    End Sub
End Class
