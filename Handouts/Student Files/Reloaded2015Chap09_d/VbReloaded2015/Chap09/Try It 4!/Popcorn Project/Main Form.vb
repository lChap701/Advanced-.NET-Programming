' Project name:         Popcorn Project
' Project purpose:      Display the highest number sold and the number of months 
'                       in which that sales amount occurred
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private sold() As Integer = {300, 350, 363, 375,
                                 380, 350, 368, 347,
                                 410, 402, 405, 410}

    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click
        ' finds the highest number sold and the number of
        ' months in which that sales amount occurred

        Dim lastSub As Integer = sold.GetUpperBound(0)
        Dim highestSold As Integer = sold(0)
        Dim numMonths As Integer = 1

        For subscript As Integer = 1 To lastSub
            If sold(subscript) = highestSold Then
                numMonths += 1
            Else
                If sold(subscript) > highestSold Then
                    highestSold = sold(subscript)
                    numMonths = 1
                End If
            End If
        Next subscript

        highestLabel.Text = highestSold.ToString
        monthsLabel.Text = numMonths.ToString
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
