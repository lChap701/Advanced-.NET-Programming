' Project name:         Allenton Project
' Project purpose:      Display weight on planets and the moon
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' calculates and displays your weight on other planets and the moon
        ' Jupiter is 2.54 times earth weight, Venus is .91, Mars is .38, and the moon is .17

        Dim earth As Double
        Dim jupiter As Double
        Dim venus As Double
        Dim mars As Double
        Dim moon As Double

        ' calculate weights
        jupiter = earth * 2.54
        venus = earth * 0.91
        mars = earth * 0.38
        moon = earth * 0.17

        ' display weights
        jupiterLabel.Text = jupiter.ToString("N2")
        venusLabel.Text = venus.ToString("N2")
        marsLabel.Text = mars.ToString("N2")
        moonLabel.Text = mars.ToString("N2")
    End Sub
End Class
