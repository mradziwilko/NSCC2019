'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Gas Guzzler
'Date: 9/27/2019
'Author: Marshall Radziwilko
'Operation: 
'  This application prompts user for information on a trip such as Starting Kilometers, Ending Kilometers, Gas Filled, and Gas Fill Cost, then converts into Miles and KM and
'  Creates a Formulat on the total trip.
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date 		 Programmer 		  Change 
'9/27/2019 - Marshall Radziwiko - Created Application
'-----------------------------------------------------------------------------


Module Module1

    Sub Main()

        Dim intStartKM As Decimal
        Dim intEndKM As Decimal
        Dim intFillCost As Decimal
        Dim intFillAmm As Decimal

        Dim intTravledKM As Decimal
        Dim intTraveledMiles As Decimal
        Dim intFillGal As Decimal
        Dim MilesPerGal As Decimal
        Dim FinalCost As Decimal





        Dim txtQuestion1 = "What was the Starting KM of the Vehicle?"
        Dim txtQuestion2 = "What is the Ending KM of the Vehicle?"
        Dim txtQuestion3 = "How much did it cost you to fill the tank?"
        Dim txtQuestion4 = "How many Liters of Gas did you fill?"


        ' Output Questions
        Console.WriteLine(vbCrLf & txtQuestion1)
        intStartKM = Console.ReadLine()
        Console.Clear()

        Console.WriteLine(vbCrLf & txtQuestion2)
        intEndKM = Console.ReadLine()
        Console.Clear()

        Console.WriteLine(vbCrLf & txtQuestion3)
        intFillCost = Console.ReadLine()
        Console.Clear()

        Console.WriteLine(vbCrLf & txtQuestion4)
        intFillAmm = Console.ReadLine()
        Console.Clear()



        ' Do Math for Each Question
        intTravledKM = Math.Round(intEndKM - intStartKM, 2)
        intTraveledMiles = Math.Round(intTravledKM * 0.621371, 2)
        intFillGal = Math.Round(intFillAmm * 0.264172, 2)
        MilesPerGal = Math.Round(intTraveledMiles / intFillGal, 2)
        FinalCost = Math.Round(intFillCost / intTravledKM, 2)

        ' Calculate and Output Results for Questions.

        Console.WriteLine("===============================================================")
        Console.WriteLine("Travel Information")
        Console.WriteLine("===============================================================")

        Console.WriteLine(vbCrLf & $"The starting KM Was: {intStartKM} KM")

        Console.WriteLine(vbCrLf & $"The Ending KM was: {intEndKM} KM")

        Console.WriteLine(vbCrLf & $"The Ammount of gas filled was: {intFillAmm} Liters")

        Console.WriteLine(vbCrLf & $"The Cost of the gas was: {intFillCost.ToString("C")}" & vbCrLf)

        Console.WriteLine("===============================================================")
        Console.WriteLine("Final Travel Information")
        Console.WriteLine("===============================================================")

        Console.WriteLine(vbCrLf & $"Traveled Distance was: {intTravledKM} KM")

        Console.WriteLine(vbCrLf & $"You Traveled in Miles: {intTraveledMiles} Miles ")

        Console.WriteLine(vbCrLf & $"You Filled your Tank in Gallons: {intFillGal} Gallons")

        Console.WriteLine(vbCrLf & $"The Miles per gallon where: {MilesPerGal} MPG")

        Console.WriteLine(vbCrLf & $"The Cost of the Trip per KM is: {FinalCost.ToString("C")} Dollers Per Kilometer" & vbCrLf)

        Console.WriteLine("===============================================================" & vbCrLf)




        Console.WriteLine("Press Any Key To Continue.")



        Console.ReadKey(True)




    End Sub

End Module
