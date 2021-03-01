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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inpLA = New System.Windows.Forms.TextBox()
        Me.inpLR = New System.Windows.Forms.TextBox()
        Me.inpLT = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblYearInterestRate = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.errTxt = New System.Windows.Forms.Label()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.lblCostOfLoan = New System.Windows.Forms.Label()
        Me.lblNOM = New System.Windows.Forms.Label()
        Me.lblMonthInterestRate = New System.Windows.Forms.Label()
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loan Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Loan Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Loan Term"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(397, 42)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LOAN CALCULATOR"
        '
        'inpLA
        '
        Me.inpLA.Location = New System.Drawing.Point(103, 83)
        Me.inpLA.Name = "inpLA"
        Me.inpLA.Size = New System.Drawing.Size(314, 20)
        Me.inpLA.TabIndex = 4
        '
        'inpLR
        '
        Me.inpLR.Location = New System.Drawing.Point(103, 109)
        Me.inpLR.Name = "inpLR"
        Me.inpLR.Size = New System.Drawing.Size(314, 20)
        Me.inpLR.TabIndex = 5
        '
        'inpLT
        '
        Me.inpLT.Location = New System.Drawing.Point(103, 137)
        Me.inpLT.Name = "inpLT"
        Me.inpLT.Size = New System.Drawing.Size(314, 20)
        Me.inpLT.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(233, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "C&alculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(342, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "&Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblYearInterestRate)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.errTxt)
        Me.GroupBox1.Controls.Add(Me.lblInterest)
        Me.GroupBox1.Controls.Add(Me.lblCostOfLoan)
        Me.GroupBox1.Controls.Add(Me.lblNOM)
        Me.GroupBox1.Controls.Add(Me.lblMonthInterestRate)
        Me.GroupBox1.Controls.Add(Me.lblLoanAmount)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(435, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 180)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'lblYearInterestRate
        '
        Me.lblYearInterestRate.AutoSize = True
        Me.lblYearInterestRate.Location = New System.Drawing.Point(141, 68)
        Me.lblYearInterestRate.Name = "lblYearInterestRate"
        Me.lblYearInterestRate.Size = New System.Drawing.Size(0, 13)
        Me.lblYearInterestRate.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Yearly Interest Rate:"
        '
        'errTxt
        '
        Me.errTxt.AutoSize = True
        Me.errTxt.ForeColor = System.Drawing.Color.Red
        Me.errTxt.Location = New System.Drawing.Point(6, 157)
        Me.errTxt.Name = "errTxt"
        Me.errTxt.Size = New System.Drawing.Size(0, 13)
        Me.errTxt.TabIndex = 25
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Location = New System.Drawing.Point(143, 137)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(0, 13)
        Me.lblInterest.TabIndex = 24
        '
        'lblCostOfLoan
        '
        Me.lblCostOfLoan.AutoSize = True
        Me.lblCostOfLoan.Location = New System.Drawing.Point(143, 112)
        Me.lblCostOfLoan.Name = "lblCostOfLoan"
        Me.lblCostOfLoan.Size = New System.Drawing.Size(0, 13)
        Me.lblCostOfLoan.TabIndex = 23
        '
        'lblNOM
        '
        Me.lblNOM.AutoSize = True
        Me.lblNOM.Location = New System.Drawing.Point(143, 91)
        Me.lblNOM.Name = "lblNOM"
        Me.lblNOM.Size = New System.Drawing.Size(0, 13)
        Me.lblNOM.TabIndex = 22
        '
        'lblMonthInterestRate
        '
        Me.lblMonthInterestRate.AutoSize = True
        Me.lblMonthInterestRate.Location = New System.Drawing.Point(143, 44)
        Me.lblMonthInterestRate.Name = "lblMonthInterestRate"
        Me.lblMonthInterestRate.Size = New System.Drawing.Size(0, 13)
        Me.lblMonthInterestRate.TabIndex = 21
        '
        'lblLoanAmount
        '
        Me.lblLoanAmount.AutoSize = True
        Me.lblLoanAmount.Location = New System.Drawing.Point(143, 21)
        Me.lblLoanAmount.Name = "lblLoanAmount"
        Me.lblLoanAmount.Size = New System.Drawing.Size(0, 13)
        Me.lblLoanAmount.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Total Interest:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Total cost of the Loan:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Number of Months:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Monthly Interest Rate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Loan Amount:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 208)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.inpLT)
        Me.Controls.Add(Me.inpLR)
        Me.Controls.Add(Me.inpLA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Loan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents inpLA As TextBox
    Friend WithEvents inpLR As TextBox
    Friend WithEvents inpLT As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblInterest As Label
    Friend WithEvents lblCostOfLoan As Label
    Friend WithEvents lblNOM As Label
    Friend WithEvents lblMonthInterestRate As Label
    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents errTxt As Label
    Friend WithEvents lblYearInterestRate As Label
    Friend WithEvents Label11 As Label
End Class
