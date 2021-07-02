Public Class clsInvoice
    Private invoiceNo As Short
    Private invoiceDate As Date
    Private invoiceType As String
    Public partner As New ClsBusinessPartner
    Private payment As String  ' cash / bank
    Private daysToDueDate As Byte ' no more than 60 days
    Private Shared NoOfInvoices As Short
    Public product As New clsProduct
    Public Quantity As Single
    Public Function InvoiceAmount() As Single
        Return Quantity * product.SellingPrice
    End Function
    Public Function DueDate() As Date
        Return DateAdd(DateInterval.Day, daysToDueDate, invoiceDate)
    End Function
    Public Sub New(p_Date As Date, p_Type As String, p_partner As String,
                   p_payment As String, p_DaysToDueDate As Byte)
        'partner = p_partner
        Me.setInvoiceDate(p_Date)
        Me.setInvoiceType(p_Type)
        Me.pPayment = p_payment
        Me.pDaysToDueDate = p_DaysToDueDate
        NoOfInvoices += 1
        invoiceNo = NoOfInvoices
        ' product = New clsProduct
    End Sub
    Public Sub New()
        NoOfInvoices += 1
        invoiceNo = NoOfInvoices
        invoiceDate = Today
        ' product = New clsProduct
    End Sub
    Public ReadOnly Property pInvoiceNo As Short
        Get
            Return invoiceNo
        End Get
    End Property
    Public Property pDaysToDueDate As Byte
        Set(value As Byte)
            If value <= 60 Then
                daysToDueDate = value
            Else
                'MsgBox("no more than 60 days")
                Throw New Exception("no more than 60 days")
            End If
        End Set
        Get
            Return daysToDueDate
        End Get
    End Property
    Public Property pPayment As String
        Get
            Return payment
        End Get
        Set(value As String)
            If LCase(value) = "cash" Or LCase(value) = "bank" Then
                payment = value
            Else
                'MsgBox("invalid payment method")
                Throw New Exception("invalid payment method")
            End If

        End Set
    End Property
    Public Sub setInvoiceType(pType As String)
        If pType = "sell" Or pType = "buy" Then
            invoiceType = pType
        Else
            'MsgBox("Invalid invoice type")
            Throw New Exception("Invalid invoice type")
        End If
    End Sub
    Public Function GetInvoiceType() As String
        Return invoiceType
    End Function
    Public Sub setInvoiceDate(pDate As Date)
        If pDate <= Today() Then
            invoiceDate = pDate
        Else
            'MsgBox("Invalid invoice date")
            Throw New Exception("Invalid invoice type")
        End If
    End Sub
    Public Function GetInvoiceDate() As Date
        Return invoiceDate
    End Function
End Class
