' Project name:         Clark Project
' Project purpose:      Add names to a list box during run time
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub enterButton_Click(sender As Object, e As EventArgs) Handles enterButton.Click
        ' adds employee names to the list box

        Dim empName As String

        empName = InputBox("Worker name:", "Name Entry")
        Do Until empName = String.Empty
            workerListBox.Items.Add(empName)
            empName = InputBox("Worker name:", "Name Entry")
        Loop
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
