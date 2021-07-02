<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLists
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
        Me.btnNewPartner = New System.Windows.Forms.Button()
        Me.btnNewProduct = New System.Windows.Forms.Button()
        Me.btnNewInvoice = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewPartner
        '
        Me.btnNewPartner.Location = New System.Drawing.Point(34, 48)
        Me.btnNewPartner.Name = "btnNewPartner"
        Me.btnNewPartner.Size = New System.Drawing.Size(147, 23)
        Me.btnNewPartner.TabIndex = 0
        Me.btnNewPartner.Text = "Add new business partner"
        Me.btnNewPartner.UseVisualStyleBackColor = True
        '
        'btnNewProduct
        '
        Me.btnNewProduct.Location = New System.Drawing.Point(34, 86)
        Me.btnNewProduct.Name = "btnNewProduct"
        Me.btnNewProduct.Size = New System.Drawing.Size(147, 23)
        Me.btnNewProduct.TabIndex = 1
        Me.btnNewProduct.Text = "Add new product"
        Me.btnNewProduct.UseVisualStyleBackColor = True
        '
        'btnNewInvoice
        '
        Me.btnNewInvoice.Location = New System.Drawing.Point(34, 130)
        Me.btnNewInvoice.Name = "btnNewInvoice"
        Me.btnNewInvoice.Size = New System.Drawing.Size(147, 23)
        Me.btnNewInvoice.TabIndex = 2
        Me.btnNewInvoice.Text = "Add new invoice"
        Me.btnNewInvoice.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Task 1 "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(286, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Task nr 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(286, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(181, 38)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "No products price 100-500"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(295, 211)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 34)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "invoices issued may or january"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(301, 268)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 26)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "amount due today for bank"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(312, 315)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(120, 38)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "quantity max"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(34, 211)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(147, 23)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Add contract"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(34, 255)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(196, 23)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "No contracts duration between ..."
        Me.Button8.UseVisualStyleBackColor = True
        '
        'frmLists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 450)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNewInvoice)
        Me.Controls.Add(Me.btnNewProduct)
        Me.Controls.Add(Me.btnNewPartner)
        Me.Name = "frmLists"
        Me.Text = "frmLists"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNewPartner As Button
    Friend WithEvents btnNewProduct As Button
    Friend WithEvents btnNewInvoice As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
