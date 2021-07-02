Public Class clsContract
    Public idContract As Integer
    Private contractDate As Date
    Public amount As Single
    Private duration As Byte

    Public Property pDate As Date
        Get
            Return contractDate
        End Get
        Set(value As Date)
            If value <= Date.Today And value > CDate("4/7/2014") Then
                contractDate = value
            Else
                Throw New Exception("Invalid date")
            End If
        End Set
    End Property

    Public Property pDuration As Byte
        Set(value As Byte)
            If value <= 24 And value > 0 Then
                duration = value
            Else
                Throw New Exception("invalid duration...")
            End If
        End Set
        Get
            Return duration
        End Get
    End Property

    Public Function EndDate() As Date
        Return Me.contractDate.AddMonths(Me.duration)
    End Function

    Public Sub subEndDate(ByRef pResult As Date)
        pResult = Me.contractDate.AddMonths(Me.duration)
    End Sub






End Class
