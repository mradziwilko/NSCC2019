'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Sales Report
'Date: 09/24/2019
'Author: David MacDonald
'Operation: This program will import data from a csv file and format it for 
'           output to the console.
'
'
'
'
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date           Programmer              Change
'-----------------------------------------------------------------------------
'09/24/2019     David MacDonald         Initial Code


Imports System.IO
Module Module1

    Dim g_SalesData As DataTable
    Sub Main()
        LoadData()
        OutputData()
        Console.WriteLine("Press Any Key to Exit...")
        Console.ReadKey()
    End Sub

    'This Sub procedure will Load Sales data from a csv file into an internalally Created
    ' Data table object. The Data Table is constructed based on the expected format of the 
    ' Data being supplied in the file. The data file is expected to be in the same directory as 
    ' the executable file.
    Private Sub LoadData()
        Const c_FileName As String = "SalesData.csv"
        Dim strDir As String = Directory.GetCurrentDirectory
        Dim strFile As String = strDir & "\" & c_FileName ' Program Expects Data Fie in the Same path as the Executable
        Dim strRow As String
        Dim arrData() As String


        If File.Exists(strFile) Then
            Dim reader As New StreamReader(strFile)

            'The program expects there to be Column names in the first row.
            strRow = reader.ReadLine
            g_SalesData = buildDataTab(strRow)

            If Not g_SalesData Is Nothing Then
                'Read the First Row of Data and Parse and add to table 
                'as long as more rows are found
                strRow = reader.ReadLine
                While strRow <> ""
                    arrData = strRow.Split(",")
                    Dim row As DataRow
                    row = g_SalesData.NewRow()
                    row.ItemArray = arrData
                    g_SalesData.Rows.Add(row)
                    strRow = reader.ReadLine
                End While
            End If
        End If
    End Sub

    ' This Function will Create a datatable object to import data from a csv file
    ' Parameters: fieldString - This parameter passes in a comma separated List of Field Names
    ' that will be used to create columns in the table 
    ' Columns are expected to be in a specific position and the data types are set based on the column position
    Private Function buildDataTab(fieldString As String) As DataTable
        Dim dt As New DataTable("SalesData")
        Dim strFields As String()
        Dim idx As Int16
        If Not (fieldString = "") Then
            strFields = fieldString.Split(",")
            For idx = 0 To strFields.Length - 1
                'Create a New Column and Set its attributes
                Dim column As New DataColumn
                column.ColumnName = strFields(idx)
                column.Caption = strFields(idx)
                'Data types are set based on the column position in the file.
                Select Case idx
                    Case 0
                        column.DataType = System.Type.GetType("System.Int32")
                    Case 1, 2, 4
                        column.DataType = System.Type.GetType("System.String")
                    Case 3
                        column.DataType = System.Type.GetType("System.Decimal")
                End Select
                dt.Columns.Add(column)
            Next
            Return dt
        Else
            Return Nothing
        End If
    End Function

    'This Sub procedure will output the contents of the data table created to the console
    ' Each columns value is output to a fixed position on the screen.
    ' The 
    Sub OutputData()
        If g_SalesData.Rows.Count > 1 Then
            Console.WriteLine("Sales Report")
            Dim intRow As Integer
            For intRow = 0 To g_SalesData.Rows.Count - 1
                ' Column Positions are specified then each column in the table is output for each row in the table.
                Console.WriteLine("{0,-5} {1,-10} {2,-10}{3,-15}{4,-10}",
                                        g_SalesData.Rows(intRow).Item(0),
                                        g_SalesData.Rows(intRow).Item(1),
                                        g_SalesData.Rows(intRow).Item(2),
                                        CDec(g_SalesData.Rows(intRow).Item(3)).ToString("C"),
                                        get_Employment_Status(g_SalesData.Rows(intRow).Item(4)))
            Next
        Else
            Console.WriteLine("No Data Found")
        End If
    End Sub

    'This function will return an Employment Status Description from the supplied code.
    Function get_Employment_Status(emp_Code As String) As String
        Select Case emp_Code
            Case "F"
                Return "Full Time"
            Case "P"
                Return "Part Time"
            Case Else
                Return ""
        End Select
    End Function

End Module
