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
    Private Sub cbManufacture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbManufacture.SelectedIndexChanged
        ' When item is selected, Clear the Listbox(lbModels) of items and add New items.
        Select Case cbManufacture.SelectedIndex
            Case "0"
                lbModels.Items.Clear()
                lbModels.Items.Add("Mustang")
                lbModels.Items.Add("Focus")
                lbModels.Items.Add("F150")
                lbModels.Items.Add("Fusion")
                lbModels.Items.Add("Escape")
                lbModels.Items.Add("Tempo")

            Case "1"
                lbModels.Items.Clear()
                lbModels.Items.Add("Ram 1500")
                lbModels.Items.Add("Avenger")
                lbModels.Items.Add("Viper")
                lbModels.Items.Add("Durango")
                lbModels.Items.Add("Shadow")
            Case "2"
                lbModels.Items.Clear()
                lbModels.Items.Add("Model 3")
                lbModels.Items.Add("Model S")
                lbModels.Items.Add("Model X")
                lbModels.Items.Add("Roadster Crea")
            Case "3"
                lbModels.Items.Clear()
                lbModels.Items.Add("Camry")
                lbModels.Items.Add("Celica")
                lbModels.Items.Add("RAV4")
                lbModels.Items.Add("Corolla")
                lbModels.Items.Add("Yaris ")


        End Select

        lblMan.Text = "None."
        lblMod.Text = "None."
    End Sub

    Private Sub lbModels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbModels.SelectedIndexChanged
        ' Set text
        Dim txtModel As String
        Dim txtMake As String


        ' get Selected Items into a varaible.
        txtModel = lbModels.SelectedItem.ToString
        txtMake = cbManufacture.SelectedItem.ToString


        ' Set Manufacture / Model's Labels
        lblMan.Text = txtMake
        lblMod.Text = txtModel



    End Sub
End Class
