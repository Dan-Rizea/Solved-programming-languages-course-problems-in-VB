Public Class clsProduct
    Public mProductID As Integer 'to be implemented as a public property between 100 and 200
    Public mName As String 'no validation
    Private mProductType As String 'food, healthcare 
    Public mPrice As Decimal 'positive values 
    Private mUM As String
    Public Function vatRATE()
        Select Case LCase(pProductType)
            Case "food"
                Return 0
            Case "healthcare"
                Return 0.05
            Case "clothing"
                Return 0.2


        End Select

    End Function
    Public Function calcPrice()
        Dim price As Decimal = (1 + vatRATE()) * mPrice
        Return price

    End Function

    Public Property pProductType As String
        Get
            Return mProductType

        End Get
        Set(value As String)
            If LCase(value) = "food" Or
                    LCase(value) = "healthcare" Or
                LCase(value) = "clothing" Then
                mProductType = value
            Else
                MsgBox("error invalid product type")
            End If
        End Set
    End Property

    Public Property pUM As String
        Get
            Return mUM
        End Get
        Set(value As String)
            If LCase(value) = "kilo" Or
                    LCase(value) = "piece" Then
                mUM = value
            Else
                MsgBox("invalid unit of measurement")

            End If

        End Set
    End Property



End Class
