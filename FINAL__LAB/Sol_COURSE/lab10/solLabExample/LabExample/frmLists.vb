Public Class frmLists
    Dim arrPartner() As ClsBusinessPartner
    Dim colProducts As New ArrayList
    Dim colInvoice As New ArrayList

    Private Sub btnNewPartner_Click(sender As Object, e As EventArgs) Handles btnNewPartner.Click
        Try
            If arrPartner Is Nothing Then
                ReDim arrPartner(0)
            Else
                Dim indexPartner As Byte = arrPartner.GetUpperBound(0) + 1
                ReDim Preserve arrPartner(indexPartner)

            End If
            Dim index As Byte = arrPartner.GetLength(0) - 1
            Dim objP As New ClsBusinessPartner(InputBox("Partner name "),
                                               InputBox("Partner type"))

            arrPartner(index) = objP
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'all partners of a certain type
        If arrPartner Is Nothing Then
            MsgBox("No partner data")
        Else
            Dim partnertype As String = InputBox("Partner type: ", "", "person")
            Dim countpartner As Byte

            For Each objPartner As ClsBusinessPartner In arrPartner
                If objPartner.pPartnerType = partnertype Then
                    countpartner += 1
                End If
            Next
            MsgBox("Nr of partners = " & countpartner)
        End If
    End Sub

    Private Sub btnNewProduct_Click(sender As Object, e As EventArgs) Handles btnNewProduct.Click
        Dim p As New clsProduct
        With p
            .pproductID = InputBox("Product ID")
            .productName = InputBox("Product name")
            .productType = InputBox("Product type")
            .pProductPrice = InputBox("Product price")
        End With
        colProducts.Add(p)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'the average price for all products of a certain type
        If colProducts.Count = 0 Then
            MsgBox("No products available")
        Else
            Dim index As Byte, total As Single
            Dim pType As String = InputBox("Product type: ")
            Dim nr As Byte
            Do
                Dim currentProduct As clsProduct = colProducts(index)
                If pType = currentProduct.productType Then
                    total += currentProduct.pProductPrice
                    nr += 1
                End If
                index += 1
            Loop While index < colProducts.Count
            If nr = 0 Then
                MsgBox("No matching products")
            Else
                MsgBox("Average price= " & total / nr)
            End If

        End If
    End Sub

    Private Sub btnNewInvoice_Click(sender As Object, e As EventArgs) Handles btnNewInvoice.Click
        Dim invoice As New clsInvoice(InputBox("Invoice date"),
                                      InputBox("Invoice type"),
                                      "", InputBox("Payment method"),
                                       InputBox("Days to due date"))
        Dim partnerid As Byte = InputBox("Partner id")
        Dim Productid As Byte = InputBox("Product id")
        Dim found As Boolean = False
        For Each p As clsProduct In colProducts
            If p.pproductID = Productid Then
                invoice.product = p
                found = True
                Exit For
            End If
        Next
        If found = False Then
            MsgBox("No such product")
        End If
        found = False
        For Each p As ClsBusinessPartner In arrPartner
            If p.pPartnerID = partnerid Then
                invoice.partner = p
                found = True
                Exit For
            End If
        Next
        If found = False Then
            MsgBox("No such partner")
        End If
        colInvoice.Add(invoice)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If colProducts.Count = 0 Then
            MsgBox("No products")
        Else
            Dim index1 As Byte
            Dim count As Single
            Do
                Dim hom1 As clsProduct = colProducts(index1)
                If hom1.pProductPrice >= 100 And
                    hom1.pProductPrice <= 500 Then
                    count += 1
                End If
                index1 += 1
            Loop While index1 < colProducts.Count
            MsgBox("Nr of products: " & count)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If colInvoice.Count = 0 Then
            MsgBox("No invoice")
        Else
            Dim count As Byte
            Dim index2 As Byte
            For index2 = 0 To colInvoice.Count - 1
                Dim hom2 As clsInvoice = colInvoice(index2)
                If (Month(hom2.GetInvoiceDate) = 5 Or
                    Month(hom2.GetInvoiceDate) = 1) And
                    Year(hom2.GetInvoiceDate) = Year(Today()) Then
                    count += 1
                End If

            Next
            MsgBox("Nr of invoices :" & count)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If colInvoice.Count = 0 Then
            MsgBox("No invoices")
        Else
            Dim count As Byte
            For Each hom3 As clsInvoice In colInvoice
                If hom3.DueDate = Today() And
                  LCase(hom3.pPayment) = "bank" Then
                    count += 1
                End If
            Next
            MsgBox("Nr of invoices: " & count)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If colInvoice.Count = 0 Then
            MsgBox("No products")
        Else
            Dim id As Byte = InputBox("Porduct id: ")
            Dim max As Single
            For Each i As clsInvoice In colInvoice
                If i.product.pproductID = id And
                    max < i.Quantity Then
                    max = i.Quantity
                End If
            Next
            MsgBox("max of quantity: " & max)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If arrPartner IsNot Nothing Then
            Dim idP As Integer = InputBox("Partner ID")
            For Each p As ClsBusinessPartner In arrPartner
                If p.pPartnerID = idP Then
                    Dim c As New clsContract
                    With c
                        .idContract = InputBox("Id contract")
                        .pDate = InputBox("Date")
                        .pDuration = InputBox("Duration")
                        .amount = InputBox("Amount")
                    End With
                    p.colContracts.Add(c)
                    Exit Sub
                End If
            Next
            MsgBox("Invalid partner ID")
        Else
            MsgBox("No partners")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Not arrPartner Is Nothing Then
            Dim d1 As Byte = InputBox("Duration min")
            Dim d2 As Byte = InputBox("Duration max")
            Dim no As Integer
            For Each p As ClsBusinessPartner In arrPartner
                no += p.nbContract(d1, d2)
            Next
            MsgBox("Total no contracts = " & no)
        Else
            MsgBox("No partners -> no contracts")
        End If
    End Sub
End Class