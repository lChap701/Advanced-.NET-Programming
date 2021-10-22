' Project name:	        ImageList Project
' Project purpose:      Example of using an ImageList control
' Created/revised by:	<your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub jumpButton_Click(sender As Object, e As EventArgs) Handles jumpButton.Click
        ' view images, one at a time

        Dim numImages As Integer = ImageList1.Images.Count

        For index As Integer = 0 To numImages - 1
            jumpPictureBox.Image = ImageList1.Images.Item(index)
            Me.Refresh()
            System.Threading.Thread.Sleep(500)
        Next index
        jumpPictureBox.Image = ImageList1.Images.Item(0)
    End Sub
End Class
