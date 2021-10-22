' Project name:         Sorting Project
' Project purpose:      Sorting examples
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub ascendButton_Click(sender As Object, e As EventArgs) Handles ascendButton.Click
        ' sorts the array in ascending order

        Dim pays() As Double = {9.75, 12.5, 10.75, 8.35}
        Array.Sort(pays)

        paysListBox.Items.Clear()
        For Each element As Double In pays
            paysListBox.Items.Add(element)
        Next element
    End Sub

    Private Sub reverseButton_Click(sender As Object, e As EventArgs) Handles reverseButton.Click
        ' sorts the array in reverse order

        Dim pays() As Double = {9.75, 12.5, 10.75, 8.35}
        Array.Reverse(pays)

        paysListBox.Items.Clear()
        For Each element As Double In pays
            paysListBox.Items.Add(element)
        Next element
    End Sub

    Private Sub descendButton_Click(sender As Object, e As EventArgs) Handles descendButton.Click
        ' sorts the array in desscending order

        Dim pays() As Double = {9.75, 12.5, 10.75, 8.35}
        Array.Sort(pays)
        Array.Reverse(pays)

        paysListBox.Items.Clear()
        For Each element As Double In pays
            paysListBox.Items.Add(element)
        Next element
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
