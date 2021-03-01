Public Class Form1

    ' Declare Costables
    Const cn_MovieTicket As String = "Movie Ticket",
          cn_Popcorn As String = "Popcorn",
          cn_Pop As String = "Pop",
          cn_Bars As String = "Bars",
          cp_MovieTicket As Decimal = 14.99,
          cp_SmallPopcorn As Decimal = 3.99,
          cp_MediumPopcorn As Decimal = 4.99,
          cp_LargePopcorn As Decimal = 5.99,
          cp_SmallPop As Decimal = 4.0,
          cp_MediumPop As Decimal = 5.0,
          cp_LargePop As Decimal = 6.5,
          cp_Bars As Decimal = 2.99,
          c_tax As Decimal = 0.15,
          c_disc As Decimal = 0.1
    ' Set Product List 
    Dim listProduct() As String = {cn_MovieTicket, cn_Popcorn, cn_Pop, cn_Bars}

    ' Declare Global Values
    Dim currTotal As Decimal
    Dim SItem, inpDoW As String
    Dim SetDisc As Boolean



    ' On Load set List items for Products
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetListItems()
    End Sub


    ' Date value on change, recalculate totals if day is Tuesday, else recalculate with no discount.
    Private Sub inpDate_ValueChanged(sender As Object, e As EventArgs) Handles inpDate.ValueChanged

        inpDoW = inpDate.Value.DayOfWeek
        SetDisc = ChkDisc(inpDoW)
        calcTotals(SetDisc)

    End Sub

    ' Add Item to list
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        Try
            ' Set Temp values for Add Button.
            Dim selItem As String = cbproduct.SelectedItem
            Dim selSize As String = ""
            Dim selPrice As Decimal
            Dim selQuantity As Decimal = txtQuantity.Text
            Dim selPriceST As Decimal

            ' Throw error if Item is empty
            If selItem = "" Then
                Throw New NullReferenceException("Error: Product not Selected")
            End If

            ' Set error if Quantity is below 0
            If selQuantity <= 0 Then
                Throw New Exception("Error: Quantity can not be 0 or below.")
            End If


            ' Case for each item, if item is a Popcorn or Pop, make the Size Box Enabled, else if not, set it to Disabled
            Select Case selItem

                Case cn_MovieTicket

                    selPrice = ReturnSize(selItem, "")

                Case cn_Popcorn

                    If rbSmall.Checked = True Then
                        selSize = "Small "
                    ElseIf rbMedium.Checked = True Then
                        selSize = "Medium "
                    ElseIf rbLarge.Checked = True Then
                        selSize = "Large "
                    End If

                    selPrice = ReturnSize(selItem, selSize)

                Case cn_Pop

                    If rbSmall.Checked = True Then
                        selSize = "Small "
                    ElseIf rbMedium.Checked = True Then
                        selSize = "Medium "
                    ElseIf rbLarge.Checked = True Then
                        selSize = "Large "
                    End If

                    selPrice = ReturnSize(selItem, selSize)

                Case cn_Bars
                    selPrice = ReturnSize(selItem, "")

            End Select

            ' Combine Price + Quantity ordered and Add to List
            selPriceST = selPrice * selQuantity
            lbItems.Items.Add($"{selSize}{selItem}{vbTab}Qty:{selQuantity}{vbTab}Price:{selPrice.ToString("C2")}")
            lbLineTotal.Items.Add($"{selPriceST.ToString("C2")}")


            ' Set Discount if applicable to tuesday
            inpDoW = inpDate.Value.DayOfWeek
            inpDoW = inpDate.Value.DayOfWeek
            SetDisc = ChkDisc(inpDoW)
            ' Calculate Totals
            calcTotals(SetDisc)


            'Error Mesages
        Catch exNull As NullReferenceException
            MsgBox(exNull.Message)
        Catch exICE As InvalidCastException
            MsgBox("Error: Quantity Empty or Invalid.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub SetListItems()
        ' Clear Lists and add new Products
        cbproduct.Items.Clear()
        cbproduct.Items.AddRange(listProduct)
    End Sub


    ' Check Function if is tuesday, if not set return to False.
    Function ChkDisc(inpDoW As String) As Boolean

        If inpDoW = DayOfWeek.Tuesday Then
            Return True
        Else
            Return False

        End If

    End Function


    ' Calculate all totals, check for discount, if discount set discount to 10% off, if no discount calculate total and set discount to 0

    Private Sub calcTotals(setDisc As Boolean)
        Dim Subtotal As Decimal = 0
        Dim calctax As Decimal = 0
        Dim calcdisc As Decimal = 0
        Dim DiscDisc As Decimal = 0
        Dim calcTotal As Decimal = 0

        Subtotal = getListTotals()

        If setDisc = True Then

            calcdisc = Subtotal * c_disc
            DiscDisc = Subtotal - calcdisc
            calctax = funcCalcTax(DiscDisc)
            calcTotal = DiscDisc + calctax

            lbDisc.Text = calcdisc.ToString("C2")
            lbTax.Text = calctax.ToString("C2")
            lbTotal.Text = calcTotal.ToString("C2")

        Else

            calctax = funcCalcTax(Subtotal)
            calcTotal = Subtotal + calctax


            lbDisc.Text = "$0.00"
            lbTax.Text = calctax.ToString("C2")
            lbTotal.Text = calcTotal.ToString("C2")

        End If

        currTotal = calcTotal

    End Sub


    ' Get the totals from List box and return totals
    Function getListTotals() As Decimal
        Dim tmpSubTotal As Decimal = 0

        For i = 0 To lbLineTotal.Items.Count - 1
            tmpSubTotal = tmpSubTotal + lbLineTotal.Items(i)
        Next

        Return tmpSubTotal
    End Function


    ' Calculate tax and return
    Function funcCalcTax(Numb1 As Decimal) As Decimal
        Dim tmpTax As Decimal
        tmpTax = Numb1 * c_tax
        Return tmpTax
    End Function


    ' Return Small, Med, Large prices if product has sizes
    Function ReturnSize(item As String, size As String) As Decimal
        Dim retPrice As Decimal


        If item = cn_Popcorn Then

            Select Case size
                Case "Small "
                    retPrice = cp_SmallPopcorn

                Case "Medium "
                    retPrice = cp_MediumPopcorn
                Case "Large "
                    retPrice = cp_LargePopcorn
            End Select


        ElseIf item = cn_Pop Then

            Select Case size
                Case "Small "
                    retPrice = cp_SmallPop

                Case "Medium "
                    retPrice = cp_MediumPop
                Case "Large "
                    retPrice = cp_LargePop
            End Select


        ElseIf item = cn_MovieTicket Then
            retPrice = cp_MovieTicket
        ElseIf item = cn_Bars Then
            retPrice = cp_Bars
        End If


        Return retPrice


    End Function

    ' Check if product has Size, if size is true then enable the box, else disable.
    Private Sub cbproduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbproduct.SelectedIndexChanged


        SItem = cbproduct.SelectedItem




        Select Case SItem

            Case cn_MovieTicket
                gbSize.Enabled = False
            Case cn_Popcorn
                gbSize.Enabled = True
            Case cn_Pop
                gbSize.Enabled = True
            Case cn_Bars
                gbSize.Enabled = False
        End Select




    End Sub



    ' Check for all feilds, if empty throw errors, else calculate totals.
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try

            If txtPaid.Text = "" Then
                Throw New NullReferenceException("Input Ammount Empty.")
            ElseIf Not IsNumeric(txtPaid.Text) Then

                Throw New NullReferenceException("Input Must be a Number.")

            ElseIf txtPaid.Text <= 0 Then
                Throw New Exception("Input Must be higher then 0.")

            End If

            If lbItems.Items.Count <= 0 Then
                Throw New NullReferenceException("Nothing Added to List")
            End If
            If lbLineTotal.Items.Count <= 0 Then
                Throw New NullReferenceException("Nothing Added to List")
            End If



            Dim ammPaid As Decimal = txtPaid.Text
            Dim ammPaidTotal As Decimal
            DisableUI()

            If ammPaid >= currTotal Then

                ammPaidTotal = (0 - currTotal) + ammPaid


                MsgBox("Change: " & ammPaidTotal.ToString("C2"))
                lbChange.Text = ammPaidTotal.ToString("C2")
                DisableRest()

            Else
                ammPaidTotal = currTotal - ammPaid

                MsgBox("Still owing: " & ammPaidTotal.ToString("C2"))
                EnableUI()




            End If




        Catch exNull As NullReferenceException
            MsgBox(exNull.Message)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    ' Reset Intefrace and Totals and proper fields.
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        EnableUI()
        ResetFeilds()


    End Sub


    ' Reset totals and Labels
    Sub ResetFeilds()
        currTotal = 0

        lbChange.Text = "$"
        lbDisc.Text = "$"
        lbTax.Text = "$"
        lbTotal.Text = "$"
        txtPaid.Text = ""
        txtQuantity.Text = ""
        cbproduct.SelectedIndex = -1
        lbItems.Items.Clear()
        lbLineTotal.Items.Clear()
        gbSize.Enabled = False
        rbSmall.Checked = True
    End Sub

    ' Disable UI, Will make everything not able to be clicked untill reset button is clicked.
    Sub DisableUI()
        gbProduct.Enabled = False
        gbQuantity.Enabled = False
        gbSize.Enabled = False
    End Sub

    ' Only able if price is still owing
    Sub DisableRest()
        btnCalculate.Enabled = False
        txtPaid.Enabled = False


    End Sub


    ' Re-enable UI
    Sub EnableUI()
        gbProduct.Enabled = True
        gbQuantity.Enabled = True
        gbSize.Enabled = True
        btnCalculate.Enabled = True
        txtPaid.Enabled = True
    End Sub

End Class
