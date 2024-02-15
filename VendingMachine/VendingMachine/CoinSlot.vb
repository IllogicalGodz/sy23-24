Imports System.Data.OleDb
Public Class CoinSlot
    Public Event coinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer)
    Public Event buyevent(p As Image)
    Public Property Nickels As Integer
    Public Property Quarters As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Dim _Total As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            _Total = Dollars + Quarters * 0.25 + Dimes * 0.1 + Nickels * 0.5
            Return _Total
        End Get
    End Property
    Public Sub CoinReturn()
        RaiseEvent coinReturnEvent(Dollars, Quarters, Dimes, Nickels)
        Quarters = 0
        Dimes = 0
        Dollars = 0
        Nickels = 0
    End Sub
    Public Sub InsetNickels()
        Nickels = Nickels + 1
    End Sub
    Public Sub InsetQuarter()
        Quarters = Quarters + 1
    End Sub
    Public Sub InsetDimes()
        Dimes = Dimes + 1
    End Sub
    Public Sub InsetDollar()
        Dollars = Dollars + 1
    End Sub
    Public Sub buy(p As productControl)
        If p.ProductCount > 0 And p.ProductPrice <= _Total Then
            p.buy()
            _Total = _Total - p.ProductPrice
            Quarters = 0
            Dollars = 0
            Dimes = 0
            Nickels = _Total / 0.05
            RaiseEvent buyevent(p.ProductPicture)
        End If
    End Sub
End Class
