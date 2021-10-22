' Project name:         Debug Project
' Project purpose:      Displays the city name included in an address
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub addressTextBox_Enter(sender As Object, e As EventArgs) Handles addressTextBox.Enter
        addressTextBox.SelectAll()
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the city name

        Const Prompt As String = "Please enter a city name followed by a comma, a space, and a state name."
        Dim address As String
        Dim city As String
        Dim index As Integer

        address = addressTextBox.Text

        ' find the comma
        index = address.IndexOf(",")

        If index <> -1 Then
            ' if the address contains a comma, assign the city name to the city variable,
            ' then display the city name; otherwise, display an appropriate message
            city = address.Substring(index, address.Length - 1)
            MessageBox.Show(city, "City Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(Prompt, "City Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        addressTextBox.Focus()
    End Sub
End Class
