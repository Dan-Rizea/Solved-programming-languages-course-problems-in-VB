Public Class frmInvoice
    Const StandardVAT As Single = 0.19
    Dim ActualVAT As Single = StandardVAT
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsNumeric(Me.txtPrice.Text) And
            IsNumeric(Me.txtQuantity.Text) And
            IsNumeric(Me.txtInvoiceNo.Text) And
            Len(Me.txtCustomer.Text) >= 3 And
            Len(Me.txtProductName.Text) >= 3 And
                Me.cboProductType.SelectedIndex >= 0 And
                Me.cboUM.SelectedIndex >= 0 And
                Now() > Me.dtpInvoiceDate.Value Then


            Dim amount As Single = (Me.txtPrice.Text *
                                              Me.txtQuantity.Text)

            '(1 + If(Me.chkVAT.Checked = True, 0.19, 0)), 2)
            Dim discountRate As Single
            If amount < 100 Then
                discountRate = 0
            ElseIf amount >= 100 And amount <= 300 Then
                discountRate = 0.1
            ElseIf amount <= 1000 Then
                discountRate = 0.2
            ElseIf amount <= 5000 Then
                discountRate = 0.25
            Else
                discountRate = 0.3
            End If
            amount = amount * (1 - discountRate)

            Dim VAT As Single = amount * If(Me.chkVAT.Checked = True, ActualVAT, 0)
            Me.txtAmount.Text = FormatNumber(amount + VAT, 2)
            Me.txtvatamount.Text = FormatNumber(VAT, 2)


        Else
            MsgBox("eroare",, "Eroare!")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.txtAmount.Text = ""
        Me.txtCustomer.Text = ""
        Me.txtInvoiceNo.Text = ""
        Me.txtPrice.Text = ""
        Me.txtProductName.Text = ""
        Me.txtQuantity.Text = ""
        Me.txtvatamount.Text = ""
        Me.cboProductType.SelectedIndex = -1 'nothing selected
        Me.cboUM.SelectedIndex = -1 'nothing selected
        Me.dtpInvoiceDate.Value = Today()
        Me.chkVAT.Checked = False
        Me.radPerson.Checked = True
        Me.radRomanian.Checked = True





    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim errorMsg As String = ""

        If IsNumeric(Me.txtInvoiceNo.Text) = False Then
            errorMsg &= "Invoice Number must be a number" & vbCrLf
        End If

        If dtpInvoiceDate.Value > Today() Then
            errorMsg = errorMsg & "Invalid date" & vbCrLf
        End If

        If Len(Me.txtProductName.Text) < 3 Then
            errorMsg = errorMsg & "Product Name must be >3 " & vbCrLf
        End If

        If IsNumeric(Me.txtPrice.Text) = False OrElse Me.txtPrice.Text < 0 Then
            errorMsg &= "Price must be a nr and >0" & vbCrLf
        End If
        If IsNumeric(Me.txtQuantity.Text) = False OrElse
                                   Me.txtQuantity.Text < 0 Then
            errorMsg &= "Quantity must be a nr and >0" & vbCrLf
        End If
        If cboProductType.SelectedIndex = -1 Then
            errorMsg &= "Must choose a product type" & vbCrLf
        End If
        If cboUM.SelectedIndex = -1 Then
            errorMsg &= "Must choose a um" & vbCrLf
        End If

        If errorMsg = "" Then
            Dim amount As Single = Me.txtQuantity.Text * Me.txtPrice.Text
            Dim discount As Single = 0
            If amount > 300 Then
                discount = 0.2
            ElseIf amount > 200 Then
                discount = 0.1
            ElseIf amount > 100 Then
                discount = 0.05
            End If
            Me.txtAmount.Text = FormatNumber(amount * (1 - discount) *
                                   (1 +
                                   If(Me.chkVAT.Checked = True, ActualVAT, 0)), 2)
            Me.txtDueDate.Text = FormatDateTime(DateAdd(DateInterval.Day,
                                         DaysToDueDate(Me.txtAmount.Text),
                                         Me.dtpInvoiceDate.Value),
                                                DateFormat.ShortDate)


        Else
            MsgBox(errorMsg)
        End If
    End Sub

    Private Sub ConversionEuro(pAmount As Single)
        Dim rate As String = InputBox("exchange rate", "Conversion", 5)
        If Not IsNumeric(rate) Then
            MsgBox("Invalid rate")
        Else
            Dim AmountEuro As Single = pAmount / rate
            MsgBox("Amount Euro =" & AmountEuro)
        End If
    End Sub

    Private Function DaysToDueDate(pAmount As Single) As Byte
        Dim NoDays As Byte
        If pAmount > 500 Then
            NoDays = 50
        ElseIf pAmount > 250 Then
            NoDays = 25
        ElseIf pAmount > 150 Then
            NoDays = 20
        Else
            NoDays = 10
        End If
        Return NoDays
    End Function

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If Me.txtAmount.Text = "" Then
            MsgBox("Invalid amount")
        Else
            Call ConversionEuro(Me.txtAmount.Text)
        End If
    End Sub

    Private Sub btnVAT_Click(sender As Object, e As EventArgs) Handles btnVAT.Click
        If MsgBox("Standard VAT rate?",
                   MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                   "VAT") = MsgBoxResult.Yes Then
            ActualVAT = StandardVAT
        Else
            Dim VAT As String = InputBox("VAT rate", "VAT", StandardVAT)
            If IsNumeric(VAT) AndAlso VAT < 1 Then
                ActualVAT = VAT
            Else
                MsgBox("Invalid VAT")

            End If

        End If
    End Sub
End Class
