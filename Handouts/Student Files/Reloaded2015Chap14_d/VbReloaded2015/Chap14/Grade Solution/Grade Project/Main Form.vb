' Project name:         Grade Project
' Project purpose:      Displays a grade based on two test scores
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class MainForm
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' calculates and displays a letter grade

        ' instantiate a CourseGrade object

        ' assign test scores

        ' determine the grade

        ' display the grade

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list boxes with values

        For score As Integer = 0 To 100
            test1ListBox.Items.Add(score.ToString)
            test2ListBox.Items.Add(score.ToString)
        Next score

        test1ListBox.SelectedItem = "75"
        test2ListBox.SelectedItem = "75"
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles test1ListBox.SelectedValueChanged, test2ListBox.SelectedValueChanged
        gradeLabel.Text = String.Empty
    End Sub
End Class
