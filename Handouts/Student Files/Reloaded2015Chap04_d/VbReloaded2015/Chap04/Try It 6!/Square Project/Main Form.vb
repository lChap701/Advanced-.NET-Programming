' Project name:         Square Project
' Project purpose:      Displays the area and/or perimeter of a square
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculates the area and/or perimeter

        Dim side As Double
        Dim answer As Double

        ' store input in a variable
        Double.TryParse(sideTextBox.Text, side)

        ' clear answerLabel
        answerLabel.Text = String.Empty

        ' perform calculation(s) and display answer(s)
        If areaCheckBox.Checked = True Then
            answer = side * side
            answerLabel.Text = "Area: " &
                answer.ToString("N1") & ControlChars.NewLine
        End If
        If perimeterCheckBox.Checked Then
            answer = side * 4
            answerLabel.Text = answerLabel.Text &
                "Perimeter: " & answer.ToString("N1")
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
