' Project name:         Products Project
' Project purpose:      Search a list box for a product ID and then display the price
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' Searches the list box for the product ID and then 
        ' either selects the ID or deselects any ID and then
        ' displays a message. Selecting or deselecting an ID 
        ' invokes the list box's SelectedIndexChanged event, which 
        ' displays the price.

        Dim isFound As Boolean
        Dim index As Integer
        Dim numItems As Integer
        Dim id As String

        ' assign ID and number of list box items to variables
        id = idTextBox.Text.ToUpper
        numItems = idsListBox.Items.Count

        ' search the list box, stopping either after the 
        ' last item or when the ID is found
        Do While index < numItems AndAlso isFound = False
            If id = idsListBox.Items(index).ToString.ToUpper Then
                isFound = True
            Else
                index += 1
            End If
        Loop

        If isFound = True Then
            idsListBox.SelectedIndex = index
        Else
            idsListBox.SelectedIndex = -1
            MessageBox.Show("ID not found", "Product Finder",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub idsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idsListBox.SelectedIndexChanged
        ' displays the price of the selected ID

        Dim price As Double

        Select Case idsListBox.SelectedIndex
            Case 0   ' AB654
                price = 12.59
            Case 1, 2 ' FX123 and FX457
                price = 14.99
            Case 3 ' JH733
                price = 9.99
            Case 4, 5 ' KVB419 and KYT897
                price = 23.79
            Case 6 To 8 ' NK111, PQR333, and UVP492
                price = 35.99
        End Select
        priceLabel.Text = price.ToString("C2")
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with IDs

        idsListBox.Items.Add("AB654")
        idsListBox.Items.Add("FX123")
        idsListBox.Items.Add("FX457")
        idsListBox.Items.Add("JH733")
        idsListBox.Items.Add("KVB419")
        idsListBox.Items.Add("KYT897")
        idsListBox.Items.Add("NK111")
        idsListBox.Items.Add("PQR333")
        idsListBox.Items.Add("UVP492")
    End Sub
End Class
