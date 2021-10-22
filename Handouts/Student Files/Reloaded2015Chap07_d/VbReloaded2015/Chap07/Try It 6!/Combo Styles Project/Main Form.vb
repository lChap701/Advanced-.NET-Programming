' Project name:         Combo Styles Project
' Project purpose:      Demonstrates the three styles of combo boxes
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

        nameComboBox.Items.Add("Amy")
        nameComboBox.Items.Add("Beth")
        nameComboBox.Items.Add("Carl")
        nameComboBox.Items.Add("Dan")
        nameComboBox.Items.Add("Jan")
        nameComboBox.SelectedIndex = 0

        cityComboBox.Items.Add("London")
        cityComboBox.Items.Add("Madrid")
        cityComboBox.Items.Add("Paris")
        cityComboBox.SelectedItem = "Madrid"

        stateComboBox.Items.Add("Alabama")
        stateComboBox.Items.Add("Maine")
        stateComboBox.Items.Add("New York")
        stateComboBox.Items.Add("South Dakota")
        stateComboBox.Text = "New York"
    End Sub
End Class
