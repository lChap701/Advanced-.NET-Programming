' Project name:         Square Project
' Project purpose:      Displays either the area or the perimeter of a square
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the area or perimeter

        Dim formula As String
        Dim decimalPlaces As String
        Dim side As Double
        Dim answer As Double
        Dim formulaMsg As String

        ' store input in variables
        formula = formulaTextBox.Text.ToUpper
        decimalPlaces = decimalTextBox.Text
        Double.TryParse(sideTextBox.Text, side)

        ' determine formula and perform calculation
        If formula = "A" Then
            answer = side * side
            formulaMsg = "Area: "
        Else
            answer = side * 4
            formulaMsg = "Perimeter: "
        End If

        ' determine number of decimal places and display answer
        If decimalPlaces = "1" Then
            answerLabel.Text = formulaMsg & answer.ToString("N1")
        Else
            answerLabel.Text = formulaMsg & answer.ToString("N2")
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
