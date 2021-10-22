' Project name:         Allen Project
' Project purpose:      Display the amount sold for each cookie type
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill the list box with values

        cookieListBox.Items.Add("Chunky Chocolate")
        cookieListBox.Items.Add("Macadamia")
        cookieListBox.Items.Add("Peanut Butter")
        cookieListBox.Items.Add("Snickerdoodle")
        cookieListBox.Items.Add("Sugar")
        cookieListBox.SelectedIndex = 0
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ' add amount sold to the appropriate total

        ' declare array and variables
        Static totalBoxesSold(4) As Integer
        Dim sold As Integer
        Dim subscript As Integer

        Integer.TryParse(soldTextBox.Text, sold)
        subscript = cookieListBox.SelectedIndex

        ' update array value
        totalBoxesSold(subscript) += sold

        ' display array values
        chunkyChocLabel.Text = totalBoxesSold(0).ToString
        macadamiaLabel.Text = totalBoxesSold(1).ToString
        peanutButLabel.Text = totalBoxesSold(2).ToString
        snickerLabel.Text = totalBoxesSold(3).ToString
        sugarLabel.Text = totalBoxesSold(4).ToString

        soldTextBox.Focus()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub soldTextBox_Enter(sender As Object, e As EventArgs) Handles soldTextBox.Enter
        soldTextBox.SelectAll()
    End Sub

    Private Sub soldTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles soldTextBox.KeyPress
        ' allow numbers, the hyphen, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "-" AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles soldTextBox.TextChanged, cookieListBox.SelectedIndexChanged
        chunkyChocLabel.Text = String.Empty
        macadamiaLabel.Text = String.Empty
        peanutButLabel.Text = String.Empty
        snickerLabel.Text = String.Empty
        sugarLabel.Text = String.Empty
    End Sub
End Class
