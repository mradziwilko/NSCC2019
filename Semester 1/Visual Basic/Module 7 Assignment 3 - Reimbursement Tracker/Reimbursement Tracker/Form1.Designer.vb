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
        Me.lbNumbers = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbKM = New System.Windows.Forms.TextBox()
        Me.btnIni = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTraveled = New System.Windows.Forms.Label()
        Me.lblTdays = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTReimAmm = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFRKMTrav = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTFRDays = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTFRAmm = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbErrorBox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter KM Traveled"
        '
        'lbNumbers
        '
        Me.lbNumbers.FormattingEnabled = True
        Me.lbNumbers.Location = New System.Drawing.Point(15, 40)
        Me.lbNumbers.Name = "lbNumbers"
        Me.lbNumbers.Size = New System.Drawing.Size(180, 264)
        Me.lbNumbers.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KM"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 336)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tbKM
        '
        Me.tbKM.Location = New System.Drawing.Point(15, 310)
        Me.tbKM.Name = "tbKM"
        Me.tbKM.Size = New System.Drawing.Size(39, 20)
        Me.tbKM.TabIndex = 4
        '
        'btnIni
        '
        Me.btnIni.Location = New System.Drawing.Point(15, 365)
        Me.btnIni.Name = "btnIni"
        Me.btnIni.Size = New System.Drawing.Size(75, 23)
        Me.btnIni.TabIndex = 5
        Me.btnIni.Text = "&Initialize "
        Me.btnIni.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(213, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total KM Traveled"
        '
        'lblTraveled
        '
        Me.lblTraveled.AutoSize = True
        Me.lblTraveled.Location = New System.Drawing.Point(213, 63)
        Me.lblTraveled.Name = "lblTraveled"
        Me.lblTraveled.Size = New System.Drawing.Size(0, 13)
        Me.lblTraveled.TabIndex = 7
        '
        'lblTdays
        '
        Me.lblTdays.AutoSize = True
        Me.lblTdays.Location = New System.Drawing.Point(213, 111)
        Me.lblTdays.Name = "lblTdays"
        Me.lblTdays.Size = New System.Drawing.Size(0, 13)
        Me.lblTdays.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Days"
        '
        'lblTReimAmm
        '
        Me.lblTReimAmm.AutoSize = True
        Me.lblTReimAmm.Location = New System.Drawing.Point(213, 162)
        Me.lblTReimAmm.Name = "lblTReimAmm"
        Me.lblTReimAmm.Size = New System.Drawing.Size(0, 13)
        Me.lblTReimAmm.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(213, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Total Reimbursement Amount ($)"
        '
        'lblFRKMTrav
        '
        Me.lblFRKMTrav.AutoSize = True
        Me.lblFRKMTrav.Location = New System.Drawing.Point(213, 218)
        Me.lblFRKMTrav.Name = "lblFRKMTrav"
        Me.lblFRKMTrav.Size = New System.Drawing.Size(0, 13)
        Me.lblFRKMTrav.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(213, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Total Flat Rate Kms Travelled"
        '
        'lblTFRDays
        '
        Me.lblTFRDays.AutoSize = True
        Me.lblTFRDays.Location = New System.Drawing.Point(213, 269)
        Me.lblTFRDays.Name = "lblTFRDays"
        Me.lblTFRDays.Size = New System.Drawing.Size(0, 13)
        Me.lblTFRDays.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(213, 245)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Total Flat Rate Days"
        '
        'lblTFRAmm
        '
        Me.lblTFRAmm.AutoSize = True
        Me.lblTFRAmm.Location = New System.Drawing.Point(213, 315)
        Me.lblTFRAmm.Name = "lblTFRAmm"
        Me.lblTFRAmm.Size = New System.Drawing.Size(0, 13)
        Me.lblTFRAmm.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(213, 291)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(162, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Total Flat Rate Ammount($)"
        '
        'tbErrorBox
        '
        Me.tbErrorBox.AutoSize = True
        Me.tbErrorBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbErrorBox.Location = New System.Drawing.Point(12, 436)
        Me.tbErrorBox.Name = "tbErrorBox"
        Me.tbErrorBox.Size = New System.Drawing.Size(78, 20)
        Me.tbErrorBox.TabIndex = 18
        Me.tbErrorBox.Text = "ERROR:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 458)
        Me.Controls.Add(Me.tbErrorBox)
        Me.Controls.Add(Me.lblTFRAmm)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblTFRDays)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblFRKMTrav)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTReimAmm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTdays)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTraveled)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIni)
        Me.Controls.Add(Me.tbKM)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbNumbers)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbNumbers As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents tbKM As TextBox
    Friend WithEvents btnIni As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTraveled As Label
    Friend WithEvents lblTdays As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTReimAmm As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblFRKMTrav As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTFRDays As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTFRAmm As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbErrorBox As Label
End Class
