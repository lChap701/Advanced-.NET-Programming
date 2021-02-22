' Project name:         Kettleson Project
' Project purpose:      Uses a sequential access file to keep track of the names of club members
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub nameTextBox_Enter(sender As Object, e As EventArgs) Handles nameTextBox.Enter
        nameTextBox.SelectAll()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' reads names from a sequential access file 
        ' and displays them in the list box

        Dim inFile As IO.StreamReader
        Dim name As String

        ' clear previous names from the list box
        membersListBox.Items.Clear()

        ' determine whether the file exists
        If IO.File.Exists("members.txt") Then
            ' open the file for input
            inFile = IO.File.OpenText("members.txt")
            ' process loop instructions until end of file
            Do Until inFile.Peek = -1
                ' read a name
                name = inFile.ReadLine
                ' add name to list box
                membersListBox.Items.Add(name)
            Loop
            ' close the file
            inFile.Close()
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' saves the contents of the list box
        ' to a sequential access file

        ' declare a StreamWriter variable
        Dim outFile As IO.StreamWriter
        ' open the file for output
        outFile = IO.File.CreateText("members.txt")
        ' write each name on a separate line in the file
        For Each member As String In membersListBox.Items
            outFile.WriteLine(member)
        Next member
        ' close the file
        outFile.Close()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ' adds a name to the list box

        nameTextBox.Text = nameTextBox.Text.Trim
        If nameTextBox.Text <> "" Then
            membersListBox.Items.Add(nameTextBox.Text)
        End If
        nameTextBox.Focus()
        nameTextBox.SelectAll()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        ' deletes a name from the list box

        Dim index As Integer

        index = membersListBox.SelectedIndex
        If index <> -1 Then
            membersListBox.Items.RemoveAt(index)
        End If
    End Sub
End Class
