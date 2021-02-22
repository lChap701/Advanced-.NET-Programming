' Project name:         StartsWith EndsWith Project
' Project purpose:      Examples of the StartsWith and EndsWith methods
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub startsWithButton_Click(sender As Object, e As EventArgs) Handles startsWithButton.Click
        ' determine whether a string starts with 606

        Dim zip As String

        ' prompt the user to enter a 5-digit ZIP code
        zip = InputBox("Enter a 5-digit ZIP code", "ZIP Code").Trim
        ' determine whether the ZIP contains 5 characters
        If zip.Length = 5 Then
            ' if ZIP starts with "606", display the message "The ZIP code starts with 606"
            ' otherwise, display the message "The ZIP code does not start with 606"
            ' <ENTER THE APPROPRIATE CODE HERE>

        Else
            MessageBox.Show("Invalid ZIP code", "Entry Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub endsWithButton_Click(sender As Object, e As EventArgs) Handles endsWithButton.Click
        ' determine whether a string ends with a percent sign

        Dim rate As String

        ' prompt the user to enter a rate
        rate = InputBox("Enter the bonus rate", "Bonus Rate").Trim
        ' if the rate ends with a percent sign, display the message "The rate ends with a %"
        ' otherwise, display the message "The rate does not end with a %"
        ' <ENTER THE APPROPRIATE CODE HERE>

    End Sub
End Class
