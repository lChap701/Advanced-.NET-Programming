' Project name:         Gym Project
' Project purpose:      Display 3-month, 6-month, and 12-month 
'                       membership fees
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    ' class-level array

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box


    End Sub

    Private Sub membershipListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles membershipListBox.SelectedIndexChanged
        ' display membership fees


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
