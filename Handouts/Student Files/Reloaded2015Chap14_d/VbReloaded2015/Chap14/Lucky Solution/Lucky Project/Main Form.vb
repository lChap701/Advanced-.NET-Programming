' Project name:         Lucky Project
' Project purpose:      Simulates the Lucky Number Game
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    ' declare class-level variable
    Private points As Integer = 10

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub rollButton_Click(sender As Object, e As EventArgs) Handles rollButton.Click
        ' simulates the Lucky Number Game

        Dim randGen As New Random
        Dim random1 As Integer
        Dim random2 As Integer

        ' remove images
        firstDiePictureBox.Image = Nothing
        secondDiePictureBox.Image = Nothing

        ' disable Roll 'Em button
        rollButton.Enabled = False

        ' refresh form and then delay execution
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)

        ' generate two random integers from 1 through 6
        random1 = randGen.Next(1, 7)
        random2 = randGen.Next(1, 7)

        ' display appropriate image in firstDiePictureBox
        Select Case random1
            Case 1
                firstDiePictureBox.Image = dot1PictureBox.Image
            Case 2
                firstDiePictureBox.Image = dot2PictureBox.Image
            Case 3
                firstDiePictureBox.Image = dot3PictureBox.Image
            Case 4
                firstDiePictureBox.Image = dot4PictureBox.Image
            Case 5
                firstDiePictureBox.Image = dot5PictureBox.Image
            Case Else
                firstDiePictureBox.Image = dot6PictureBox.Image
        End Select

        ' display appropriate image in secondDiePictureBox
        Select Case random2
            Case 1
                secondDiePictureBox.Image = dot1PictureBox.Image
            Case 2
                secondDiePictureBox.Image = dot2PictureBox.Image
            Case 3
                secondDiePictureBox.Image = dot3PictureBox.Image
            Case 4
                secondDiePictureBox.Image = dot4PictureBox.Image
            Case 5
                secondDiePictureBox.Image = dot5PictureBox.Image
            Case Else
                secondDiePictureBox.Image = dot6PictureBox.Image
        End Select

        ' check sum of random numbers
        If random1 + random2 = 7 Then
            Dim count As Integer = 1
            Do While count <= 10
                numberLabel.Visible = Not numberLabel.Visible
                Me.Refresh()
                System.Threading.Thread.Sleep(200)
                count += 1
            Loop
            points += 2
        Else
            points -= 1
            If points = 0 Then
                MessageBox.Show("Sorry, you lost all of your points! " &
                                "Click the Start Over button to try again.",
                                "Lucky Number Game", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        End If
        ' display points
        pointsLabel.Text = points.ToString
        ' enable Roll 'Em button
        rollButton.Enabled = True

    End Sub

    Private Sub startOverButton_Click(sender As Object, e As EventArgs) Handles startOverButton.Click
        ' start a new game

        points = 10
        pointsLabel.Text = points.ToString
        firstDiePictureBox.Image = Nothing
        secondDiePictureBox.Image = Nothing

    End Sub
End Class
