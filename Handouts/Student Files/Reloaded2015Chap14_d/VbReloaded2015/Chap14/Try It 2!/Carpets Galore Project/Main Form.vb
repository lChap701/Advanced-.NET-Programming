' Project name:         Carpets Galore Project
' Project purpose:      Displays the number of square yards of carpet and the cost of the carpet
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' displays square yards and cost of carpet

        ' instantiate a Rectangle object
        Dim floor As New Rectangle

        ' declare variables
        Dim priceSqYd As Double
        Dim sqYards As Double
        Dim cost As Double

        ' assign values
        Double.TryParse(lengthListBox.SelectedItem.ToString, floor.Length)
        Double.TryParse(widthListBox.SelectedItem.ToString, floor.Width)
        Double.TryParse(priceListBox.SelectedItem.ToString, priceSqYd)

        ' calculate the square yards
        sqYards = floor.GetArea / 9
        ' calculate the carpet cost
        cost = priceSqYd * sqYards
        ' display output
        sqYardsLabel.Text = sqYards.ToString("N1")
        costLabel.Text = cost.ToString("C2")
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles lengthListBox.SelectedValueChanged,
        widthListBox.SelectedValueChanged, priceListBox.SelectedValueChanged
        sqYardsLabel.Text = String.Empty
        costLabel.Text = String.Empty
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list boxes with data and then selects a default item

        For nums As Double = 4 To 30 Step 0.5
            lengthListBox.Items.Add(nums.ToString("N1"))
            widthListBox.Items.Add(nums.ToString("N1"))
        Next nums

        For prices As Double = 5 To 25 Step 0.5
            priceListBox.Items.Add(prices.ToString("N2"))
        Next prices

        lengthListBox.SelectedItem = "10.0"
        widthListBox.SelectedItem = "10.0"
        priceListBox.SelectedItem = "8.00"
    End Sub
End Class
