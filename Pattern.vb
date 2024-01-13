Module Module1
    Sub Main()

        Dim i, j, n As Integer

        Console.WriteLine("Enter the number of lines : ")
        n = CInt(Console.ReadLine())

        For i = 1 To n
            For j = 1 To n
                Console.Write(" * ")

            Next
            n -= 1
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub
End Module



Module Module1
   Sub Main()

        Dim i, j, n As Integer

        Console.WriteLine("Enter the number of lines : ")
        n = CInt(Console.ReadLine())

        For i = 1 To n
            For j = 1 To i
                Console.Write(i & " ")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub
End Module




Module Module1
    Sub Main()

        'variable declaration
        Dim i, j, n As Integer

        Console.WriteLine("Enter the number of lines : ")
        n = CInt(Console.ReadLine())

        'loop to display number pattern
        For i = 1 To n
            For j = 1 To i
                Console.Write(j & " ")
            Next
            'for next line
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub
End Module





Module Module1
    Sub main()

        Dim n, i, j, k As Integer

        Console.WriteLine("Enter number of lines : ")
        n = CInt(Console.ReadLine())

        For i = 1 To n
            For j = 2 To n
                Console.Write(" ")
            Next
            For k = 1 To 2 * i - 1
                Console.Write("*")
            Next

            Console.WriteLine()

            n -= 1
        Next

        Console.ReadLine()

    End Sub
End Module






Module Module1
    Sub Main()

        Dim i, j, s, n As Integer

        Console.WriteLine("Enter the number of lines : ")
        n = CInt(Console.ReadLine())
        s = 1

        For i = 1 To n
            For j = 1 To i
                Console.Write(s & " ")
                s += 1
            Next

            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub
End Module
