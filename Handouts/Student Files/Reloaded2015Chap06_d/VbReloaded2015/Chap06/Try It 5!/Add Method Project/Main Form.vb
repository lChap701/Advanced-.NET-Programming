' Project name:         Add Method Project
' Project purpose:      Use a list box's Add method
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' add items to the statesListBox
        statesListBox.Items.Add("Alaska")
        statesListBox.Items.Add("Delaware")
        statesListBox.Items.Add("Georgia")
        statesListBox.Items.Add("Iowa")

        ' add items to the codesListBox
        Dim code As Integer = 100
        Do While code <= 106
            codesListBox.Items.Add(code.ToString)
            code += 1
        Loop
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
