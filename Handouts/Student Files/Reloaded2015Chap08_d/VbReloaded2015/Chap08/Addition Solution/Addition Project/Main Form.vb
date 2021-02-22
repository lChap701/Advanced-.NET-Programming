' Project name:	        Addition Project
' Project purpose:      Displays random addition problems 
'                       using numbers from 1 to 12
' Created/revised by:	<your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm



    Private Sub newButton_Click(sender As Object, e As EventArgs) Handles newButton.Click
        ' display new addition problem


    End Sub

    Private Sub checkButton_Click(sender As Object, e As EventArgs) Handles checkButton.Click
        ' check user's answer


        answerTextBox.SelectAll()
        answerTextBox.Focus()
    End Sub

    Private Sub answerTextBox_Enter(sender As Object, e As EventArgs) Handles answerTextBox.Enter
        answerTextBox.SelectAll()
    End Sub

    Private Sub answerTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles answerTextBox.KeyPress
        ' allow only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
