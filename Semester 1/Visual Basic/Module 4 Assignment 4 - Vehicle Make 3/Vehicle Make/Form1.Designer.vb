<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.cbManufacture = New System.Windows.Forms.ComboBox()
        Me.lblModels = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbManufacture
        '
        Me.cbManufacture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbManufacture.BackColor = System.Drawing.Color.White
        Me.cbManufacture.FormattingEnabled = True
        Me.cbManufacture.Items.AddRange(New Object() {""})
        Me.cbManufacture.Location = New System.Drawing.Point(3, 25)
        Me.cbManufacture.Name = "cbManufacture"
        Me.cbManufacture.Size = New System.Drawing.Size(220, 21)
        Me.cbManufacture.TabIndex = 1
        Me.cbManufacture.Text = "Please Select a Manufacture"
        '
        'lblModels
        '
        Me.lblModels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblModels.FormattingEnabled = True
        Me.lblModels.Location = New System.Drawing.Point(3, 72)
        Me.lblModels.Name = "lblModels"
        Me.lblModels.Size = New System.Drawing.Size(220, 119)
        Me.lblModels.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Model's:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Manufacturer's:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Green
        Me.lblPrice.Location = New System.Drawing.Point(17, 201)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 20)
        Me.lblPrice.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 53)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblModels)
        Me.Controls.Add(Me.cbManufacture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Vehicle Make Selector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbManufacture As ComboBox
    Friend WithEvents lblModels As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrice As Label
End Class
