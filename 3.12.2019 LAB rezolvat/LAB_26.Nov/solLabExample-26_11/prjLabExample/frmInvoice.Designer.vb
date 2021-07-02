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
        Me.radCompany = New System.Windows.Forms.RadioButton()
        Me.radPerson = New System.Windows.Forms.RadioButton()
        Me.radRO = New System.Windows.Forms.RadioButton()
        Me.radForeign = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.cboProductType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(144, 31)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Invoice No"
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(144, 57)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpInvoiceDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Invoice Date"
        '
        'radCompany
        '
        Me.radCompany.AutoSize = True
        Me.radCompany.Checked = True
        Me.radCompany.Location = New System.Drawing.Point(112, 19)
        Me.radCompany.Name = "radCompany"
        Me.radCompany.Size = New System.Drawing.Size(69, 17)
        Me.radCompany.TabIndex = 4
        Me.radCompany.TabStop = True
        Me.radCompany.Text = "Company"
        Me.radCompany.UseVisualStyleBackColor = True
        '
        'radPerson
        '
        Me.radPerson.AutoSize = True
        Me.radPerson.Location = New System.Drawing.Point(112, 43)
        Me.radPerson.Name = "radPerson"
        Me.radPerson.Size = New System.Drawing.Size(58, 17)
        Me.radPerson.TabIndex = 5
        Me.radPerson.Text = "Person"
        Me.radPerson.UseVisualStyleBackColor = True
        '
        'radRO
        '
        Me.radRO.AutoSize = True
        Me.radRO.Checked = True
        Me.radRO.Location = New System.Drawing.Point(21, 5)
        Me.radRO.Name = "radRO"
        Me.radRO.Size = New System.Drawing.Size(73, 17)
        Me.radRO.TabIndex = 7
        Me.radRO.TabStop = True
        Me.radRO.Text = "Romanian"
        Me.radRO.UseVisualStyleBackColor = True
        '
        'radForeign
        '
        Me.radForeign.AutoSize = True
        Me.radForeign.Location = New System.Drawing.Point(21, 29)
        Me.radForeign.Name = "radForeign"
        Me.radForeign.Size = New System.Drawing.Size(60, 17)
        Me.radForeign.TabIndex = 8
        Me.radForeign.Text = "Foreign"
        Me.radForeign.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Customer name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radCompany)
        Me.GroupBox1.Controls.Add(Me.radPerson)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 78)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Type"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radRO)
        Me.Panel1.Controls.Add(Me.radForeign)
        Me.Panel1.Location = New System.Drawing.Point(330, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 65)
        Me.Panel1.TabIndex = 11
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(144, 179)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerName.TabIndex = 12
        '
        'cboProductType
        '
        Me.cboProductType.FormattingEnabled = True
        Me.cboProductType.Location = New System.Drawing.Point(144, 206)
        Me.cboProductType.Name = "cboProductType"
        Me.cboProductType.Size = New System.Drawing.Size(121, 21)
        Me.cboProductType.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Product type"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboProductType)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpInvoiceDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
    Friend WithEvents radCompany As RadioButton
    Friend WithEvents radPerson As RadioButton
    Friend WithEvents radRO As RadioButton
    Friend WithEvents radForeign As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents cboProductType As ComboBox
    Friend WithEvents Label3 As Label
End Class
