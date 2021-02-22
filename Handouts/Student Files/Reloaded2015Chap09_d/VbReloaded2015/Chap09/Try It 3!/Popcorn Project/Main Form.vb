' Project name:         Popcorn Project
' Project purpose:      Display the total number of two-gallon tins sold during a 12-month period
'                       and the average number sold each month
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private sold() As Integer = {300, 350, 363, 375,
                                 380, 350, 368, 347,
                                 410, 402, 405, 410}

    Private Sub forNextButton_Click(sender As Object, e As EventArgs) Handles forNextButton.Click
        ' displays the total and average sold

        Dim highSub As Integer = sold.GetUpperBound(0)
        Dim total As Integer
        Dim average As Double

        ' accumulate numbers sold 
        For subscript As Integer = 0 To highSub
            total += sold(subscript)
        Next subscript
        ' calculate average
        average = total / sold.Length

        totalLabel.Text = total.ToString("N0")
        avgLabel.Text = average.ToString("N0")
    End Sub

    Private Sub doLoopButton_Click(sender As Object, e As EventArgs) Handles doLoopButton.Click
        ' displays the total and average sold

        Dim highSub As Integer = sold.GetUpperBound(0)
        Dim total As Integer
        Dim average As Double
        Dim subscript As Integer

        ' accumulate numbers sold
        Do While subscript <= highSub
            total += sold(subscript)
            subscript += 1
        Loop
        ' calculate average
        average = total / sold.Length

        totalLabel.Text = total.ToString("N0")
        avgLabel.Text = average.ToString("N0")
    End Sub

    Private Sub forEachNextButton_Click(sender As Object, e As EventArgs) Handles forEachNextButton.Click
        ' displays the total and average sold

        Dim total As Integer
        Dim average As Double

        ' accumulate numbers sold
        For Each monthSale As Integer In sold
            total += monthSale
        Next monthSale
        ' calculate average
        average = total / sold.Length

        totalLabel.Text = total.ToString("N0")
        avgLabel.Text = average.ToString("N0")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
