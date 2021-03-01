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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.inpQuant = New System.Windows.Forms.TextBox()
        Me.inpItemNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.disc15 = New System.Windows.Forms.RadioButton()
        Me.disc10 = New System.Windows.Forms.RadioButton()
        Me.disc0 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbOrdered = New System.Windows.Forms.ListBox()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbInvoice = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.inpQuant)
        Me.GroupBox1.Controls.Add(Me.inpItemNumber)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Product"
        '
        'inpQuant
        '
        Me.inpQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inpQuant.Location = New System.Drawing.Point(115, 50)
        Me.inpQuant.Name = "inpQuant"
        Me.inpQuant.Size = New System.Drawing.Size(87, 20)
        Me.inpQuant.TabIndex = 11
        '
        'inpItemNumber
        '
        Me.inpItemNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inpItemNumber.Location = New System.Drawing.Point(16, 50)
        Me.inpItemNumber.Name = "inpItemNumber"
        Me.inpItemNumber.Size = New System.Drawing.Size(87, 20)
        Me.inpItemNumber.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Item Number"
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(16, 87)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(186, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add to Order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.disc15)
        Me.GroupBox2.Controls.Add(Me.disc10)
        Me.GroupBox2.Controls.Add(Me.disc0)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(246, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 127)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Discounts"
        '
        'disc15
        '
        Me.disc15.AutoSize = True
        Me.disc15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.disc15.Location = New System.Drawing.Point(28, 76)
        Me.disc15.Name = "disc15"
        Me.disc15.Size = New System.Drawing.Size(92, 17)
        Me.disc15.TabIndex = 2
        Me.disc15.Text = "1&5 Discount"
        Me.disc15.UseVisualStyleBackColor = True
        '
        'disc10
        '
        Me.disc10.AutoSize = True
        Me.disc10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.disc10.Location = New System.Drawing.Point(28, 53)
        Me.disc10.Name = "disc10"
        Me.disc10.Size = New System.Drawing.Size(101, 17)
        Me.disc10.TabIndex = 1
        Me.disc10.Text = "1&0% Discount"
        Me.disc10.UseVisualStyleBackColor = True
        '
        'disc0
        '
        Me.disc0.AutoSize = True
        Me.disc0.Checked = True
        Me.disc0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.disc0.Location = New System.Drawing.Point(28, 30)
        Me.disc0.Name = "disc0"
        Me.disc0.Size = New System.Drawing.Size(94, 17)
        Me.disc0.TabIndex = 0
        Me.disc0.TabStop = True
        Me.disc0.Text = "N&o Discount"
        Me.disc0.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ordered Items"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Invoice"
        '
        'lbOrdered
        '
        Me.lbOrdered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbOrdered.FormattingEnabled = True
        Me.lbOrdered.Location = New System.Drawing.Point(22, 176)
        Me.lbOrdered.Name = "lbOrdered"
        Me.lbOrdered.Size = New System.Drawing.Size(423, 93)
        Me.lbOrdered.TabIndex = 4
        '
        'btnComplete
        '
        Me.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComplete.Location = New System.Drawing.Point(22, 559)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(137, 23)
        Me.btnComplete.TabIndex = 6
        Me.btnComplete.Text = "&Complete Order"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(165, 559)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(137, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(308, 559)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbInvoice
        '
        Me.lbInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbInvoice.FormattingEnabled = True
        Me.lbInvoice.Location = New System.Drawing.Point(22, 291)
        Me.lbInvoice.Name = "lbInvoice"
        Me.lbInvoice.Size = New System.Drawing.Size(423, 262)
        Me.lbInvoice.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 594)
        Me.Controls.Add(Me.lbInvoice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.lbOrdered)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Timber Toms"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbOrdered As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents disc15 As RadioButton
    Friend WithEvents disc10 As RadioButton
    Friend WithEvents disc0 As RadioButton
    Friend WithEvents btnComplete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents inpQuant As TextBox
    Friend WithEvents inpItemNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbInvoice As ListBox
End Class
