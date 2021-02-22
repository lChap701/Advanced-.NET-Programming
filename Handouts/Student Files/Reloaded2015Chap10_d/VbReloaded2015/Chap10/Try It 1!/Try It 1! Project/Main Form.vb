' Project name:         Try It 1! Project
' Project purpose:      Examples of the Length property, and the Trim, Remove, and Insert methods
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub length1Button_Click(sender As Object, e As EventArgs) Handles length1Button.Click
        Dim state As String = "Oklahoma"
        Dim numChars As Integer = state.Length
        MessageBox.Show("Number of characters in Oklahoma: " & numChars.ToString, "Length Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub length2Button_Click(sender As Object, e As EventArgs) Handles length2Button.Click
        Dim numChars As Integer
        numChars = cityTextBox.Text.Length
        MessageBox.Show("Number of characters in cityTextBox: " & numChars.ToString, "Length Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub length3Button_Click(sender As Object, e As EventArgs) Handles length3Button.Click
        Dim zip As String
        Do
            zip = InputBox("5-digit ZIP code", "ZIP")
        Loop Until zip.Length = 5
        MessageBox.Show(zip, "Length Example 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub trim1Button_Click(sender As Object, e As EventArgs) Handles trim1Button.Click
        Dim state As String
        state = stateTextBox.Text.Trim
        stateTextBox.Text = state
    End Sub

    Private Sub remove2Button_Click(sender As Object, e As EventArgs) Handles remove2Button.Click
        Dim cityState As String = "Louisville, KY"
        stateTextBox.Text = cityState.Remove(0, 12)
    End Sub

    Private Sub remove3Button_Click(sender As Object, e As EventArgs) Handles remove3Button.Click
        Dim cityState As String = "Louisville, KY"
        cityTextBox.Text = cityState.Remove(10)
    End Sub

    Private Sub remove4Button_Click(sender As Object, e As EventArgs) Handles remove4Button.Click
        Dim firstName As String = "Jose"
        firstName = firstName.Remove(2, 1)
        firstTextBox.Text = firstName
    End Sub

    Private Sub insert1Button_Click(sender As Object, e As EventArgs) Handles insert1Button.Click
        Dim phone As String = "111-2222"
        phone = phone.Insert(0, "(877) ")
        MessageBox.Show(phone, "Insert Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub insert2Button_Click(sender As Object, e As EventArgs) Handles insert2Button.Click
        Dim fullName As String = "Ella Jacoby"
        fullName = fullName.Insert(5, "C. ")
        MessageBox.Show(fullName, "Insert Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
