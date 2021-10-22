' Project name:         TV Project
' Project purpose:      Displays the selected list box item
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with array values and then selects the first item

        Dim tvSeries() As String = {"Aquarius", "House of Cards",
                                    "Sense8", "Wayward Pines"}

        ' Example 1
        Dim highestSub As Integer = tvSeries.GetUpperBound(0)
        For subscript As Integer = 0 To highestSub
            seriesListBox.Items.Add(tvSeries(subscript))
        Next subscript

        ' Example 2
        'Dim highestSub As Integer = tvSeries.Length - 1
        'Dim subscript As Integer
        'Do While subscript <= highestSub
        '    seriesListBox.Items.Add(tvSeries(subscript))
        '    subscript += 1
        'Loop
        seriesListBox.SelectedIndex = 0
    End Sub

    Private Sub seriesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seriesListBox.SelectedIndexChanged
        seriesLabel.Text = seriesListBox.SelectedItem.ToString
    End Sub
End Class
