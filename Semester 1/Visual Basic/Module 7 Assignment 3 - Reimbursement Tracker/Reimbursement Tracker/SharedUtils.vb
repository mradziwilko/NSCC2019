Module SharedUtils
    ' Main Function
    Sub Calculate(lbKM As ListBox, frmMain As Form1)

        ' Local Variables
        Dim inpTotal, inpDays, inpFRTrav, inpFRDay As Integer
        Dim inpRemAmm, inpFRAmm As Decimal
        Dim currSel As Decimal
        Dim FRorNoFR As Boolean = False

        ' Get the Total of KM From Listbox
        inpTotal = CalcKMTotals(lbKM)

        ' Get the Total Days from Listbox
        inpDays = showDaysTraveled(lbKM)


        ' For Each item in Listbox do something
        For i = 0 To lbKM.Items.Count - 1
            ' Set Current Selection
            currSel = lbKM.Items(i)


            ' Check if Value is Flat Rate or Normal Rate True = Flat Rate, False = Norm Rate
            FRorNoFR = CheckifFR(currSel)


            If FRorNoFR = True Then

                ' Add Item to Flat Rate Section and add to Total Amount 
                inpFRTrav += currSel
                inpFRDay += 1
                inpFRAmm += 150
                inpRemAmm += 150


            Else

                ' Calculate Normal Rate
                inpRemAmm += CountNormDays(currSel)
            End If

        Next


        ' Display Totals:
        frmMain.lblTraveled.Text = inpTotal
        frmMain.lblTdays.Text = inpDays
        frmMain.lblTReimAmm.Text = inpRemAmm.ToString("C2")
        frmMain.lblFRKMTrav.Text = inpFRTrav
        frmMain.lblTFRDays.Text = inpFRDay
        frmMain.lblTFRAmm.Text = inpFRAmm.ToString("C2")


    End Sub


    ' Reset all feilds, clear Listbox and KM feilds
    Sub initilize(frmMain As Form1)

        frmMain.lbNumbers.Items.Clear()
        frmMain.tbKM.Clear()
        frmMain.lblTraveled.Text = "0"
        frmMain.lblTdays.Text = "0"
        frmMain.lblTReimAmm.Text = "$"
        frmMain.lblFRKMTrav.Text = "0"
        frmMain.lblTFRDays.Text = "0"
        frmMain.lblTFRAmm.Text = "$"
        frmMain.tbErrorBox.Text = ""
        clearError(frmMain, Color.Red)
    End Sub

    ' Clear Error text, Just used for Astetics
    Sub clearError(frmMain As Form1, colorcode As Color)
        frmMain.tbErrorBox.ForeColor = colorcode
        frmMain.tbErrorBox.Text = ""
    End Sub


    ' Get Error Code, and Post in Error Text Result.
    Sub funerror(Code As Integer, frmMain As Form1, Optional Feild As String = "")
        frmMain.tbErrorBox.Text = rtnError(Code, Feild)
    End Sub

    ' Add Entered item to List box *Numbers*
    Sub AddItem(Numb As Integer, frmMain As Form1)
        frmMain.lbNumbers.Items.Add(Numb)
    End Sub



    ' Returns Days Traveled from Listbox
    Function showDaysTraveled(lbNumbers As ListBox) As Integer
        Return lbNumbers.Items.Count
    End Function


    ' Check if Flat Rate or Norm Rate, True = Flat Rate, False = Norm Rate
    Function CheckifFR(amount As Integer) As Boolean
        Dim tmpVal As Boolean = False
        If amount <= 300 Then
            tmpVal = False
        Else
            tmpVal = True

        End If

        Return tmpVal

    End Function



    ' get the math for normal day KM, output Amount
    Function CountNormDays(Amount As Decimal) As Decimal
        Dim tmpRetVal As Decimal
        tmpRetVal = 0.53 * Amount
        Return tmpRetVal
    End Function


    ' Calculate all totals of KM Driven return as Integer
    Function CalcKMTotals(KMList As ListBox) As Integer
        Dim Subtotal As Integer = 0
        For i = 0 To KMList.Items.Count - 1
            Subtotal += KMList.Items(i)
        Next
        Return Subtotal
    End Function


    'Return Error Code for System.
    Function rtnError(Code As Integer, Optional Feild As String = "") As String
        Dim rtnString As String
        Select Case Code

            Case 401 ' Invalid Number, such as  letter.
                rtnString = $"{Feild} Error: Not a valid number."
            Case 402
                rtnString = $"{Feild} Error: KM Must be 0 or Higher."
            Case 403
                rtnString = $"{Feild} Error: Cannot Travel over 1000km in one day."
            Case 404
                rtnString = $"{Feild} Error: Empty Feild."
            Case 405
                rtnString = $"{Feild} Error: Must Be Whole Number."
            Case Else
                rtnString = $"Unknown Error: Please try again."
        End Select

        Return rtnString
    End Function



    ' Check if Number is a Whole Value, if not Return False.
    Public Function IsInteger(value As Object) As Boolean
        Dim output As Integer
        If (Integer.TryParse(value.ToString(), output)) Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
