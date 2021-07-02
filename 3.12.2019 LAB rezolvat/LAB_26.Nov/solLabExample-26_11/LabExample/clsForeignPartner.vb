Public Class clsForeignPartner
    Inherits clsPartner
    Private Currency As String ' eur/usd/chf
    Private ExchangeRate As Single ' <6 non negative values

    Public Sub New(p_Type As String, p_Name As String,
                   p_Currency As String, p_ExchangeRate As Single)
        MyBase.New(p_Type, p_Name)
        Me.pCurrency = p_Currency
        Me.pExchangeRate = p_ExchangeRate
    End Sub

    Public Function PartnerDetails() As String
        Dim Detail As String = "ID= " & Me.PartnerID & vbCrLf &
                               "Name= " & Me.pName & vbCrLf &
                               "Type= " & Me.pType & vbCrLf &
                               "Currency= " & Me.Currency
        Return Detail
    End Function

    Public Property pCurrency As String
        Get
            Return Currency
        End Get
        Set(value As String)
            If LCase(value) = "eur" Or
               LCase(value) = "usd" Or
               LCase(value) = "chf" Then
                Currency = value
            End If
        End Set
    End Property

    Public Property pExchangeRate As Single
        Set(value As Single)
            If Len(value) < 6 And Len(value) > 0 Then
                ExchangeRate = value
            End If
        End Set
        Get
            Return ExchangeRate
        End Get
    End Property
End Class
