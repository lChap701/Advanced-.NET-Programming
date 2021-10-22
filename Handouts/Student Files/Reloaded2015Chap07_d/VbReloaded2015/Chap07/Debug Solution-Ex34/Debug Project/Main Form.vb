' Project name:	        Debug Project
' Project purpose:      Displays commission rates in a list box
' Created/revised by:	<your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills list box with rates

        For rate As Double = 0.03 To 0.06 Step 0.01
            ratesListBox.Items.Add(rate.ToString("P0"))
        Next rate
        ratesListBox.SelectedIndex = 0
    End Sub
End Class
