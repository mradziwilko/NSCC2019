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
        Me.cbManufacture = New System.Windows.Forms.ComboBox()
        Me.lbCars = New System.Windows.Forms.ListBox()
        Me.lbOrderCars = New System.Windows.Forms.ListBox()
        Me.lbOrderCost = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inpQuantity = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.Label()
        Me.tbTax = New System.Windows.Forms.Label()
        Me.tbSubtotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select An Auto For Details"
        '
        'cbManufacture
        '
        Me.cbManufacture.BackColor = System.Drawing.Color.White
        Me.cbManufacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbManufacture.FormattingEnabled = True
        Me.cbManufacture.Location = New System.Drawing.Point(16, 47)
        Me.cbManufacture.Name = "cbManufacture"
        Me.cbManufacture.Size = New System.Drawing.Size(154, 21)
        Me.cbManufacture.TabIndex = 1
        '
        'lbCars
        '
        Me.lbCars.FormattingEnabled = True
        Me.lbCars.Location = New System.Drawing.Point(15, 89)
        Me.lbCars.Name = "lbCars"
        Me.lbCars.Size = New System.Drawing.Size(192, 212)
        Me.lbCars.TabIndex = 2
        '
        'lbOrderCars
        '
        Me.lbOrderCars.FormattingEnabled = True
        Me.lbOrderCars.Location = New System.Drawing.Point(213, 89)
        Me.lbOrderCars.Name = "lbOrderCars"
        Me.lbOrderCars.Size = New System.Drawing.Size(223, 212)
        Me.lbOrderCars.TabIndex = 3
        '
        'lbOrderCost
        '
        Me.lbOrderCost.FormattingEnabled = True
        Me.lbOrderCost.Location = New System.Drawing.Point(442, 89)
        Me.lbOrderCost.Name = "lbOrderCost"
        Me.lbOrderCost.Size = New System.Drawing.Size(192, 212)
        Me.lbOrderCost.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(65, 354)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(46, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quantity"
        '
        'inpQuantity
        '
        Me.inpQuantity.Location = New System.Drawing.Point(16, 356)
        Me.inpQuantity.Name = "inpQuantity"
        Me.inpQuantity.Size = New System.Drawing.Size(43, 20)
        Me.inpQuantity.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(227, 353)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(46, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(117, 353)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(104, 23)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove Selected"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(279, 353)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(378, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Subtotal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Taxes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Total:"
        '
        'tbTotal
        '
        Me.tbTotal.AutoSize = True
        Me.tbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.Location = New System.Drawing.Point(433, 364)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(14, 13)
        Me.tbTotal.TabIndex = 16
        Me.tbTotal.Text = "$"
        '
        'tbTax
        '
        Me.tbTax.AutoSize = True
        Me.tbTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTax.Location = New System.Drawing.Point(433, 340)
        Me.tbTax.Name = "tbTax"
        Me.tbTax.Size = New System.Drawing.Size(14, 13)
        Me.tbTax.TabIndex = 15
        Me.tbTax.Text = "$"
        '
        'tbSubtotal
        '
        Me.tbSubtotal.AutoSize = True
        Me.tbSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSubtotal.Location = New System.Drawing.Point(433, 317)
        Me.tbSubtotal.Name = "tbSubtotal"
        Me.tbSubtotal.Size = New System.Drawing.Size(14, 13)
        Me.tbSubtotal.TabIndex = 14
        Me.tbSubtotal.Text = "$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Price:"
        '
        'lbPrice
        '
        Me.lbPrice.AutoSize = True
        Me.lbPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrice.Location = New System.Drawing.Point(51, 316)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(14, 13)
        Me.lbPrice.TabIndex = 18
        Me.lbPrice.Text = "$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Models"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Order Item"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(442, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Line Price"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Make"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 390)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.tbTax)
        Me.Controls.Add(Me.tbSubtotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.inpQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbOrderCost)
        Me.Controls.Add(Me.lbOrderCars)
        Me.Controls.Add(Me.lbCars)
        Me.Controls.Add(Me.cbManufacture)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Line Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbManufacture As ComboBox
    Friend WithEvents lbCars As ListBox
    Friend WithEvents lbOrderCars As ListBox
    Friend WithEvents lbOrderCost As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents inpQuantity As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbTotal As Label
    Friend WithEvents tbTax As Label
    Friend WithEvents tbSubtotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbPrice As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
End Class
