' Project name:         Try It 3! Project
' Project purpose:      Examples of the Contains, IndexOf, and Substring methods
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub contains1Button_Click(sender As Object, e As EventArgs) Handles contains1Button.Click
        Dim cityState As String = "Boston, MA"
        Dim isContained As Boolean
        isContained = cityState.Contains("MA")
        MessageBox.Show("The Contains method returns " & isContained.ToString, "Contains Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub contains2Button_Click(sender As Object, e As EventArgs) Handles contains2Button.Click
        Dim cityState As String = "Boston, MA"
        Dim isContained As Boolean
        isContained = cityState.Contains("Ma")
        MessageBox.Show("The Contains method returns " & isContained.ToString, "Contains Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub contains3Button_Click(sender As Object, e As EventArgs) Handles contains3Button.Click
        Dim address As String = "12 Dover St."
        If address.ToUpper.Contains("DOVER") Then
            MessageBox.Show("The Contains method returns True because the address contains DOVER", "Contains Example 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("The Contains method returns False because the address does not contain DOVER", "Contains Example 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub indexOf4Button_Click(sender As Object, e As EventArgs) Handles indexOf4Button.Click
        Dim cityState As String = "Boston, MA"
        Dim charIndex As Integer
        charIndex = cityState.IndexOf("MA")
        MessageBox.Show("The IndexOf method returns " & charIndex.ToString, "IndexOf Example 4", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub indexOf5Button_Click(sender As Object, e As EventArgs) Handles indexOf5Button.Click
        Dim cityState As String = "Boston, MA"
        Dim charIndex As Integer
        charIndex = cityState.IndexOf("Ma")
        MessageBox.Show("The IndexOf method returns " & charIndex.ToString, "IndexOf Example 5", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub indexOf6Button_Click(sender As Object, e As EventArgs) Handles indexOf6Button.Click
        Dim address As String = "12 Dover St."
        Dim charIndex As Integer
        charIndex = address.ToLower.IndexOf("dover st.", 5)
        MessageBox.Show("The IndexOf method returns " & charIndex.ToString, "IndexOf Example 6", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub substring1Button_Click(sender As Object, e As EventArgs) Handles substring1Button.Click
        Dim full As String = "Josh Wentworth"
        Dim firstName As String = full.Substring(0, 4)
        Dim lastName As String = full.Substring(5)
        MessageBox.Show("First name: " & firstName & ControlChars.NewLine & "Last name: " & lastName,
                        "Substring Example 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub substring2Button_Click(sender As Object, e As EventArgs) Handles substring2Button.Click
        Dim employeeNum As String = "38F45"
        Dim status As String
        status = employeeNum.Substring(2, 1)
        MessageBox.Show("Status: " & status, "Substring Example 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
