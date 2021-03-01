'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Average Calculator
'Date: 9/25/2019
'Author: Marshall Radziwilko
'Operation: 
' Ask Base Questions
' Add and Devide Numbers
' Output Results
' Exit Application
'
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'9/25/2019 - Added Comments
'-----------------------------------------------------------------------------

Module Module1

    ' Assign Variables as Integers
    Dim intNumber1 As Integer
    Dim intNumber2 As Integer
    Dim intNumber3 As Integer
    Dim intNumberAdd As Integer
    Dim intNumberDiv As Integer

    Sub Main(args As String())
        ' Clear Console Window
        Console.Clear()

        ' Output Questions / Store Variable 1
        Console.WriteLine(vbCrLf + "Calculation the average of 3 Numbers, Please enter the numbers now.")
        Console.WriteLine(vbCrLf + "Number 1:")
        intNumber1 = Console.ReadLine()



        ' Output Questions / Store Variable 2
        Console.WriteLine(vbCrLf + "Number 2:")
        intNumber2 = Console.ReadLine()


        ' Output Questions / Store Variable 3
        Console.WriteLine(vbCrLf + "Number 3:")
        intNumber3 = Console.ReadLine()


        ' Add All 3 Numbers to a Single Number then Devide by 3
        intNumberAdd = (intNumber1 + intNumber2 + intNumber3)
        intNumberDiv = (intNumberAdd / 3)


        ' Output Results, and Exit Application
        Console.WriteLine($"{vbCrLf}The Average of {intNumber1} and {intNumber2} and {intNumber3} is {intNumberDiv}")
        Console.WriteLine($"{vbCrLf}Press anykey to continue")

        ' Read key to Exit
        Console.ReadKey(True)




    End Sub


End Module