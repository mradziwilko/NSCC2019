'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
' Program: Reimbursement Tracker
' Date: 12/4/2019
' Author: Marshall Radziwilko
' Operation: 
'     - A Button to initialize the form for data input. Form should also be initialized when the program starts.
'     - A textbox should be used to add daily miles travelled to a list box, each entry in the listbox represents a day's KMs travelled.
'     - Calculate the total amount of KMs travelled.
'     - Calculate total Amount of KMs traveled for Flat Rate Days.
'     - Calculate the total number of days travelled (each entry in the listbox Is considered a travel day)
'     - Calculate Total Number of Days travelled that are flat rate KMs
'     - Calculate the total reimbursement amount based on the above reimbursement rules And KMs Travelled.
'     - Calculate the total flat rate reimbursement amounts based on flat rate rules.
'     - User input/ Exception Errors in the program are handled And friendly messages Is displayed to the user.
' 
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'11/21/2019 - Created First Illituration - Marshall Radziwilko
'-----------------------------------------------------------------------------


Public Class Form1


    ' Initialize Button
    Private Sub btnIni_Click(sender As Object, e As EventArgs) Handles btnIni.Click
        initilize(Me)
        tbErrorBox.Text = "Success: Items Cleared."
        tbErrorBox.ForeColor = Color.Green

    End Sub

    ' Add Button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try


            clearError(Me, Color.Red)

            If tbKM.Text = "" Then
                funerror(404, Me, "KM") ' Empty Feild
            ElseIf Not IsNumeric(tbKM.Text) Then
                funerror(401, Me, "KM") ' Invalid Cast
            ElseIf tbKM.Text > 1000 Then
                funerror(403, Me, "KM") ' Over KM
            ElseIf tbKM.Text <= 0 Then
                funerror(402, Me, "KM") ' Below KM
            ElseIf Not IsInteger(tbKM.Text) Then

                funerror(405, Me, "KM") ' Below KM

            Else
                Dim inpKM As Integer = tbKM.Text
                ' Get Field value

                ' Add Feild to List
                AddItem(inpKM, Me)

                ' Calculate totals
                Calculate(lbNumbers, Me)

            End If
        Catch ex As Exception
            funerror(500, Me) ' Unknown Errors Handeled
        End Try
    End Sub


    ' Form Load.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initilize(Me)
    End Sub

End Class
