Option Explicit On
Option Infer Off
Option Strict On

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ex1Button_Click(sender As Object, e As EventArgs) Handles ex1Button.Click
        Dim number As Integer = 20
        Dim answer As Double

        ' Write an assignment statement that divides the number variable
        ' by 8 and then assigns the result to the answer variable. 
        ' <ENTER THE ASSIGNMENT STATEMENT IN THE NEXT LINE>

        answerLabel.Text = Convert.ToString(answer)
    End Sub

    Private Sub ex2Button_Click(sender As Object, e As EventArgs) Handles ex2Button.Click
        Dim order As Double = 76.35
        Dim answer As Double

        ' Write an assignment statement that multiplies the order
        ' variable by 10 and then assigns the result to the answer variable.
        ' <ENTER THE ASSIGNMENT STATEMENT IN THE NEXT LINE>

        answerLabel.Text = Convert.ToString(answer)
    End Sub

    Private Sub ex3Button_Click(sender As Object, e As EventArgs) Handles ex3Button.Click
        Dim num As Integer = 5
        Dim answer As Double

        ' Write an assignment statement that adds 7 to the
        ' contents of the num variable, then raises the result
        ' to the second power, and then assigns the final result
        ' to the answer variable.
        ' <ENTER THE ASSIGNMENT STATEMENT IN THE NEXT LINE>

        answerLabel.Text = Convert.ToString(answer)
    End Sub

    Private Sub ex4Button_Click(sender As Object, e As EventArgs) Handles ex4Button.Click
        Dim score1 As Integer = 100
        Dim score2 As Integer = 86
        Dim answer As Double

        ' Write an assignment statement that assigns the average
        ' test score to the answer variable. 
        ' <ENTER THE ASSIGNMENT STATEMENT IN THE NEXT LINE>

        answerLabel.Text = Convert.ToString(answer)
    End Sub

    Private Sub ex5Button_Click(sender As Object, e As EventArgs) Handles ex5Button.Click
        Dim num1 As Double = 25.5
        Dim num2 As Integer = 3
        Dim answer As Double

        ' Write an assignment statement that divides the num1
        ' variable by the num2 variable and then assigns the 
        ' remainder to the answer variable. 
        ' <ENTER THE ASSIGNMENT STATEMENT IN THE NEXT LINE>

        answerLabel.Text = Convert.ToString(answer)
    End Sub

    Private Sub ex6Button_Click(sender As Object, e As EventArgs) Handles ex6Button.Click
        Dim cost As Double = 45.99

        ' Write an assignment statement that multiplies the cost
        ' variable by 1.09 and then assigns the result to the 
        ' cost variable. 
        ' <ENTER THE ASSIGNMENT STATEMENT IN THE NEXT LINE>

        answerLabel.Text = Convert.ToString(cost)
    End Sub
End Class
