' Class filename:       Computer.vb
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class Computer
    Private _id As String
    Private _currentPrice As Decimal

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property CurrentPrice As Decimal
        Get
            Return _currentPrice
        End Get
        Set(value As Decimal)
        End Set
    End Property

    Public Sub New()
        _id = String.Empty
        _currentPrice = 0
    End Sub

    Public Function GetNewPrice(ByVal discountRate As Decimal) As Decimal
        Return _currentPrice - _currentPrice * discountRate
    End Function
End Class
