' Class filename:       Employee.vb
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class Employee
    Public Property EmpNumber As String
    Public Property EmpName As String

    Public Sub New()
        _EmpNumber = String.Empty
        _EmpName = String.Empty
    End Sub

    Public Sub New(ByVal num As String, ByVal name As String)
        EmpNumber = num
        EmpName = name
    End Sub

    Public Function GetGross(ByVal salary As Double) As Double
        ' calculates the gross pay for salaried
        ' employees, who are paid twice per month

        Return salary / 24
    End Function

    Public Function GetGross(ByVal hours As Double,
                             ByVal rate As Double) As Double
        ' calculates the weekly gross pay for hourly employees

        Return hours * rate
    End Function
End Class
