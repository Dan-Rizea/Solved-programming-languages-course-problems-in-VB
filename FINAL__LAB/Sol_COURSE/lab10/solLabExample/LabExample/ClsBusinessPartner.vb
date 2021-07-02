Public Class ClsBusinessPartner
    Protected PartnerID As Byte
    Protected PartnerName As String
    Protected PartnerType As String
    Private Shared NoOfID As Byte

    Public colContracts As New ArrayList

    Public Function nbContract(pDuration1 As Byte, pDuration2 As Byte) As Byte
        Dim nb As Byte
        For Each c As clsContract In colContracts
            If c.pDuration >= pDuration1 And c.pDuration <= pDuration2 And
                c.pDate.Month = 4 And
                c.pDate.Year = 2015 Then
                nb += 1
            End If
        Next
        Return nb
    End Function

    Public Function minAmountContract() As Decimal
        Dim min As Decimal
        Dim colCurrentYear As New ArrayList
        For Each c As clsContract In colContracts
            If c.pDate.Year = Today.Year Then colCurrentYear.Add(c)
        Next
        If colCurrentYear.Count > 0 Then
            Dim c As clsContract = colCurrentYear(0)
            min = c.amount
            For Each c In colCurrentYear
                If c.amount <= min Then min = c.amount
            Next
            Return min
        Else
            Return 0
        End If
    End Function

    Public Function totalAmount(pEndDate As Date) As Decimal
        Dim total As Decimal
        For Each c As clsContract In colContracts
            'If c.EndDate = pEndDate Then total += c.amount
            Dim d As Date
            c.subEndDate(d)
            If d = pEndDate Then total += c.amount
        Next
        Return total
    End Function

    Public Function maxDuration() As clsContract
        Dim objContract As New clsContract

        For Each c As clsContract In colContracts
            If c.pDuration >= objContract.pDuration Then objContract = c
        Next
        If colContracts.Count > 0 Then
            Return objContract
        Else
            Return Nothing
        End If
    End Function

    Public Function maxDuration2() As ArrayList
        Dim col2 As New ArrayList
        Dim max As Byte
        For Each c As clsContract In colContracts
            If c.pDuration >= max Then max = c.pDuration
        Next
        For Each c As clsContract In colContracts
            If c.pDuration = max Then col2.Add(c)
        Next
        Return col2
    End Function

    Public Function task1_Contracts() As Integer
        Dim no As Integer
        For Each c As clsContract In colContracts
            If c.pDate.Month = Today.Month And c.pDate.Year = Today.Year Then
                no += 1
            End If
        Next
        Return no
    End Function

    Public Function task2_Contracts(pNoYears As Byte) As Single
        Dim sum As Single, no As Integer
        Dim count As Integer = colContracts.Count
        For i As Integer = 0 To count - 1
            Dim c As clsContract = colContracts(i)
            If c.pDate >= Today.AddYears(-pNoYears) Then
                sum += c.amount
                no += 1
            End If
        Next
        If no > 0 Then
            Return sum / no
        Else
            Return 0
        End If

    End Function

    Public Sub New()
        NoOfID += 1
        PartnerID = NoOfID
        Me.pPartnerName = "unknown"
        Me.pPartnerType = "company"
    End Sub
    Public Sub New(p_partnerName As String, p_partnerType As String)
        NoOfID += 1
        PartnerID = NoOfID
        Me.pPartnerName = p_partnerName
        Me.pPartnerType = p_partnerType
    End Sub

    Public Property pPartnerName As String
        Get
            Return PartnerName
        End Get
        Set(value As String)
            If Len(value) >= 3 Then
                PartnerName = value
            Else
                'MsgBox("Invalid partner name")
                Throw New Exception("Invalid partner name")
            End If
        End Set
    End Property
    Public Property pPartnerType As String
        Get
            Return PartnerType
        End Get
        Set(value As String)
            If LCase(value) = "company" Or LCase(value) = "person" Then
                PartnerType = value
            Else
                'MsgBox("Invalid Partner type")
                Throw New Exception("Invalid Partner type")
            End If
        End Set
    End Property
    Public ReadOnly Property pPartnerID As Byte
        Get
            Return PartnerType
        End Get
    End Property
End Class
