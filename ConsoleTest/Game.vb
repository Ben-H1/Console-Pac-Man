Imports System
Imports System.Threading
Public Class Game

    Dim map(29, 36) As Boolean
    Dim pellets(28, 36)

    Dim score As Integer

    Dim wallColour As ConsoleColor
    Dim wallFlashColour As ConsoleColor
    Dim backgroundColour As ConsoleColor

    Dim pelletColour As ConsoleColor
    Dim pelletChar As Char

    Dim scoreColour As ConsoleColor

    Dim pacManx As Integer
    Dim pacMany As Integer
    Dim pacManColour As ConsoleColor

    Dim upKey As ConsoleKey
    Dim leftKey As ConsoleKey
    Dim downKey As ConsoleKey
    Dim rightKey As ConsoleKey

    Dim wakaState As Integer
    Public sound As Boolean = True
    Public fClear As Boolean = True

    Dim gameOver As Boolean

    Public Sub New()

        SetMap()
        SetPellets()

        score = 0

        wallColour = ConsoleColor.Blue
        wallFlashColour = ConsoleColor.Cyan
        backgroundColour = ConsoleColor.Black

        pelletColour = ConsoleColor.DarkYellow
        pelletChar = "."

        scoreColour = ConsoleColor.White

        pacManColour = ConsoleColor.Yellow

        gameOver = False

        upKey = ConsoleKey.UpArrow
        leftKey = ConsoleKey.LeftArrow
        downKey = ConsoleKey.DownArrow
        rightKey = ConsoleKey.RightArrow

        wakaState = 1

    End Sub

    Private Sub SetMap()

        For y = 1 To 36
            For x = 1 To 28
                map(x, y) = False
            Next
        Next

        'Skip lines 1 and 2

        'Line 3
        For x = 1 To 28
            map(x, 3) = True
        Next

        'Line 4
        map(1, 4) = True
        map(14, 4) = True
        map(15, 4) = True
        map(28, 4) = True

        'Lines 5 to 7
        For y = 5 To 7
            map(1, y) = True
            For x = 3 To 6
                map(x, y) = True
            Next
            For x = 8 To 12
                map(x, y) = True
            Next
            map(14, y) = True
            map(15, y) = True
            For x = 17 To 21
                map(x, y) = True
            Next
            For x = 23 To 26
                map(x, y) = True
            Next
            map(28, y) = True
        Next

        'Line 8
        map(1, 8) = True
        map(28, 8) = True

        'Lines 9 and 10
        For y = 9 To 10
            map(1, y) = True
            For x = 3 To 6
                map(x, y) = True
            Next
            map(8, y) = True
            map(9, y) = True
            For x = 11 To 18
                map(x, y) = True
            Next
            map(20, y) = True
            map(21, y) = True
            For x = 23 To 26
                map(x, y) = True
            Next
            map(28, y) = True
        Next

        'Line 11
        map(1, 11) = True
        map(8, 11) = True
        map(9, 11) = True
        map(14, 11) = True
        map(15, 11) = True
        map(20, 11) = True
        map(21, 11) = True
        map(28, 11) = True

        'Line 12
        For x = 1 To 6
            map(x, 12) = True
        Next
        For x = 8 To 12
            map(x, 12) = True
        Next
        map(14, 12) = True
        map(15, 12) = True
        For x = 17 To 21
            map(x, 12) = True
        Next
        For x = 23 To 28
            map(x, 12) = True
        Next

        'Line 13
        map(6, 13) = True
        For x = 8 To 12
            map(x, 13) = True
        Next
        map(14, 13) = True
        map(15, 13) = True
        For x = 17 To 21
            map(x, 13) = True
        Next
        map(23, 13) = True

        'Line 14
        map(6, 14) = True
        map(8, 14) = True
        map(9, 14) = True
        map(20, 14) = True
        map(21, 14) = True
        map(23, 14) = True

        'Line 15
        map(6, 15) = True
        map(8, 15) = True
        map(9, 15) = True
        For x = 11 To 18
            map(x, 15) = True
        Next
        map(20, 15) = True
        map(21, 15) = True
        map(23, 15) = True

        'Line 16
        For x = 1 To 6
            map(x, 16) = True
        Next
        map(8, 16) = True
        map(9, 16) = True
        map(11, 16) = True
        map(18, 16) = True
        map(20, 16) = True
        map(21, 16) = True
        For x = 23 To 28
            map(x, 16) = True
        Next

        'Line 17
        map(11, 17) = True
        map(18, 17) = True

        'Line 18
        For x = 1 To 6
            map(x, 18) = True
        Next
        map(8, 18) = True
        map(9, 18) = True
        map(11, 18) = True
        map(18, 18) = True
        map(20, 18) = True
        map(21, 18) = True
        For x = 23 To 28
            map(x, 18) = True
        Next

        'Line 19
        map(6, 19) = True
        map(8, 19) = True
        map(9, 19) = True
        For x = 11 To 18
            map(x, 19) = True
        Next
        map(20, 19) = True
        map(21, 19) = True
        map(23, 19) = True

        'Line 20
        map(6, 20) = True
        map(8, 20) = True
        map(9, 20) = True
        map(20, 20) = True
        map(21, 20) = True
        map(23, 20) = True

        'Line 21
        map(6, 21) = True
        map(8, 21) = True
        map(9, 21) = True
        For x = 11 To 18
            map(x, 21) = True
        Next
        map(20, 21) = True
        map(21, 21) = True
        map(23, 21) = True

        'Line 22
        For x = 1 To 6
            map(x, 22) = True
        Next
        map(8, 22) = True
        map(9, 22) = True
        For x = 11 To 18
            map(x, 22) = True
        Next
        map(20, 22) = True
        map(21, 22) = True
        For x = 23 To 28
            map(x, 22) = True
        Next

        'Line 23
        map(1, 23) = True
        map(14, 23) = True
        map(15, 23) = True
        map(28, 23) = True

        'Lines 24 and 25
        For y = 24 To 25
            map(1, y) = True
            For x = 3 To 6
                map(x, y) = True
            Next
            For x = 8 To 12
                map(x, y) = True
            Next
            map(14, y) = True
            map(15, y) = True
            For x = 17 To 21
                map(x, y) = True
            Next
            For x = 23 To 26
                map(x, y) = True
            Next
            map(28, y) = True
        Next

        'Line 26
        map(1, 26) = True
        map(5, 26) = True
        map(6, 26) = True
        map(23, 26) = True
        map(24, 26) = True
        map(28, 26) = True

        'Lines 27 and 28
        For y = 27 To 28
            For x = 1 To 3
                map(x, y) = True
            Next
            map(5, y) = True
            map(6, y) = True
            map(8, y) = True
            map(9, y) = True
            For x = 11 To 18
                map(x, y) = True
            Next
            map(20, y) = True
            map(21, y) = True
            map(23, y) = True
            map(24, y) = True
            For x = 26 To 28
                map(x, y) = True
            Next
        Next

        'Line 29
        map(1, 29) = True
        map(8, 29) = True
        map(9, 29) = True
        map(14, 29) = True
        map(15, 29) = True
        map(20, 29) = True
        map(21, 29) = True
        map(28, 29) = True

        'Lines 30 and 31
        For y = 30 To 31
            map(1, y) = True
            For x = 3 To 12
                map(x, y) = True
            Next
            map(14, y) = True
            map(15, y) = True
            For x = 17 To 26
                map(x, y) = True
            Next
            map(28, y) = True
        Next

        'Line 32
        map(1, 32) = True
        map(28, 32) = True

        'Line 33
        For x = 1 To 28
            map(x, 33) = True
        Next

        'Skip lines 34 to 36

    End Sub

    Private Sub SetPellets()

        For y = 1 To 36
            For x = 1 To 28
                pellets(x, y) = False
            Next
        Next

        'Skip lines 1 to 3

        'Line 4
        For x = 2 To 13
            pellets(x, 4) = True
        Next
        For x = 16 To 27
            pellets(x, 4) = True
        Next

        'Lines 5 to 7
        For y = 5 To 7
            pellets(2, y) = True
            pellets(7, y) = True
            pellets(13, y) = True
            pellets(16, y) = True
            pellets(22, y) = True
            pellets(27, y) = True
        Next

        'Line 8
        For x = 2 To 27
            pellets(x, 8) = True
        Next

        'Lines 9 and 10
        For y = 9 To 10
            pellets(2, y) = True
            pellets(7, y) = True
            pellets(10, y) = True
            pellets(19, y) = True
            pellets(22, y) = True
            pellets(27, y) = True
        Next

        'Line 11
        For x = 2 To 7
            pellets(x, 11) = True
        Next
        For x = 10 To 13
            pellets(x, 11) = True
        Next
        For x = 16 To 19
            pellets(x, 11) = True
        Next
        For x = 22 To 27
            pellets(x, 11) = True
        Next

        'Lines 12 to 22
        For y = 12 To 22
            pellets(7, y) = True
            pellets(22, y) = True
        Next

        'Line 23
        For x = 2 To 13
            pellets(x, 23) = True
        Next
        For x = 16 To 27
            pellets(x, 23) = True
        Next

        'Lines 24 and 25
        For y = 24 To 25
            pellets(2, y) = True
            pellets(7, y) = True
            pellets(13, y) = True
            pellets(16, y) = True
            pellets(22, y) = True
            pellets(27, y) = True
        Next

        'Line 26
        For x = 2 To 4
            pellets(x, 26) = True
        Next
        For x = 7 To 13
            pellets(x, 26) = True
        Next
        For x = 16 To 22
            pellets(x, 26) = True
        Next
        For x = 25 To 27
            pellets(x, 26) = True
        Next

        'Lines 27 and 28
        For y = 27 To 28
            pellets(4, y) = True
            pellets(7, y) = True
            pellets(10, y) = True
            pellets(19, y) = True
            pellets(22, y) = True
            pellets(25, y) = True
        Next

        'Line 29
        For x = 2 To 7
            pellets(x, 29) = True
        Next
        For x = 10 To 13
            pellets(x, 29) = True
        Next
        For x = 16 To 19
            pellets(x, 29) = True
        Next
        For x = 22 To 27
            pellets(x, 29) = True
        Next

        'Lines 30 and 31
        For y = 30 To 31
            pellets(2, y) = True
            pellets(13, y) = True
            pellets(16, y) = True
            pellets(27, y) = True
        Next

        'Line 32
        For x = 2 To 27
            pellets(x, 32) = True
        Next

        'Skip lines 33 to 36

    End Sub

    Public Sub StartGame()

        score = 0
        gameOver = False

        DrawMap()
        DrawPellets()

        pacManx = 14
        pacMany = 26

        RunGame()

    End Sub

    Private Sub RunGame()

        Dim key As ConsoleKey

        DrawScore()

        DrawPacMan(pacManx, pacMany)

        DrawReady()
        PlayTheme()
        DeleteReady()

        Do Until gameOver = True

            'key = Console.ReadKey.Key

            If Console.KeyAvailable Then
                key = Console.ReadKey.Key
            End If

            Select Case key
                Case upKey
                    MoveUp()

                Case leftKey
                    MoveLeft()

                Case downKey
                    MoveDown()

                Case rightKey
                    MoveRight()

            End Select

            If pellets(pacManx, pacMany) = True Then

                pellets(pacManx, pacMany) = False
                score += 10
                DrawScore()

            End If

            gameOver = CheckPellets()

            If sound = True Then
                Thread.Sleep(75)
            Else
                Thread.Sleep(175)
            End If

        Loop

        GameOverProcedure()

    End Sub

#Region "Moving"

    Private Sub MoveUp()

        If map(pacManx, pacMany - 1) = False Then

            DeletePacMan(pacManx, pacMany)
            pacMany -= 1
            DrawPacMan(pacManx, pacMany)

            Waka()

        Else

            DeletePacMan(pacManx, pacMany)
            DrawPacMan(pacManx, pacMany)

        End If

    End Sub

    Private Sub MoveLeft()

        If map(pacManx - 1, pacMany) = False Then

            DeletePacMan(pacManx, pacMany)

            If pacManx = 1 And pacMany = 17 Then
                pacManx = 28
            Else
                pacManx -= 1
            End If

            DrawPacMan(pacManx, pacMany)

            Waka()

        Else

            DeletePacMan(pacManx, pacMany)
            DrawPacMan(pacManx, pacMany)

        End If

    End Sub

    Private Sub MoveDown()

        If map(pacManx, pacMany + 1) = False Then

            DeletePacMan(pacManx, pacMany)
            pacMany += 1
            DrawPacMan(pacManx, pacMany)

            Waka()

        Else

            DeletePacMan(pacManx, pacMany)
            DrawPacMan(pacManx, pacMany)

        End If

    End Sub

    Private Sub MoveRight()

        If map(pacManx + 1, pacMany) = False Then

            DeletePacMan(pacManx, pacMany)

            If pacManx = 28 And pacMany = 17 Then
                pacManx = 1
            Else
                pacManx += 1
            End If

            DrawPacMan(pacManx, pacMany)

            Waka()

        Else

            DeletePacMan(pacManx, pacMany)
            DrawPacMan(pacManx, pacMany)

        End If

    End Sub

#End Region

    Private Sub Waka()

        If sound = True Then
            If wakaState = 1 Then
                Console.Beep(500, 100)
                wakaState = 2
            Else
                Console.Beep(250, 100)
                wakaState = 1
            End If
        End If

    End Sub

    Private Sub PlayTheme()

        If sound = True Then

            Console.Beep(247, 250)
            Console.Beep(494, 250)
            Console.Beep(370, 250)
            Console.Beep(311, 250)

            Console.Beep(494, 125)
            Console.Beep(370, 375)
            Console.Beep(311, 500)

            Thread.Sleep(100)

            Console.Beep(262, 250)
            Console.Beep(523, 250)
            Console.Beep(392, 250)
            Console.Beep(330, 250)

            Console.Beep(523, 125)
            Console.Beep(392, 375)
            Console.Beep(330, 500)

            Thread.Sleep(100)

            Console.Beep(247, 250)
            Console.Beep(494, 250)
            Console.Beep(370, 250)
            Console.Beep(311, 250)

            Console.Beep(494, 125)
            Console.Beep(370, 375)
            Console.Beep(311, 500)

            Thread.Sleep(100)

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

        Else

            Thread.Sleep(3000)

        End If

    End Sub

#Region "Drawing"

    Private Sub DrawMap()

        Console.Clear()

        For y = 1 To 36
            For x = 1 To 28

                Console.SetCursorPosition(x * 2 - 2, y - 1)
                Console.BackgroundColor = wallColour
                If map(x, y) = True Then
                    Console.Write("  ")
                End If
                Console.BackgroundColor = backgroundColour

            Next
        Next

    End Sub

    Private Sub DrawPellets()

        For y = 1 To 36
            For x = 1 To 28

                If pellets(x, y) = True Then
                    Console.ForegroundColor = pelletColour
                    Console.SetCursorPosition((x * 2) - 2, y - 1)
                    Console.Write(pelletChar & " ")
                    Console.ForegroundColor = ConsoleColor.Gray
                End If

            Next
        Next

    End Sub

    Private Sub DrawPacMan(x As Integer, y As Integer)

        Console.BackgroundColor = pacManColour
        Console.SetCursorPosition((x * 2) - 2, y - 1)
        Console.Write("  ")
        Console.SetCursorPosition((x * 2) - 2, y - 1)
        Console.BackgroundColor = backgroundColour

    End Sub

    Private Sub DeletePacMan(x As Integer, y As Integer)

        Console.BackgroundColor = backgroundColour
        Console.SetCursorPosition((x * 2) - 2, y - 1)
        Console.Write("  ")
        Console.SetCursorPosition((x * 2) - 2, y - 1)

    End Sub

    Private Sub DrawScore()

        Console.ForegroundColor = scoreColour
        Console.SetCursorPosition(0, 0)
        Console.Write("Score")
        Console.SetCursorPosition(0, 1)
        Console.Write(score)
        Console.SetCursorPosition((pacManx * 2) - 2, pacMany - 1)
        Console.ForegroundColor = ConsoleColor.Gray

    End Sub

    Private Sub DrawReady()

        Console.SetCursorPosition(25, 19)
        Console.ForegroundColor = pacManColour
        Console.Write("Ready!")
        Console.ForegroundColor = ConsoleColor.Gray
        Console.SetCursorPosition((pacManx * 2) - 2, pacMany - 1)

    End Sub

    Private Sub DeleteReady()

        Console.SetCursorPosition(25, 19)
        Console.BackgroundColor = backgroundColour
        Console.Write("      ")
        Console.SetCursorPosition((pacManx * 2) - 2, pacMany - 1)

    End Sub

#End Region

    Private Function CheckPellets()

        CheckPellets = False

        For y = 1 To 36
            For x = 1 To 28

                If pellets(x, y) = True Then

                    Return False

                End If

            Next
        Next

        Return True

    End Function

    Private Sub GameOverProcedure()

        Thread.Sleep(1000)

        FancyClear()

        Module1.EnterScore(score)

    End Sub

    Private Sub FancyClear()

        For y = 0 To 37
            For x = 0 To 55
                Console.BackgroundColor = backgroundColour
                Console.SetCursorPosition(x, y)
                Console.Write(" ")
                Thread.Sleep(1)
            Next
        Next

    End Sub

End Class