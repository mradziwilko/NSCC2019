'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
' Program: Arrays
' Date: 12/2/2019
' Author: Marshall Radziwilko
' Operation: 
'    - Create an application that will use an array To store numbers that will be averaged. 
'      The application should contain a Listbox, a Button, a textbox And a label. An array 
'      Of integers should be created As a Global variable And it should store up To 50 numbers.
'    - When clicking the Button a number in the textbox control should be added to the array, 
'      the array should be searched Using a For... Next Loop To find the Next empty element 
'      And the number should be stored In the empty element When it Is found.
'    - After storing Each New number, the array should be looped To sum all 
'      Of the numbers And calculate the average. A Do...While Loop should be used To sum the items.
'    - Be sure To trap For exceptions When accessing the arrays elements.
'    - Finally, the arrays contents should be displayed In the listbox.
'    - Set the text Of the label To the Average
' 
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'12/2/2019 - Created First Illituration - Marshall Radziwilko
'-----------------------------------------------------------------------------

Public Class Form1
    ' Decalre Array as Integer
    Dim numbArr(49) As Integer


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            ' Declare local Variables
            Dim int_Index As Integer
            Dim int_LastValue As Integer = 0
            Dim int_NewValue As Integer = tbNumber.Text


            ' Mark 0 is concidered -1 for No Mark, add Number to list dont throw error.
            If int_NewValue = 0 Then

                For int_Index = 0 To numbArr.Length - 1

                    If numbArr(int_Index) = Nothing Then

                        numbArr(int_Index) = -1
                        lbItems.Items.Add(0)
                        Recalc()

                        Exit For
                    Else
                        int_LastValue = numbArr(int_Index)
                    End If
                Next


                ' If number is higher them 100 throw error
            ElseIf int_NewValue >= 101 Then
                Throw New Exception("Number cannot be above 100.")


                ' If number is LESS then 0 (Not equal)
            ElseIf int_NewValue < 0 Then
                Throw New Exception("Number Entered below 0.")


            Else
                For int_Index = 0 To numbArr.Length - 1

                    If numbArr(int_Index) = Nothing Then

                        numbArr(int_Index) = int_NewValue
                        lbItems.Items.Add(int_NewValue)
                        Recalc()

                        Exit For
                    Else
                        int_LastValue = numbArr(int_Index)
                    End If
                Next
            End If


            ' Show Null error or Invalid Input Entered.
        Catch exNull As InvalidCastException

            MsgBox("Invalid Input, Ether Empty or Not Numerical.")

            'Show message if something goes wrong.
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub


    ' Calculate totals, get all totals from Array, if Number is -1 is equal to a 0 as a Mark if 0 add number to count else if empty dont calc.
    Sub Recalc()
        Try
            ' Declare temp Values
            Dim int As Integer = 0
            Dim cntNum As Integer = 0
            Dim subtotal As Integer
            Dim average As Decimal = 0


            ' Do while loop for each item in array
            Do While int <= numbArr.Length - 1

                ' If Item is Empty, go to next but do nothing
                If numbArr(int) = Nothing Then
                    int += 1
                    cntNum += 0
                    ' if Item is -1 which is equal to a 0 Mark, set to 0 and add to totals
                ElseIf numbArr(int) = -1 Then

                    subtotal = subtotal + 0
                    int += 1
                    cntNum += 1

                    ' else Add numbers to totals
                Else

                    subtotal = subtotal + numbArr(int)
                    int += 1
                    cntNum += 1

                End If
            Loop

            ' Calculate Average
            average = subtotal / cntNum
            lblAvrNum.Text = average.ToString("N2")

        Catch ex As Exception
            ' Show Error Message if something goes wrong.
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
