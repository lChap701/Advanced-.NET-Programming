' Project name:         Seminar Project
' Project purpose:      Display the average number of seminar registrants
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the average number of registrants

        Const Prompt As String = "Enter number of registrants. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const Title As String = "Number of Registrants"
        Dim inputRegistrants As String
        Dim registrants As Integer
        Dim numSeminars As Integer
        Dim totalRegistrants As Integer
        Dim avgRegistrants As Double

        ' clear text box and label
        registrantsTextBox.Text = String.Empty
        averageLabel.Text = String.Empty

        ' get first number of registrants
        inputRegistrants = InputBox(Prompt, Title)

        ' repeat as long as the user enters a value
        Do While inputRegistrants <> String.Empty
            ' display the input in the text box
            registrantsTextBox.Text = registrantsTextBox.Text &
                inputRegistrants & ControlChars.NewLine

            ' convert input to a number
            Integer.TryParse(inputRegistrants, registrants)
            ' update the counter and accumulator
            numSeminars += 1
            totalRegistrants += registrants

            ' get the next number of registrants
            inputRegistrants = InputBox(Prompt, Title)
        Loop

        ' verify that the seminars counter is greater than 0
        If numSeminars > 0 Then
            avgRegistrants = totalRegistrants / numSeminars
            averageLabel.Text = avgRegistrants.ToString("N0")
        Else
            averageLabel.Text = "N/A"
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
