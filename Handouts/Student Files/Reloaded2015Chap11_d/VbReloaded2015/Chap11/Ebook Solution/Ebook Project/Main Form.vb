' Project name:         Ebook Project
' Project purpose:      Adds and deletes list box entries
'                       Reads information from a sequential access file
'                       Writes information to a sequential access file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with data from 
        ' a sequential access file


    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ' adds eBook information to the list box

        ' declare variables

        ' get the eBook information

        ' format the price, then concatenate the input
        ' items, using 40 characters for the title, 
        ' 35 characters for the author, and 5 
        ' characters for the price

        ' add the information to the list box

    End Sub

    Private Sub removeButton_Click(sender As Object, e As EventArgs) Handles removeButton.Click
        ' removes the selected line from the list box

        ' if a line is selected, remove the line

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' save the list box information

        ' declare a StreamWriter variable

        ' open the file for output

        ' write each line in the list box


        ' close the file

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
