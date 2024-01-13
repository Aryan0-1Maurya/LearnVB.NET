Module Module1    Sub Main()
        'using 2D-ARRAYS        Dim RowSize As Integer = 5, ColSize As Integer = 5
        'declaring 2-d arrays below        Dim Matrix1 As Integer(,) = New Integer(RowSize - 1, ColSize - 1) {}        Dim Matrix2 As Integer(,) = New Integer(RowSize - 1, ColSize - 1) {}        Dim ResultMatrix As Integer(,) = New Integer(RowSize - 1, ColSize - 1) {}        Dim i As Integer, j As Integer
        Try            Console.WriteLine("PROGRAM To PRINT ADDITION OF TWO MATRICES ")            Console.WriteLine(vbLf & " Enter the Size of a Matrix N*N form : ")            Dim s As String = Console.ReadLine()            Dim values As String() = s.Split("*"c)            RowSize = Integer.Parse(values(0))            ColSize = Integer.Parse(values(1))
            If RowSize > 5 OrElse ColSize > 5 Then                'limiting the size of matrix                Console.BackgroundColor = ConsoleColor.DarkRed                'changing background color to red                Console.WriteLine(" The Size Of Matrix should Be in Less Than 5 (limiting size of array)")                Console.WriteLine(vbLf & vbLf & vbTab & " Press Enter key to exit....")                Console.ReadKey()                Return            Else

                'Initializing all the elements to zero                For i = 0 To RowSize - 1                    For j = 0 To ColSize - 1Matrix1(i, j) = 0                        Matrix2(i, j) = 0                    Next                Next                'Reading elements of Matrix1                Console.WriteLine(vbLf & " Enter the elements of Matrix1({0}*{1})", RowSize, ColSize)                For i = 0 To RowSize - 1                    For j = 0 To ColSize - 1                        Console.Write(" Matrix1[{0},{1}] : ", i, j)                        Matrix1(i, j) = Convert.ToInt32(Console.ReadLine())                    Next                Next                'Reading elements of Matrix2                Console.WriteLine(vbLf & " Enter the elements of Matrix2({0}*{1})", RowSize, ColSize)                For i = 0 To RowSize - 1                    For j = 0 To ColSize - 1                        Console.Write(" Matrix2[{0},{1}] : ", i, j)                        Matrix2(i, j) = Convert.ToInt32(Console.ReadLine())                    Next                Next
                'calculating ResultMatrix, by adding Matrix1 and Matrix2                For i = 0 To RowSize - 1                    For j = 0 To ColSize - 1                        ResultMatrix(i, j) = Matrix1(i, j) + Matrix2(i, j)                    Next                Next
                'Printing Result Matrix                Console.Write(vbLf & vbLf & vbTab & "Resultant Matrix" & vbLf & vbLf & vbTab)                For i = 0 To RowSize - 1
                    For j = 0 To ColSize - 1                        If ResultMatrix(i, j) = Matrix1(i, j) + Matrix2(i, j)                    Next                Next
                'Printing Result Matrix                Console.Write(vbLf & vbLf & vbTab & "Resultant Matrix" & vbLf & vbLf & vbTab)                For i = 0 To RowSize - 1
                    For j = 0 To ColSize - 1                        If ResultMatrix(i, j) < 10 Then                            'Making number as 01,02,etc,.                             Console.Write(" 0" & Convert.ToString(ResultMatrix(i, j)))                        Else                            Console.Write(" " & Convert.ToString(ResultMatrix(i, j)))                        End If
                        If j = ColSize - 1 Then                            Console.Write(vbLf & vbTab)
                        End If                    Next                Next            End If        Catch            'to catch exceptions,suppose string entered as a RowSize or Colsize of matrix            Console.BackgroundColor = ConsoleColor.DarkRed            Console.WriteLine("WARNING:only Number are allowed, Enter Correct Input example 3*3 or 4*4")            Console.ResetColor()        End Try
        Console.WriteLine(vbLf & vbLf & vbTab & " Press Enter key to exit....")        Console.ReadLine()
    End SubEnd Module



Imports System
Module Module1    Sub Main()
        Console.WriteLine("Math library function")        Console.WriteLine("Value for PI is " & Math.PI)        Console.WriteLine("Absolute value of -1 is " & Math.Abs(-231))        Console.WriteLine("50 raised to the power of 2 is " & Math.Pow(50, 2))
        Console.Read()
    End SubEnd Module


Imports System.Linq
Module Module1    Sub Main()
        'Magic squares of odd order        Const n = 9        Dim i, j, v As Integer
        Console.WriteLine("The square order is : " & n)
        For i = 1 To n            For j = 1 To n                v = ((i * 2 - j + n - 1) Mod n) * n + ((i * 2 + j - 2) Mod n) + 1                Console.Write(" " & Right(Space(5) & v, 5))            Next j            Console.WriteLine("")        Next i
        'print magicsquare        Console.WriteLine("The magic number is : " & n * (n * n + 1) \ 2)
        Console.ReadKey()
    End SubEnd Module





Imports System.LinqModule Module1
    'function declaration    Function ValidLuhn(value As String)        Return value.Select(Function(c, i) (AscW(c) - 48) << ((value.Length - i - 1) And 1)).Sum(Function(n) If(n > 9, n - 9, n)) Mod 10 = 0    End Function
    'main declaration    Sub Main()        'check its valid number or not         Console.WriteLine(ValidLuhn("49927398716"))        Console.WriteLine(ValidLuhn("49927398717"))        Console.WriteLine(ValidLuhn("1234567812345678"))        Console.WriteLine(ValidLuhn("1234567812345670"))        Console.ReadKey()    End Sub
End Module




Module Module1    Sub Main()
        Dim ts = From a In Enumerable.Range(1, 20)                 From b In Enumerable.Range(a, 21 - a)                 From c In Enumerable.Range(b, 21 - b)                 Where a * a + b * b = c * c                 Select New With {a, b, c}
        For Each t In ts            System.Console.WriteLine("{0}, {1}, {2}", t.a, t.b, t.c)        Next
        Console.ReadKey()
    End SubEnd Module



Module Module1
    Function GCD(a As Integer, b As Integer) As Integer
        If a = 0 Then            Return b        End If
        While b <> 0            If a > b Then                a -= b            Else                b -= a            End If        End While
        Return a    End Function
    Function LCM(a As Integer, b As Integer) As Integer        Return (a * b) \ GCD(a, b)    End Function
    Sub Main()        Console.Write("LCM is : ")        Console.Write(LCM(12, 11))        Console.Read()    End Sub
End Module


Module Module1
    Sub Main()        Dim n As Integer = 1        Dim found As Integer = 0
        Do Until found = 10            If IsHappy(n) Then                found += 1                Console.WriteLine("{0}: {1}", found, n)            End If            n += 1        Loop
        Console.ReadLine()    End Sub
    Private Function IsHappy(ByVal n As Integer)        Dim cache As New List(Of Long)()
        Do Until n = 1            cache.Add(n)            n = Aggregate c In n.ToString()                Into Total = Sum(Int32.Parse(c) ^ 2)            If cache.Contains(n) Then Return False        Loop
        Return True    End Function
End Module




Module Module1
    Sub Main()        ' Checking sequence of 27.
        Dim l As List(Of Long) = HailstoneSequence(27)        Console.WriteLine("27 has {0} elements in sequence : ", l.Count())
        For i As Integer = 0 To 3 : Console.Write("{0}, ", l(i)) : Next        Console.Write("... ")        For i As Integer = l.Count - 4 To l.Count - 1 : Console.Write(", {0}", l(i)) : Next
        Console.WriteLine()
        ' Finding longest sequence for numbers below 100000.
        Dim max As Integer = 0        Dim maxCount As Integer = 0
        For i = 1 To 99999            l = HailstoneSequence(i)            If l.Count > maxCount Then                max = i                maxCount = l.Count            End If        Next        Console.WriteLine("Max elements in sequence for number below 100k: {0} with {1} elements.", max, maxCount)        Console.ReadLine()    End Sub
    Private Function HailstoneSequence(ByVal n As Long) As List(Of Long)        Dim valList As New List(Of Long)()        valList.Add(n)
        Do Until n = 1            n = IIf(n Mod 2 = 0, n / 2, (3 * n) + 1)            valList.Add(n)        Loop
        Return valList    End Function
End Module



Imports System
Module Module1
    Sub Main()        Dim lNum As New List(Of Integer)(New Integer() {90, 47, 58, 29, 22, 32, 55, 5, 55, 73})        For i As UInteger = 0 To 9            Console.WriteLine(String.Join(" ", (From n In Difference(i, lNum) Select String.Format("{0,5}", n)).ToArray()))        Next        Console.ReadKey()    End Sub
    Private Function Difference(ByVal Level As UInteger, ByVal Numbers As List(Of Integer)) As List(Of Integer)        If Level >= Numbers.Count Then Throw New ArgumentOutOfRangeException("Level", "Level must be less than number of items in Numbers")
        For i As Integer = 1 To Level            Numbers = (From n In Enumerable.Range(0, Numbers.Count - 1)                       Select Numbers(n + 1) - Numbers(n)).ToList()        Next
        Return Numbers    End Function
End Module


Module CountingInFactors    Sub Main()
        For i As Integer = 1 To 10            Console.WriteLine("{0} = {1}", i, CountingInFactors(i))        Next
        For i As Integer = 9991 To 10000            Console.WriteLine("{0} = {1}", i, CountingInFactors(i))        Next    End Sub
    Private Function CountingInFactors(ByVal n As Integer) As String        If n = 1 Then Return "1"
        Dim sb As New Text.StringBuilder()
        CheckFactor(2, n, sb)        If n = 1 Then Return sb.ToString()
        CheckFactor(3, n, sb)        If n = 1 Then Return sb.ToString()
        For i As Integer = 5 To n Step 2            If i Mod 3 = 0 Then Continue For
            CheckFactor(i, n, sb)            If n = 1 Then Exit For        Next
        Return sb.ToString()    End Function
    Private Sub CheckFactor(ByVal mult As Integer, ByRef n As Integer, ByRef sb As Text.StringBuilder)        Do While n Mod mult = 0            If sb.Length > 0 Then sb.Append(" x ")            sb.Append(mult)            n = n / mult        Loop    End Sub
End Module



Imports System
Module Module1    Sub Main()
        Dim base As Integer = 2        Dim power As Integer = 5
        Console.WriteLine("{0} to the {1}th power is {2}",          base, power, base ^ power)
        Console.Read()
    End SubEnd Module




Module Module1    Sub Main()
        Dim n, r, sum, t As Integer
        Console.WriteLine("Enter a number : ")        n = CInt(Console.ReadLine())        sum = 0        t = n
        While n <> 0            r = n Mod 10            sum += Math.Pow(r, 3)            n = n \ 10
        End While
        If sum = t Then            Console.WriteLine(t.ToString + " is a Armstrong Number")        Else            Console.WriteLine(t.ToString + " is not an Armstrong Number")        End If
        Console.ReadLine()
    End SubEnd Module


Imports System.Collections.GenericImports System.LinqImports System.Text
Module Module1    Sub Main()
        Dim matrix1 As Integer(,), matrix2 As Integer(,)        Dim row1 As Integer, col1 As Integer, row2 As Integer, col2 As Integer, i As Integer, j As Integer, k As Integer, temp As Integer = 0
        Console.WriteLine("Please insert no. of rows in matrix 1 : ")        row1 = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Please insert no. of columns in matrix 1 : ")        col1 = Integer.Parse(Console.ReadLine())        matrix1 = New Integer(row1 - 1, col1 - 1) {}
        Console.WriteLine("Please insert no. of rows in matrix 2 : ")        row2 = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Please insert no. of columns in matrix 2 : ")        col2 = Integer.Parse(Console.ReadLine())        matrix2 = New Integer(row2 - 1, col2 - 1) {}
        If col1 <> row2 Then            Console.WriteLine("Multiplication is not applicable")            Console.WriteLine("Number of columns of matrix1 must be equal to Number of rows of matrix2.")        Else            Console.WriteLine("Please Input the values for matrix 1")            For i = 0 To row1 - 1                For j = 0 To col1 - 1                    matrix1(i, j) = Integer.Parse(Console.ReadLine())                Next            Next            Console.WriteLine("Please Input the values for matrix 2")            For i = 0 To row2 - 1                For j = 0 To col- 1                    matrix2(i, j) = Integer.Parse(Console.ReadLine())                Next            Next            Console.Clear()            Console.WriteLine("Entered Input : ")            Console.WriteLine("Matrix 1 : ")            For i = 0 To row1 - 1                For j = 0 To col1 - 1                    Console.Write(matrix1(i, j))                    Console.Write(" ")                Next                Console.WriteLine()            Next            Console.WriteLine("Matrix 2 : ")            For i = 0 To row2 - 1                For j = 0 To col2 - 1                    Console.Write(matrix2(i, j))                    Console.Write(" ")                Next                Console.WriteLine()            Next            Console.WriteLine("Product of Matrix 1 & Matrix 2 is : ")            For i = 0 To row1 - 1                For j = 0 To col2 - 1                    For k = 0 To row2 - 1                        temp = temp + (matrix1(i, k) * matrix2(k, j))                    Next                    Console.Write(temp & " ")                    temp = 0                Next                Console.WriteLine()            Next        End If
        Console.Read()
    End SubEnd Module


Imports System
Module Module1
    Function sumsq(ByVal i As ICollection(Of Integer)) As Integer        If i Is Nothing OrElse i.Count = 0 Then            Return 0        End If        Return i.[Select](Function(x) x * x).Sum()    End Function
    Sub Main()        Dim a As Integer() = New Integer() {1, 2, 3, 4, 5}        Console.Write("Sum of square is : ")        Console.Write(sumsq(a))        Console.WriteLine()        For K As Integer = 0 To 16            Console.WriteLine("SumOfSquares({0}) = {1}", K, SumOfSquares(K))        Next        Console.ReadKey()    End Sub
    Function SumOfSquares(ByVal Max As Integer)        Dim Square As Integer = 0        Dim Add As Integer = 1        Dim Sum As Integer = 0        For J As Integer = 0 To Max - 1            Square += Add            Add += 2            Sum += Square        Next        Return Sum    End Function
    Function SumOfSquaresByMult(ByVal Max As Integer)        Dim Sum As Integer = 0        For J As Integer = 1 To Max            Sum += J * J        Next        Return Sum    End Function
End Module




Module Module1    Sub Main()
        Dim n, sum, r As Integer
        Console.WriteLine("Enter a Number : ")        n = CInt(Console.ReadLine())
        sum = 0
        While n <> 0            r = n Mod 10            sum += r            n \= 10        End While
        Console.WriteLine("Sum of Digits : " + sum.ToString())        Console.ReadLine()
    End SubEnd Module


Module Module1    Sub Main()
        Dim n As Integer, k As Integer, limit As Integer        Console.WriteLine("The Sieve of Eratosthenes is a simple algorithm that finds the prime numbers up to a given integer.")        Console.WriteLine()
        Console.WriteLine("Enter Range : ")        limit = Console.ReadLine        Dim flags(limit) As Integer
        For n = 2 To Math.Sqrt(limit)            If flags(n) = 0 Then                For k = n * n To limit Step n                    flags(k) = 1                Next k            End If        Next n
        ' Display the primes        For n = 2 To limit            If flags(n) = 0 Then                Console.WriteLine(n)            End If        Next n
        Console.Read()
    End SubEnd Module

Module Module1    Sub Main()
        Dim n, r As Integer
        Console.WriteLine("Enter an number : ")        n = CInt(Console.ReadLine())
        Console.WriteLine("Reverse number of entered number is : ")
        While n <> 0            r = n Mod 10            Console.Write(r)            n \= 10        End While
        Console.ReadKey()
    End SubEnd Module



Module Module1    Sub Main()
        Dim n, r, sum, t As Integer
        Console.WriteLine("Enter a Number : ")        n = CInt(Console.ReadLine())        sum = 0        t = n
        While n <> 0            r = n Mod 10            sum = sum * 10 + r            n = n \ 10        End While
        If sum = t Then            Console.WriteLine(t.ToString() + " is a Palindrome Number")        Else            Console.WriteLine(t.ToString() + " is not a Palindrome Number")        End If
        Console.Read()
    End SubEnd Module


Module Module1
    Sub Main()        Dim i As Integer        Console.WriteLine("Enter a number : ")        i = Console.ReadLine()        Console.WriteLine(words(i))        Console.ReadKey()    End Sub
    'function declaration    Function words(ByVal Number As Integer) As String        Dim small() As String = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight",         "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",         "eighteen", "nineteen"}        Dim tens() As String = {"", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"}        Select Case Number            Case Is < 20                words = small(Number)            Case 20 To 99                words = tens(Number \ 10) + " " + small(Number Mod 10)            Case 100 To 999                words = small(Number \ 100) + " hundred " + IIf(((Number Mod 100) <> 0), "and ", "") + words(Number Mod 100)            Case 1000                words = "one thousand"        End Select    End Function
End Module