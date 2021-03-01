'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Sally's Shear Delight
'Date: 10/25/2019
'Author: Marshall Radziwilko
'Operation: 
' As User for Type of service, after ask for client age, if client is over
' 65 give 10% discount, calculate subtotal, calculate discount if present, 
' cacluate tax, after get tendard money, and then see if any change is due.
' 
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'10/25/2019 - Created First Illituration
'-----------------------------------------------------------------------------
Module Module1
    ' Set Constants
    Dim srvChoice, Age As Integer
    Dim Price, CalcTax, FinalTax, AgePrice, AgePriceDisc, Tendered, TenderedFinal As Decimal
    Dim Discount As Boolean

    Dim Tax As Decimal = 1.15
    Dim txtService As String
    Sub Main()
        ' Clear Console
        Console.Clear()
        ' Add Header
        headerinp()

        ' Show Selection Menu
        Console.WriteLine(" ")
        Console.WriteLine("  +-+-+-+-+-+-+ Sally's Shear Delight +-+-+-+-+-+-++-+-")
        Console.WriteLine("  | # |  Service Description               |   Price  |")
        Console.WriteLine("  +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+")
        Console.WriteLine("  | 1 |  Men’s dry cut                     |  $18.75  |")
        Console.WriteLine("  | 2 |  Men’s wash and cut                |  $29.50  |")
        Console.WriteLine("  | 3 |  Ladies wash, cut & blow dry       |  $38.75  |")
        Console.WriteLine("  | 4 |  Ladies color, cut & style         |  $79.80  |")
        Console.WriteLine("  | 5 |  Ladies color, foils, cut & style  |  $95.50  |")
        Console.WriteLine("  +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+")

        ' Ask for Selection, the choice in doing this way allows input to be to the right of the text instead of below.
        Console.Write("  Enter Choice: ")
        srvChoice = Console.ReadLine()
        Console.CursorTop = Console.CursorTop - 1
        Console.SetCursorPosition(Len("  Enter choice: " & srvChoice), Console.CursorTop)


        ' Clear Console
        Console.Clear()
        ' Choice Selection, if 1 - 5 Set price and title. else Show error and close.
        Select Case srvChoice
            Case 1
                Price = 18.75
                txtService = "Men’s dry cut"
                ContinueProg()
            Case 2
                Price = 29.5
                txtService = "Men’s wash and cut"
                ContinueProg()
            Case 3
                Price = 38.75
                txtService = "Ladies wash, cut & blow dry"
                ContinueProg()
            Case 4
                Price = 79.8
                txtService = "Ladies color, cut & style"
                ContinueProg()
            Case 5
                Price = 95.5
                txtService = "Ladies color, foils, cut & style"
                ContinueProg()
            Case Else
                Console.Clear()
                Console.WriteLine("Did not Select a Service.")
        End Select
    End Sub
    Sub ContinueProg()

        ' Clear Console for next input and add header
        Console.Clear()
        headerinp()

        ' Enter Clients Age, input will show to right of text (EXample: ###).
        Console.Write("     Please Enter Clients Age: ")
        Age = Console.ReadLine()
        Console.CursorTop = Console.CursorTop - 1
        Console.SetCursorPosition(Len("     Please Enter Clients Age: " & Age), Console.CursorTop)


        '  If age is greater then 65 set discount to 1 else 0 to no discount.
        If Age >= 65 Then
            Discount = True
        ElseIf Age <= 64 Then
            Discount = False
        End If

        ' Clear Console
        Console.Clear()

        ' If no Discount, Calculate tax and subtotal, if is discount, first get discount, discount from price, then calculate tax and subtotals

        Select Case Discount
            Case True
                AgePrice = Price / 1.1
                AgePriceDisc = Price - AgePrice
                CalcTax = AgePrice * 1.15 - AgePrice
                FinalTax = AgePrice + CalcTax

            Case False
                CalcTax = Price * 1.15 - Price
                FinalTax = Price + CalcTax

        End Select

        ' Show Pre Reciept for user to show how much a person has to pay.
        headerinp()
        Console.WriteLine($"     1x {txtService} {Price.ToString("C2")} ")
        Console.WriteLine("     +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+")

        '  Case if 0 then No Discount, case 1 is Seniors Discount
        Select Case Discount
            Case True
                Console.WriteLine($"               Pre Total: { Price.ToString("C2")}")
                Console.WriteLine($"                Discount: { AgePriceDisc.ToString("C2")}")
                Console.WriteLine($"                Subtotal: {AgePrice.ToString("C2")}")
                Console.WriteLine($"                     Tax: {CalcTax.ToString("C2")}")
                Console.WriteLine($"                   Total: {FinalTax.ToString("C2")}")

            Case False
                Console.WriteLine($"                Subtotal: {Price.ToString("C2")}")
                Console.WriteLine($"                     Tax: {CalcTax.ToString("C2")}")
                Console.WriteLine($"                   Total: {FinalTax.ToString("C2")}")
        End Select

        Console.WriteLine(" ")
        ' ask for Tendard cash
        Console.Write("     Please Enter Amount Tendered: ")
        Tendered = Console.ReadLine()
        Console.CursorTop = Console.CursorTop - 1
        Console.SetCursorPosition(Len("     Please Enter Amount Tendered: " & Tendered), Console.CursorTop)


        Console.Clear()
        headerinp()
        Console.WriteLine($"     1x {txtService} {Price.ToString("C2")} ")
        Console.WriteLine("     +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+")

        '  Case if 0 then No Discount, case 1 is Seniors Discount
        Select Case Discount
            Case True
                Console.WriteLine($"                              Pre Total: { Price.ToString("C2")}")
                Console.WriteLine($"                               Discount: { AgePriceDisc.ToString("C2")}")
                Console.WriteLine($"                               Subtotal: {AgePrice.ToString("C2")}")
                Console.WriteLine($"                                    Tax: {CalcTax.ToString("C2")}")
                Console.WriteLine($"                                  Total: {FinalTax.ToString("C2")}")

            Case False
                Console.WriteLine($"                               Subtotal: {Price.ToString("C2")}")
                Console.WriteLine($"                                    Tax: {CalcTax.ToString("C2")}")
                Console.WriteLine($"                                  Total: {FinalTax.ToString("C2")}")
        End Select
        TenderedFinal = FinalTax - Tendered

        Console.WriteLine($"                                   CASH: {Tendered.ToString("C2")}")
        If Tendered > 0 Then
            Console.WriteLine($"                             Amount owing:{TenderedFinal.ToString("C2")}")
        End If


        Console.WriteLine(" ")
        Console.ReadKey(True)
    End Sub



    ' Header Decliration. just for asstetics and so I dont have to keep inputing this code
    Sub headerinp()
        Console.WriteLine("     +-+-+-+-+-+-+-+ +-+-+-+-+-+ +-+-+-+-+-+-+-+")
        Console.WriteLine("     |S|a|l|l|y|'|s| |S|h|e|a|r| |D|e|l|i|g|h|t|")
        Console.WriteLine("     +-+-+-+-+-+-+-+ +-+-+-+-+-+ +-+-+-+-+-+-+-+")
    End Sub
End Module
