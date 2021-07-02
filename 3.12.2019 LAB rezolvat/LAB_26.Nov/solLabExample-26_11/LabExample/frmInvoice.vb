Public Class frmInvoice
    Const standardVAT As Single = 0.19
    Dim actualVAT As Single = standardVAT
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsNumeric(Me.txtQuantity.Text) And
            IsNumeric(Me.txtPrice.Text) And
            IsNumeric(Me.txtInvoiceNo.Text) And
            Len(Me.txtCustomer.Text) And
            Len(Me.txtProductName.Text) And
            Me.cboProductType.SelectedIndex >= 0 And
            Me.cboUM.SelectedIndex > -1 And
            Now() > Me.dtpInvoiceDate.Value Then ' validation test
            Dim amount As Single = Me.txtPrice.Text * Me.txtQuantity.Text
            Dim discountRate As Single
            If amount < 100 Then
                discountRate = 0.1
            ElseIf amount < 200 Then
                discountRate = 0.15
            ElseIf amount >= 200 And amount < 500 Then
                discountRate = 0.2
            Else
                discountRate = 0.3
            End If

            Dim vat As Single = If(Me.chkVAT.Checked = True,
                actualVAT, 0) * amount * (1 - discountRate)

            Me.txtAmount.Text = FormatNumber(amount *
                                             (1 - discountRate) +
                                             vat, 2)
            Me.txtVAT.Text = FormatNumber(vat, 2)
        Else

            MsgBox("Invalid input data!",, "Error")

        End If

        'If 2 > 3 Then

        'Else

        'End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.txtAmount.Text = ""
        Me.txtCustomer.Text = ""
        Me.txtInvoiceNo.Text = ""
        Me.txtPrice.Text = ""
        Me.txtProductName.Text = ""
        Me.txtQuantity.Text = ""
        Me.cboProductType.SelectedIndex = -1
        Me.cboUM.SelectedIndex = -1
        Me.chkVAT.Checked = False
        Me.dtpInvoiceDate.Value = Today()
        Me.radPerson.Checked = True
        Me.radRomanian.Checked = True


    End Sub

    Private Sub btnValidate2_Click(sender As Object, e As EventArgs) Handles btnValidate2.Click
        Dim errorMsg As String = "Error"
        If IsNumeric(Me.txtInvoiceNo.Text) = False Then
            errorMsg = errorMsg & vbCrLf & "Invalid invoice nr."
        End If
        If dtpInvoiceDate.Value > Now() Then
            errorMsg = errorMsg & vbCrLf & "invalid invoice date"
        End If
        If Len(txtCustomer.Text) < 3 Then
            errorMsg &= vbCrLf & "Invalid customer name"
            'ElseIf IsNumeric(txtCustomer.Text) = True Then
            '   errorMsg &= "Invalid customer name"
        End If
        If IsNumeric(txtPrice.Text) = False Then
            errorMsg &= vbCrLf & "Invalid price"
        End If
        If Not IsNumeric(txtQuantity.Text) Then
            errorMsg &= vbCrLf & "Invalid quantity"
        End If
        If cboProductType.SelectedIndex < 0 Then
            errorMsg &= vbCrLf & "No product type"
        End If
        If cboUM.SelectedIndex < 0 Then
            errorMsg &= vbCrLf & "No UM"
        End If
        If errorMsg = "Error" Then
            Dim amount As Single = Me.txtPrice.Text * Me.txtQuantity.Text
            Dim discount As Single = 0
            If amount > 500 Then
                discount = 0.2
            ElseIf amount > 300 Then
                discount = 0.1
            ElseIf amount > 200 Then
                discount = 0.05
            End If
            Me.txtAmount.Text = FormatNumber(amount * (1 - discount) *
                                   (1 + If(chkVAT.Checked, actualVAT, 0)), 2)
            Dim no As Byte = DaysToDueDate(Me.txtAmount.Text)
            Dim dueDate As Date = DateAdd(DateInterval.Day, no, Me.dtpInvoiceDate.Value)
            Me.txtDueDate.Text = FormatDateTime(dueDate, DateFormat.ShortDate)
        Else
            MsgBox(errorMsg)
        End If

    End Sub

    Private Sub convertEuro(pAmount As Single)
        Dim exchangeRate As String = InputBox("Exchange rate",
                                              "Conversion", 5)
        If IsNumeric(exchangeRate) Then
            Dim result As Single = pAmount / exchangeRate
            MsgBox("Amount in euro=" & result)
        Else
            MsgBox("Invalid exchange rate")
        End If
    End Sub

    Private Sub btnConversion_Click(sender As Object, e As EventArgs) Handles btnConversion.Click
        If Me.txtAmount.Text = "" Then
            MsgBox("No amount to convert")
        Else
            Call convertEuro(Me.txtAmount.Text)
        End If
    End Sub

    Private Function DaysToDueDate(pAmount As Single) As Byte
        Dim noDays As Byte
        If pAmount > 1000 Then
            noDays = 60
        ElseIf pAmount > 600 Then
            noDays = 30
        Else
            noDays = 10
        End If
        Return noDays
    End Function

    Private Sub btnVAT_Click(sender As Object, e As EventArgs) Handles btnVAT.Click
        If MsgBox("Standard VAT?",
                  MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                  "VAT") = MsgBoxResult.No Then
            Dim vat As String = InputBox("Insert VAT",
                               "VAT", standardVAT)
            If IsNumeric(vat) AndAlso vat < 1 Then
                actualVAT = vat
            Else
                MsgBox("Invalid VAT")
            End If
        Else
            actualVAT = standardVAT

        End If
        MsgBox("Current VAT Rate = " & actualVAT)
    End Sub

    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
