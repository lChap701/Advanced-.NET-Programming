' Project name:         FormClosing Project
' Project purpose:      FormClosing examples
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        membersListBox.SelectedIndex = 0
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        ' Example 1
        Dim outFile As IO.StreamWriter
        outFile = IO.File.CreateText("members.txt")
        For Each member As String In membersListBox.Items
            outFile.WriteLine(member)
        Next member
        outFile.Close()

        MessageBox.Show("The names were written to the file.",
                        "Example 1",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        ' Example 2
        Dim button As DialogResult
        button = MessageBox.Show("Do you want to exit?",
                                 "Exit Verification",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Exclamation,
                                 MessageBoxDefaultButton.Button2)

        If button = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
