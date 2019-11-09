Module Module1

    Dim game As New Game
    Dim highScores(9, 1) As String

    Dim bDevMenu As Boolean = False

    Public Sub Main()

        SetUp()
        Menu()

    End Sub

    Private Sub SetUp()

        Console.SetWindowSize(56, 37)
        SetInitialHighScores()

    End Sub

    Private Sub SetInitialHighScores()

        highScores(0, 0) = "AAA" : highScores(0, 1) = "0000"
        highScores(1, 0) = "BBB" : highScores(1, 1) = "0000"
        highScores(2, 0) = "CCC" : highScores(2, 1) = "0000"
        highScores(3, 0) = "DDD" : highScores(3, 1) = "0000"
        highScores(4, 0) = "EEE" : highScores(4, 1) = "0000"
        highScores(5, 0) = "FFF" : highScores(5, 1) = "0000"
        highScores(6, 0) = "GGG" : highScores(6, 1) = "0000"
        highScores(7, 0) = "HHH" : highScores(7, 1) = "0000"
        highScores(8, 0) = "III" : highScores(8, 1) = "0000"
        highScores(9, 0) = "JJJ" : highScores(9, 1) = "0000"

    End Sub

    Private Sub Menu()

        Console.Clear()

        DrawPacManLogo()
        Console.WriteLine()

        Console.WriteLine("1. Start game")
        Console.WriteLine("2. View high-scores")
        Console.WriteLine("3. Options")
        Console.WriteLine("4. Quit")

        If bDevMenu = True Then
            Console.WriteLine("5. Developer menu")
        End If

        Select Case Console.ReadKey.KeyChar()
            Case "1"
                game.StartGame()

            Case "2"
                ViewHighScores()

            Case "3"
                Options()

            Case "4"
                End

            Case "5"
                If bDevMenu = True Then
                    DevMenu()
                End If

        End Select

        Menu()

    End Sub

    Private Sub DrawPacManLogo()

        Console.WriteLine("  _____             __  __             ")
        Console.WriteLine(" |  __ \           |  \/  |            ")
        Console.WriteLine(" | |__) |_ _  ___  | \  / | __ _ _ __  ")
        Console.WriteLine(" |  ___/ _  |/ __| | |\/| |/ _  |  _ \ ")
        Console.WriteLine(" | |  | (_| | (__  | |  | | (_| | | | |")
        Console.WriteLine(" |_|   \__,_|\___| |_|  |_|\__,_|_| |_|")

    End Sub

    Private Sub ViewHighScores()

        Console.Clear()

        DrawPacManLogo()
        Console.WriteLine()

        Console.WriteLine("High-scores")
        Console.WriteLine()
        Console.WriteLine("1. " & highScores(9, 0) & " - " & highScores(9, 1))
        Console.WriteLine("2. " & highScores(8, 0) & " - " & highScores(8, 1))
        Console.WriteLine("3. " & highScores(7, 0) & " - " & highScores(7, 1))
        Console.WriteLine("4. " & highScores(6, 0) & " - " & highScores(6, 1))
        Console.WriteLine("5. " & highScores(5, 0) & " - " & highScores(5, 1))
        Console.WriteLine("6. " & highScores(4, 0) & " - " & highScores(4, 1))
        Console.WriteLine("7. " & highScores(3, 0) & " - " & highScores(3, 1))
        Console.WriteLine("8. " & highScores(2, 0) & " - " & highScores(2, 1))
        Console.WriteLine("9. " & highScores(1, 0) & " - " & highScores(1, 1))
        Console.WriteLine("10. " & highScores(0, 0) & " - " & highScores(0, 1))

        Console.WriteLine()
        Console.WriteLine("Press any key to return to the main menu")

        Console.ReadKey()

    End Sub

    Private Sub Options()

        Console.Clear()

        DrawPacManLogo()
        Console.WriteLine()

        Console.WriteLine("Options")
        Console.WriteLine()

        Console.Write("1. Toggle developer menu (")
        If bDevMenu = True Then
            Console.Write("ON")
        Else
            Console.Write("OFF")
        End If
        Console.WriteLine(")")

        Console.Write("2. Toggle sound (")
        If game.sound = True Then
            Console.Write("ON")
        Else
            Console.Write("OFF")
        End If
        Console.WriteLine(")")

        Console.Write("3. Toggle clear type (")
        If game.fClear = True Then
            Console.Write("FANCY")
        Else
            Console.Write("NORMAL")
        End If
        Console.WriteLine(")")

        Console.WriteLine("4. Return to main menu")

        Select Case Console.ReadKey.KeyChar
            Case "1"
                ToggleBool(bDevMenu)

            Case "2"
                ToggleBool(game.sound)

            Case "3"
                ToggleBool(game.fClear)

            Case "4"
                Menu()

        End Select

        Options()

    End Sub

    Private Sub ToggleBool(ByRef bool As Boolean)

        If bool = True Then
            bool = False
        Else
            bool = True
        End If

    End Sub

    Private Sub DevMenu()

        Console.Clear()

        DrawPacManLogo()
        Console.WriteLine()

        Console.WriteLine("Developer Menu")
        Console.WriteLine()
        Console.WriteLine("1. Test score adding")
        Console.WriteLine("2. Test music")
        Console.WriteLine("3. Main menu")

        Select Case Console.ReadKey.KeyChar()
            Case "1"
                EnterScore("100000")

            Case "2"
                TestMusic2()

            Case "3"
                Menu()

        End Select

        DevMenu()

    End Sub

    Public Sub TestMusic()

        Console.Beep(658, 125)
        Console.Beep(1320, 500)
        Console.Beep(990, 250)
        Console.Beep(1056, 250)
        Console.Beep(1188, 250)
        Console.Beep(1320, 125)
        Console.Beep(1188, 125)
        Console.Beep(1056, 250)
        Console.Beep(990, 250)
        Console.Beep(880, 500)
        Console.Beep(880, 250)
        Console.Beep(1056, 250)
        Console.Beep(1320, 500)
        Console.Beep(1188, 250)
        Console.Beep(1056, 250)
        Console.Beep(990, 750)
        Console.Beep(1056, 250)
        Console.Beep(1188, 500)
        Console.Beep(1320, 500)
        Console.Beep(1056, 500)
        Console.Beep(880, 500)
        Console.Beep(880, 500)
        System.Threading.Thread.Sleep(250)
        Console.Beep(1188, 500)
        Console.Beep(1408, 250)
        Console.Beep(1760, 500)
        Console.Beep(1584, 250)
        Console.Beep(1408, 250)
        Console.Beep(1320, 750)
        Console.Beep(1056, 250)
        Console.Beep(1320, 500)
        Console.Beep(1188, 250)
        Console.Beep(1056, 250)
        Console.Beep(990, 500)
        Console.Beep(990, 250)
        Console.Beep(1056, 250)
        Console.Beep(1188, 500)
        Console.Beep(1320, 500)
        Console.Beep(1056, 500)
        Console.Beep(880, 500)
        Console.Beep(880, 500)
        System.Threading.Thread.Sleep(500)
        Console.Beep(1320, 500)
        Console.Beep(990, 250)
        Console.Beep(1056, 250)
        Console.Beep(1188, 250)
        Console.Beep(1320, 125)
        Console.Beep(1188, 125)
        Console.Beep(1056, 250)
        Console.Beep(990, 250)
        Console.Beep(880, 500)
        Console.Beep(880, 250)
        Console.Beep(1056, 250)
        Console.Beep(1320, 500)
        Console.Beep(1188, 250)
        Console.Beep(1056, 250)
        Console.Beep(990, 750)
        Console.Beep(1056, 250)
        Console.Beep(1188, 500)
        Console.Beep(1320, 500)
        Console.Beep(1056, 500)
        Console.Beep(880, 500)
        Console.Beep(880, 500)
        System.Threading.Thread.Sleep(250)
        Console.Beep(1188, 500)
        Console.Beep(1408, 250)
        Console.Beep(1760, 500)
        Console.Beep(1584, 250)
        Console.Beep(1408, 250)
        Console.Beep(1320, 750)
        Console.Beep(1056, 250)
        Console.Beep(1320, 500)
        Console.Beep(1188, 250)
        Console.Beep(1056, 250)
        Console.Beep(990, 500)
        Console.Beep(990, 250)
        Console.Beep(1056, 250)
        Console.Beep(1188, 500)
        Console.Beep(1320, 500)
        Console.Beep(1056, 500)
        Console.Beep(880, 500)
        Console.Beep(880, 500)
        System.Threading.Thread.Sleep(500)
        Console.Beep(660, 1000)
        Console.Beep(528, 1000)
        Console.Beep(594, 1000)
        Console.Beep(495, 1000)
        Console.Beep(528, 1000)
        Console.Beep(440, 1000)
        Console.Beep(419, 1000)
        Console.Beep(495, 1000)
        Console.Beep(660, 1000)
        Console.Beep(528, 1000)
        Console.Beep(594, 1000)
        Console.Beep(495, 1000)
        Console.Beep(528, 500)
        Console.Beep(660, 500)
        Console.Beep(880, 1000)
        Console.Beep(838, 2000)
        Console.Beep(660, 1000)
        Console.Beep(528, 1000)
        Console.Beep(594, 1000)
        Console.Beep(495, 1000)
        Console.Beep(528, 1000)
        Console.Beep(440, 1000)
        Console.Beep(419, 1000)
        Console.Beep(495, 1000)
        Console.Beep(660, 1000)
        Console.Beep(528, 1000)
        Console.Beep(594, 1000)
        Console.Beep(495, 1000)
        Console.Beep(528, 500)
        Console.Beep(660, 500)
        Console.Beep(880, 1000)
        Console.Beep(838, 2000)

    End Sub

    Public Sub TestMusic2()

        Console.Beep(247, 250)
        Console.Beep(494, 250)
        Console.Beep(370, 250)
        Console.Beep(311, 250)

        Console.Beep(494, 125)
        Console.Beep(370, 375)
        Console.Beep(311, 500)

        System.Threading.Thread.Sleep(100)

        Console.Beep(262, 250)
        Console.Beep(523, 250)
        Console.Beep(392, 250)
        Console.Beep(330, 250)

        Console.Beep(523, 125)
        Console.Beep(392, 375)
        Console.Beep(330, 500)

        System.Threading.Thread.Sleep(100)

        Console.Beep(247, 250)
        Console.Beep(494, 250)
        Console.Beep(370, 250)
        Console.Beep(311, 250)

        Console.Beep(494, 125)
        Console.Beep(370, 375)
        Console.Beep(311, 500)

        System.Threading.Thread.Sleep(100)

        Console.Beep(311, 125)
        Console.Beep(330, 125)
        Console.Beep(349, 250)

        Console.Beep(349, 125)
        Console.Beep(370, 125)
        Console.Beep(392, 250)

        Console.Beep(392, 125)
        Console.Beep(415, 125)
        Console.Beep(440, 250)
        Console.Beep(494, 500)

    End Sub

    Public Sub EnterScore(score As String)

        Console.Clear()

        DrawPacManLogo()
        Console.WriteLine()

        Console.WriteLine("Score: " & score)
        Console.WriteLine()
        Console.Write("Enter your name: ")
        AddScore(Console.ReadLine(), score)

        ViewHighScores()
        Menu()

    End Sub

    Private Sub AddScore(name As String, score As String)

        For i As Integer = 9 To 0 Step -1
            If Val(score) > Val(highScores(i, 1)) Then
                For j As Integer = 1 To i
                    highScores(j - 1, 0) = highScores(j, 0)
                    highScores(j - 1, 1) = highScores(j, 1)
                Next
                highScores(i, 0) = name
                highScores(i, 1) = score
                Exit Sub
            End If
        Next

    End Sub

End Module