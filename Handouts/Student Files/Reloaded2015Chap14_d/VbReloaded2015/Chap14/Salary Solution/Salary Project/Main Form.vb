' Project name:         Salary Project
' Project purpose:      Calculates an employee's new salary
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the new salary

        ' declare variables

        ' assign name and salary to Worker object's properties

        ' assign raise percentage to a variable

        ' calculate and display the new salary

    End Sub

    Private Sub SelectText_Enter(sender As Object, e As EventArgs) Handles nameTextBox.Enter, currentTextBox.Enter, raisePercentTextBox.Enter
        Dim thisTextBox As TextBox
        thisTextBox = TryCast(sender, TextBox)
        thisTextBox.SelectAll()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles currentTextBox.TextChanged, raisePercentTextBox.TextChanged
        newLabel.Text = String.Empty
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
