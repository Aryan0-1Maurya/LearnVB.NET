Imports System.Net
Imports System.IO

Module Module1
    Sub Main()

        Dim charRemarks As New Dictionary(Of String, String)

        charRemarks.Add("April", "Bubbly: I'm > Tam and <= Emily")
        charRemarks.Add("Tam O'Shanter", "Burns: ""When chapman billies leave the street ...""")
        charRemarks.Add("Emily", "Short & shrift")

        Dim xml = <CharacterRemarks>
                      <%= From cr In charRemarks Select <Character name=<%= cr.Key %>><%= cr.Value %></Character> %>
                  </CharacterRemarks>

        Console.WriteLine(xml)
        Console.ReadKey()

    End Sub
End Module



Imports System.Net
Imports System.IO

Module Module1
    Sub Main()

        'write xml code
        Dim xml = <Students>
                      <Student Name="bhagyashree"/>
                      <Student Name="pratham"/>
                      <Student Name="shreya"/>
                      <Student Name="arvind"/>
                      <Student Name="ravneet"/>
                  </Students>

        Dim names = (From node In xml...<Student> Select node.@Name).ToArray
        Console.WriteLine("Extracted xml content is : ")

        'print xml content
        For Each name In names
            Console.WriteLine(name)
        Next
        Console.ReadKey()

    End Sub
End Module




Module Module1
   Sub Main()

        Dim bs, da, hr, gs As Integer

        Console.WriteLine("Enter Basic Salary : ")
        bs = CInt(Console.ReadLine())

        da = bs * 40 \ 100
        hr = bs * 20 \ 100
        gs = bs - (da + hr)

        Console.WriteLine("Gross Salary is : " + gs.ToString())
        Console.ReadLine()

    End Sub
End Module




Module Module1
    Sub Main()

        ' Start date
        Dim sdate As DateTime = New DateTime(2015, 2, 1, 3, 4, 12, 56)
        ' End date
        Dim eDate As DateTime = New DateTime(2016, 12, 12, 4, 30, 45, 12)
        ' Time Difference
        Dim diffDate As TimeSpan = eDate.Subtract(sDate)

        Console.WriteLine("Time Difference: ")
        Console.WriteLine(diffDate.Days.ToString() + " Days")
        Console.WriteLine(diffDate.Hours.ToString() + " Hours")
        Console.WriteLine(diffDate.Minutes.ToString() + " Minutes")
        Console.WriteLine(diffDate.Seconds.ToString() + " Seconds ")
        Console.WriteLine(diffDate.Milliseconds.ToString() + " Milliseconds ")
        Console.ReadKey()

    End Sub
End Module






Module Module1
    Sub main()

        Dim y As Integer

        Console.WriteLine("Enter a Year : ")
        y = CInt(Console.ReadLine())

        If y Mod 100 = 0 Then
            If y Mod 400 = 0 Then
                Console.WriteLine("The year is a Leap year")
            Else
                Console.WriteLine("The year is not a Leap year")
            End If
        Else
            If y Mod 4 = 0 Then
                Console.WriteLine("The year is a Leap year")
            Else
                Console.WriteLine("The year is not a Leap year")
            End If
        End If
        Console.ReadLine()

    End Sub
End Module

