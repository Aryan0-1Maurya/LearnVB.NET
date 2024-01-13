Module ProgrammingHub
    Dim area, radius As Double
    Sub Main()
        Console.WriteLine("Enter radius of circle : ")        radius = Console.ReadLine()
        area = 3.14 * radius * radius        Console.WriteLine("Area of Circle is {0}", area)
        'This line is to hold the output screen        Console.Read()
    End Sub
End Module


Module ProgrammingHub
    Dim area, circumference, radius As Double
    Sub Main()
        Console.WriteLine("Enter radius of circle : ")        radius = Convert.ToDouble(Console.ReadLine())
        area = 3.14 * radius * radius        Console.WriteLine("Area of Circle is {0}", area)
        circumference = 2 * 3.14 * radius        Console.WriteLine("Circumference of Circle is {0}", circumference)
        'This line is to hold the output screen        Console.Read()
    End Sub
End Module



Module Module1    Sub Main()
        Dim width As Double        Dim height As Double
        Console.WriteLine("Enter Rectangle height : ")        height = Double.Parse(Console.ReadLine())
        Console.WriteLine("Enter Rectangle width : ")        width = Double.Parse(Console.ReadLine())
        Console.Writeline("Rectangle area : ")        Console.WriteLine(height * width)
        Console.Read()
    End SubEnd Module


Module ProgrammingHub
    Dim area, base, height As Double
    Sub Main()
        Console.WriteLine("Enter base of Triangle : ")        base = Convert.ToDouble(Console.ReadLine())                Console.WriteLine("Enter height of Triangle : ")        height = Convert.ToDouble(Console.ReadLine())
        area = (1 / 2) * base * height        Console.WriteLine("Area of Triangle is {0}", area)
        'This line is to hold the output screen        Console.Read()
    End Sub
End Module



Module BoxingTheCompass    Dim _points(32) As String     Sub Main()        BuildPoints()         Dim heading As Double = 0D         For i As Integer = 0 To 32            heading = i * 11.25            Select Case i Mod 3                Case 1                    heading += 5.62                Case 2                    heading -= 5.62            End Select             Console.WriteLine("{0,2}: {1,-18} {2,6:F2}°", (i Mod 32) + 1, InitialUpper(GetPoint(heading)), heading)        Next    End Sub     Private Sub BuildPoints()        Dim cardinal As String() = New String() {"north", "east", "south", "west"}        Dim pointDesc As String() = New String() {"1", "1 by 2", "1-C", "C by 1", "C", "C by 2", "2-C", "2 by 1"}         Dim str1, str2, strC As String         For i As Integer = 0 To 3            str1 = cardinal(i)            str2 = cardinal((i + 1) Mod 4)            strC = IIf(str1 = "north" Or str1 = "south", str1 & str2, str2 & str1)            For j As Integer = 0 To 7                _points(i * 8 + j) = pointDesc(j).Replace("1", str1).Replace("2", str2).Replace("C", strC)            Next        Next    End Sub     Private Function InitialUpper(ByVal s As String) As String        Return s.Substring(0, 1).ToUpper() & s.Substring(1)    End Function     Private Function GetPoint(ByVal Degrees As Double) As String        Dim testD As Double = (Degrees / 11.25) + 0.5        Return _points(CInt(Math.Floor(testD Mod 32)))    End FunctionEnd Module



Module ProgrammingHub
    Dim hour, min, sec, totalSeconds As Integer
    Sub Main()
        Console.WriteLine("Enter time (h:m:s)")
        Console.WriteLine("Hours : ")        hour = Convert.ToInt32(Console.ReadLine())        Console.WriteLine("Minutes : ")        min = Convert.ToInt32(Console.ReadLine())        Console.WriteLine("Seconds : ")        sec = Convert.ToInt32(Console.ReadLine())
        totalSeconds = (hour * 60 * 60) + (min * 60) + sec
        Console.WriteLine("Time in seconds : {0} ", totalSeconds)
        'This line is to hold the output screen        Console.Read()
    End Sub
End Module



Module ProgrammingHub
    Dim num, square, cube As Integer
    Sub Main()
        Console.WriteLine("Enter a number : ")        num = Convert.ToInt32(Console.ReadLine())
        square = num * num        cube = num * num * num
        Console.WriteLine("Number you entered : {0}", num)        Console.WriteLine("Square of Number : {0}", square)        Console.WriteLine("Cube of Number : {0}", cube)
        'This line is to hold the output screen        Console.Read()
    End Sub
End Module



Module ProgrammingHub
    Dim seconds, hours, minutes, second As Integer
    Sub Main()
        Console.WriteLine("Enter time in seconds : ")        seconds = Console.ReadLine()
        second = seconds Mod 60        minutes = (seconds / 60) Mod 60        hours = (seconds / 60) / 60
        Console.WriteLine("{0} hours {1} minutes {2} seconds", hours, minutes, second)
        'This line is to hold the output screen        Console.Read()
    End Sub
End Module




Module ProgrammingHub
    Dim inches, feet, inche As Integer
    Sub Main()
        Console.WriteLine("Enter height in inches : ")        inches = Console.ReadLine()
        feet = inches / 12        inche = inches Mod 12
        Console.WriteLine("{0} foot and {1} inche", feet, inche)
        'This line is to hold the output screen        Console.Read()
    End Sub
End Module



Module ProgrammingHub
    Dim centigrade, fahrenheit As Double
    Sub Main()
        Console.WriteLine("Enter temperature in centigrade : ")        centigrade = Convert.ToDouble(Console.ReadLine())
        fahrenheit = 1.8 * centigrade + 32        Console.WriteLine("Fahrenheit : {0}", fahrenheit)
        'This line is to hold the output screen        Console.Read()
    End Sub
End Module



Imports SystemImports System.Text.RegularExpressions
Module Module1    Sub Main()
        'Prints a        Console.WriteLine(Chr(97))
        'Prints 97        Console.WriteLine(Asc("a"))
        Console.ReadKey()
    End SubEnd Module




Module ProgrammingHub
    Dim name As String    Dim amount, year, rate, compoundInterest As Double
    Sub Main()
        Console.WriteLine("Enter Principle amount : ")        amount = Console.ReadLine()
        Console.WriteLine("Enter Number of years : ")        year = Console.ReadLine()
        Console.WriteLine("Enter rate of interest : ")        rate = Console.ReadLine()
        compoundInterest = amount * (1 + rate / 100) ^ year        Console.WriteLine("Compound Interest : {0}", compoundInterest)
        'This line is to hold the output screen        Console.Read()
    End Sub
End Module