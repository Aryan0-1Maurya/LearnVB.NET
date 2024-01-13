Module Module1    Private Delegate Function Justification(s As String, width As Integer) As String     Private Function AlignColumns(lines As String(), justification As Justification) As String()        Const Separator As Char = "$"c        ' build input container table and calculate columns count        Dim containerTbl As String()() = New String(lines.Length - 1)() {}        Dim columns As Integer = 0        For i As Integer = 0 To lines.Length - 1            Dim row As String() = lines(i).TrimEnd(Separator).Split(Separator)            If columns < row.Length Then                columns = row.Length            End If            containerTbl(i) = row        Next        ' create formatted container table        Dim formattedTable As String()() = New String(containerTbl.Length - 1)() {}        For i As Integer = 0 To formattedTable.Length - 1            formattedTable(i) = New String(columns - 1) {}        Next        For j As Integer = 0 To columns - 1            ' get max column width            Dim columnWidth As Integer = 0            For i As Integer = 0 To containerTbl.Length - 1                If j < containerTbl(i).Length AndAlso columnWidth < containerTbl(i)(j).Length Then                    columnWidth = containerTbl(i)(j).Length                End If            Next            ' justify column cells            For i As Integer = 0 To formattedTable.Length - 1
If j < containerTbl(i).Length Then                    formattedTable(i)(j) = justification(containerTbl(i)(j), columnWidth)                Else                    formattedTable(i)(j) = New [String](" "c, columnWidth)                End If            Next        Next        ' create result        Dim result As String() = New String(formattedTable.Length - 1) {}        For i As Integer = 0 To result.Length - 1            result(i) = [String].Join(" ", formattedTable(i))        Next        Return result    End Function     Private Function JustifyLeft(s As String, width As Integer) As String        Return s.PadRight(width)    End Function    Private Function JustifyRight(s As String, width As Integer) As String        Return s.PadLeft(width)    End Function    Private Function JustifyCenter(s As String, width As Integer) As String        Return s.PadLeft((width + s.Length) / 2).PadRight(width)    End Function     Sub Main()        Dim input As String() = {"Given$a$text$file$of$many$lines,$where$fields$within$a$line$", "are$delineated$by$a$single$'dollar'$character,$write$a$program", "that$aligns$each$column$of$fields$by$ensuring$that$words$in$each$", "column$are$separated$by$at$least$one$space.", "Further,$allow$for$each$word$in$a$column$to$be$either$left$", "justified,$right$justified,$or$center$justified$within$its$column."}         For Each line As String In AlignColumns(input, AddressOf JustifyLeft)            Console.WriteLine(line)        Next        Console.ReadLine()    End Sub End Module


Module Module1    Sub Main()
        Dim a As String = "Test String"
        ' New string        Dim b As String = "Nothing"
        Console.WriteLine("Before performing a copy operation value of variable b is : " + b)        b = String.Copy(a)
        Console.WriteLine("After performing a copy operation value of variable b is : " + b)
        Console.ReadKey()
    End SubEnd Module



Module Module1    Sub Main()        Dim Value As String = "+123"
        If IsNumeric(Value) Then            Console.WriteLine("It is numeric string")        Else            Console.WriteLine("It is not numeric string")        End If
        Console.ReadKey()
    End SubEnd Module




Imports System.Net
Module Module1    Sub Main()
        Dim s As String = "123"        Console.WriteLine("Before string is : "&s)        s = CStr(CInt("123") + 1)        Console.WriteLine("Now string is : "&s)
        Console.Read()
    End SubEnd Module




Module Module1
    Sub Main()        Console.Write("Levenshtein distance is : ")        Console.Write(LevenshteinDistance("kitten", "sitting"))        Console.ReadKey()    End Sub
    Function LevenshteinDistance(ByVal String1 As String, ByVal String2 As String) As Integer        Dim Matrix(String1.Length, String2.Length) As Integer        Dim Key As Integer        For Key = 0 To String1.Length            Matrix(Key, 0) = Key        Next        For Key = 0 To String2.Length            Matrix(0, Key) = Key        Next        For Key1 As Integer = 1 To String2.Length            For Key2 As Integer = 1 To String1.Length                If String1(Key2 - 1) = String2(Key1 - 1) Then                    Matrix(Key2, Key1) = Matrix(Key2 - 1, Key1 - 1)                Else                    Matrix(Key2, Key1) = Math.Min(Matrix(Key2 - 1, Key1) + 1, Math.Min(Matrix(Key2, Key1 - 1) + 1, Matrix(Key2 - 1, Key1 - 1) + 1))                End If            Next        Next        Return Matrix(String1.Length - 1, String2.Length - 1)    End Function
End Module

Module Module1    Sub Main()
        Dim s As String = "Tom said, ""The fox ran away."""        Console.Write(s)
        Console.ReadKey()
    End SubEnd Module


Imports System.Text
Module Module1
    Sub Main()        'call method        Console.WriteLine("Reverse string is : " + Reverse("Bhagyashree"))        Console.ReadKey()    End Sub
    'method call declaration    Function Reverse(ByVal s As String) As String        Dim t() As Char = s.ToCharArray        Array.Reverse(t)        Return New String(t)    End Function
End Module




Module Module1    Sub Main()        Console.WriteLine(rot13("how are you?"))        Console.ReadKey()    End Sub
    Private Function rot13(ByVal str As String) As String        Dim newChars As Char(), i, j As Integer, original, replacement As String
        original = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"        replacement = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm"
        newChars = str.ToCharArray()
        For i = 0 To newChars.Length - 1            For j = 0 To 51                If newChars(i) = original(j) Then                    newChars(i) = replacement(j)                    Exit For                End If            Next        Next
        Return New String(newChars)    End Function
End Module



Imports System
Module Module1    Sub Main()
        ' Define string        Dim s As String = "Hello"
        '& to String concatenation        Console.WriteLine(s & " literal")
        '+ operator to String concatenation        Dim s1 As String = s + " world"        Console.WriteLine(s1)
        Console.ReadKey()
    End SubEnd Module




Imports System
Module Module1    Sub Main()
        ' Define string        Dim s As String = "HeLlo"
        ' Change 's' to Upper Case.        s = s.ToUpper()        Console.WriteLine("After converting string in uppercase : " + s)
        ' Change 's' to Lower Case.        s = s.ToLower()        Console.WriteLine("After converting string in lowercase : " + s)
        Console.ReadKey()
    End SubEnd Module