' Project name:         Magazine Project
' Project purpose:      Selects specific records
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MagazinesDataSet.tblMagazine' table. You can move, or remove it, as needed.
        Me.TblMagazineTableAdapter.Fill(Me.MagazinesDataSet.tblMagazine)

    End Sub

    Private Sub codeButton_Click(sender As Object, e As EventArgs) Handles codeButton.Click
        ' displays the record whose Code field matches the code entered by the user


    End Sub

    Private Sub nameButton_Click(sender As Object, e As EventArgs) Handles nameButton.Click
        ' displays the record whose MagName field begins with the one or more characters entered by the user


    End Sub

    Private Sub allButton_Click(sender As Object, e As EventArgs) Handles allButton.Click
        ' displays all of the records


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
