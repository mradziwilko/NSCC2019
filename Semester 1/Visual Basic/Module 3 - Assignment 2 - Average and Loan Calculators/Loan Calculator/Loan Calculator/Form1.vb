'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Interest Calculator Formed
'Date: 9/25/2019
'Author: Marshall Radziwilko
'Operation: 
' Ask Questions 
' Do Calculations
' Output Results
' Exit Application
'
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date 		 Programmer 		  Change 
'9/25/2019 - Marshall Radziwiko - Added Comments
'10/4/2019 - Marshall Radziwilko - Added Formed Values and Inputs and Outputs
'-----------------------------------------------------------------------------

Public Class Form1

    Dim decLoanAmm As Decimal
    Dim decLoanRate As Decimal
    Dim intLoanTerm As Integer
    Dim Rate As Decimal
    Dim Upper As Decimal
    Dim Lower As Decimal
    Dim Divide As Decimal
    Dim Times As Decimal
    Dim Shrink As Decimal
    Dim intrest As Decimal

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        errTxt.Text = ""

        ' Check for Empty Values, if empty Show error. Else continue with Code.
        If (inpLA.Text = "" Or inpLR.Text = "" Or inpLT.Text = "") Then
            errTxt.ForeColor = Color.Red
            errTxt.Text = "Form Feilds are Blank."
        Else

            ' Get Values from boxes
            decLoanAmm = inpLA.Text
            decLoanRate = inpLR.Text
            intLoanTerm = inpLT.Text



            ' Calculate Rate
            Rate = ((decLoanRate / 100) / 12)

            'Calculate Upper Ammount
            Upper = Rate * decLoanAmm

            'Calculate Lower Ammount
            Lower = (1 - ((1 + Rate) ^ (-1 * intLoanTerm)))

            'Devide Upper by Lower
            Divide = Upper / Lower

            'Multiply by Loan term
            Times = Divide * intLoanTerm

            'Round Number to Whole Number with 2 Decimal Places
            Shrink = Math.Round(Times, 2)

            'Get Loan Rate Cost and Shrink
            intrest = Math.Round(Shrink - decLoanAmm, 2)


            ' Set Each label with proper ammounts.
            lblLoanAmount.Text = decLoanAmm.ToString("C")
            lblMonthInterestRate.Text = Rate.ToString("p")
            lblYearInterestRate.Text = decLoanRate & "%"

            lblNOM.Text = intLoanTerm.ToString
            lblCostOfLoan.Text = Shrink.ToString("C")
            lblInterest.Text = intrest.ToString("C")




        End If


    End Sub


    ' Only Allow Numbers and . to be inside text boxes, 
    Private Sub inpLA_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inpLA.KeyPress

        If Asc(e.KeyChar) <> 8 AndAlso Not e.KeyChar = "." Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub inpLR_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inpLR.KeyPress

        If Asc(e.KeyChar) <> 8 AndAlso Not e.KeyChar = "." Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub inpLT_KeyPressed(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inpLT.KeyPress

        If Asc(e.KeyChar) <> 8 AndAlso Not e.KeyChar = "." Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    ' Exit Application
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub



    ' Clear values
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Clear Output text
        lblCostOfLoan.Text = ""
        lblInterest.Text = ""
        lblLoanAmount.Text = ""
        lblMonthInterestRate.Text = ""
        lblNOM.Text = ""
        lblYearInterestRate.Text = ""

        ' Clear Global Values
        decLoanAmm.Equals(vbNullString)
        decLoanRate.Equals(vbNullString)
        intLoanTerm.Equals(vbNullString)
        Rate.Equals(vbNullString)
        Upper.Equals(vbNullString)
        Lower.Equals(vbNullString)
        Divide.Equals(vbNullString)
        Times.Equals(vbNullString)
        Shrink.Equals(vbNullString)
        intrest.Equals(vbNullString)

        ' Clear Input Boxes
        inpLA.Text = ""
        inpLR.Text = ""
        inpLT.Text = ""


        ' Show note for Cleared Values
        errTxt.Text = "Cleared Values"
        errTxt.ForeColor = Color.Green

    End Sub
End Class
