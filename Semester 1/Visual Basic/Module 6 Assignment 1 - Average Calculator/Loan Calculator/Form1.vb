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
    Dim errorMSG As String
    Dim errorType As String
    Dim errorCust As Boolean = False


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        inpLA.BackColor = Color.White
        inpLR.BackColor = Color.White
        inpLT.BackColor = Color.White

        errorCust = False




        Try

            ' Get Values from boxes

            decLoanAmm = inpLA.Text
            decLoanRate = inpLR.Text
            intLoanTerm = inpLT.Text


            If decLoanAmm < 0 Then
                errorCust = True

                inpLA.BackColor = Color.Red
                errorType = "Error: Loan Ammount."
                errorMSG = "Message: Input below 0"
                Throw New Exception
            ElseIf decLoanRate < 0 Then
                errorCust = True

                inpLR.BackColor = Color.Red
                errorType = "Error: Loan Rate "
                errorMSG = "Message: Input below 0"
                Throw New Exception

            ElseIf intLoanTerm < 0 Then
                errorCust = True


                inpLT.BackColor = Color.Red
                errorType = "Error: Loan Term."
                errorMSG = "Message: Input below 0"
                Throw New Exception
            End If

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





        Catch exDivbyZero As DivideByZeroException

            MsgBox($"Error: Cannot Divide by 0.")

        Catch exInvalidCast As InvalidCastException

            If inpLA.Text = "" Then
                errorType = "Error: Input Ammount Invalid"
                errorMSG = "Message: Input not Valud, Only Numbers."
                inpLA.BackColor = Color.Red

            ElseIf Not IsNumeric(inpLA.Text) Then
                errorType = "Error: Input Ammount Invalid"
                errorMSG = "Message: Input not Valud, Only Numbers."
                inpLA.BackColor = Color.Red


            ElseIf inpLR.Text = "" Then
                errorType = "Error: Loan Rate Invalid"
                errorMSG = "Message: Input not Valud, Only Numbers."
                inpLR.BackColor = Color.Red

            ElseIf Not IsNumeric(inpLR.Text) Then
                errorType = "Error: Loan Rate Invalid"
                errorMSG = "Message: Input not Valud, Only Numbers."
                inpLR.BackColor = Color.Red

            ElseIf inpLT.Text = "" Then
                errorType = "Error: Loan Term"
                errorMSG = "Message: Input not Valud, Only Numbers."
                inpLT.BackColor = Color.Red

            ElseIf Not IsNumeric(inpLT.Text) Then
                errorType = "Error: Loan Term"
                errorMSG = "Message: Input not Valud, Only Numbers."
                inpLT.BackColor = Color.Red
            End If


            MsgBox($"Type: {errorType} {vbCrLf}Message: {errorMSG}")

        Catch ex As Exception

            If errorCust = True Then
                MsgBox($"Type: {errorType} {vbCrLf}Message: {errorMSG}")
            Else
                MsgBox($"{ex.Message}")
            End If



        End Try



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
    Private Sub inputsA_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inpLA.GotFocus
        inpLA.BackColor = Color.White
        inpLA.Text = ""

    End Sub
    Private Sub inputsB_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inpLR.GotFocus

        inpLR.BackColor = Color.White
        inpLR.Text = ""


    End Sub
    Private Sub inputsC_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inpLT.GotFocus
        inpLT.Text = ""
        inpLT.BackColor = Color.White



    End Sub

End Class
