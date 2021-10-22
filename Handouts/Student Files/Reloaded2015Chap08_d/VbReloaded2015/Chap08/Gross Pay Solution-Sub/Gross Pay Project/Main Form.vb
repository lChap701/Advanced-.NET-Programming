' Project name:         Gross Pay Project
' Project purpose:      Displays the gross pay
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills list boxes with values, then 
        ' selects a default item

        For hours As Double = 0.5 To 50 Step 0.5
            hoursListBox.Items.Add(hours.ToString("N1"))
        Next hours

        For rates As Double = 7.25 To 10.5 Step 0.25
            rateListBox.Items.Add(rates.ToString("N2"))
        Next rates

        hoursListBox.SelectedItem = "40.0"
        rateListBox.SelectedIndex = 0
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles hoursListBox.SelectedValueChanged, rateListBox.SelectedValueChanged
        grossLabel.Text = String.Empty
    End Sub
End Class
