Imports SystemImports System.CollectionsImports Microsoft.VisualBasicPublic Class StackExample  
    Public Shared Sub Main()
        Dim objStack As New Stack()
        objStack.Push(120)        objStack.Push(13050)        objStack.Push(103050)
        Console.WriteLine("Stack operations")
        ' operation Pop.        Dim value As Integer = objStack.Pop()        Console.WriteLine("Element popped : {0}", value)
        ' operation Peek.        value = objStack.Peek()        Console.WriteLine("Element peeked : {0}", value)
        Console.Read()
    End SubEnd Class





Imports SystemImports System.CollectionsImports Microsoft.VisualBasic
Public Class StackExample    
    Public Shared Sub Main()
        ' Creates and initializes a new Stack.        Dim objStack As New Stack()        objStack.Push("Hello")        objStack.Push("Programming")        objStack.Push("Hub")                Dim numStack As New Stack()        numStack.Push(234)        numStack.Push(567)        numStack.Push(890)
        ' Displays the properties and values of the Stack.        Console.WriteLine("Text Stack")        Console.WriteLine(ControlChars.Tab & "Count: {0}", objStack.Count)        Console.Write(ControlChars.Tab & "Values:")        PrintVal(objStack)                Console.WriteLine("Number Stack")        Console.WriteLine(ControlChars.Tab & "Count: {0}", numStack.Count)        Console.Write(ControlChars.Tab & "Values:")        PrintVal(numStack)    End Sub
    Public Shared Sub PrintVal(myCollection As IEnumerable)        Dim obj As [Object]        For Each obj In myCollection            Console.Write(" {0}", obj)        Next obj        Console.WriteLine()    End Sub 
End Class



Imports SystemImports System.Collections
Public Class QueueExample
    Public Shared Sub Main()
        ' Creates and initializes a new Queue.        Dim objQ As New Queue()        objQ.Enqueue("Hello")        objQ.Enqueue("Programming")        objQ.Enqueue("Hub!")
        ' Displays the properties and values of the Queue.        Console.WriteLine("My Queue")        Console.WriteLine(" Count: {0}", objQ.Count)        Console.Write(" Values:")        PrintValues(objQ)
    End Sub 'Main
    Public Shared Sub PrintValues(myCollection As IEnumerable)        Dim obj As [Object]        For Each obj In myCollection            Console.Write(" {0}", obj)        Next obj        Console.WriteLine()    End Sub 'PrintValues
End Class



Imports System.CollectionsModule Module1    Sub Main()
        'Hashtable instance.        Dim table As Hashtable = New Hashtable        table("MAharashtra : ") = "Mumbai"        table("Rajsthan : ") = "Jaipur"        table("Panjaab : ") = "Chandigarh"        table("Karnataka : ") = "Bengaluru"
        Console.WriteLine("Hastable's key and Value are : ")
        ' Use For Each loop over the Hashtable.        For Each element As DictionaryEntry In table            Console.Write(element.Key)            Console.Write(element.Value)            Console.WriteLine()        Next
        Console.Read()
    End SubEnd Module

Imports System
Module Module1
    Enum fruits        apple = 0        banana = 1        cherry = 2    End Enum
    Sub Main()        Dim value As fruits = fruits.apple        Select Case value            Case fruits.banana                Console.WriteLine("It is false")                Return            Case fruits.apple                Console.WriteLine("It is True")                Exit Select        End Select        Console.ReadKey()    End Sub
End Module


Imports SystemImports System.Collections.Generic
Module Module1    Sub Main()
        Dim toys As New List(Of String)()        toys.Add("Car")        toys.Add("Boat")        toys.Add("Train")
        Console.WriteLine("Elements added into list")        Console.ReadKey()
    End SubEnd Module