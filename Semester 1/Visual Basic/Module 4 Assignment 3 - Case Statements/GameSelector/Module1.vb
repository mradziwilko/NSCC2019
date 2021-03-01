'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Game Selector
'Date: 9/25/2019
'Author: Marshall Radziwilko
'Operation: 
' Select Game ID
' Input Player name or Player Names
' Output Selected Game and Names
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'10/18/2019 - Created First Illituration
'-----------------------------------------------------------------------------

Module Module1

    Dim intGame As Integer
    Dim strName As String
    Dim strPlayer1, strPlayer2, strPlayer3, strPlayer4 As String




    Sub Main()
        Console.WriteLine("Type Number to Select Game")
        Console.WriteLine("==========================")
        Console.WriteLine("1 - Doom")
        Console.WriteLine("2 - Wolfenstien 3D")
        Console.WriteLine("3 - Call of Duty")
        Console.WriteLine("4 - Battlefeild")
        Console.WriteLine("5 - Mario Cart")
        Console.WriteLine("6 - Dungeons & Dragons")
        Console.WriteLine("7 - World of Warcraft")
        Console.WriteLine("8 - Minecraft")
        Console.WriteLine("9 - Arma 2")
        Console.WriteLine("10 - Garry's Mod")
        Console.WriteLine("==========================")
        Console.WriteLine("Enter ID: ")

        intGame = Console.ReadLine()

        Select Case intGame.ToString

            Case "1"
                ' 1 Player Game Doom
                Console.WriteLine("Please enter your name")
                strPlayer1 = Console.ReadLine()
					Console.Clear()
					Console.WriteLine("==========================")
					Console.WriteLine("Game Name: Doom")
					Console.WriteLine("Max Players: 1")
					Console.WriteLine($"You Name is: {strPlayer1}")
					Console.WriteLine("==========================")
            Case "2"
                ' 2 Player Game Wolfenstien 3D
                Console.WriteLine("Please enter Player 1 Name:")
                strPlayer1 = Console.ReadLine()
                Console.WriteLine("Please enter Player 2 Name:")
                strPlayer2 = Console.ReadLine()
                Console.Clear()
                Console.WriteLine("==========================")
                Console.WriteLine("Game Name: Wolfenstien 3D")
                Console.WriteLine("Max Players: 2")
                Console.WriteLine($"Player 1 Nickname: {strPlayer1}")
                Console.WriteLine($"Player 2 Nickname: {strPlayer2}")
                Console.WriteLine("==========================")

            Case "3"
                ' 1 Player Game Call of Duty
                Console.WriteLine("Please enter your name")
                strPlayer1 = Console.ReadLine()
                Console.Clear()
                Console.WriteLine("==========================")
                Console.WriteLine("Game Name: Call of Duty")
                Console.WriteLine("Max Players: 1")
                Console.WriteLine($"You Name is: {strPlayer1}")
                Console.WriteLine("==========================")
            Case "4"
                ' 2 Player Game Battlefield
                Console.WriteLine("")
                Console.WriteLine("Please enter Player 1 Name:")
                strPlayer1 = Console.ReadLine()
                Console.WriteLine("Please enter Player 2 Name:")
                strPlayer2 = Console.ReadLine()
                Console.Clear()
                Console.WriteLine("==========================")
                Console.WriteLine("Game Name: Battlefield")
                Console.WriteLine("Max Players: 2")
                Console.WriteLine($"Player 1 Nickname: {strPlayer1}")
                Console.WriteLine($"Player 2 Nickname: {strPlayer2}")
                Console.WriteLine("==========================")
            Case "5"
                ' 1 Player Game Mario Cart
                Console.WriteLine("Please enter your name")
                strPlayer1 = Console.ReadLine()
                Console.Clear()
                Console.WriteLine("==========================")
                Console.WriteLine("Game Name: Mario Cart")
                Console.WriteLine("Max Players: 1")
                Console.WriteLine($"You Name is: {strPlayer1}")
                Console.WriteLine("==========================")
            Case "6"
                ' 2 Player Game Dungeons & Dragons
                Console.WriteLine("Please enter Player 1 Name:")
                strPlayer1 = Console.ReadLine()
                Console.WriteLine("Please enter Player 2 Name:")
                strPlayer2 = Console.ReadLine()
                Console.Clear()
                Console.WriteLine("==========================")
                Console.WriteLine("Game Name: Dungeons & Dragons")
                Console.WriteLine("Max Players: 2")
                Console.WriteLine($"Player 1 Nickname: {strPlayer1}")
                Console.WriteLine($"Player 2 Nickname: {strPlayer2}")
                Console.WriteLine("==========================")
            Case "7"
                ' 4 Player Game World of Warcraft
                Console.WriteLine("Please enter Player 1 Name:")
                strPlayer1 = Console.ReadLine()
                Console.WriteLine("Please enter Player 2 Name:")
                strPlayer2 = Console.ReadLine()
                Console.WriteLine("Please enter Player 3 Name:")
                strPlayer3 = Console.ReadLine()
                Console.WriteLine("Please enter Player 4 Name:")
                strPlayer4 = Console.ReadLine()
                Console.Clear()
                Console.WriteLine("==========================")
                Console.WriteLine("Game Name: World of Warcraft")
                Console.WriteLine("Max Players: 4")
                Console.WriteLine($"Player 1 Nickname: {strPlayer1}")
                Console.WriteLine($"Player 2 Nickname: {strPlayer2}")
                Console.WriteLine($"Player 3 Nickname: {strPlayer3}")
                Console.WriteLine($"Player 4 Nickname: {strPlayer4}")
                Console.WriteLine("==========================")
            Case "8"
                ' 4 Player Game Minecraft
                Console.WriteLine("Please enter Player 1 Name:")
                strPlayer1 = Console.ReadLine()
                Console.WriteLine("Please enter Player 2 Name:")
                strPlayer2 = Console.ReadLine()
                Console.WriteLine("Please enter Player 3 Name:")
                strPlayer3 = Console.ReadLine()
                Console.WriteLine("Please enter Player 4 Name:")
                strPlayer4 = Console.ReadLine()
                Console.Clear()
                Console.WriteLine("==========================")
                Console.WriteLine("Game Name: Minecraft")
                Console.WriteLine("Max Players: 4")
                Console.WriteLine($"Player 1 Nickname: {strPlayer1}")
                Console.WriteLine($"Player 2 Nickname: {strPlayer2}")
                Console.WriteLine($"Player 3 Nickname: {strPlayer3}")
                Console.WriteLine($"Player 4 Nickname: {strPlayer4}")
                Console.WriteLine("==========================")
            Case "9"
                ' 4 Player Game  Arma 2
                Console.WriteLine("Please enter Player 1 Name:")
                strPlayer1 = Console.ReadLine()
                Console.WriteLine("Please enter Player 2 Name:")
                strPlayer2 = Console.ReadLine()
                Console.WriteLine("Please enter Player 3 Name:")
                strPlayer3 = Console.ReadLine()
                Console.WriteLine("Please enter Player 4 Name:")
                strPlayer4 = Console.ReadLine()
                Console.Clear()
                Console.WriteLine("==========================")
                Console.WriteLine("Game Name: Arma 2")
                Console.WriteLine("Max Players: 4")
                Console.WriteLine($"Player 1 Nickname: {strPlayer1}")
                Console.WriteLine($"Player 2 Nickname: {strPlayer2}")
                Console.WriteLine($"Player 3 Nickname: {strPlayer3}")
                Console.WriteLine($"Player 4 Nickname: {strPlayer4}")
                Console.WriteLine("==========================")
            Case "10"
                ' 4 Player Game Garry's Mod
                Console.WriteLine("Please enter Player 1 Name:")
                strPlayer1 = Console.ReadLine()
                Console.WriteLine("Please enter Player 2 Name:")
                strPlayer2 = Console.ReadLine()
                Console.WriteLine("Please enter Player 3 Name:")
                strPlayer3 = Console.ReadLine()
                Console.WriteLine("Please enter Player 4 Name:")
                strPlayer4 = Console.ReadLine()
                Console.Clear()
                Console.WriteLine("==========================")
                Console.WriteLine("Game Name: Garry's Mod")
                Console.WriteLine("Max Players: 4")
                Console.WriteLine($"Player 1 Nickname: {strPlayer1}")
                Console.WriteLine($"Player 2 Nickname: {strPlayer2}")
                Console.WriteLine($"Player 3 Nickname: {strPlayer3}")
                Console.WriteLine($"Player 4 Nickname: {strPlayer4}")
                Console.WriteLine("==========================")
            Case Else
                Console.WriteLine("You did not Select a Game.")
        End Select





        Console.ReadKey(True)





    End Sub

End Module
