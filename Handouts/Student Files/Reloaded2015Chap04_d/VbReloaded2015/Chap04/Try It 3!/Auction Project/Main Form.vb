' Project name:         Auction Project
' Project purpose:      Display the lowest and highest bids
' Created/revised by:   <your name> on <current date>

Option Explicit Off
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays the lowest and highest bids

        Dim bid1 As Integer
        Dim bid2 As Integer

        Integer.TryParse(bid1TextBox.Text, bid1)
        Integer.TryParse(bid2TextBox.Text, bid2)

        ' if necessary, swap bids
        If bid1 > bid2 Then
            Dim temp As Integer
            temp = bid1
            bid1 = bid2
            bid2 = temp
        End If
        bidsLabel.Text = "Lowest bid: $" & bid1.ToString("N0") &
            ControlChars.NewLine & "Highest bid: $" & bid2.ToString("N0")
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class

