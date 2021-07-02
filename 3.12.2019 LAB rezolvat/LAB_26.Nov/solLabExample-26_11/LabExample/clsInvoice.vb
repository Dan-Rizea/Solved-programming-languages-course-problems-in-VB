Option Compare Text
Public Class clsInvoice

    Private InvoiceNb As Integer
    Private InvoiceDate As Date
    Private InvoiceType As String  ' sell/buy
    Public PartnerName As String
    Private payment As String 'cash/bank
    Private daysToDueDate As Byte 'No more than 60 days
    Private Shared NbOfInvoices As Integer

    Public Product As New clsProduct
    Public Quantity As Single 'positive 

    Public Function invoiceAmount() As Single
        Return Quantity * Product.calcPrice
    End Function
    Public Function DueDate() As Date
        Return DateAdd(DateInterval.Day, daysToDueDate, InvoiceDate)
    End Function
    Public Sub New()
        NbOfInvoices += 1
        InvoiceNb = NbOfInvoices
        ' Product = New clsProduct
    End Sub
    Public Sub New(p_Date As Date, p_Type As String, p_Partner As String,
                    p_Payment As String, p_DaysToDueDate As Byte)
        NbOfInvoices += 1
        InvoiceNb = NbOfInvoices
        Call Me.SetInvoiceDate(p_Date)
        Call Me.SetInvoiceType(p_Type)
        Me.pDaysToDueDate = p_DaysToDueDate
        Me.PPayment = p_Payment
        'Product = New clsProduct
    End Sub

    Public ReadOnly Property pInvoiceNb As Integer
        Get
            Return InvoiceNb
        End Get

    End Property

    Public Property pDaysToDueDate As Byte
        Set(value As Byte)
            If value <= 60 Then
                daysToDueDate = value
            Else
                MsgBox("No more than 60 days")
            End If
        End Set
        Get
            Return daysToDueDate
        End Get
    End Property

    Public Property PPayment As String
        Get
            Return payment
        End Get
        Set(value As String)
            If value = "cash" Or value = "bank" Then
                payment = value
            Else
                MsgBox("invalid payment method")

            End If
        End Set
    End Property

    Public Sub SetInvoiceType(pType As String)
        If LCase(pType) = "sell" Or UCase(pType) = "buy" Then
            InvoiceType = pType
        Else
            MsgBox("Invalid invoice type")
        End If
    End Sub

    Public Function GetInvoiceType() As String
        Return LCase(InvoiceType)
    End Function

    Public Sub SetInvoiceDate(pDate As Date)
        If pDate <= Today() Then
            InvoiceDate = pDate
        Else
            MsgBox("Invalid invoice date")
        End If
    End Sub

    Public Function GetInvoiceDate() As Date
        Return InvoiceDate
    End Function



End Class
