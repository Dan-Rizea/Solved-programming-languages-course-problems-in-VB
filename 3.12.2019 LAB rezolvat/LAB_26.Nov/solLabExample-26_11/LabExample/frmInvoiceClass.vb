Public Class frmInvoiceClass

    Dim noBetweenProduct As Integer
    Dim invoicesBetween As Integer
    Dim totalToBePaid As Integer
    Dim partnerType1 As Integer
    Dim partnerType2 As Integer
    Dim sellInvoices(2999) As Integer
    Private Sub btnClasses_Click(sender As Object, e As EventArgs) Handles btnClasses.Click
        Dim objInvoice As New clsInvoice(InputBox("Date"),
                                         InputBox("Invoice type"),
                                         InputBox("Partner"),
                                         InputBox("Payment"),
                                         InputBox("Days to due date")
                                         )

        objInvoice.SetInvoiceDate(InputBox("Invoice date", , Today()))
        With obj_Invoice
            MsgBox("Invoice Number= " & .pInvoiceNb & vbCrLf &
                    "Partner name= " & .PartnerName & vbCrLf &
               "Invoice date= " & FormatDateTime(.GetInvoiceDate,
                                                 DateFormat.ShortDate) & vbCrLf &
               "Invoice type= " & .GetInvoiceType & vbCrLf &
               "payment = " & .PPayment & vbCrLf &
               "Due Date = " & .DueDate)
        End With
    End Sub

    Dim obj_Invoice As clsInvoice
    Const TITLE As String = "Invoice Data"

    Private Sub btnNewData_Click(sender As Object, e As EventArgs) Handles btnNewData.Click
        obj_Invoice = New clsInvoice
        With obj_Invoice
            If MsgBox("Defaul values for the new invoice?",
                              MsgBoxStyle.YesNo, TITLE) = MsgBoxResult.No Then
                .PartnerName = InputBox("Partner name?", TITLE)
                .SetInvoiceDate(InputBox("What is the date of the invoice?",
                                        TITLE, Today()))
                .SetInvoiceType(InputBox("Invoice type", TITLE, "sell"))
                .PPayment = InputBox("payment method", TITLE, "cash")
                .pDaysToDueDate = InputBox("days to due date", TITLE, 10)
                .Product.mName = InputBox("product name")
                .Product.mPrice = InputBox("product price")
                .Product.pProductType = InputBox("product type")
                If (Month(.GetInvoiceDate) = 1 Or Month(.GetInvoiceDate) = 5) And Year(.GetInvoiceDate) = Year(Today) Then
                    invoicesBetween += 1
                End If
                If .pDaysToDueDate = 0 And LCase(.PPayment) = "bank" Then
                    totalToBePaid += .Product.mPrice
                End If
                If .GetInvoiceType = "sell" Then
                    sellInvoices(Year(.GetInvoiceDate) - 1) += 1
                End If
            End If
        End With
    End Sub

    Private Sub btnDisplayData_Click(sender As Object, e As EventArgs) Handles btnDisplayData.Click
        If obj_Invoice Is Nothing Then
            MsgBox("No invoice available")
        Else
            With obj_Invoice
                MsgBox("Invoice Number= " & .pInvoiceNb & vbCrLf &
                    "Partner name= " & .PartnerName & vbCrLf &
               "Invoice date= " & FormatDateTime(.GetInvoiceDate,
                                                 DateFormat.ShortDate) & vbCrLf &
               "Invoice type= " & .GetInvoiceType & vbCrLf &
               "payment = " & .PPayment & vbCrLf &
               "Due Date = " & .DueDate & vbCrLf &
               "Product name= " & .Product.mName & vbCrLf &
               "invoice amount= " & .invoiceAmount)
            End With
        End If
    End Sub

    Dim objPartner As clsPartner
    Dim objFPartner As clsForeignPartner

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With objPartner
            InputBox("Partner Name")
            Dim PT As String = InputBox("Partner Type")
            If PT = "person" Then
                partnerType1 += 1
            ElseIf PT = "company" Then
                partnerType2 += 1
            End If
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If objPartner IsNot Nothing Then
            MsgBox("Name= " & objPartner.pName)
        Else
            MsgBox("No partner available")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        objFPartner = New clsForeignPartner(InputBox("Type= "),
                                            InputBox("Name"),
                                            "usd",
                                            5.5)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If objFPartner Is Nothing Then
            MsgBox("No foreign partner")
        Else
            MsgBox(objFPartner.PartnerDetails)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sum As Single
        Dim count As Byte
        Do
            Dim objProduct As New clsProduct
            With objProduct
                .mName = InputBox("product name")
                .mPrice = InputBox("product price")
                .pProductType = InputBox("product type")
                If LCase(.pProductType) = "food" Then
                    sum += .mPrice
                    count += 1
                End If
                If .mPrice >= 100 And .mPrice <= 500 Then
                    NoBetweenProduct += 1
                End If

            End With
        Loop Until MsgBox("More products?", MsgBoxStyle.YesNo) = MsgBoxResult.No
        If count > 0 Then
            Dim average As Single = sum / count
            MsgBox("average price= " & average)
        Else
            MsgBox("no food products")
        End If

    End Sub

    Private Sub btnBetweenPrice_Click(sender As Object, e As EventArgs) Handles btnBetweenPrice.Click
        MsgBox("Number = " & noBetweenProduct)
    End Sub

    Private Sub btnNoInvoices_Click(sender As Object, e As EventArgs) Handles btnNoInvoices.Click
        MsgBox("Invoices between = " & invoicesBetween)
    End Sub

    Private Sub btnTotalPaid_Click(sender As Object, e As EventArgs) Handles btnTotalPaid.Click
        MsgBox("Total to be paid = " & totalToBePaid)
    End Sub

    Private Sub btnBusinessPartners_Click(sender As Object, e As EventArgs) Handles btnBusinessPartners.Click
        Dim businessPartnerInput As String = InputBox("Type of business partner = ")
        If businessPartnerInput = "person" Then
            MsgBox("Number of persons = " & partnerType1)
        ElseIf businessPartnerInput = "company" Then
            MsgBox("Number of companies = " & partnerType2)
        Else MsgBox("Not a valid input")
        End If
    End Sub

    Private Sub btnSellInvoices_Click(sender As Object, e As EventArgs) Handles btnSellInvoices.Click
        Dim sellingYear As Integer = InputBox("Insert the year of the invoices")
        MsgBox("The number of invoices sold in " & sellingYear & " is " & sellInvoices(sellingYear - 1))
    End Sub
End Class