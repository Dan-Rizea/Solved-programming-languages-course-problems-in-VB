Public Class clsForeignPartner
    Inherits ClsBusinessPartner

    Private Currency As String 'euro, dolar, franc elvetian
    Private ExchangeRate As Single ' <=6
    Public Sub New()
        MyBase.New("unknown", "person")
        pCurrency = "eur"
        pExchangeRate = 5
    End Sub
    Public Property pCurrency As String
        Get
            Return Currency
        End Get
        Set(value As String)
            If LCase(value) = "eur" Or LCase(value) = "usd" Or
                LCase(value) = "chf" Then
                Currency = value
            Else
                MsgBox("Invalid Currency")
            End If
        End Set
    End Property

    Public Property pExchangeRate As Single
        Get
            Return ExchangeRate
        End Get
        Set(value As Single)
            If value <= 6 Then
                ExchangeRate = value
            Else
                MsgBox("Invalid ex rate")
            End If
        End Set
    End Property
    Public Function PartnerDetails() As String
        Dim result As String = "name:" & Me.PartnerName & vbCrLf &
                                 "type:" & Me.PartnerType & vbCrLf &
                                 "currency:" & Me.Currency
        Return result
    End Function


End Class
