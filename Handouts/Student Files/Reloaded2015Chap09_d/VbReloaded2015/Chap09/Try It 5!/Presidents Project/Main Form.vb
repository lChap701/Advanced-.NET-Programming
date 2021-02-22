' Project name:         Presidents Project
' Project purpose:      Display the name of a president's vice president 
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    ' class-level array
    Private vicePresidents() As String = {"John Adams",
                                          "Richard Nixon",
                                          "Lyndon Johnson",
                                          "George H. W. Bush",
                                          "Joe Biden"}

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill list boxes with names of presidents

        presidentsListBox.Items.Add("George Washington")
        presidentsListBox.Items.Add("Dwight Eisenhower")
        presidentsListBox.Items.Add("John F. Kennedy")
        presidentsListBox.Items.Add("Ronald Reagan")
        presidentsListBox.Items.Add("Barack Obama")
        presidentsListBox.SelectedIndex = 0
    End Sub

    Private Sub presidentsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles presidentsListBox.SelectedIndexChanged
        ' display associated name from vicePresidents array

        Dim subscript As Integer = presidentsListBox.SelectedIndex
        vicePresLabel.Text = vicePresidents(subscript)
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
