' Project name:         Items Project
' Project purpose:      Demonstrates the Insert, Remove, and Remove At methods of the Items collection
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with values, then selects the first value

        namesListBox.Items.Add("Jameston, Harry")
        namesListBox.Items.Add("Neven, John")
        namesListBox.Items.Add("Smith, Mary")
        namesListBox.Items.Add("Woods, Janet")
        namesListBox.Items.Add("Yardley, Pat")
        namesListBox.SelectedIndex = 0
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub insertButton_Click(sender As Object, e As EventArgs) Handles insertButton.Click
        ' adds a name at a specified position in the list box


    End Sub

    Private Sub removeButton_Click(sender As Object, e As EventArgs) Handles removeButton.Click
        ' removes a specified name from the list box


    End Sub

    Private Sub removeAtButton_Click(sender As Object, e As EventArgs) Handles removeAtButton.Click
        ' removes a name from a specified position in the list box


    End Sub
End Class
