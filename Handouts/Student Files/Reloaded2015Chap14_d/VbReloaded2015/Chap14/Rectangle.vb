' Class filename:       Rectangle.vb
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class Rectangle
    Private _length As Double
    Private _width As Double

    Public Property Length As Double
        Get
            Return _length
        End Get
        Set(value As Double)
            If value > 0 Then
                _length = value
            Else
                _length = 0
            End If
        End Set
    End Property

    Public Property Width As Double
        Get
            Return _width
        End Get
        Set(value As Double)
            If value > 0 Then
                _width = value
            Else
                _width = 0
            End If
        End Set
    End Property

    Public Sub New()
        _length = 0
        _width = 0
    End Sub

    Public Sub New(ByVal l As Double, ByVal w As Double)
        Length = l
        Width = w
    End Sub

    Public Function GetArea() As Double
        Return _length * _width
    End Function

End Class
