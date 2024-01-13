Imports System

Module Module1
    Sub Main()

        Console.WriteLine("After Using Round function")
        Console.WriteLine(System.Math.Round(1001.674))

        Console.Read()

    End Sub
End Module




Module Module1

    Function Recursive(ByVal value As Integer, ByRef count As Integer) As Integer

        Console.WriteLine("Recursive({0}, {1})", value, count)

        count = count + 1
        If value >= 250 Then
            Return value
        End If
        Return Recursive(value * 4, count)

    End Function

    Sub Main()

        Dim count As Integer = 0
        Dim total As Integer = Recursive(3, count)

        Console.WriteLine("Total = {0}", total)
        Console.WriteLine("Count = {0}", count)
        Console.Read()

    End Sub

End Module





Module ForwardDifference
 
    Sub Main()
        Dim returnedValue As Double = Multiply(4, 3)
        Console.WriteLine("Multiplication is : " & returnedValue)
    End Sub
    
    Function Multiply(ByVal a As Integer, ByVal b As Integer) As Integer
    Return a * b
    End Function

End Module