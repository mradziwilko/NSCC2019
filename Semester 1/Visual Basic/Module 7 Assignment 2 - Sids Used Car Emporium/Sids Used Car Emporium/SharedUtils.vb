Module SharedUtils


    ' Calculate all items in Listbox return value.
    Function calcListBox(lbCost As ListBox) As Decimal
        Dim Subtotal As Decimal = 0
        For i = 0 To lbCost.Items.Count - 1
            Subtotal = Subtotal + lbCost.Items(i)
        Next
        Return Subtotal
    End Function



    ' Add Manufacture, Model and Quantity to the Models Listbox
    Sub addOrderList(lbModels As ListBox, manName As String, modelName As String, itmQuantity As Integer, itmspaces As Integer)
        If itmspaces = 1 Then

            lbModels.Items.Add($"{manName}{vbTab}{modelName}{vbTab}Qty:{itmQuantity}")
        ElseIf itmspaces = 2 Then
            lbModels.Items.Add($"{manName}{vbTab}{modelName}{vbTab}{vbTab}Qty:{itmQuantity}")
        End If
    End Sub


    ' Add cost of item to Cost Listbox
    Sub addCost(lbCost As ListBox, itmCost As Decimal)
        lbCost.Items.Add($"{itmCost.ToString("C2")}")
    End Sub



    ' Function Error to get error from function and Show msg box on error.
    Sub funerror(Code As Integer, Optional Feild As String = "")
        MsgBox(rtnError(Code, Feild))
    End Sub

    ' Return Error String to error sub 
    Function rtnError(Code As Integer, Optional Feild As String = "") As String
        Dim rtnString As String
        Select Case Code

            Case 401
                rtnString = $"{Feild} Error: Price not found."
            Case 402
                rtnString = $"{Feild} Error: Nothing Selected."
            Case 403
                rtnString = $"{Feild} Error: Invalid Character"
            Case 404
                rtnString = $"{Feild} Error: Empty feild."
            Case 405
                rtnString = $"{Feild} Error:  Quantity to Low."
            Case 406
                rtnString = $"{Feild} Error: Quantity to High."
            Case 407
                rtnString = $"{Feild} Error: No Car Selected. "
            Case Else
                rtnString = $"Unknown Error: Please try again."
        End Select

        Return rtnString
    End Function


End Module
