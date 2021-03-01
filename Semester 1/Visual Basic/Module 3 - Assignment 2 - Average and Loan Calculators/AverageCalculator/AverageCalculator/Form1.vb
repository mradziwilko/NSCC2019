'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Average Calculator
'Date: 9/25/2019
'Author: Marshall Radziwilko
'Operation: 
' Ask Base Questions
' Add and Devide Numbers
' Output Results
' Exit Application
'
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'9/25/2019 - Added Comments
'10/4/2019 - Added Form UI Eliments and Output
'-----------------------------------------------------------------------------
Public Class frmMain

    ' Declare Variables
    Dim decNumb1 As Decimal
    Dim decNumb2 As Decimal
    Dim decNumb3 As Decimal
    Dim intNumberAdd As Integer
    Dim intNumberDiv As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Click Calculate Button
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        lblError.Text = ""
        ' Check if Values are Empty
        If (txtNumb1.Text = "" Or txtNumb2.Text = "" Or txtNumb3.Text = "") Then
            lblError.ForeColor = Color.Red
            lblError.Text = "Error."
        Else
            ' Set Values
            decNumb1 = txtNumb1.Text
            decNumb2 = txtNumb2.Text
            decNumb3 = txtNumb3.Text


            ' Calculate Average
            intNumberAdd = (decNumb1 + decNumb2 + decNumb3)
            intNumberDiv = (intNumberAdd / 3)

            ' Set text
            lblAver.Text = $"{intNumberDiv.ToString}"

        End If


    End Sub



    ' End Application
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    ' Clear Fields and values
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear Stored Variables
        decNumb1.Equals(vbNullString)
        decNumb2.Equals(vbNullString)
        decNumb3.Equals(vbNullString)


        ' Clear Input boxes
        txtNumb1.Text = ""
        txtNumb2.Text = ""
        txtNumb3.Text = ""
        lblAver.Text = ""

        lblError.ForeColor = Color.Green
        lblError.Text = "Cleared Values."

    End Sub

End Class
