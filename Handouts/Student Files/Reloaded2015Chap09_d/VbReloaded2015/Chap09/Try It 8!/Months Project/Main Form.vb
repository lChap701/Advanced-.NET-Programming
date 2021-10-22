' Project name:         Months Project
' Project purpose:      Displays the contents of a two-dimensional array in a list box
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private months(,) As String = {{"Jan", "31"},
                                   {"Feb", "28"},
                                   {"Mar", "31"}}

    Private Sub ex1Button_Click(sender As Object, e As EventArgs) Handles ex1Button.Click
        ' fills the list box with values

        Dim highRow As Integer = months.GetUpperBound(0)
        Dim highCol As Integer = months.GetUpperBound(1)
        monthsListBox.Items.Clear()
        For row As Integer = 0 To highRow
            For col As Integer = 0 To highCol
                monthsListBox.Items.Add(months(row, col))
            Next col
        Next row
    End Sub

    Private Sub ex2Button_Click(sender As Object, e As EventArgs) Handles ex2Button.Click
        ' fills the list box with values

        Dim highRow As Integer = months.GetUpperBound(0)
        Dim highCol As Integer = months.GetUpperBound(1)
        Dim row As Integer
        Dim col As Integer
        monthsListBox.Items.Clear()
        Do While col <= highCol
            row = 0
            Do While row <= highRow
                monthsListBox.Items.Add(months(row, col))
                row += 1
            Loop
            col += 1
        Loop
    End Sub

    Private Sub ex3Button_Click(sender As Object, e As EventArgs) Handles ex3Button.Click
        ' fills the list box with values

        monthsListBox.Items.Clear()
        For Each monthElement As String In months
            monthsListBox.Items.Add(monthElement)
        Next monthElement
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
