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
    Dim intNumb1 As Decimal
    Dim intNumb2 As Decimal
    Dim intNumb3 As Decimal
    Dim intNumberAdd As Decimal
    Dim intNumberDiv As Decimal
    Dim intDivDivision As Decimal
    Dim fldEmpty As Boolean
    Dim fldIsNumb As Boolean
    Dim fldBetween As Boolean
    Dim frmError As Boolean



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    ' Click Calculate Button
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        lblError.Text = ""
        lblEligable.Visible = False
        lblEligable.Text = ""
        lblEligable.ForeColor = Color.Black

        If txtNumb1.Text = "" Or txtNumb2.Text = "" Or txtNumb3.Text = "" Then
            ' Throw Error
            lblError.Text = "Values Empty"
        Else
            ' true = is not a number, false = Is a Number
            If Not IsNumeric(txtNumb1.Text) Or Not IsNumeric(txtNumb2.Text) Or Not IsNumeric(txtNumb3.Text) Then
                ' Throw Error
                lblError.Text = "Not a Number"
            Else

                intNumb1 = Convert.ToDecimal(txtNumb1.Text)
                intNumb2 = Convert.ToDecimal(txtNumb2.Text)
                intNumb3 = Convert.ToDecimal(txtNumb3.Text)

                If intNumb1 > 0 And intNumb1 < 100 And intNumb2 > 0 And intNumb2 < 100 And intNumb3 > 0 And intNumb3 < 100 Then


                    ' Calculate Average
                    intNumberAdd = (intNumb1 + intNumb2 + intNumb3)
                    intNumberDiv = intNumberAdd / 3

                    intDivDivision = intNumberDiv / 100

                    If intNumberDiv < 59 Then

                        If intNumb1 >= 95 Or intNumb2 >= 95 Or intNumb3 >= 95 Then
                            ShowCheck()
                            HideCross()
                            lblEligable.Visible = True
                            lblEligable.ForeColor = Color.Green
                            lblEligable.Text = "Re-write eligible."


                        Else
                            ShowCross()
                            HideCheck()
                            lblEligable.Visible = True
                            lblEligable.ForeColor = Color.Red
                            lblEligable.Text = "No Re-write eligible."



                        End If


                    Else
                        ShowCheck()
                        HideCross()
                        lblEligable.Visible = True
                        lblEligable.ForeColor = Color.Green
                        lblEligable.Text = "Passed."

                    End If


                    If (Math.Round(intNumberDiv) < 59) Then
                        lblAver.ForeColor = Color.Red
                    Else
                        lblAver.ForeColor = Color.Green
                    End If

                    lblAver.Text = intDivDivision.ToString("p0")


                Else
                    lblError.Text = "Numbers are to Big"

                End If
            End If

        End If

    End Sub

    Function ShowCheck()
        imgCheck.Visible = True

    End Function
    Function HideCheck()
        imgCheck.Visible = False

    End Function
    Function ShowCross()
        imgCross.Visible = True
    End Function
    Function HideCross()
        imgCross.Visible = False
    End Function


    ' End Application
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub


End Class
