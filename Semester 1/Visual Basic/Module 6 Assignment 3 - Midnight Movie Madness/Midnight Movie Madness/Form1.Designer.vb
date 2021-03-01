<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbproduct = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gbSize = New System.Windows.Forms.GroupBox()
        Me.rbLarge = New System.Windows.Forms.RadioButton()
        Me.rbMedium = New System.Windows.Forms.RadioButton()
        Me.rbSmall = New System.Windows.Forms.RadioButton()
        Me.gbQuantity = New System.Windows.Forms.GroupBox()
        Me.inpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.gbProduct = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbItems = New System.Windows.Forms.ListBox()
        Me.lbLineTotal = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.lbTax = New System.Windows.Forms.Label()
        Me.lbDisc = New System.Windows.Forms.Label()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbChange = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.gbSize.SuspendLayout()
        Me.gbQuantity.SuspendLayout()
        Me.gbProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Midnight Movie Madness"
        '
        'cbproduct
        '
        Me.cbproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbproduct.FormattingEnabled = True
        Me.cbproduct.Location = New System.Drawing.Point(17, 19)
        Me.cbproduct.Name = "cbproduct"
        Me.cbproduct.Size = New System.Drawing.Size(121, 21)
        Me.cbproduct.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(17, 46)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(121, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Add to Order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'gbSize
        '
        Me.gbSize.Controls.Add(Me.rbLarge)
        Me.gbSize.Controls.Add(Me.rbMedium)
        Me.gbSize.Controls.Add(Me.rbSmall)
        Me.gbSize.Enabled = False
        Me.gbSize.Location = New System.Drawing.Point(172, 46)
        Me.gbSize.Name = "gbSize"
        Me.gbSize.Size = New System.Drawing.Size(100, 100)
        Me.gbSize.TabIndex = 4
        Me.gbSize.TabStop = False
        Me.gbSize.Text = "Size"
        '
        'rbLarge
        '
        Me.rbLarge.AutoSize = True
        Me.rbLarge.Location = New System.Drawing.Point(7, 66)
        Me.rbLarge.Name = "rbLarge"
        Me.rbLarge.Size = New System.Drawing.Size(52, 17)
        Me.rbLarge.TabIndex = 2
        Me.rbLarge.Text = "Large"
        Me.rbLarge.UseVisualStyleBackColor = True
        '
        'rbMedium
        '
        Me.rbMedium.AutoSize = True
        Me.rbMedium.Location = New System.Drawing.Point(7, 43)
        Me.rbMedium.Name = "rbMedium"
        Me.rbMedium.Size = New System.Drawing.Size(62, 17)
        Me.rbMedium.TabIndex = 1
        Me.rbMedium.Text = "Medium"
        Me.rbMedium.UseVisualStyleBackColor = True
        '
        'rbSmall
        '
        Me.rbSmall.AutoSize = True
        Me.rbSmall.Checked = True
        Me.rbSmall.Location = New System.Drawing.Point(7, 19)
        Me.rbSmall.Name = "rbSmall"
        Me.rbSmall.Size = New System.Drawing.Size(50, 17)
        Me.rbSmall.TabIndex = 0
        Me.rbSmall.TabStop = True
        Me.rbSmall.Text = "Small"
        Me.rbSmall.UseVisualStyleBackColor = True
        '
        'gbQuantity
        '
        Me.gbQuantity.Controls.Add(Me.inpDate)
        Me.gbQuantity.Controls.Add(Me.Label2)
        Me.gbQuantity.Controls.Add(Me.txtQuantity)
        Me.gbQuantity.Location = New System.Drawing.Point(278, 46)
        Me.gbQuantity.Name = "gbQuantity"
        Me.gbQuantity.Size = New System.Drawing.Size(205, 100)
        Me.gbQuantity.TabIndex = 5
        Me.gbQuantity.TabStop = False
        Me.gbQuantity.Text = "Quantity"
        '
        'inpDate
        '
        Me.inpDate.Location = New System.Drawing.Point(6, 66)
        Me.inpDate.MinDate = New Date(2019, 11, 1, 0, 0, 0, 0)
        Me.inpDate.Name = "inpDate"
        Me.inpDate.Size = New System.Drawing.Size(188, 20)
        Me.inpDate.TabIndex = 8
        Me.inpDate.Value = New Date(2019, 11, 28, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Date"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(6, 19)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(30, 20)
        Me.txtQuantity.TabIndex = 0
        '
        'gbProduct
        '
        Me.gbProduct.Controls.Add(Me.cbproduct)
        Me.gbProduct.Controls.Add(Me.btnAdd)
        Me.gbProduct.Location = New System.Drawing.Point(12, 46)
        Me.gbProduct.Name = "gbProduct"
        Me.gbProduct.Size = New System.Drawing.Size(154, 100)
        Me.gbProduct.TabIndex = 6
        Me.gbProduct.TabStop = False
        Me.gbProduct.Text = "Product"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Items"
        '
        'lbItems
        '
        Me.lbItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.Location = New System.Drawing.Point(12, 165)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(260, 210)
        Me.lbItems.TabIndex = 8
        '
        'lbLineTotal
        '
        Me.lbLineTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbLineTotal.FormattingEnabled = True
        Me.lbLineTotal.Location = New System.Drawing.Point(278, 165)
        Me.lbLineTotal.Name = "lbLineTotal"
        Me.lbLineTotal.Size = New System.Drawing.Size(205, 210)
        Me.lbLineTotal.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(284, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Line Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total Discount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total Tax:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 437)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Order Total:"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(111, 437)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(13, 13)
        Me.lbTotal.TabIndex = 16
        Me.lbTotal.Text = "$"
        '
        'lbTax
        '
        Me.lbTax.AutoSize = True
        Me.lbTax.Location = New System.Drawing.Point(111, 415)
        Me.lbTax.Name = "lbTax"
        Me.lbTax.Size = New System.Drawing.Size(13, 13)
        Me.lbTax.TabIndex = 15
        Me.lbTax.Text = "$"
        '
        'lbDisc
        '
        Me.lbDisc.AutoSize = True
        Me.lbDisc.Location = New System.Drawing.Point(111, 391)
        Me.lbDisc.Name = "lbDisc"
        Me.lbDisc.Size = New System.Drawing.Size(13, 13)
        Me.lbDisc.TabIndex = 14
        Me.lbDisc.Text = "$"
        '
        'txtPaid
        '
        Me.txtPaid.Location = New System.Drawing.Point(201, 412)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(100, 20)
        Me.txtPaid.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(217, 391)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Money Paid:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(207, 437)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Change:"
        '
        'lbChange
        '
        Me.lbChange.AutoSize = True
        Me.lbChange.Location = New System.Drawing.Point(260, 437)
        Me.lbChange.Name = "lbChange"
        Me.lbChange.Size = New System.Drawing.Size(13, 13)
        Me.lbChange.TabIndex = 20
        Me.lbChange.Text = "$"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(358, 391)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(125, 23)
        Me.btnCalculate.TabIndex = 21
        Me.btnCalculate.Text = "Caluclate Change"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(358, 420)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(125, 23)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "Reset Order"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 469)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lbChange)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.lbTax)
        Me.Controls.Add(Me.lbDisc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbLineTotal)
        Me.Controls.Add(Me.lbItems)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbProduct)
        Me.Controls.Add(Me.gbQuantity)
        Me.Controls.Add(Me.gbSize)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Midnight Movie Madness"
        Me.gbSize.ResumeLayout(False)
        Me.gbSize.PerformLayout()
        Me.gbQuantity.ResumeLayout(False)
        Me.gbQuantity.PerformLayout()
        Me.gbProduct.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbproduct As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents gbSize As GroupBox
    Friend WithEvents rbLarge As RadioButton
    Friend WithEvents rbMedium As RadioButton
    Friend WithEvents rbSmall As RadioButton
    Friend WithEvents gbQuantity As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents gbProduct As GroupBox
    Friend WithEvents inpDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents lbItems As ListBox
    Friend WithEvents lbLineTotal As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents lbTax As Label
    Friend WithEvents lbDisc As Label
    Friend WithEvents txtPaid As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbChange As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
End Class
