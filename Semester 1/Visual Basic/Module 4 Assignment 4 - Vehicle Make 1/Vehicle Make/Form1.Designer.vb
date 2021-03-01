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
        Me.cbManufacture = New System.Windows.Forms.ComboBox()
        Me.lbModels = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMan = New System.Windows.Forms.Label()
        Me.lblMod = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbManufacture
        '
        Me.cbManufacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbManufacture.FormattingEnabled = True
        Me.cbManufacture.Items.AddRange(New Object() {"Dodge", "Ford", "Telsa", "Toyota"})
        Me.cbManufacture.Location = New System.Drawing.Point(12, 42)
        Me.cbManufacture.Name = "cbManufacture"
        Me.cbManufacture.Size = New System.Drawing.Size(202, 21)
        Me.cbManufacture.TabIndex = 0
        '
        'lbModels
        '
        Me.lbModels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbModels.FormattingEnabled = True
        Me.lbModels.Location = New System.Drawing.Point(12, 90)
        Me.lbModels.Name = "lbModels"
        Me.lbModels.Size = New System.Drawing.Size(202, 93)
        Me.lbModels.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Model's:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Manufacturer's:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Selected Manufacture:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Selected Model:"
        '
        'lblMan
        '
        Me.lblMan.AutoSize = True
        Me.lblMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMan.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMan.Location = New System.Drawing.Point(354, 45)
        Me.lblMan.Name = "lblMan"
        Me.lblMan.Size = New System.Drawing.Size(45, 15)
        Me.lblMan.TabIndex = 6
        Me.lblMan.Text = "None."
        '
        'lblMod
        '
        Me.lblMod.AutoSize = True
        Me.lblMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMod.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMod.Location = New System.Drawing.Point(354, 90)
        Me.lblMod.Name = "lblMod"
        Me.lblMod.Size = New System.Drawing.Size(45, 15)
        Me.lblMod.TabIndex = 7
        Me.lblMod.Text = "None."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 191)
        Me.Controls.Add(Me.lblMod)
        Me.Controls.Add(Me.lblMan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbModels)
        Me.Controls.Add(Me.cbManufacture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Vehicle Make Selector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbManufacture As ComboBox
    Friend WithEvents lbModels As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMan As Label
    Friend WithEvents lblMod As Label
End Class
