' Project name:         MusicBox Project
' Project purpose:      Selects specific records. Also displays the number of music boxes.
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On   ' using LINQ

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MusicBoxDataSet.tblBox' table. You can move, or remove it, as needed.
        Me.TblBoxTableAdapter.Fill(Me.MusicBoxDataSet.tblBox)

    End Sub

    Private Sub allButton_Click(sender As Object, e As EventArgs) Handles allButton.Click
        ' displays all of the records


    End Sub

    Private Sub shapeButton_Click(sender As Object, e As EventArgs) Handles shapeButton.Click
        ' displays music boxes having the selected shape


    End Sub

    Private Sub sourceButton_Click(sender As Object, e As EventArgs) Handles sourceButton.Click
        ' displays either gift music boxes or purchased music boxes


    End Sub

    Private Sub countButton_Click(sender As Object, e As EventArgs) Handles countButton.Click
        ' displays the number of music boxes


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
