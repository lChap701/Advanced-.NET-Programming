' Project name:         Debug Project
' Project purpose:      Displays the contents of an array in two label controls
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    ' first column contains first names, second column contains last names
    Private names() As String = {{"Mary", "Jones"}, {"Susan", "Washington"}, {"Carol", "O'Brien"},
                                 {"Jacob", "Harper"}, {"Sue", "Chen"}}

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the first and last names in label controls

        ' clear label controls, then display names
        firstLabel.Text = String.Empty
        lastLabel.Text = String.Empty
        For row As Integer = 1 To names.GetUpperBound()
            firstLabel.Text = firstLabel.Text & names(row, 0) & ControlChars.NewLine
            lastLabel.Text = lastLabel.Text & names(row, 1) & ControlChars.NewLine
        Next row
    End Sub
End Class
