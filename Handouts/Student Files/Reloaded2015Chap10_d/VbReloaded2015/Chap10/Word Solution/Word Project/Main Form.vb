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
End Class
