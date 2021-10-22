' Project name:         Magazine Project
' Project purpose:      Selects specific records. Also displays the average cost of a magazine
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MagazinesDataSet.tblMagazine' table. You can move, or remove it, as needed.
        Me.TblMagazineTableAdapter.Fill(Me.MagazinesDataSet.tblMagazine)

    End Sub

    Private Sub allButton_Click(sender As Object, e As EventArgs) Handles allButton.Click
        ' displays all of the records


    End Sub

    Private Sub costButton_Click(sender As Object, e As EventArgs) Handles costButton.Click
        ' displays records having a cost equal to or greater than the amount entered by the user


    End Sub

    Private Sub avgButton_Click(sender As Object, e As EventArgs) Handles avgButton.Click
        ' displays the average cost of a magazine


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
