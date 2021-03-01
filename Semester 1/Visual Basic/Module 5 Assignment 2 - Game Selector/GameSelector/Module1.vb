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
' 10/18/2019 - Created First Illituration
' 11/1/2019 - Remodled App to use Loops and check for valid game.
'-----------------------------------------------------------------------------

Module Module1
    ' Set String Variables and Game List (Used just to make code smaller)
    Dim intGame, strGameName, playerName, extStr As String
    Dim arrGameList() As String = {"Type Number to Select Game", "==========================", "1 - Doom", "2 - Wolfenstien 3D", "3 - Call of Duty", "4 - Battlefeild", "5 - Mario Cart", "6 - Dungeons & Dragons", "7 - World of Warcraft", "8 - Minecraft", "9 - Arma 2", "10 - Garry's Mod", "=========================="}

    ' Set True/False Boolean for checks
    Dim blnFinish, errorInp As Boolean
    Dim inpStep2 As Boolean = False
    Dim ExtVar As Boolean = False

    ' Array List for Players, cleared once a new game starts.
    Dim arrayPlayers As New ArrayList


    ' Set Defualt players and counts
    Dim PlayerCnt As Integer = 1
    Dim intPlayers As Integer = 0
    Dim startCount As Integer = 0





    Sub Main()

        ' Exit variable, once set to True, it would exit application.
        Do Until ExtVar = True

            ' First Loop to check for game list, if invalid then repeat list check.
            Do Until inpStep2 = True

                Console.Clear()

                ' If error Exists show error.
                If errorInp = True Then

                    Console.WriteLine("Invalid Input, Please type a game.")
                    Console.WriteLine("")
                End If

                ' Just to make code smaller, make game list as sub process. (bottom of page)
                printlist()

                ' Input Game ID
                Console.WriteLine("Enter ID: ")
                intGame = Console.ReadLine()

                ' Make sure everytime a game is selected, it wont show error before only after.
                errorInp = False

                ' Select game, set Game Name, Set Players and then Exit this loop when true, if error dont set go back to start.
                Select Case intGame
                    Case "1"
                        strGameName = "Doom"
                        intPlayers = 1
                        inpStep2 = True
                    Case "2"
                        strGameName = "Wolfenstien 3D"
                        intPlayers = 2
                        inpStep2 = True
                    Case "3"
                        strGameName = "Call of Duty"
                        intPlayers = 1
                        inpStep2 = True
                    Case "4"
                        strGameName = "Battlefeild"
                        intPlayers = 2
                        inpStep2 = True
                    Case "5"
                        strGameName = "Mario Cart"
                        intPlayers = 1
                        inpStep2 = True
                    Case "6"
                        strGameName = "Dungeons & Dragons"
                        intPlayers = 2
                        inpStep2 = True
                    Case "7"
                        strGameName = "World of Warcraft"
                        intPlayers = 4
                        inpStep2 = True
                    Case "8"
                        strGameName = "Minecraft"
                        intPlayers = 4
                        inpStep2 = True
                    Case "9"
                        strGameName = "Arma 2"
                        intPlayers = 4
                        inpStep2 = True
                    Case "10"
                        strGameName = "Garry's Mod"
                        intPlayers = 4
                        inpStep2 = True
                    Case Else
                        Console.Clear()
                        errorInp = True

                        printlist()
                        Console.WriteLine("")

                End Select

            Loop
            Console.Clear()


            ' For Each player in game, ask for player name and store it in an array that is not sorted.
            Do Until startCount >= intPlayers
                startCount = startCount + 1
                Console.WriteLine($"Please Enter Player {startCount}")
                playerName = Console.ReadLine()
                arrayPlayers.Add(playerName)
            Loop

            Console.Clear()


            ' Print out results for chosen game and max players
            Console.WriteLine($"Chosen Game: {strGameName}")
            Console.WriteLine($"Max Players: {intPlayers}")


            ' for Each player in Player array, print out player ID and Name.
            For Each item In arrayPlayers
                Console.WriteLine($"Player #{PlayerCnt}: {item}")
                PlayerCnt = PlayerCnt + 1
            Next

            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("Press Enter to Restart or Type Quit to Exit.")
            Console.WriteLine("")
            extStr = Console.ReadLine()

            ' Select Varaible for Exit, if exit is entered, set to Exit Variable and quit, or set variables to empty and reload.
            Select Case extStr
                Case "Quit"
                    ExtVar = True
                Case "quit"
                    ExtVar = True
                Case Else
                    Console.Clear()
                    PlayerCnt = 1
                    arrayPlayers.Clear()
                    strGameName = ""
                    intPlayers = 0
                    strGameName = ""
                    inpStep2 = False
                    intGame = ""
            End Select




        Loop

    End Sub


    Sub printlist()

        For Each item In arrGameList
            Console.WriteLine($"{item}")
        Next

    End Sub

End Module
