'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program: Game Selector
'Date: 9/25/2019
'Author: Marshall Radziwilko
'Operation: 
' Input Game ID
' Set Game Name, Set Player count
' Ask for Player NickName or NickNames 
' Output Formated dialog
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date Programmer Change 
'10/18/2019 - Created First Illituration
'-----------------------------------------------------------------------------

Module Module1

    Dim intGame, maxPlayers, strName, strPlayer1, strPlayer2, strPlayer3, strPlayer4, strGameName, strError As String
    Dim blnFinish As Boolean




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


        ' Set Game Name and Set Players
        Select Case intGame.ToString

            Case "1"
                ' 1 Player Game Doom
                strGameName = "Doom"
                maxPlayers = 1

            Case "2"
                ' 2 Player Game Wolfenstien 3D

                strGameName = "Wolfenstien 3D"
                maxPlayers = 2

            Case "3"
                ' 1 Player Game Call of Duty
                strGameName = "Call of Duty"
                maxPlayers = 1
            Case "4"
                ' 2 Player Game Battlefield
                strGameName = "Battlefield"
                maxPlayers = 2

            Case "5"
                ' 1 Player Game Mario Cart
                strGameName = "Mario Cart"
                maxPlayers = 1

            Case "6"
                ' 2 Player Game Dungeons & Dragons
                strGameName = "Dungeons & Dragons"
                maxPlayers = 2

            Case "7"
                ' 4 Player Game World of Warcraft
                strGameName = "World of Warcraft"
                maxPlayers = 4

            Case "8"
                ' 4 Player Game Minecraft
                strGameName = "Minecraft"
                maxPlayers = 4

            Case "9"
                ' 4 Player Game  Arma 2
                strGameName = "Arma 2"
                maxPlayers = 4

            Case "10"
                ' 4 Player Game Garry's Mod
                strGameName = "Garry's Mod"
                maxPlayers = 4

            Case Else
                strError = "Did not Select a Game."
                maxPlayers = 0
        End Select




        ' Each Player Input name and set to output.
        Select Case maxPlayers
            Case 1
                Console.WriteLine("Please Enter your Nick Name:")
                strPlayer1 = Console.ReadLine()
                If strPlayer1 = "" Then
                    strError = "ERROR: Player Name is empty, Please play again."
                Else
                    blnFinish = True
                End If

            Case 2
                Console.WriteLine("Player 1 Nick Name:")
                strPlayer1 = Console.ReadLine()
                Console.WriteLine("Player 2 Nick Name:")
                strPlayer2 = Console.ReadLine()
                If strPlayer1 = "" Or strPlayer2 = "" Then
                    strError = "ERROR: Player Names are empty, Please play again."
                Else
                    blnFinish = True
                End If
            Case 4
                Console.WriteLine("Player 1 Nick Name:")
                strPlayer1 = Console.ReadLine()
                Console.WriteLine("Player 2 Nick Name:")
                strPlayer2 = Console.ReadLine()
                Console.WriteLine("Player 3 Nick Name:")
                strPlayer3 = Console.ReadLine()
                Console.WriteLine("Player 4 Nick Name:")
                strPlayer4 = Console.ReadLine()
                If strPlayer1 = "" Or strPlayer2 = "" Or strPlayer3 = "" Or strPlayer4 = "" Then
                    strError = "ERROR: Player Names are empty, Please play again."
                Else
                    blnFinish = True
                End If

            Case Else

        End Select



        ' Final output, show Game Name, Max Players and Players.
        Select Case blnFinish
            Case True

                Console.Clear()
                Console.WriteLine("==========================")
                Console.WriteLine($"Game Name: {strGameName}")
                Console.WriteLine($"Max Players: {maxPlayers}")
                Select Case maxPlayers
                    Case 1
                        Console.WriteLine($"Nickname: {strPlayer1}")
                    Case 2
                        Console.WriteLine($"Player 1 Nickname: {strPlayer1}")
                        Console.WriteLine($"Player 2 Nickname: {strPlayer2}")
                    Case 4
                        Console.WriteLine($"Player 1 Nickname: {strPlayer1}")
                        Console.WriteLine($"Player 2 Nickname: {strPlayer2}")
                        Console.WriteLine($"Player 3 Nickname: {strPlayer3}")
                        Console.WriteLine($"Player 4 Nickname: {strPlayer4}")
                End Select
                Console.WriteLine("==========================")
            Case Else
                ' If Error, Show Error String. Set with strError.
                Console.WriteLine(strError)
        End Select

        ' Press Key to Exit.

        Console.WriteLine("Press any key to continue.")
        Console.ReadKey(True)





    End Sub

End Module
