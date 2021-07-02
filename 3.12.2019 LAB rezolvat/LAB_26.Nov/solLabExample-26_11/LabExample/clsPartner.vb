Public Class clsPartner
    Protected PartnerID As Integer
    Protected PartnerType As String
    Protected PartnerName As String
    Public Shared NoOfID As Integer

    Public Sub New(p_Type As String, p_Name As String)
        NoOfID += 1
        PartnerID = NoOfID
        Me.pName = p_Name
        Me.pType = p_Type
    End Sub

    Public Property pName As String
        Set(value As String)
            If Len(value) >= 3 Then
                PartnerName = value
            End If
        End Set
        Get
            Return PartnerName
        End Get
    End Property

    Public Property pType As String
        Set(value As String)
            If value = "Company" Or value = "Person" Then
                PartnerName = value
            End If
        End Set
        Get
            Return PartnerName
        End Get
    End Property

End Class
