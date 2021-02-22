' Project name:         Debug Project
' Project purpose:      Calculates the number of positive integers, negative integers, and zeros entered by the user
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        ' displays the number of positive integers, the number of negative integers, 
        ' and the number of zeros entered

        Const Prompt As String = "Enter an integer. Click Cancel to end. "
        Dim inputNumber As String
        Dim number As Integer
        Dim positiveCounter As Integer
        Dim negativeCounter As Integer
        Dim zeroCounter As Integer

        inputNumber = InputBox(Prompt, "Number Entry", "0")
        Do While inputNumber <> String.Empty
            Integer.TryParse(inputNumber, number)
            ' update appropriate counter
            If number > 0 Then
                positiveCounter = number + 1
            ElseIf number < 0 Then
                negativeCounter = number + 1
            Else
                zeroCounter = number + 1
            End If
        Loop

        ' display counters
        positiveLabel.Text = positiveCounter.ToString
        negativeLabel.Text = negativeCounter.ToString
        zeroLabel.Text = zeroCounter.ToString
    End Sub
End Class
