' Project name:         Try It 4! Project
' Project purpose:      Examples of the Like operator
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub ex1button_Click(sender As Object, e As EventArgs) Handles ex1button.Click
        Dim firstName As String
        firstName = InputBox("First name", "Example 1")
        If firstName.ToUpper Like "B?LL" Then
            MessageBox.Show("You entered the letter B, followed by one character and the letters LL.", "Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("You did not enter the letter B, followed by one character and the letters LL.", "Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ex2Button_Click(sender As Object, e As EventArgs) Handles ex2Button.Click
        If stateTextBox.Text Like "K*" Then
            MessageBox.Show("You entered the letter K followed by zero or more characters.", "Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("You did not enter the letter K followed by zero or more characters.", "Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ex3Button_Click(sender As Object, e As EventArgs) Handles ex3Button.Click
        Dim id As String
        id = InputBox("Enter ID", "Example 3")
        Do While id Like "###*"
            MessageBox.Show("The ID contains 3 digits followed by zero or more characters.", "Example 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
            id = InputBox("Enter ID", "Example 3")
        Loop
        MessageBox.Show("The ID does not contain 3 digits followed by zero or more characters.", "Example 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ex4Button_Click(sender As Object, e As EventArgs) Handles ex4Button.Click
        Dim firstName As String
        firstName = InputBox("First name", "Example 4")
        If firstName.ToUpper Like "T[OI]M" Then
            MessageBox.Show("You entered either Tom or Tim.", "Example 4", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("You did not enter Tom or Tim.", "Example 4", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ex5Button_Click(sender As Object, e As EventArgs) Handles ex5Button.Click
        Dim letter As String
        letter = InputBox("Enter one letter", "Example 5")
        If letter Like "[a-z]" Then
            MessageBox.Show("You entered one lowercase letter.", "Example 5", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("You did not enter one lowercase letter.", "Example 5", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ex6Button_Click(sender As Object, e As EventArgs) Handles ex6Button.Click
        Dim fullName As String
        Dim currentChar As String
        Dim nonLetter As Integer

        fullName = nameTextBox.Text
        For index As Integer = 0 To fullName.Length - 1
            currentChar = fullName.Substring(index, 1)
            If currentChar Like "[!a-zA-Z]" Then
                nonLetter += 1
            End If
        Next index
        MessageBox.Show("Number of non-letters: " & nonLetter.ToString, "Example 6", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ex7Button_Click(sender As Object, e As EventArgs) Handles ex7Button.Click
        If rateTextBox.Text Like "*.*" Then
            MessageBox.Show("The rateTextBox contains a period.", "Example 7", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("The rateTextBox does not contain a period.", "Example 7", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ex8Button_Click(sender As Object, e As EventArgs) Handles ex8Button.Click
        Dim partNum As String

        partNum = InputBox("Enter one or more characters", "Example 8")
        If partNum.ToUpper Like "[A-Z][A-Z]##" Then
            MessageBox.Show("The string contains two letters followed by two numbers.", "Example 8", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("The string does not contain two letters followed by two numbers.", "Example 8", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
