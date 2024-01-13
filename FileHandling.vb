Imports System.IO

Module Module1
    Sub Main()

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\test\text.txt", True)
        file.WriteLine("Here is the first string.")
        file.WriteLine("Hello all,good afternoon")
        file.Close()

        Console.WriteLine("content has been successfully written into file ......")
        Console.ReadKey()

    End Sub
End Module




Imports System.IO

Module Module1
    Sub Main()

        ' Store the line in this String.
        Dim line As String

        ' Create new StreamReader instance with Using block.
        Using reader As StreamReader = New StreamReader("C:\test\text.txt")
            ' Read one line from file
            line = reader.ReadLine
        End Using

        ' Write the line we read from "file.txt"
        Console.WriteLine(line)
        Console.ReadKey()

    End Sub
End Module




Imports System.IO

Module Module1
    Sub Main()

        ' Copy one file to a new location.
        File.Copy("C:\test\text.txt", "C:\test\test.txt", True)

        ' Display file contents.
        Console.WriteLine(File.ReadAllText("C:\test\text.txt"))
        Console.WriteLine(File.ReadAllText("C:\test\test.txt"))
        Console.ReadKey()

    End Sub
End Module