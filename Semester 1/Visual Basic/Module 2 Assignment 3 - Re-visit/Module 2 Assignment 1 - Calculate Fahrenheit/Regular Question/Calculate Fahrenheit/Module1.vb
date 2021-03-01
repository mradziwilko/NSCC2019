'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Calculate Fahrenheit
'Date: 9/25/2019
'Author: Marshall Radziwilko
'Operation: 
' Ask Questions 
' Do Calculations
' Output Results
' Exit Application
'
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date 		 Programmer 		  Change 
'9/25/2019 - Marshall Radziwiko - Added Comments
'-----------------------------------------------------------------------------

Module Module1


    Sub Main(args As String())

        ' Clear Prior Console Output
        Console.Clear()

        ' Declare Variables and Questions		
        Dim intCelcius As Decimal
        Dim intFahrenheit As Decimal
        Dim Question = "What is the Celcius Number"


        'Ask Question To Request Celcius
        Console.WriteLine(vbCrLf + Question)
        intCelcius = Console.ReadLine()

        'Convert Cecius to Fahrenheit		
        intFahrenheit = intCelcius * 1.8 + 32


        'Output Results		
        Console.WriteLine($"{vbCrLf}The result of {intCelcius}°C is {intFahrenheit}°F.")

        ' Notice to Exit and Quit Application		
        Console.WriteLine(vbCrLf + "Press any key to continue.")
        Console.ReadKey(True)

    End Sub


End Module