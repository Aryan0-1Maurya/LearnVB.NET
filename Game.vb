Imports System

Module Module1
    Sub Main()

        For i = 1 To 30
            If i Mod 15 = 0 Then
                Console.WriteLine("FizzBuzz")
            ElseIf i Mod 5 = 0 Then
                Console.WriteLine("Buzz")
            ElseIf i Mod 3 = 0 Then
                Console.WriteLine("Fizz")
            Else
                Console.WriteLine(i)
            End If
        Next
        Console.ReadKey()

    End Sub
End Module





Module Module1
    Sub MoveTowerDisks(ByVal disks As Integer, ByVal fromTower As Integer, ByVal toTower As Integer, ByVal viaTower As Integer)

        If disks > 0 Then
            MoveTowerDisks(disks - 1, fromTower, viaTower, toTower)
            System.Console.WriteLine("Move disk {0} from {1} to {2}", disks, fromTower, toTower)
            MoveTowerDisks(disks - 1, viaTower, toTower, fromTower)
        End If

    End Sub

    Sub Main()
        MoveTowerDisks(4, 1, 2, 3)
        Console.ReadKey()
    End Sub

End Module