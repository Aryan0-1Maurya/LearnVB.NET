Module ProgrammingHub

    Dim num1, num2, temp As Integer
    Sub Main()

        Console.WriteLine("Enter 1st number : ")
        num1 = Console.ReadLine()
        Console.WriteLine("Enter 2nd number : ")
        num2 = Console.ReadLine()

        Console.WriteLine("Values before swapping")
        Console.WriteLine("num1 = {0}", num1)
        Console.WriteLine("num2 = {0}", num2)

        temp = num1
        num1 = num2
        num2 = temp

        Console.WriteLine("Values after swapping")
        Console.WriteLine("num1 = {0}", num1)
        Console.WriteLine("num2 = {0}", num2)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module



Module Module1

    Sub Main()

        ' Calculate square root of number
        Dim root As Double = Math.Sqrt(36)

        Console.WriteLine("The square root of number is : {0}", root)
        
    End Sub
    
End Module




Module Module1

    Sub Main()
        Dim i As Integer ' counter

        Console.WriteLine("NUMBER" & vbTab & "SQUARE" & vbCrLf)

        ' square numbers from 1 to 5
        For i = 1 To 5
            Console.WriteLine(i & vbTab & Square(i))
        Next
        Console.Read()
    End Sub

    Function Square(ByVal y As Integer) As Integer
        Return y ^ 2

    End Function

End Module



Module ProgrammingHub

    Sub Main()
        Dim n, p, r, sum As Integer
        Console.WriteLine("Enter a number: ")
        n = Integer.Parse(Console.ReadLine())
        p = 1
        sum = 0
        While p <= n \ 2
            r = n Mod p
            If r = 0 Then
                sum += p
            End If
            p += 1
        End While
        If sum = n Then
            Console.WriteLine(n.ToString + " is a Perfect Number")
        Else
            Console.WriteLine(n.ToString + " is NOT a Perfect Number")
        End If
        Console.ReadLine()
    End Sub
End Module


Module ProgrammingHub

    Dim num1, num2, num3 As Double
    Sub Main()

        Console.WriteLine("Enter 1st number : ")
        num1 = Console.ReadLine()
        Console.WriteLine("Enter 2nd number : ")
        num2 = Console.ReadLine()
        Console.WriteLine("Enter 3rd number : ")
        num3 = Console.ReadLine()

        If (num1 >= num2 And num1 >= num3) Then
            Console.WriteLine("Largest number is {0}", num1)
        ElseIf (num2 >= num1 And num2 >= num3) Then
            Console.WriteLine("Largest number is {0}", num2)
        Else
            Console.WriteLine("Largest number is {0}", num3)
        End If

        'This line is to hold the output screen
        Console.Read()
    End Sub

End Module



Module ProgrammingHub

    Dim num As Integer
    Sub Main()

        Console.Write("Enter a Number : ")
        num = Console.ReadLine()

        If (num Mod 2 = 0) Then
            Console.WriteLine("{0} is even", num)
        Else
            Console.WriteLine("{0} is odd", num)
        End If

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module



Module ProgrammingHub

    
    Sub Main()
        Dim num As Integer = 0 
        Dim _pre As Integer = 1
        Dim _next As Integer = 0
        Dim temp As Integer = 0
        Dim i As Integer = 0
        Console.Write("Enter number upto which Fibonacci series to print: ")
        num = Integer.Parse(Console.ReadLine())

        While i < num
            Console.WriteLine(_next)
            temp = _pre
            _pre = _next
            _next = _pre + temp
            i = i + 1
        End While

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module




Module ProgrammingHub

    Dim factorial = 1, i, num As Integer
    Sub Main()

        Console.WriteLine("Enter a number to find a factorial of it : ")
        num = Console.ReadLine()

        factorial = 1
        For i = 1 To num
            factorial = factorial * i
        Next

        Console.WriteLine("Factorial of {0} is {1}", num, factorial)

        'This line is to hold the output screen
        Console.Read()

    End Sub

End Module



Module ProgrammingHub

        Sub Main()
        
            Console.WriteLine("Enter Number to check if it is an Armstrong Number")
            
            Dim numToCheck As Integer = Integer.Parse(Console.ReadLine())
            Dim lenthOfNum As Integer = numToCheck.ToString().Length
            Dim reminder As Double = 0
            Dim sum As Double = 0
            Dim tempNo As Integer = numToCheck
            
            While tempNo > 0
                reminder = tempNo Mod 10
                sum = sum + Math.Pow(reminder, lenthOfNum)
                tempNo = tempNo \ 10
            End While
            
            If sum = numToCheck Then
                Console.WriteLine("The given Number {0} is an Armstrong Number", numToCheck)
            Else
                Console.WriteLine("The given Number {0} is NOT an Armstrong Number", numToCheck)
            End If
            Console.ReadLine()
        End Sub

End Module
