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
        Me.inpInstructor = New System.Windows.Forms.TextBox()
        Me.inpClassroom = New System.Windows.Forms.TextBox()
        Me.inpSearch = New System.Windows.Forms.TextBox()
        Me.rbInstructor = New System.Windows.Forms.RadioButton()
        Me.rbClassroom = New System.Windows.Forms.RadioButton()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Instructor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Classroom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Search"
        '
        'inpInstructor
        '
        Me.inpInstructor.Location = New System.Drawing.Point(9, 41)
        Me.inpInstructor.Name = "inpInstructor"
        Me.inpInstructor.Size = New System.Drawing.Size(175, 20)
        Me.inpInstructor.TabIndex = 3
        '
        'inpClassroom
        '
        Me.inpClassroom.Location = New System.Drawing.Point(9, 95)
        Me.inpClassroom.Name = "inpClassroom"
        Me.inpClassroom.Size = New System.Drawing.Size(175, 20)
        Me.inpClassroom.TabIndex = 4
        '
        'inpSearch
        '
        Me.inpSearch.Location = New System.Drawing.Point(21, 41)
        Me.inpSearch.Name = "inpSearch"
        Me.inpSearch.Size = New System.Drawing.Size(184, 20)
        Me.inpSearch.TabIndex = 5
        '
        'rbInstructor
        '
        Me.rbInstructor.AutoSize = True
        Me.rbInstructor.Checked = True
        Me.rbInstructor.Location = New System.Drawing.Point(21, 73)
        Me.rbInstructor.Name = "rbInstructor"
        Me.rbInstructor.Size = New System.Drawing.Size(69, 17)
        Me.rbInstructor.TabIndex = 6
        Me.rbInstructor.TabStop = True
        Me.rbInstructor.Text = "Instructor"
        Me.rbInstructor.UseVisualStyleBackColor = True
        '
        'rbClassroom
        '
        Me.rbClassroom.AutoSize = True
        Me.rbClassroom.Location = New System.Drawing.Point(21, 96)
        Me.rbClassroom.Name = "rbClassroom"
        Me.rbClassroom.Size = New System.Drawing.Size(73, 17)
        Me.rbClassroom.TabIndex = 7
        Me.rbClassroom.TabStop = True
        Me.rbClassroom.Text = "Classroom"
        Me.rbClassroom.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(9, 134)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(175, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(21, 134)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(184, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.inpInstructor)
        Me.GroupBox1.Controls.Add(Me.inpClassroom)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 180)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Teacher"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.inpSearch)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.rbInstructor)
        Me.GroupBox2.Controls.Add(Me.rbClassroom)
        Me.GroupBox2.Location = New System.Drawing.Point(214, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 180)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 204)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Teachers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents inpInstructor As TextBox
    Friend WithEvents inpClassroom As TextBox
    Friend WithEvents inpSearch As TextBox
    Friend WithEvents rbInstructor As RadioButton
    Friend WithEvents rbClassroom As RadioButton
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
