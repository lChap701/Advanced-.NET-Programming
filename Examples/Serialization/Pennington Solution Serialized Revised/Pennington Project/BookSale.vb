' Class filename:       Pennington.vb
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

'Serializable is required in order to serialize objects of this class
<Serializable>
Public Class BookSale
    Private _quantity As Integer
    Private _price As Decimal
    Private _totalDue As Decimal

    Public Property Quantity As Integer
        Get
            Return _quantity
        End Get
        Set(value As Integer)
            _quantity = value
        End Set
    End Property

    Public Property Price As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = value
        End Set
    End Property

    Public Property TotalDue As Decimal
        Get
            Return _totalDue
        End Get
        Set(value As Decimal)
            _totalDue = value
        End Set
    End Property

    Public Sub New()
        _quantity = 0
        _price = 0D
        _totalDue = 0D
    End Sub

    Public Sub CalculateTotalDue()
        Dim sale As Decimal
        sale = _quantity * _price
        _totalDue += sale
    End Sub
End Class
