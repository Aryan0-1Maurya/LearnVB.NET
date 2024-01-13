Module Module1
    Sub Main()

        Dim result As String, a As String = "pants", b As String = "glasses"

        Select Case a
            Case b
                result = "Match"
                Console.WriteLine(result)
            Case a
                result = "Hey"
                Console.WriteLine(result)
            Case Else
                result = "Impossible"
                Console.WriteLine(result)
        End Select

        Console.ReadKey()

    End Sub
End Module



Module Module1
    Sub Main()

        Console.WriteLine("Enter a and b value : ")

        Dim a As Integer = CInt(Console.ReadLine)
        Dim b As Integer = CInt(Console.ReadLine)

        'Using if statements
        If a < b Then Console.WriteLine("a is less than b")
        If a = b Then Console.WriteLine("a equals b")
        If a > b Then Console.WriteLine("a is greater than b")

        Console.ReadKey()

    End Sub
End Module





Module Module1
    Sub Main()

        Dim result As String, a As String = "pants", b As String = "glass"
        If a = b Then
            result = "Test passed"
            Console.WriteLine(result)
        ElseIf a <> b Then
            result = "Test failed"
            Console.WriteLine(result)
        Else
            result = "Test impossible"
            Console.WriteLine(result)
        End If

        Console.ReadKey()

    End Sub
End Module





Imports System.Threading

Module Module1
    Public rnd As New Random

    Sub Main()

        Dim result As String, a As String = "pants", b As String = "glasses"

        If a = b Then
            result = "Test passed"
            Console.WriteLine(result)
        Else
            result = "Test failed"
            Console.WriteLine(result)
        End If
        Console.ReadKey()

    End Sub

End Module
