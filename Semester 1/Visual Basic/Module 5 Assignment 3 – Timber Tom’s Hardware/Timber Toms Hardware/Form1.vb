Public Class Form1
    Dim txtInpNumber, infErrorMsg, txtQuantity, txtItemName As String
    Dim Discount As Decimal
    Dim infError As Boolean = False
    Dim inpTxt As String
    Dim Subtotal, Total, Tax, calcDisc, newSubtotal, calcTax As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        If lbOrdered.Items.Count = 0 Then

        Else
            inpQuant.Enabled = False
            inpItemNumber.Enabled = False
            btnAdd.Enabled = False
            btnComplete.Enabled = False




            If disc0.Checked = True Then

                Discount = 0
            ElseIf disc10.Checked = True Then

                Discount = 0.1
            ElseIf disc15.Checked = True Then
                Discount = 0.15
            Else
                Discount = 0
            End If

            lbInvoice.Items.Add($"Timber Toms Hardware - {TimeOfDay.ToString("h:mm:ss tt")}")
            lbInvoice.Items.Add("==================================")
            For counter = 0 To (lbOrdered.Items.Count - 1)
                lbInvoice.Items.Add(lbOrdered.Items.Item(counter))
            Next
            lbInvoice.Items.Add("==================================")


            If Discount = 0 Then


                calcTax = Subtotal * 0.15


                Total = Subtotal + calcTax


                lbInvoice.Items.Add($"Subtotal: {Subtotal.ToString("C2")}")
                lbInvoice.Items.Add($"Tax: {calcTax.ToString("C2")}")
                lbInvoice.Items.Add($"Total: {Total.ToString("C2")}")




            Else
                calcDisc = Subtotal * Discount
                newSubtotal = Subtotal - calcDisc

                calcTax = newSubtotal * 0.15


                Total = newSubtotal + calcTax


                lbInvoice.Items.Add($"Subtotal: {Subtotal.ToString("C2")}")
                lbInvoice.Items.Add($"Discount: {calcDisc.ToString("C2")}")
                lbInvoice.Items.Add($"Tax: {calcTax.ToString("C2")}")
                lbInvoice.Items.Add($"Total: {Total.ToString("C2")}")


            End If



        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        inpQuant.Enabled = True
        inpItemNumber.Enabled = True
        lbInvoice.Items.Clear()
        lbOrdered.Items.Clear()
        btnAdd.Enabled = True
        btnComplete.Enabled = True
        Subtotal = 0
        Total = 0

        disc0.Select()

    End Sub

    Dim itemprice As Decimal
    Dim itemNumber As Integer



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtInpNumber = inpItemNumber.Text
        txtQuantity = inpQuant.Text
        infError = False

        If IsNumeric(txtInpNumber) And IsNumeric(txtQuantity) And Not txtInpNumber = "" And Not txtQuantity = "" Then

            Select Case txtInpNumber
                Case 100
                    itemNumber = 100
                    txtItemName = "Wrench"
                    itemprice = 3.5
                Case 101
                    itemNumber = 101
                    txtItemName = "Pipe wrench"
                    itemprice = 5.75
                Case 200
                    itemNumber = 200
                    txtItemName = "Rip saw"
                    itemprice = 16.23
                Case 201
                    itemNumber = 201
                    txtItemName = "Framing Hammer"
                    itemprice = 32.5
                Case 203
                    itemNumber = 203
                    txtItemName = "Framing square"
                    itemprice = 27.5
                Case 305
                    itemNumber = 305
                    txtItemName = "Solder (roll)"
                    itemprice = 6.34
                Case 306
                    itemNumber = 306
                    txtItemName = "Paste"
                    itemprice = 4.26
                Case Else
                    infError = True
                    infErrorMsg = "Invalid Choice."

            End Select

        Else
            If Not IsNumeric(txtInpNumber) Or txtInpNumber = "" Then
                infErrorMsg = "Item Number is Empty or a Incorrect Value."
                infError = True
            ElseIf Not IsNumeric(txtQuantity) Or txtQuantity = "" Then
                infErrorMsg = "Quantity is Empty or a Incorrect Value."
                infError = True
            End If
        End If


        If infError = True Then
            MsgBox($"Error: {infErrorMsg}")

        Else
            inpTxt = $"{itemNumber} {vbTab} {txtItemName} {vbTab} {itemprice.ToString("C2")} {vbTab} {txtQuantity}"


            Subtotal = Subtotal + (itemprice * txtQuantity)
            lbOrdered.Items.Add(inpTxt)


        End If


    End Sub


End Class
