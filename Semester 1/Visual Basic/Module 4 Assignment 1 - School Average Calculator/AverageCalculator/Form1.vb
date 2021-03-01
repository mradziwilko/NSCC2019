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
    Dim intNumberAdd As Decimal
    Dim intNumberDiv As Decimal
    Dim fldEmpty As Boolean
    Dim fldIsNumb As Boolean
    Dim fldBetween As Boolean
    Dim frmError As Boolean



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    ' Click Calculate Button
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        lblError.Text = ""

        ' Check for Feilds if Empty
        fldEmpty = ChkFeilds()
        If fldEmpty = True Then
            lblError.ForeColor = Color.Red
            lblError.Text = "Empty Feilds"
            frmError = True
        Else

            ' Check if is Number
            fldIsNumb = ChkifNumber()
            If fldIsNumb = True Then
                lblError.ForeColor = Color.Red
                lblError.Text = "Fields Non Numaric"
                frmError = True
            Else

                ' Check if is Higher then 0 and lower then 100
                fldBetween = ChkVal()
                If fldBetween = True Then
                    lblError.ForeColor = Color.Red
                    lblError.Text = "Feild not Between 0 - 100."
                    frmError = True
                Else

                    ' No Errors Calculate and Format
                    Calculate()
                End If
            End If
        End If

    End Sub


    Function ChkFeilds() As Boolean

        ' true = is Empty, false = Is not empty
        If txtNumb1.Text = "" Or txtNumb2.Text = "" Or txtNumb3.Text = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Function ChkifNumber() As Boolean

        ' true = is not a number, false = Is a Number
        If IsNumeric(txtNumb1.Text) = False Or IsNumeric(txtNumb2.Text) = False Or IsNumeric(txtNumb3.Text) = False Then
            Return True
        Else
            Return False
        End If

    End Function

    Function ChkVal() As Boolean
        Dim intNumb1 As Decimal = Convert.ToDecimal(txtNumb1.Text)
        Dim intNumb2 As Decimal = Convert.ToDecimal(txtNumb2.Text)
        Dim intNumb3 As Decimal = Convert.ToDecimal(txtNumb3.Text)

        ' if Number 1 to 3 is Greater then or equal 0 but less then or equal to 100, 
        ' true = is Error, false = no Error
        If intNumb1 >= 0 And intNumb1 <= 100 Then
            If intNumb2 >= 0 And intNumb2 <= 100 Then
                If intNumb3 >= 0 And intNumb3 <= 100 Then
                Else
                    Return True
                End If
            Else
                Return True
            End If
        Else
            Return True
        End If


    End Function

    Sub Calculate()
        ' Set Values
        decNumb1 = Convert.ToDecimal(txtNumb1.Text)
        decNumb2 = Convert.ToDecimal(txtNumb2.Text)
        decNumb3 = Convert.ToDecimal(txtNumb3.Text)


        ' Calculate Average
        intNumberAdd = (decNumb1 + decNumb2 + decNumb3)
        intNumberDiv = (intNumberAdd / 3) / 100

        ' Set text Color and Text and Add %
        lblAver.Text = $"{intNumberDiv.ToString("P2")}"


        ' Change Color if is Red = Less then 60, Green = 60 or greater.
        If (Math.Round(intNumberDiv) < 0.6) Then
            lblAver.ForeColor = Color.Red



        Else
            lblAver.ForeColor = Color.Green



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
