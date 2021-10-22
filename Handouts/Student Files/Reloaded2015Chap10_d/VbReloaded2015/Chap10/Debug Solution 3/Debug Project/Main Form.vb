' Project name:         Debug Project
' Project purpose:      Inserts a space after each letter 
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub lettersTextBox_Enter(sender As Object, e As EventArgs) Handles lettersTextBox.Enter
        lettersTextBox.SelectAll()
    End Sub

    Private Sub lettersTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lettersTextBox.KeyPress
        ' accepts only letters and the Backspace key

        If (e.KeyChar.ToString.ToUpper < "A" OrElse e.KeyChar.ToString.ToUpper > "Z") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub lettersTextBox_TextChanged(sender As Object, e As EventArgs) Handles lettersTextBox.TextChanged
        lettersWithSpacesLabel.Text = String.Empty
    End Sub

    Private Sub insertButton_Click(sender As Object, e As EventArgs) Handles insertButton.Click
        ' inserts a space after each letter

        Dim letters As String

        letters = lettersTextBox.Text

        If letters.Length = 5 Then
            lettersWithSpacesLabel.Text = letters.Substring(0, 1)
            For index As Integer = 0 To letters.Length - 1
                lettersWithSpacesLabel.Text = lettersWithSpacesLabel.Text & " " & letters.Substring(index, 0)
            Next index
        Else
            MessageBox.Show("Please enter 5 letters", "Debugging Exercise", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        lettersTextBox.Focus()
    End Sub
End Class
