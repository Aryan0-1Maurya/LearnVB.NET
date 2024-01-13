Imports System.IO
Imports System.Collections.ObjectModel
Imports System.Console

Module Module1
        Sub Main()

            Console.Write("Enter two numbers : ")
            Dim a As Integer = Integer.Parse(Console.ReadLine())
            Dim b As Integer = Integer.Parse(Console.ReadLine())

            WriteLine("Sum " & a + b)
            WriteLine("Difference " & a - b)
            WriteLine("Product " & a - b)
            WriteLine("Quotient " & a / b)
            WriteLine("Integer Quotient " & a \ b)
            WriteLine("Remainder " & a Mod b)
            WriteLine("Exponent " & a ^ b)

            Console.Read()

    End Sub
End Module





Imports System.IO
Imports System.Collections.ObjectModel
Imports System.Console
Imports System
Imports System.Collections.Generic

Module Module1
    Sub Main()

        Console.WriteLine("5 : " & Convert.ToString(5, 2))
        Console.WriteLine("50 : " & Convert.ToString(50, 2))
        Console.WriteLine("9000 : " & Convert.ToString(9000, 2))

        Console.ReadKey()

    End Sub
End Module