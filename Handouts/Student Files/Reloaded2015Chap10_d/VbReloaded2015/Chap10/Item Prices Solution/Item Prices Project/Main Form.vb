' Project name:         Item Prices Project
' Project purpose:      Displays prices in combo boxes
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the combo boxes with values

        ' leaves the prices left-aligned
        For price As Double = 9.45 To 11.45 Step 0.25
            leftComboBox.Items.Add(price.ToString("N2"))
        Next price
        leftComboBox.SelectedIndex = 0

        ' right-aligns the prices
        For price As Double = 9.45 To 11.45 Step 0.25
            rightComboBox.Items.Add(price)
        Next price
        rightComboBox.SelectedIndex = 0
    End Sub
End Class

