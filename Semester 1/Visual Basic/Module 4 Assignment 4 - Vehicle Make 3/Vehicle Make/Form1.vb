'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Vehicle Make
'Date: 10/22/2019
'Author: Marshall Radziwilko
'Operation: 
' Person selects Manfuacture and system forms new list in List box, when Model is selected, label boxes will show Selected
' Manufacture and Selected Model, if Model is changed, Labels updated, if manufacture changed, labels are cleared,
' items are then cleared from list box, and new items are inputed into listbox.
'
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'10/22/2019 - Added main Code
'-----------------------------------------------------------------------------
Public Class Form1

    ' Defines for Each Section
    Dim listManufacture() As String = {"Dodge", "Ford", "Telsa", "Toyota"}
    Dim listDodge() As String = {"Mustang", "Focus", "F150", "Fusion", "Escape", "Tempo"}
    Dim listDodgePrice() As String = {"29,995", "19,995", "24,950", "14,995", "12,995", "4,995"}
    Dim listFord() As String = {"Ram 1500", "Avenger", "Viper", "Durango", "Shadow"}
    Dim listFordPrice() As String = {"45,995", "39,995", "79,995", "19,995", "2,995"}
    Dim listTelsa() As String = {"Model 3", "Model S", "Model X", "Roadster Crea"}
    Dim listTelsaPrice() As String = {"29,995", "49,995", "69,995", "89,995"}
    Dim listToyota() As String = {"Camry", "Celica", "RAV4", "Corolla", "Yaris"}
    Dim listToyotaPrice() As String = {"9,995", "19,995", "24,995", "4,995", "8,995"}
    Dim setText As Decimal = 0


    ' If ever get focus back, clear current select, resize back to normal state.
    Private Sub cbManufacture_GotFocus(sender As Object, e As EventArgs) Handles cbManufacture.GotFocus
        cbManufacture.Text = ""
        Me.Height = "92"
        lblModels.Items.Clear()
    End Sub
    ' If ever get focus back, clear current select, resize back to normal state.
    Private Sub cbManufacture_Select(sender As Object, e As EventArgs) Handles cbManufacture.Click
        cbManufacture.Text = ""
        Me.Height = "92"
        lblModels.Items.Clear()
    End Sub



    ' When item is selected, Clear the Listbox(lbModels) of items and add New items.
    Private Sub cbManufacture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbManufacture.SelectedIndexChanged

        Me.Height = "234"
        Select Case cbManufacture.SelectedItem
            Case "Dodge"
                lblModels.Items.Clear()
                lblModels.Items.AddRange(listDodge)
            Case "Ford"
                lblModels.Items.Clear()
                lblModels.Items.AddRange(listFord)
            Case "Telsa"
                lblModels.Items.Clear()
                lblModels.Items.AddRange(listTelsa)
            Case "Toyota"
                lblModels.Items.Clear()
                lblModels.Items.AddRange(listToyota)
        End Select

        lblPrice.Text = ""

    End Sub

    ' Deny Input to Combobox
    Private Sub cbManufacture_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbManufacture.KeyPress
        e.Handled = True
    End Sub


    ' Make sure window and Listboxes are Cleared and valid Data is inserted into ComboBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbManufacture.Items.Clear()
        cbManufacture.Items.AddRange(listManufacture)
        Me.Height = "92"
    End Sub


    ' Set Prices for each model, resize Screen to show Price Dialog on Select.
    Private Sub lbModels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lblModels.SelectedIndexChanged

        Me.Height = "268"
        Select Case lblModels.SelectedItem
            Case "Mustang"
                setText = listDodgePrice(0)
            Case "Focus"
                setText = listDodgePrice(1)
            Case "F150"
                setText = listDodgePrice(2)
            Case "Fusion"
                setText = listDodgePrice(3)
            Case "Escape"
                setText = listDodgePrice(4)
            Case "Tempo"
                setText = listDodgePrice(5)


            Case "Ram 1500"
                setText = listFordPrice(0)
            Case "Avenger"
                setText = listFordPrice(1)
            Case "Viper"
                setText = listFordPrice(2)
            Case "Durango"
                setText = listFordPrice(3)
            Case "Shadow"
                setText = listFordPrice(4)


            Case "Camry"
                setText = listToyotaPrice(0)
            Case "Celica"
                setText = listToyotaPrice(1)
            Case "RAV4"
                setText = listToyotaPrice(2)
            Case "Corolla"
                setText = listToyotaPrice(3)
            Case "Yaris"
                setText = listToyotaPrice(4)


            Case "Model 3"
                setText = listTelsaPrice(0)
            Case "Model S"
                setText = listTelsaPrice(1)
            Case "Model X"
                setText = listTelsaPrice(2)
            Case "Roadster Crea"
                setText = listTelsaPrice(3)

        End Select
        lblPrice.Text = $"Price: {setText.ToString("C2")}"

    End Sub
End Class
