<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumb1 = New System.Windows.Forms.TextBox()
        Me.txtNumb2 = New System.Windows.Forms.TextBox()
        Me.txtNumb3 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAver = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblEligable = New System.Windows.Forms.Label()
        Me.imgCross = New System.Windows.Forms.PictureBox()
        Me.imgCheck = New System.Windows.Forms.PictureBox()
        CType(Me.imgCross, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grade 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Grade 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grade 3:"
        '
        'txtNumb1
        '
        Me.txtNumb1.Location = New System.Drawing.Point(84, 71)
        Me.txtNumb1.Name = "txtNumb1"
        Me.txtNumb1.Size = New System.Drawing.Size(409, 20)
        Me.txtNumb1.TabIndex = 3
        '
        'txtNumb2
        '
        Me.txtNumb2.Location = New System.Drawing.Point(84, 96)
        Me.txtNumb2.Name = "txtNumb2"
        Me.txtNumb2.Size = New System.Drawing.Size(409, 20)
        Me.txtNumb2.TabIndex = 4
        '
        'txtNumb3
        '
        Me.txtNumb3.Location = New System.Drawing.Point(83, 122)
        Me.txtNumb3.Name = "txtNumb3"
        Me.txtNumb3.Size = New System.Drawing.Size(409, 20)
        Me.txtNumb3.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(24, 148)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(468, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Average of Numbers:"
        '
        'lblAver
        '
        Me.lblAver.AutoSize = True
        Me.lblAver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAver.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblAver.Location = New System.Drawing.Point(134, 184)
        Me.lblAver.Name = "lblAver"
        Me.lblAver.Size = New System.Drawing.Size(0, 13)
        Me.lblAver.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(479, 42)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "AVERAGE CALCULATOR"
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(24, 220)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(105, 220)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(186, 223)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 16)
        Me.lblError.TabIndex = 12
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEligable
        '
        Me.lblEligable.AutoSize = True
        Me.lblEligable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEligable.ForeColor = System.Drawing.Color.Green
        Me.lblEligable.Location = New System.Drawing.Point(337, 182)
        Me.lblEligable.Name = "lblEligable"
        Me.lblEligable.Size = New System.Drawing.Size(121, 16)
        Me.lblEligable.TabIndex = 13
        Me.lblEligable.Text = "Re-write eligible"
        Me.lblEligable.Visible = False
        '
        'imgCross
        '
        Me.imgCross.Image = Global.AverageCalculator.My.Resources.Resources.cross
        Me.imgCross.InitialImage = CType(resources.GetObject("imgCross.InitialImage"), System.Drawing.Image)
        Me.imgCross.Location = New System.Drawing.Point(303, 179)
        Me.imgCross.Name = "imgCross"
        Me.imgCross.Size = New System.Drawing.Size(28, 25)
        Me.imgCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCross.TabIndex = 15
        Me.imgCross.TabStop = False
        Me.imgCross.Visible = False
        '
        'imgCheck
        '
        Me.imgCheck.Image = Global.AverageCalculator.My.Resources.Resources.check
        Me.imgCheck.InitialImage = CType(resources.GetObject("imgCheck.InitialImage"), System.Drawing.Image)
        Me.imgCheck.Location = New System.Drawing.Point(303, 179)
        Me.imgCheck.Name = "imgCheck"
        Me.imgCheck.Size = New System.Drawing.Size(28, 25)
        Me.imgCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCheck.TabIndex = 14
        Me.imgCheck.TabStop = False
        Me.imgCheck.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgCheck)
        Me.Controls.Add(Me.lblEligable)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAver)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumb3)
        Me.Controls.Add(Me.txtNumb2)
        Me.Controls.Add(Me.txtNumb1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgCross)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Average Calculator"
        CType(Me.imgCross, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumb1 As TextBox
    Friend WithEvents txtNumb2 As TextBox
    Friend WithEvents txtNumb3 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAver As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblError As Label
    Friend WithEvents lblEligable As Label
    Friend WithEvents imgCheck As PictureBox
    Friend WithEvents imgCross As PictureBox
End Class
