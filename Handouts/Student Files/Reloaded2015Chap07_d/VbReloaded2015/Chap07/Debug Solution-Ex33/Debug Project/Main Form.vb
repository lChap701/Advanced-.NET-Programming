' Project name:         Debug Project
' Project purpose:      Displays the number of positive integers, negative integers, and zeros entered by the user.
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        ' displays the number of positive integers, negative integers, and zeros entered

        Const Prompt As String = "Enter an integer. Click Cancel to end. "
        Dim numInput As String
        Dim number As Integer
        Dim positive As Integer
        Dim negative As Integer
        Dim zero As Integer

        numInput = InputBox(Prompt, "Number Entry", "0")
        Do While numInput <> String.Empty
            Integer.TryParse(numInput, number)
            ' update appropriate counter
            If number > 0 Then
                positive = 1
            ElseIf number < 0 Then
                negative = 1
            Else
                zero = 1
            End If
        Loop

        ' display counters
        positiveLabel.Text = positive.ToString
        negativeLabel.Text = negative.ToString
        zeroLabel.Text = zero.ToString
    End Sub
End Class
