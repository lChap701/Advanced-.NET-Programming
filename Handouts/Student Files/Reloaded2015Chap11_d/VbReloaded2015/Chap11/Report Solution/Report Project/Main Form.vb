' Project name:         Report Project
' Project purpose:      Writes a report to a sequential access file
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Structure CommissionInfo
        Public name As String
        Public commission As Integer
    End Structure

    Private salespeople(2) As CommissionInfo

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill array with values

        salespeople(0).name = "Karen Klementz"
        salespeople(0).commission = 12600
        salespeople(1).name = "Jack Harper"
        salespeople(1).commission = 900
        salespeople(2).name = "Tim Harris"
        salespeople(2).commission = 5750
    End Sub

End Class
