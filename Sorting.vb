Imports System.Collections.Generic
Module BubbleSortProgram
    Sub Main()        'input array initialization that needs to be sorted        Dim arr() As Integer = {120, 23, 453, 123, 2446, 2324, 5, 77, 4646, 12}
        Dim temp,writ,i,bsort As Integer = 0
        For writ = 0 To arr.Length - 1            'outer loop iterates n times(n is the length of the array)            For bsort = 0 To arr.Length - 2                'inner loop will iterate n-1 times                If arr(bsort) > arr(bsort + 1) Then                    'logic: if the LHS value is greater than RHS then swap the value                    'swap logic                    temp = arr(bsort + 1)                    arr(bsort + 1) = arr(bsort)                    arr(bsort) = temp                End If            Next        Next
        'print the sorted array on console        For i = 0 To arr.Length - 1            Console.Write(arr(i))            Console.Write(" ")        Next
        'keeps the console open till any key is entered        Console.ReadKey()
    End Sub
End Module




Imports System.Collections.Generic
Module HeapSortProgram
    'static function-functions that are invoked without creating an object of the class    Public Sub HeapSort(input As Integer())        'an unordered array input of length heapSize        Dim heapSize As Integer = input.Length        For p As Integer = (heapSize - 1) / 2 To 0 Step -1            'Build the heap in array a input that largest value is at the root            MaxHeap(input, heapSize, p)        Next        ' (The following loop maintains the invariants that input[0:end] is a heap and every element        ' beyond end is greater than everything before it (so input[end:count] is in sorted order))        For i As Integer = input.Length - 1 To 1 Step -1            '(input[0] is the root and largest value. The swap moves it in front of the sorted elements.)            Dim temp As Integer = input(i)            input(i) = input(0)            input(0) = temp            '(the heap size is reduced by one)            heapSize -= 1            '(the swap ruined the heap property, so restore it)            MaxHeap(input, heapSize, 0)        Next    End Sub
    Private Sub MaxHeap(input As Integer(), heapSize As Integer, index As Integer)        print(input)        Dim left As Integer = (index + 1) * 2 - 1        Dim right As Integer = (index + 1) * 2        Dim largest As Integer = 0        '(The largest holds the largest element. Since we assume the heaps rooted at the ' children are valid, this means that we are done.)        If left < heapSize AndAlso input(left) > input(index) Then            largest = left        Else            largest = index        End If
        If right < heapSize AndAlso input(right) > input(largest) Then            largest = right        End If
        If largest <> index Then            Dim temp As Integer = input(index)            input(index) = input(largest)            input(largest) = temp            '(repeat to continue sifting down the child now)            MaxHeap(input, heapSize, largest)        End If
    End Sub
    'function to print the array    Public Sub print(arr As Integer())        For i As Integer = 0 To arr.Length - 1            Console.Write(arr(i))            Console.Write(" ")      Next        Console.WriteLine()    End Sub
    Sub Main()        'input array initialization that needs to be sorted        Dim arr As Integer() = {5, 7, 3, 4, 1}
        Console.WriteLine("Before Sorting")        print(arr)        Console.WriteLine("Sorting Process starts:")        'invokation of static function within the same class needs not object reference or class name        HeapSort(arr)        Console.WriteLine("Sorting Process ends:")        Console.WriteLine("After Sorting")        print(arr)        'keeps the console open till any key is entered        Console.ReadKey()
    End Sub
End Module



Module InsertionSortProgram
    'static function-functions that are invoked without creating an object of the class    Private Sub InsertionSort(input As Integer())        'The outer loop runs over all the elements except the first one          'because the single-element prefix input[0:1]        'is trivially sorted,so the invariant that the first i+1 entries are sorted is true         'from the start.         For i As Integer = 0 To input.Length - 2            'The inner loop moves element input[i] to its correct place             'so that after the loop,            'the first i+2 elements are sorted.            For j As Integer = i + 1 To 1 Step -1                If input(j - 1) > input(j) Then                    Dim temp As Integer = input(j - 1)                    input(j - 1) = input(j)                    input(j) = temp                End If            Next            print(input)        Next
    End Sub
    'function to print the array    Public Sub print(arr As Integer())        For i As Integer = 0 To arr.Length - 1            Console.Write(arr(i))            Console.Write(" ")
        Next        Console.WriteLine()    End Sub
    Sub Main()        'input array initialization that needs to be sorted        Dim arr As Integer() = {5, 7, 3, 4, 1}
        Console.WriteLine("Before Sorting")        print(arr)        Console.WriteLine("Sorting Process starts:")        'invokation of static function within the same class needs not obje'reference or class name        InsertionSort(arr)        Console.WriteLine("Sorting Process ends:")        Console.WriteLine("After Sorting")        print(arr)        'keeps the console open till any key is entered        Console.ReadKey()
    End Sub
End Module



Module Module1    Sub Main()
        'array of String()         Dim array As String() = New String() {"Maharashtra", "Rajsthan", "Panjab", "UP", "Karnataka"}
        ' Use the System.Array.Sort shared method.        System.Array.Sort(Of String)(array)
        Console.WriteLine("Array after sorting : ")
        ' Loop through the results.        Dim values As String
        For Each values In array            Console.WriteLine(values)        Next
        Console.Read()
    End SubEnd Module



Module Module1    Sub Main()
        'array of Integer()         Dim arr As Integer() = New Integer() {34, 51, 24, 65, 92}        Array.Sort(arr)
        Console.WriteLine("Array after sorting : ")
        ' Loop through the results.        Dim values As Integer        For Each values In arr            Console.WriteLine(values)        Next
        Console.Read()
    End SubEnd Module


Module ProgrammingHub
            Sub MergeSort(ByVal ar() As Integer,ByVal low As Integer, ByVal high As Integer)                print(ar)                If low >= high Then Return                         Dim length As Integer = high - low + 1                        Dim middle As Integer = Math.Floor((low + high) / 2)                        MergeSort(ar, low, middle)                        MergeSort(ar, middle + 1, high)                        Dim temp(ar.Length - 1) As Integer                        For i As Integer = 0 To length - 1                            temp(i) = ar(low + i)                        Next                        Dim m1 As Integer = 0                        Dim m2 As Integer = middle - low + 1                        For i As Integer = 0 To length - 1                If m2 <= high - low Then                If m1 <= middle - low Then                If temp(m1) > temp(m2) Then                                        ar(i + low) = temp(m2)                                        m2 += 1                                    Else                                        ar(i + low) = temp(m1)                                        m1 += 1                                    End If                                Else                                    ar(i + low) = temp(m2)                                    m2 += 1                                End If                            Else                                ar(i + low) = temp(m1)  m1 += 1                            End If                        Next                            End Sub
  'function to print the array  Public Sub print(arr As Integer())   For i As Integer = 0 To arr.Length - 1    Console.Write(arr(i).toString + " ")   Next   Console.WriteLine()  End Sub    Sub Main()   'input array initialization that needs to be sorted   Dim arr As Integer() = {5, 7, 3, 4, 1}
   Console.WriteLine("Before Sorting")   print(arr)   Console.WriteLine("Sorting Process starts:")   'invokation of static function within the same class needs not    'object reference or class name   MergeSort(arr, 0, arr.Length - 1)   Console.WriteLine("Sorting Process ends:")   Console.WriteLine("After Sorting")   print(arr)   'keeps the console open till any key is entered   Console.ReadKey()
  End Sub
End Module


Module ShellSortProgram
    Private Sub shellSort(input As Integer(), array_size As Integer)        Dim i As Integer, j As Integer, increment As Integer, temp As Integer        increment = 3        ' Start with the largest gap and work down to a gap of 1         While increment > 0            print(input)            For i = 0 To array_size - 1                j = i                temp = input(i)                ' shift earlier gap-sorted elements up until the correct location for input[i] is found                While (j >= increment) AndAlso (input(j - increment) > temp)                    input(j) = input(j - increment)                    j = j - increment                End While                'put temp (the original input[i]) in its correct location                input(j) = temp            Next            If increment / 2 <> 0 Then                increment = increment / 2            ElseIf increment = 1 Then                increment = 0            Else                increment = 1            End If        End While    End Sub
    'function to print the array    Public Sub print(arr As Integer())        For i As Integer = 0 To arr.Length - 1            Console.Write(arr(i))            Console.Write(" ")Next        Console.WriteLine()    End Sub
    Sub Main()        'input array initialization that needs to be sorted        Dim arr As Integer() = {5, 7, 3, 4, 1}
        Console.WriteLine("Before Sorting")        print(arr)        Console.WriteLine("Sorting Process starts:")        'invokation of static function within the same class needs not object reference or class name        shellSort(arr, arr.Length)        Console.WriteLine("Sorting Process ends:")        Console.WriteLine("After Sorting")        print(arr)        'keeps the console open till any key is entered        Console.ReadKey()    End Sub
End Module



Module QuickSortProgram
    Public Sub QuickSort(input As Integer(), left As Integer, right As Integer)        If left < right Then            Dim q As Integer = Partition(input, left, right)            QuickSort(input, left, q - 1)            QuickSort(input, q + 1, right)        End If    End Sub
    Private Function Partition(input As Integer(), left As Integer, right As Integer) As Integer        print(input)        ' put the chosen pivot at input[right]        Dim pivot As Integer = input(right)        Dim temp As Integer
        Dim i As Integer = left        ' Compare remaining array elements against pivot = input[right]        For j As Integer = left To right - 1            ' Move pivot to its final place            If input(j) <= pivot Then                temp = input(j)                input(j) = input(i)                input(i) = temp                i += 1            End If        Next
        input(right) = input(i)        input(i) = pivot
        Return i    End Function
    'function to print the array    Public Sub print(arr As Integer())        For i As Integer = 0 To arr.Length - 1            Console.Write(arr(i))            Console.Write(" ")Next        Console.WriteLine()    End Sub
    Sub Main()        'input array initialization that needs to be sorted        Dim arr As Integer() = {5, 7, 3, 4, 1}
        Console.WriteLine("Before Sorting")        print(arr)        Console.WriteLine("Sorting Process starts:")        'invokation of static function within the same class needs not object reference or class name        QuickSort(arr, 0, arr.Length - 1)        Console.WriteLine("Sorting Process ends:")        Console.WriteLine("After Sorting")        print(arr)        'keeps the console open till any key is entered        Console.ReadKey()    End Sub
End Module



Module SelectionSortProgram
    Public Sub selectionSort(arr As Integer())        'pos_min is short for position of min        Dim pos_min As Integer, temp As Integer
        For i As Integer = 0 To arr.Length - 2            print(arr)            pos_min = i            'set pos_min to the current index of array            For j As Integer = i + 1 To arr.Length - 1                If arr(j) < arr(pos_min) Then                    'pos_min will keep track of the index that min is in, this is needed when a swap happens                    pos_min = j                End If            Next
            'if pos_min no longer equals i than a smaller value must have been found, so a swap must occur            If pos_min <> i Then                temp = arr(i)                arr(i) = arr(pos_min)                arr(pos_min) = temp            End If        Next    End Sub'function to print the array    Public Sub print(arr As Integer())        For i As Integer = 0 To arr.Length - 1            Console.Write(arr(i))            Console.Write(" ")
        Next        Console.WriteLine()    End Sub
    Sub Main()        'input array initialization that needs to be sorted        Dim arr As Integer() = {5, 7, 3, 4, 1}
        Console.WriteLine("Before Sorting")        print(arr)        Console.WriteLine("Sorting Process starts:")        'invokation of static function within the same class needs not object reference or class name        selectionSort(arr)        Console.WriteLine("Sorting Process ends:")        Console.WriteLine("After Sorting")        print(arr)        'keeps the console open till any key is entered        Console.ReadKey()    End Sub
End Module