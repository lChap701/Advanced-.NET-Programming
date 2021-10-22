' Project name:         City Project
' Project purpose:      Displays the city and state names in a list box
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Structure CityStateInfo
        Public city As String
        Public state As String
    End Structure

    ' declare array of structure variables
    Private citiesStates(6) As CityStateInfo

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill array with IDs and prices

        citiesStates(0).city = "Augusta"
        citiesStates(0).state = "GA"
        citiesStates(1).city = "Wichita"
        citiesStates(1).state = "KS"
        citiesStates(2).city = "New Orleans"
        citiesStates(2).state = "LA"
        citiesStates(3).city = "Salem"
        citiesStates(3).state = "OR"
        citiesStates(4).city = "Roswell"
        citiesStates(4).state = "NM"
        citiesStates(5).city = "Oak Hill"
        citiesStates(5).state = "WV"
        citiesStates(6).city = "Minot"
        citiesStates(6).state = "ND"
    End Sub

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        ' displays city and state names


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
End Class
