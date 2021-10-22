' Project name:         Word Project
' Project purpose:      A game that allows the user to guess a
'                       word letter-by-letter
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private secretWord As String
    Private numIncorrect As Integer

    Private Sub DetermineGameOver(ByVal aDashWasReplaced As Boolean)
        ' determine whether the game is over and
        ' take the appropriate action

        If aDashWasReplaced Then
            ' if the word does not contain any dashes, the game
            ' is over because player 2 guessed the word
            If wordLabel.Text.Contains("-") = False Then
                MessageBox.Show("Great guessing!", "Game Over",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                checkButton.Enabled = False
            End If
        Else
            ' if 7 incorrect guesses, the game is over
            If numIncorrect = 7 Then
                MessageBox.Show("Sorry, the word is " &
                                secretWord & ".", "Game Over",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                checkButton.Enabled = False
            End If
        End If
    End Sub

    Private Sub checkButton_Click(sender As Object, e As EventArgs) Handles checkButton.Click
        ' check if the letter appears in the word

        Dim letter As String
        Dim dashReplaced As Boolean

        letter = letterTextBox.Text

        ' look at each letter in the word
        For index As Integer = 0 To 5
            If secretWord.Substring(index, 1) = letter Then
                ' replace corresponding dash with letter
                wordLabel.Text =
                    wordLabel.Text.Remove(index, 1)
                wordLabel.Text =
                    wordLabel.Text.Insert(index, letter)
                dashReplaced = True
            End If
        Next index

        If dashReplaced Then
            Call DetermineGameOver(dashReplaced)
        Else  ' no dash was replaced
            incorrectLabel.Text =
                incorrectLabel.Text & " " & letter
            numIncorrect += 1
            remainingLabel.Text = (7 - numIncorrect).ToString
            Call DetermineGameOver(dashReplaced)
        End If

        ' clear text box and set focus
        letterTextBox.Text = String.Empty
        letterTextBox.Focus()
    End Sub

    Private Sub fileExitMenuItem_Click(sender As Object, e As EventArgs) Handles fileExitMenuItem.Click
        Me.Close()

    End Sub

    Private Sub letterTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles letterTextBox.KeyPress
        ' allows only letters and the Backspace key

        If e.KeyChar Like "[!A-Za-z]" AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub fileNewMenuItem_Click(sender As Object, e As EventArgs) Handles fileNewMenuItem.Click
        ' start a new game

        wordLabel.Text = String.Empty
        incorrectLabel.Text = String.Empty
        letterTextBox.Text = String.Empty
        numIncorrect = 0
        remainingLabel.Text = "7"

        ' get a 6-letter word from player 1
        ' trim and convert to uppercase
        secretWord = InputBox("Enter a 6-letter word:",
                              "Guess the Word Game").Trim.ToUpper

        ' determine whether the word contains 6 letters
        If secretWord Like "[A-Z][A-Z][A-Z][A-Z][A-Z][A-Z]" Then
            ' display 6 dashes
            wordLabel.Text = "------"
            ' enable button and set focus
            checkButton.Enabled = True
            letterTextBox.Focus()
        Else
            MessageBox.Show("6 letters are required",
                            "Guess the Word Game",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            checkButton.Enabled = False
        End If
    End Sub
End Class
