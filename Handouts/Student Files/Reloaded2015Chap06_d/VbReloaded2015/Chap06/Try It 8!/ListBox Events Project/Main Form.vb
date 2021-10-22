' Project name:         ListBox Events Project
' Project purpose:      Examples of the SelectedValueChanged and SelectedIndexChanged events
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' add items to the regionsListBox
        Dim region As Integer = 1
        Do While region <= 4
            regionsListBox.Items.Add(region.ToString)
            region += 1
        Loop

        ' add items to the titlesListBox
        titlesListBox.Items.Add("CEO")
        titlesListBox.Items.Add("COO")
        titlesListBox.Items.Add("CFO")

        ' select the default list box item
        regionsListBox.SelectedItem = "3"
        titlesListBox.SelectedIndex = 0
    End Sub

    Private Sub regionsListBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles regionsListBox.SelectedValueChanged
        ' displays the shipping charge

        Dim region As String
        region = Convert.ToString(regionsListBox.SelectedItem)

        Select Case region
            Case "1"
                shippingLabel.Text = "$10"
            Case "2"
                shippingLabel.Text = "$12"
            Case "3"
                shippingLabel.Text = "$15"
            Case Else
                shippingLabel.Text = "$20"
        End Select
    End Sub

    Private Sub titlesListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles titlesListBox.SelectedIndexChanged
        ' displays the title

        Select Case titlesListBox.SelectedIndex
            Case 0
                standsForLabel.Text = "Chief Executive Officer"
            Case 1
                standsForLabel.Text = "Chief Operations Officer"
            Case Else
                standsForLabel.Text = "Chief Financial Officer"
        End Select
    End Sub
End Class
