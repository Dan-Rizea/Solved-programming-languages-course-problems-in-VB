<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radPerson = New System.Windows.Forms.RadioButton()
        Me.radCompany = New System.Windows.Forms.RadioButton()
        Me.radRomanian = New System.Windows.Forms.RadioButton()
        Me.radForeign = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProductType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboUM = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkVAT = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtvatamount = New System.Windows.Forms.TextBox()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDueDate = New System.Windows.Forms.TextBox()
        Me.btnVAT = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(109, 22)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Invoice no."
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(109, 58)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpInvoiceDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Invoice date"
        '
        'radPerson
        '
        Me.radPerson.AutoSize = True
        Me.radPerson.Checked = True
        Me.radPerson.Location = New System.Drawing.Point(100, 19)
        Me.radPerson.Name = "radPerson"
        Me.radPerson.Size = New System.Drawing.Size(58, 17)
        Me.radPerson.TabIndex = 4
        Me.radPerson.TabStop = True
        Me.radPerson.Text = "Person"
        Me.radPerson.UseVisualStyleBackColor = True
        '
        'radCompany
        '
        Me.radCompany.AutoSize = True
        Me.radCompany.Location = New System.Drawing.Point(100, 42)
        Me.radCompany.Name = "radCompany"
        Me.radCompany.Size = New System.Drawing.Size(69, 17)
        Me.radCompany.TabIndex = 5
        Me.radCompany.Text = "Company"
        Me.radCompany.UseVisualStyleBackColor = True
        '
        'radRomanian
        '
        Me.radRomanian.AutoSize = True
        Me.radRomanian.Checked = True
        Me.radRomanian.Location = New System.Drawing.Point(61, 22)
        Me.radRomanian.Name = "radRomanian"
        Me.radRomanian.Size = New System.Drawing.Size(119, 17)
        Me.radRomanian.TabIndex = 6
        Me.radRomanian.TabStop = True
        Me.radRomanian.Text = "Romanian customer"
        Me.radRomanian.UseVisualStyleBackColor = True
        '
        'radForeign
        '
        Me.radForeign.AutoSize = True
        Me.radForeign.Location = New System.Drawing.Point(195, 22)
        Me.radForeign.Name = "radForeign"
        Me.radForeign.Size = New System.Drawing.Size(106, 17)
        Me.radForeign.TabIndex = 7
        Me.radForeign.TabStop = True
        Me.radForeign.Text = "Foreign customer"
        Me.radForeign.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radCompany)
        Me.GroupBox1.Controls.Add(Me.radPerson)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 76)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer type"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radForeign)
        Me.Panel1.Controls.Add(Me.radRomanian)
        Me.Panel1.Location = New System.Drawing.Point(254, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 56)
        Me.Panel1.TabIndex = 9
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(109, 209)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomer.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Customer name"
        '
        'cboProductType
        '
        Me.cboProductType.FormattingEnabled = True
        Me.cboProductType.Items.AddRange(New Object() {"Food", "Cleaning products", "Healthcare", "Cosmetics", "ITC", "Kids"})
        Me.cboProductType.Location = New System.Drawing.Point(109, 254)
        Me.cboProductType.Name = "cboProductType"
        Me.cboProductType.Size = New System.Drawing.Size(100, 21)
        Me.cboProductType.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Product type"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(109, 296)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 20)
        Me.txtProductName.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Product name"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(109, 333)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 16
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(109, 359)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Quantity"
        '
        'cboUM
        '
        Me.cboUM.FormattingEnabled = True
        Me.cboUM.Items.AddRange(New Object() {"kilo", "piece", "litre", "meter"})
        Me.cboUM.Location = New System.Drawing.Point(304, 295)
        Me.cboUM.Name = "cboUM"
        Me.cboUM.Size = New System.Drawing.Size(121, 21)
        Me.cboUM.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(274, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "UM"
        '
        'txtAmount
        '
        Me.txtAmount.Enabled = False
        Me.txtAmount.Location = New System.Drawing.Point(109, 398)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 401)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Total amount"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(304, 377)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 24
        Me.btnOK.Text = "Validate"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(397, 377)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkVAT
        '
        Me.chkVAT.AccessibleName = "chkVAT"
        Me.chkVAT.AutoSize = True
        Me.chkVAT.Location = New System.Drawing.Point(508, 296)
        Me.chkVAT.Name = "chkVAT"
        Me.chkVAT.Size = New System.Drawing.Size(47, 17)
        Me.chkVAT.TabIndex = 26
        Me.chkVAT.Text = "VAT"
        Me.chkVAT.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(428, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "VAT Amount"
        '
        'txtvatamount
        '
        Me.txtvatamount.Location = New System.Drawing.Point(501, 254)
        Me.txtvatamount.Name = "txtvatamount"
        Me.txtvatamount.ReadOnly = True
        Me.txtvatamount.Size = New System.Drawing.Size(100, 20)
        Me.txtvatamount.TabIndex = 28
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(304, 415)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(168, 23)
        Me.btnValidate.TabIndex = 29
        Me.btnValidate.Text = "Validate/Explicit err"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(501, 417)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(100, 19)
        Me.btnConvert.TabIndex = 30
        Me.btnConvert.Text = "ConvertAmount"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(263, 327)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Due Date "
        '
        'txtDueDate
        '
        Me.txtDueDate.Location = New System.Drawing.Point(325, 324)
        Me.txtDueDate.Name = "txtDueDate"
        Me.txtDueDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDueDate.TabIndex = 32
        '
        'btnVAT
        '
        Me.btnVAT.Location = New System.Drawing.Point(501, 376)
        Me.btnVAT.Name = "btnVAT"
        Me.btnVAT.Size = New System.Drawing.Size(75, 23)
        Me.btnVAT.TabIndex = 33
        Me.btnVAT.Text = "Set VAT Rate"
        Me.btnVAT.UseVisualStyleBackColor = True
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVAT)
        Me.Controls.Add(Me.txtDueDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.txtvatamount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkVAT)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboUM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboProductType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpInvoiceDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Name = "frmInvoice"
        Me.Text = "Invoice data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpInvoiceDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents radPerson As RadioButton
    Friend WithEvents radCompany As RadioButton
    Friend WithEvents radRomanian As RadioButton
    Friend WithEvents radForeign As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboProductType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboUM As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents chkVAT As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtvatamount As TextBox
    Friend WithEvents btnValidate As Button
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDueDate As TextBox
    Friend WithEvents btnVAT As Button
End Class
