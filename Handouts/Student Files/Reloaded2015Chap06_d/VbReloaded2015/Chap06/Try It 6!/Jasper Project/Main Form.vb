' Project name:         Jasper Project
' Project purpose:      Add names to a list box during run time
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ' adds the employee name to the list box

        If nameTextBox.Text <> String.Empty Then
            workerListBox.Items.Add(nameTextBox.Text)
        Else
            MessageBox.Show("Please enter a name.", "Jasper's",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
