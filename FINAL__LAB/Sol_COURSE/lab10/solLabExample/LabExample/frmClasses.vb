Public Class frmClasses
    Dim objInvoice As clsInvoice
    Const title As String = "Invoice data"

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        objInvoice = New clsInvoice
        With objInvoice
            If MsgBox("Default invoice data?",
                  MsgBoxStyle.YesNo,
                  title) = MsgBoxResult.No Then
                '.invoiceDate = InputBox("Invoice date", title, Today())
                .setInvoiceDate(InputBox("Invoice date"))
                .partner.pPartnerName = InputBox("Partner name", title)
                .partner.pPartnerType = InputBox("Partner type")
                .setInvoiceType(InputBox("Invoice type", title, "sell"))
                .pPayment = InputBox("payment method", title, "cash")
                .pDaysToDueDate = InputBox("days to due date", title, 60)
                .product.pproductID = InputBox("Product id")
                .product.productName = InputBox("Product name")
                .product.pProductPrice = InputBox("Product price")
                .Quantity = InputBox("Product quantity")

            Else
                MsgBox("New invoice created")
            End If
        End With
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If objInvoice Is Nothing Then
            MsgBox("No invoice available")
        Else
            With objInvoice
                MsgBox("Invoice number " & .pInvoiceNo & vbCrLf &
                     "Invoice date " & FormatDateTime(.GetInvoiceDate,
                                   DateFormat.ShortDate) & vbCrLf &
                   "Due Date " & FormatDateTime(.DueDate, DateFormat.ShortDate) & vbCrLf &
                   "Customer/Supplier " & .partner.pPartnerName & vbCrLf &
                   "Invoice type " & .GetInvoiceType() & vbCrLf &
                   "payment " & .pPayment & vbCrLf &
                   "product name " & .product.productName & vbCrLf &
                   "Invoice amount " & .InvoiceAmount)

            End With
        End If


    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim I1 As New clsInvoice(InputBox("Date", "", Today()),
                     InputBox("Type", "", "sell"),
                    InputBox("partner"),
                     InputBox("payment", "", "cash"),
                       InputBox("Days to due date"))

        With I1
            MsgBox("Invoice number " & .pInvoiceNo & vbCrLf &
                 "Invoice date " & FormatDateTime(.GetInvoiceDate,
                               DateFormat.ShortDate) & vbCrLf &
               "Due Date " & FormatDateTime(.DueDate, DateFormat.ShortDate) & vbCrLf &
               "Customer/Supplier " & .partner.pPartnerName & vbCrLf &
               "Invoice type " & .GetInvoiceType() & vbCrLf &
               "payment " & .pPayment)

        End With





    End Sub
    Dim objPartner As ClsBusinessPartner
    Dim objFPartner As clsForeignPartner
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objPartner = New ClsBusinessPartner(InputBox("Name"),
                                             InputBox("Type",, "company"))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        objFPartner = New clsForeignPartner()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If objPartner IsNot Nothing Then
            MsgBox("ID=" & objPartner.pPartnerID & vbCrLf &
                   "Name=" & objPartner.pPartnerName)
        Else
            MsgBox("No partner data")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If objFPartner Is Nothing Then
            MsgBox("No foreign partner")
        Else
            MsgBox(objFPartner.PartnerDetails & vbCrLf &
                   "ID=" & objFPartner.pPartnerID)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Sum As Single
        Dim count As Byte
        Do
            Dim objProduct As New clsProduct
            objProduct.productName = InputBox("Product name")
            objProduct.pProductPrice = InputBox("Product price")
            'If objProduct.productType = "food" Then
            Sum += objProduct.pProductPrice
                count += 1
            'End If

        Loop While MsgBox("More products?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes
        MsgBox("Avg price = " & Sum / count)
    End Sub
End Class