' Project name:         West Coast Project
' Project purpose:      Display the number of stores in a state
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Structure StateInfo
        Public id As String
        Public stores As Integer
    End Structure

    ' declare array of structure variables  
    Private states(2) As StateInfo

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' populate array, then add each ID to the list box

        states(0).id = "CA"
        states(0).stores = 110
        states(1).id = "OR"
        states(1).stores = 75
        states(2).id = "WA"
        states(2).stores = 63

        For index As Integer = 0 To 2
            idListBox.Items.Add(states(index).id)
        Next index
        idListBox.SelectedIndex = 0
    End Sub

    Private Sub numStoresButton_Click(sender As Object, e As EventArgs) Handles numStoresButton.Click
        ' displays the number of stores associated
        ' with the state ID selected in the list box

        Dim index As Integer

        index = idListBox.SelectedIndex
        storesLabel.Text = states(index).stores.ToString
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub idListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idListBox.SelectedIndexChanged
        storesLabel.Text = String.Empty
    End Sub
End Class
