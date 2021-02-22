' Project name:         MessageBox Project
' Project purpose:      Use the value returned by the MessageBox.Show method
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ex1Button_Click(sender As Object, e As EventArgs) Handles ex1Button.Click

        Dim button As DialogResult
        msgLabel.Text = String.Empty

        button = MessageBox.Show("Delete this record?", "Payroll",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button2)

        If button = DialogResult.Yes Then
            msgLabel.Text = "Record deleted"
        End If
    End Sub

    Private Sub ex2Button_Click(sender As Object, e As EventArgs) Handles ex2Button.Click

        If MessageBox.Show("Play another game?", "Math Monster",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            msgLabel.Text = "New game"
        Else
            msgLabel.Text = "Game closed"
        End If
    End Sub
End Class
