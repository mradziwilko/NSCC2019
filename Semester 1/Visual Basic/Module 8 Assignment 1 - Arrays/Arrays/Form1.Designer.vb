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
        Me.lbItems = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbNumber = New System.Windows.Forms.TextBox()
        Me.lblAvrNum = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbItems
        '
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.Location = New System.Drawing.Point(26, 68)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(201, 95)
        Me.lbItems.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(152, 42)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tbNumber
        '
        Me.tbNumber.Location = New System.Drawing.Point(26, 42)
        Me.tbNumber.Name = "tbNumber"
        Me.tbNumber.Size = New System.Drawing.Size(120, 20)
        Me.tbNumber.TabIndex = 2
        '
        'lblAvrNum
        '
        Me.lblAvrNum.AutoSize = True
        Me.lblAvrNum.Location = New System.Drawing.Point(136, 177)
        Me.lblAvrNum.Name = "lblAvrNum"
        Me.lblAvrNum.Size = New System.Drawing.Size(0, 13)
        Me.lblAvrNum.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Average of Numbers:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 248)
        Me.Controls.Add(Me.lblAvrNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNumber)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lbItems)
        Me.Name = "Form1"
        Me.Text = "Arrays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbItems As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents tbNumber As TextBox
    Friend WithEvents lblAvrNum As Label
    Friend WithEvents Label3 As Label
End Class
