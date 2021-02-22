' Project name:         Salary Project
' Project purpose:      Displays the salary amount associated with a code
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private salaries() As Integer = {25000, 35000, 55000, 70000, 80200, 90500}

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the salary amount associated with a code

        Dim inputCode As String
        Dim code As Integer
        Dim subscript As Integer

        inputCode = InputBox("Salary code (1 - 6)", "Salary")
        Integer.TryParse(inputCode, code)
        ' subtract 1 from the code to get the appropriate subscript
        subscript = code - 1

        If subscript >= 0 AndAlso subscript < salaries.Length Then
            salaryLabel.Text = salaries(subscript).ToString("C0")
        Else
            salaryLabel.Text = String.Empty
            MessageBox.Show("The salary code must be from 1 through 6.", "Salary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
