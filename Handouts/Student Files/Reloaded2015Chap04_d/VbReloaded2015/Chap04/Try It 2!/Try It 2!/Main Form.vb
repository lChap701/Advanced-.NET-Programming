Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub ex1Button_Click(sender As Object, e As EventArgs) Handles ex1Button.Click
        ' results in NAN
        Dim x As Integer
        Dim y As Integer
        Dim z As Double
        z = x / y
        answerLabel.Text = z.ToString
    End Sub

    Private Sub ex2Button_Click(sender As Object, e As EventArgs) Handles ex2Button.Click
        ' results in NAN
        Dim x As Double
        Dim y As Double
        Dim z As Double
        z = x / y
        answerLabel.Text = z.ToString
    End Sub

    Private Sub ex3Button_Click(sender As Object, e As EventArgs) Handles ex3Button.Click
        ' results in Infinity
        Dim x As Integer = 5
        Dim y As Integer
        Dim z As Double
        z = x / y
        answerLabel.Text = z.ToString
    End Sub

    Private Sub ex4Button_Click(sender As Object, e As EventArgs) Handles ex4Button.Click
        ' results in a runtime error
        Dim x As Integer = 10
        Dim y As Integer
        Dim z As Double
        z = x \ y
        answerLabel.Text = z.ToString
    End Sub

    Private Sub ex5Button_Click(sender As Object, e As EventArgs) Handles ex5Button.Click
        ' results in a runtime error
        Dim x As Decimal
        Dim y As Decimal
        Dim z As Double
        z = x / y
        answerLabel.Text = z.ToString
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
