Imports System

Module Module1
    Sub Main()

        Dim i As Integer = 0

        Try
            Dim y As Integer = 1200 / i
        Catch ex As ArithmeticException
            Console.WriteLine("Arithmetic Exception occurred")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()

    End Sub
End Module






Imports System.Threading

Module Module1
    Public rnd As New Random

    Sub Main()
        Dim t1 As New Thread(AddressOf Foo)
        Dim t2 As New Thread(AddressOf Foo)
        Dim t3 As New Thread(AddressOf Foo)

        t1.Start("Enjoy")
        t2.Start("programming hub ")
        t3.Start("Code")

        t1.Join()
        t2.Join()
        t3.Join()
    End Sub

    Sub Foo(ByVal state As Object)
        Thread.Sleep(rnd.Next(1000))
        Console.WriteLine(state)
        Console.ReadKey()
    End Sub

End Module
