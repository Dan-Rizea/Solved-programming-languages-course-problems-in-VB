<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvoiceClass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClasses = New System.Windows.Forms.Button()
        Me.btnNewData = New System.Windows.Forms.Button()
        Me.btnDisplayData = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnBetweenPrice = New System.Windows.Forms.Button()
        Me.btnNoInvoices = New System.Windows.Forms.Button()
        Me.btnTotalPaid = New System.Windows.Forms.Button()
        Me.btnBusinessPartners = New System.Windows.Forms.Button()
        Me.btnSellInvoices = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClasses
        '
        Me.btnClasses.Location = New System.Drawing.Point(236, 39)
        Me.btnClasses.Name = "btnClasses"
        Me.btnClasses.Size = New System.Drawing.Size(147, 59)
        Me.btnClasses.TabIndex = 0
        Me.btnClasses.Text = "Invoice Class Examples"
        Me.btnClasses.UseVisualStyleBackColor = True
        '
        'btnNewData
        '
        Me.btnNewData.Location = New System.Drawing.Point(40, 39)
        Me.btnNewData.Name = "btnNewData"
        Me.btnNewData.Size = New System.Drawing.Size(147, 23)
        Me.btnNewData.TabIndex = 1
        Me.btnNewData.Text = "New invoice data"
        Me.btnNewData.UseVisualStyleBackColor = True
        '
        'btnDisplayData
        '
        Me.btnDisplayData.Location = New System.Drawing.Point(40, 68)
        Me.btnDisplayData.Name = "btnDisplayData"
        Me.btnDisplayData.Size = New System.Drawing.Size(147, 23)
        Me.btnDisplayData.TabIndex = 2
        Me.btnDisplayData.Text = "Display invoice data"
        Me.btnDisplayData.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "New Partner"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(236, 151)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "New Foreign Partner"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(40, 182)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Display Partner"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(236, 181)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Display Foreign Partner"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(40, 252)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(196, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Multiple Products / average price"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnBetweenPrice
        '
        Me.btnBetweenPrice.Location = New System.Drawing.Point(40, 339)
        Me.btnBetweenPrice.Name = "btnBetweenPrice"
        Me.btnBetweenPrice.Size = New System.Drawing.Size(137, 73)
        Me.btnBetweenPrice.TabIndex = 8
        Me.btnBetweenPrice.Text = "Number of times the price is between 100 and 500"
        Me.btnBetweenPrice.UseVisualStyleBackColor = True
        '
        'btnNoInvoices
        '
        Me.btnNoInvoices.Location = New System.Drawing.Point(183, 339)
        Me.btnNoInvoices.Name = "btnNoInvoices"
        Me.btnNoInvoices.Size = New System.Drawing.Size(109, 73)
        Me.btnNoInvoices.TabIndex = 9
        Me.btnNoInvoices.Text = "Number of invoices in the current year Jan or May"
        Me.btnNoInvoices.UseVisualStyleBackColor = True
        '
        'btnTotalPaid
        '
        Me.btnTotalPaid.Location = New System.Drawing.Point(298, 339)
        Me.btnTotalPaid.Name = "btnTotalPaid"
        Me.btnTotalPaid.Size = New System.Drawing.Size(113, 73)
        Me.btnTotalPaid.TabIndex = 10
        Me.btnTotalPaid.Text = "Total amount to be paid today"
        Me.btnTotalPaid.UseVisualStyleBackColor = True
        '
        'btnBusinessPartners
        '
        Me.btnBusinessPartners.Location = New System.Drawing.Point(417, 339)
        Me.btnBusinessPartners.Name = "btnBusinessPartners"
        Me.btnBusinessPartners.Size = New System.Drawing.Size(94, 73)
        Me.btnBusinessPartners.TabIndex = 11
        Me.btnBusinessPartners.Text = "Number of business partners"
        Me.btnBusinessPartners.UseVisualStyleBackColor = True
        '
        'btnSellInvoices
        '
        Me.btnSellInvoices.Location = New System.Drawing.Point(517, 339)
        Me.btnSellInvoices.Name = "btnSellInvoices"
        Me.btnSellInvoices.Size = New System.Drawing.Size(94, 73)
        Me.btnSellInvoices.TabIndex = 12
        Me.btnSellInvoices.Text = "Sell invoices by year"
        Me.btnSellInvoices.UseVisualStyleBackColor = True
        '
        'frmInvoiceClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSellInvoices)
        Me.Controls.Add(Me.btnBusinessPartners)
        Me.Controls.Add(Me.btnTotalPaid)
        Me.Controls.Add(Me.btnNoInvoices)
        Me.Controls.Add(Me.btnBetweenPrice)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDisplayData)
        Me.Controls.Add(Me.btnNewData)
        Me.Controls.Add(Me.btnClasses)
        Me.Name = "frmInvoiceClass"
        Me.Text = "frmInvoiceClass"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClasses As Button
    Friend WithEvents btnNewData As Button
    Friend WithEvents btnDisplayData As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnBetweenPrice As Button
    Friend WithEvents btnNoInvoices As Button
    Friend WithEvents btnTotalPaid As Button
    Friend WithEvents btnBusinessPartners As Button
    Friend WithEvents btnSellInvoices As Button
End Class
