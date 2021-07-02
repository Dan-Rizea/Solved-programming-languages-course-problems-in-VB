Public Class clsProduct
    Private productID As Byte
    Public productName As String
    Public productUM As String    'implement as property - kilo, piece...
    Private productPrice As Decimal
    Public productType As String 'implement as property - food, clothing, etc

    Public Property pproductID As Byte
        Get
            Return productID
        End Get
        Set(value As Byte)
            If value >= 100 And value <= 200 Then
                productID = value
            Else
                'MsgBox("Invalid productID")
                Throw New Exception("Invalid productID")
            End If
        End Set
    End Property
    Public Property pProductPrice As Decimal
        Get
            Return productPrice
        End Get
        Set(value As Decimal)
            If value > 0 Then
                productPrice = value
            Else
                MsgBox("Invalid price")
                Throw New Exception("Invalid price")
            End If
        End Set
    End Property
    Public Function VATrate() As Single
        Select Case LCase(productType)
            Case "food"
                Return 0
            Case "healthcare"
                Return 0.05
            Case Else
                Return 0.2
        End Select
    End Function
    Public Function SellingPrice() As Single
        Return productPrice * (1 + VATrate())
    End Function
End Class
