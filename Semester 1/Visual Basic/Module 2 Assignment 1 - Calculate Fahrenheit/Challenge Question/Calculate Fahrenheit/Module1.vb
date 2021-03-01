Module Module1

    Sub Main()

        ' I do this to clear input of Console for Better Reading.
        Console.Clear()

        ' Declare Variables

        Dim intCelcius As Decimal
        Dim intFahrenheit As Decimal
        Dim intFahrenheitRounded As Decimal

        Dim Question = "What is the Celcius Number"



        'Ask Question To Request Celcius
        Console.WriteLine(vbCrLf + Question)
        intCelcius = Console.ReadLine()


        'Convert Cecius to Fahrenheit		
        intFahrenheit = intCelcius * 1.8 + 32


        'Round Fahrenheit to 1 Decimal Place
        intFahrenheitRounded = Math.Round(intFahrenheit, 1)


        'Output Results		
        Console.WriteLine($"{vbCrLf}The result of {intCelcius}°C is {intFahrenheitRounded}°F.")

        'Output Notice to quit

        Console.WriteLine(vbCrLf + "Press any key to continue.")

        'Quit Application

        Console.ReadKey(True)
    End Sub

End Module
