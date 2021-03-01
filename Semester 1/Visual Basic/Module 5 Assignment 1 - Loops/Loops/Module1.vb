Module Module1

    Dim txtString1 As String = "Sum of the Numbers Entered:"
    Dim txtString2 As String = "Total Number Of Numbers Entered:"
    Dim txtString3 As String = "Average of Numbers Entered:"
    Dim txtString4 As String = "Please Enter a Numerical Number"
    Dim txtString5 As String = "Please enter a new number (or type 'C' to continue)."
    Dim txtString6 As String = "Invalid input, Press Enter key to Continue."
    Dim txtString7 As String = "Invalid input, Input is Emtpy, press any key to continue."
    Dim txtString8 As String = "Type 'Quit' to Exit or Press Enter to continue."
    Dim inpNumber As String
    Dim StoredNumber As Integer = 0
    Dim numCount As Integer = 0
    Dim Average As Decimal



    Sub Main()
        Dim inpChoice As String = "nope"

        Do Until inpChoice = "Quit"

            Console.Clear()
            Console.WriteLine($"{txtString4}")
            inpNumber = Console.ReadLine()
            If inpNumber = "" Then

                Console.Clear()
                Console.WriteLine($"{txtString6}")
                Console.ReadKey(True)

            ElseIf IsNumeric(inpNumber) = False Then

                Console.Clear()
                Console.WriteLine($"{txtString6}")
                Console.ReadKey(True)
            Else
                Do Until IsNumeric(inpNumber) = False


                Console.Clear()

                StoredNumber = StoredNumber + inpNumber
                    Console.WriteLine($"{txtString5}")
                    inpNumber = Console.ReadLine()
                    If inpNumber = "" Then

                        Console.Clear()
                        Console.WriteLine($"{txtString7}")
                        Console.ReadKey()

                        inpNumber = 0


                    End If

                    numCount = numCount + 1



            Loop

            Console.Clear()
            Average = StoredNumber / numCount



                Console.WriteLine($"{txtString1} {StoredNumber.ToString("n2")}")
                Console.WriteLine($"{txtString2} {numCount}")
                Console.WriteLine($"{txtString3} {Average.ToString("n2")}")


                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine($"{txtString8}")
                inpChoice = Console.ReadLine()


            Select Case inpChoice

                Case "Quit"
                    inpChoice = "Quit"

                Case "quit"
                    inpChoice = "Quit"

                Case Else
                    numCount = 0
                    inpNumber = 0
                    StoredNumber = 0
            End Select

            End If


        Loop






    End Sub

End Module
