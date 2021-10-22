' Project name:         Align Columns Project
' Project purpose:      Examples of aligning columns of information
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub ex1Button_Click(sender As Object, e As EventArgs) Handles ex1Button.Click
        ' right-aligns a list of numbers

        Dim priceOfItem As String
        For price As Double = 9 To 11 Step 0.5
            priceOfItem = price.ToString("N2").PadLeft(5)
            pricesListBox.Items.Add(priceOfItem)
        Next price
    End Sub

    Private Sub ex2Button_Click(sender As Object, e As EventArgs) Handles ex2Button.Click
        ' aligns the second column when the first column 
        ' contains strings with varying lengths

        Dim outFile As IO.StreamWriter
        Dim heading As String =
            "Name" & Strings.Space(11) & "City"
        Dim name As String
        Dim city As String

        outFile = IO.File.CreateText("friends.txt")
        outFile.WriteLine(heading)

        name = InputBox("Enter name:", "Name")
        Do While name <> String.Empty
            city = InputBox("Enter city:", "City")
            outFile.WriteLine(name.PadRight(15) & city)
            name = InputBox("Enter name:", "Name")
        Loop
        outFile.Close()
        MessageBox.Show("Names and cities written to file.",
                        "Example 2", MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
End Class
