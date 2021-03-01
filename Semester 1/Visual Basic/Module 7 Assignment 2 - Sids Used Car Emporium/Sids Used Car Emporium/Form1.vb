'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
' Program: Sids Used Car Emporium
' Date: 11/21/2019
' Author: Marshall Radziwilko
' Operation: 
'     - Added a Text box to allow a quantity to be entered
'     - Added Two List boxes, one to store the details of the Cars ordered, the second to store the extended price of the cars being ordered.
'     - Added a button to add the quantity of cars selected to the items list box and the extended price to the extended price list box
'     - Added a button to “Remove” the selected item from both list boxes.
'     - Added three Label Controls, one to Display the Subtotal, the second to display Tax and the third to display the total order price.
'     - Added a “Add to order” button is clicked, the Make, Model and Quantity will be added to the Order details list box, and the extended 
'       price will be calculated and added to the prices list box.
'     - The taxes and the total label price labels will be updated each time an item is added to the list box. A loop should be used to 
'       calculate the subtotal based on the contents of the listbox and the tax and total labels updated to reflect the new total.
'     - When the “Remove” button is clicked, if an item is selected in the “Order Details” List box, the selected item will be removed from 
'       both list boxes at the index that was selected. When an item is removed, the tasks from step 4 should be executed again.
'     - Exception type specific handling should be used to trap any errors that might occur with the quantity text box. A generic Exception 
'       handler should also be used to trap for unaccounted problems. Problems should be reported to the user.
'     - When an item is selected in the “Models” listbox, if a price is not defined for the selected model, throw and handle an IndexOutOfRangeException. 
'       Show the user a user friendly message that the price was not found. (Add a model to the box without a corresponding price to test this functionality)
'     - Addedd Validation to the combobox and listbox to ensure something is selected prior to adding the item to the list box.
'     - Added a working clear button
'     - Added a working exit button 
' 
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'11/21/2019 - Created First Illituration - Marshall Radziwilko
'-----------------------------------------------------------------------------


Public Class Form1

    ' Manufacture Strings
    Dim listManufacture() As String = {"Dodge", "Ford", "Telsa", "Toyota"}


    ' Defined each Model and Price and Tax as Constent
    Const cn_Mustang As String = "Mustang",          ' Dodge
        cn_Focus As String = "Focus",
        cn_F150 As String = "F150",
        cn_Fusion As String = "Fusion",
        cn_Escape As String = "Escape",
        cn_Tempo As String = "Tempo",       ' cp_Mustang As Decimal = 29995,
        cp_Focus As Decimal = 19995,
        cp_F150 As Decimal = 24950, ' Ford 150
        cp_Fusion As Decimal = 14995,
        cp_Escape As Decimal = 12995,
        cp_tempo As Decimal = 4995,
        cn_Ram1500 As String = "Ram 1500",          ' Ford
        cn_Avenger As String = "Avenger",
        cn_Viper As String = "Viper",
        cn_Durango As String = "Durango",
        cn_Shadow As String = "Shadow",
        cp_Ram1500 As Decimal = 45995,
        cp_Avenger As Decimal = 39995,
        cp_Viper As Decimal = 79995,
        cp_Durango As Decimal = 19995,
        cp_Shadow As Decimal = 2995,
        cn_Model3 As String = "Model 3",          ' Tesla
        cn_ModelS As String = "Model S",
        cn_ModelX As String = "Model X",
        cn_RoadsterCrea As String = "Roadster Crea",
        cp_Model3 As Decimal = 29995,
        cp_ModelS As Decimal = 49995,
        cp_ModelX As Decimal = 69995,
        cp_RoadsterCrea As Decimal = 89995,
        cn_Camry As String = "Camry",             ' Toyota
        cn_Celica As String = "Celica",
        cn_RAV4 As String = "RAV4",
        cn_Corolla As String = "Corolla",
        cn_Yaris As String = "Yaris",
        cp_Camry As Decimal = 9995,
        cp_Celica As Decimal = 19995,
        cp_RAV4 As Decimal = 24995,
        cp_Corolla As Decimal = 4995,
        cp_Yaris As Decimal = 8995,
        tax As Decimal = 0.15                   ' Tax 


    ' Remove Button, Checks first if Item is selected if not Removes Item from Selected and Coresponding Selected Index from Cost Listbox then Re-Calculates Totals
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try

            If lbOrderCars.SelectedIndex = -1 Then

                Throw New Exception("Nothing Selected")
            Else
                Dim SelCost = lbOrderCost.SelectedIndex
                Dim SelModel = lbOrderCars.SelectedIndex
                Dim SelPrice = lbOrderCost.SelectedItem

                lbOrderCost.Items.RemoveAt(SelModel)
                lbOrderCars.Items.RemoveAt(SelModel)


                CalcTotal()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



	' If Cost item is selected, make sure right Price is selected, if person changes reselect proper price from order listbox
    Private Sub lbOrderCost_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbOrderCost.Click

        If lbOrderCars.SelectedIndex = -1 Then

        Else
            lbOrderCost.SetSelected(lbOrderCars.SelectedIndex, True)

        End If
    End Sub

	' If changed Selection on Order Car Listbox, make sure right Price is selected.
    Private Sub lbOrderCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbOrderCars.SelectedIndexChanged


        If lbOrderCars.SelectedIndex = -1 Then

        Else
            lbOrderCost.SetSelected(lbOrderCars.SelectedIndex, True)

        End If
    End Sub



	' First check for Invalid Inputs such as Empty Values, or is Quantity is a Integer and not empty. After add to both Listbox for Cart and Cost and Calc ReCaculate totals
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim SelectedModel As String = lbCars.SelectedItem
        Dim SelectedMan As String = cbManufacture.SelectedItem
        If SelectedMan = "" Then
            funerror(404, "Manufacture")
        ElseIf SelectedModel = "" Then
            funerror(402, "Model")
        ElseIf inpQuantity.Text = "" Then
            funerror(404, "Quantity")
        ElseIf Not IsNumeric(inpQuantity.Text) Then
            funerror(403, "Quantity")
        ElseIf inpQuantity.Text <= 0 Then
            funerror(405, "Quantity")
        ElseIf inpQuantity.Text >= 100 Then
            funerror(406, "Quantity")
        Else

            Dim selPrice As Decimal
            Dim selQuantity As Integer
            Dim selMan As String = cbManufacture.SelectedItem



            Select Case SelectedModel
                Case cn_Focus
                    selPrice = cp_Focus
                    selQuantity = inpQuantity.Text
                Case cn_F150
                    selPrice = cp_F150
                    selQuantity = inpQuantity.Text
                Case cn_Fusion
                    selPrice = cp_Fusion
                    selQuantity = inpQuantity.Text
                Case cn_Escape
                    selPrice = cp_Escape
                    selQuantity = inpQuantity.Text
                Case cn_Tempo
                    selPrice = cp_tempo
                    selQuantity = inpQuantity.Text
                Case cn_Ram1500
                    selPrice = cp_Ram1500
                    selQuantity = inpQuantity.Text
                Case cn_Avenger
                    selPrice = cp_Avenger
                    selQuantity = inpQuantity.Text
                Case cn_Viper
                    selPrice = cp_Viper
                    selQuantity = inpQuantity.Text
                Case cn_Durango
                    selPrice = cp_Durango
                    selQuantity = inpQuantity.Text
                Case cn_Shadow
                    selPrice = cp_Shadow
                    selQuantity = inpQuantity.Text
                Case cn_Model3
                    selPrice = cp_Model3
                    selQuantity = inpQuantity.Text
                Case cn_ModelS
                    selPrice = cp_ModelS
                    selQuantity = inpQuantity.Text
                Case cn_ModelX
                    selPrice = cp_ModelX
                    selQuantity = inpQuantity.Text
                Case cn_RoadsterCrea
                    selPrice = cp_RoadsterCrea
                    selQuantity = inpQuantity.Text
                Case cn_Camry
                    selPrice = cp_Camry
                    selQuantity = inpQuantity.Text
                Case cn_Celica
                    selPrice = cp_Celica
                    selQuantity = inpQuantity.Text
                Case cn_RAV4
                    selPrice = cp_RAV4
                    selQuantity = inpQuantity.Text
                Case cn_Corolla
                    selPrice = cp_Corolla
                    selQuantity = inpQuantity.Text
                Case cn_Yaris
                    selPrice = cp_Yaris
                    selQuantity = inpQuantity.Text
                Case Else
                    funerror(407, "Model")

            End Select

            Dim CalcCost As Decimal = selPrice * selQuantity

            If SelectedModel = cn_Ram1500 Or SelectedModel = cn_RoadsterCrea Then
                addOrderList(lbOrderCars, selMan, SelectedModel, selQuantity, 1)
            Else
                addOrderList(lbOrderCars, selMan, SelectedModel, selQuantity, 2)
            End If

            addCost(lbOrderCost, CalcCost)
            CalcTotal()
        End If

    End Sub



    ' When a Manufacture is selected, clear the current List and add proper cars to Listbox of models
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbManufacture.SelectedIndexChanged
        Dim selManu As String = cbManufacture.SelectedItem


        fillMakes(selManu)


    End Sub


    ' Make sure everything is Cleared, and Manufacture List is populated
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
        FillCars()
    End Sub


    ' Everytime a Model is selected Update Price Label
    Private Sub lbCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCars.SelectedIndexChanged

        Dim SelectedModel As String = lbCars.SelectedItem

        lbPrice.Text = retModelPrice(SelectedModel).ToString("C2")


    End Sub

    Function retModelPrice(ModelName As String) As Decimal
        Dim tmpPrice As Decimal

        Try


            Select Case ModelName
                Case cn_Focus
                    tmpPrice = cp_Focus
                Case cn_F150
                    tmpPrice = cp_F150
                Case cn_Fusion
                    tmpPrice = cp_Fusion
                Case cn_Escape
                    tmpPrice = cp_Escape
                Case cn_Tempo
                    tmpPrice = cp_tempo
                Case cn_Ram1500
                    tmpPrice = cp_Ram1500
                Case cn_Avenger
                    tmpPrice = cp_Avenger
                Case cn_Viper
                    tmpPrice = cp_Viper
                Case cn_Durango
                    tmpPrice = cp_Durango
                Case cn_Shadow
                    tmpPrice = cp_Shadow
                Case cn_Model3
                    tmpPrice = cp_Model3
                Case cn_ModelS
                    tmpPrice = cp_ModelS
                Case cn_ModelX
                    tmpPrice = cp_ModelX
                Case cn_RoadsterCrea
                    tmpPrice = cp_RoadsterCrea
                Case cn_Camry
                    tmpPrice = cp_Camry
                Case cn_Celica
                    tmpPrice = cp_Celica
                Case cn_RAV4
                    tmpPrice = cp_RAV4
                Case cn_Corolla
                    tmpPrice = cp_Corolla
                Case cn_Yaris
                    tmpPrice = cp_Yaris
                Case Else
                    funerror(401, "Price")
            End Select

            Return tmpPrice


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Function






    ' Clear all values in Listboxes, Unselect current manufacture, Clear All prices from Labels
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ClearForm()
    End Sub

    Sub fillMakes(selModel As String)
        Select Case selModel
            Case "Dodge"
                lbCars.Items.Clear()
                lbCars.Items.Add(cn_Mustang)
                lbCars.Items.Add(cn_Focus)
                lbCars.Items.Add(cn_F150)
                lbCars.Items.Add(cn_Fusion)
                lbCars.Items.Add(cn_Escape)
                lbCars.Items.Add(cn_Tempo)
            Case "Ford"
                lbCars.Items.Clear()
                lbCars.Items.Add(cn_Ram1500)
                lbCars.Items.Add(cn_Avenger)
                lbCars.Items.Add(cn_Viper)
                lbCars.Items.Add(cn_Durango)
                lbCars.Items.Add(cn_Shadow)
            Case "Telsa"
                lbCars.Items.Clear()
                lbCars.Items.Add(cn_Model3)
                lbCars.Items.Add(cn_ModelS)
                lbCars.Items.Add(cn_ModelX)
                lbCars.Items.Add(cn_RoadsterCrea)

            Case "Toyota"
                lbCars.Items.Clear()
                lbCars.Items.Add(cn_Camry)
                lbCars.Items.Add(cn_Celica)
                lbCars.Items.Add(cn_RAV4)
                lbCars.Items.Add(cn_Corolla)
                lbCars.Items.Add(cn_Yaris)

        End Select
    End Sub
    Sub ClearForm()

        tbSubtotal.Text = "$"
        tbTax.Text = "$"
        tbTotal.Text = "$"
        lbPrice.Text = "$"
        inpQuantity.Text = ""
        lbOrderCost.Items.Clear()
        lbOrderCars.Items.Clear()
        lbCars.Items.Clear()
        cbManufacture.SelectedIndex = -1
    End Sub


    ' General Function when a Item is added, get all information from Cost, Calculate and input all Labels to proper prices.
    Sub CalcTotal()

        Dim Subtotal As Decimal

        Dim calctax As Decimal = 0
        Dim calcTotal As Decimal = 0

        Subtotal = calcListBox(lbOrderCost)

        tbSubtotal.Text = Subtotal.ToString("C2")

        calctax = funcCalcTax(Subtotal)

        calcTotal = Subtotal + calctax

        tbTax.Text = calctax.ToString("C2")
        tbTotal.Text = calcTotal.ToString("C2")

    End Sub

    ' Fill Cars
    Sub FillCars()
        cbManufacture.Items.Clear()
        cbManufacture.Items.AddRange(listManufacture)
    End Sub


    ' Calculation for Tax
    Function funcCalcTax(Subtot As Integer) As Decimal
        Dim calculation As Decimal
        calculation = Subtot * tax
        Return calculation
    End Function



End Class
