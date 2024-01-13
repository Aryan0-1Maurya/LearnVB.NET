Module Module1    Sub Main()
        For x As Integer = 0 To 4            For y As Integer = 0 To x                Console.Write("*")            Next            Console.WriteLine()        Next        Console.ReadKey()
    End SubEnd Module



Module Module1    Sub Main()
        Dim x = 1024
        'Do loop declaration        Do            Console.WriteLine(x)            x = x \ 2        Loop While x > 0        Console.ReadKey()
    End SubEnd Module



Module Module1    Sub Main()
        'for loop declaration        For i = 1 To 10            'print i value            Console.Write(i)            'define end condition            If i = 10 Then Exit For            Console.Write(", ")        Next        Console.ReadKey()
    End SubEnd Module



Module Module1    Sub Main()
        'declaration of list collection        Dim list As New List(Of String)        'adding elements into list        list.Add("Car")        list.Add("Boat")        list.Add("Train")
        Console.WriteLine("List elements : ")
        'retrive values from list        For Each item In list            'display list element            Console.WriteLine(item)        Next        Console.ReadKey()
    End SubEnd Module



Module Module1    Sub Main()                Dim i As Integer
        For i = 10 To 0 Step -1            Console.WriteLine(i)        Next        Console.ReadKey()
    End SubEnd Module



Module Module1    Sub Main()
        Dim i As Integer        i = 0
        Do            i += 1            Console.WriteLine(i)        Loop Until i Mod 6 = 0        Console.ReadKey()
    End SubEnd Module




Module Module1    Sub Main()                Dim i As Integer
        For i = 1 To 10            Console.Write(i)            If i Mod 5 = 0 Then                Console.WriteLine()            Else                Console.Write(", ")            End If        Next        Console.ReadKey()
    End SubEnd Module




Module Module1    Sub Main()
        For i As Integer = 0 To 10            Console.WriteLine(i)        Next        Console.ReadKey()
    End SubEnd Module