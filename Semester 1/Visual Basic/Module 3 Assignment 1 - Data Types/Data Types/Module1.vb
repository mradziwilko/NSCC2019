'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Data Types
'Date: 01/10/2019
'Author: Marshall Radziwilko
'Operation: 
' Input different Values in proper format.
'
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'9/25/2019 - Added Comments
'-----------------------------------------------------------------------------
Module Module1
    ' Define Global Variables
    Dim intAge As Integer
    Dim dateBirthDate As Date
    Dim datClassStart As DateTime
    Dim intAccBal As Decimal
    Dim decPi As Decimal
    Dim shoTemp As Decimal
    Dim intProScale As Integer
    Dim intProScaletxt As String
    Dim strSelect As String
    Dim lngKMCar As Decimal
    Dim strName As String

    Sub Main()

        ' Ask for Client Name and Age
        Console.WriteLine("Please Enter your name." & vbCrLf)
        strName = Console.ReadLine()

        Console.Clear()

        Console.WriteLine("Please Enter your Age." & vbCrLf)
        intAge = Console.ReadLine()


        Console.Clear()
        Console.WriteLine("Please Enter your Cars odometer Value." & vbCrLf)
        lngKMCar = Console.ReadLine()



        Console.Clear()

        ' As for Yes / No Question
        Console.Write("Please Enter (y/n)" & vbCrLf)
        Select Case Console.ReadLine().ToLower()
            Case "y", "yes"
                strSelect = "Selected Yes"
            Case "n", "no"
                strSelect = "Selected No"
        End Select



        Console.Clear()

        ' Input How Awesome programming is and create a Scale for Text
        Console.Write("How awesome programming is: (1 - 10)" & vbCrLf)
        intProScale = Console.ReadLine()
        Select Case intProScale
            Case "1"
                intProScaletxt = "Rated as Bad"
            Case "2"
                intProScaletxt = "Rated as Not So Good"
            Case "3"
                intProScaletxt = "Rated as Not Doing Well"
            Case "4"
                intProScaletxt = "Rated as Doing So So"
            Case "5"
                intProScaletxt = "Rated as Doing Ok"
            Case "6"
                intProScaletxt = "Rated as Doing Better"
            Case "7"
                intProScaletxt = "Rated as Doing Really Good"
            Case "8"
                intProScaletxt = "Rated as Doing Very Well"
            Case "9"
                intProScaletxt = "Rated as Above Average"
            Case "10"
                intProScaletxt = "Rated as AWESOME!"
            Case Else
                intProScaletxt = " Did Not Rated Course"
        End Select

        Console.Clear()



        ' Define Non Edited Variables
        Dim edate = "03/02/1982"
        dateBirthDate = Convert.ToDateTime(edate)
        datClassStart = DateTime.Now
        intAccBal = 30000
        decPi = System.Math.PI
        shoTemp = 35




        Console.WriteLine("===============================================================")
        Console.WriteLine("Variable Output Information")
        Console.WriteLine("===============================================================" & vbCrLf)
        Console.WriteLine($"- Full Name: {strName}")
        Console.WriteLine(vbCrLf & $"- {strName}'s age: {intAge.ToString()}")
        Console.WriteLine(vbCrLf & $"- {strName}'s Birth Date: {dateBirthDate.ToString("MM/dd/yyyy")}")
        Console.WriteLine(vbCrLf & $"- {strName} bank account balance: {intAccBal.ToString("C")}")
        Console.WriteLine(vbCrLf & $"- A scale of 1 to 10 on how awesome programming is: {intProScale.ToString} - {intProScaletxt}")
        Console.WriteLine(vbCrLf & $"- The time programming class starts: {datClassStart}")
        Console.WriteLine(vbCrLf & $"- PI: {decPi.ToString}")
        Console.WriteLine(vbCrLf & $"- A Celsius temperature, without decimal points, to represent modern temperatures on Earth: {shoTemp}c")
        Console.WriteLine(vbCrLf & $"- A prompt for a user to select Y for yes Or N for no: {strSelect}")
        Console.WriteLine(vbCrLf & $"- An odometer that tracks kilometers for a car: {lngKMCar.ToString("N0")}")

        Console.WriteLine(vbCrLf & "===============================================================")
        Console.ReadKey(True)





    End Sub

End Module
