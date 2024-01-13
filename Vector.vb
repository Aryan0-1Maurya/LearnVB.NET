Module Module1
    Private Delegate Function Justification(s As String, width As Integer) As String
 
    Private Function AlignColumns(lines As String(), justification As Justification) As String()
        Const Separator As Char = "$"c
        ' build input container table and calculate columns count
        Dim containerTbl As String()() = New String(lines.Length - 1)() {}
        Dim columns As Integer = 0
        For i As Integer = 0 To lines.Length - 1
            Dim row As String() = lines(i).TrimEnd(Separator).Split(Separator)
            If columns < row.Length Then
                columns = row.Length
            End If
            containerTbl(i) = row
        Next
        ' create formatted container table
        Dim formattedTable As String()() = New String(containerTbl.Length - 1)() {}
        For i As Integer = 0 To formattedTable.Length - 1
            formattedTable(i) = New String(columns - 1) {}
        Next
        For j As Integer = 0 To columns - 1
            ' get max column width
            Dim columnWidth As Integer = 0
            For i As Integer = 0 To containerTbl.Length - 1
                If j < containerTbl(i).Length AndAlso columnWidth < containerTbl(i)(j).Length Then
                    columnWidth = containerTbl(i)(j).Length
                End If
            Next
            ' justify column cells
            For i As Integer = 0 To formattedTable.Length - 1
                If j < containerTbl(i).Length Then
                    formattPublic Class Vector3D
    Private _x, _y, _z As Double

    Public Sub New(ByVal X As Double, ByVal Y As Double, ByVal Z As Double)

        _x = X
        _y = Y
        _z = Z

    End Sub

    Public Property X() As Double

        Get
            Return _x
        End Get

        Set(ByVal value As Double)
            _x = value
        End Set

    End Property

    Public Property Y() As Double

        Get
            Return _y
        End Get

        Set(ByVal value As Double)
            _y = value
        End Set

    End Property

    Public Property Z() As Double

        Get
            Return _z
        End Get

        Set(ByVal value As Double)
            _z = value
        End Set

    End Property

    Public Function Dot(ByVal v2 As Vector3D) As Double
        Return (X * v2.X) + (Y * v2.Y) + (Z * v2.Z)
    End Function

    Public Function Cross(ByVal v2 As Vector3D) As Vector3D

        Return New Vector3D((Y * v2.Z) - (Z * v2.Y),
                            (Z * v2.X) - (X * v2.Z),
                            (X * v2.Y) - (Y * v2.X))
End Function

    Public Function ScalarTriple(ByVal v2 As Vector3D, ByVal v3 As Vector3D) As Double
        Return Me.Dot(v2.Cross(v3))
    End Function

    Public Function VectorTriple(ByRef v2 As Vector3D, ByVal v3 As Vector3D) As Vector3D
        Return Me.Cross(v2.Cross(v3))
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("({0}, {1}, {2})", _x, _y, _z)
    End Function

End Class

Module Module1
    Sub Main()

        Dim v1 As New Vector3D(3, 4, 5)
        Dim v2 As New Vector3D(4, 3, 5)
        Dim v3 As New Vector3D(-5, -12, -13)

        Console.WriteLine("v1: {0}", v1.ToString())
        Console.WriteLine("v2: {0}", v2.ToString())
        Console.WriteLine("v3: {0}", v3.ToString())
        Console.WriteLine()

        Console.WriteLine("v1 . v2 = {0}", v1.Dot(v2))
        Console.WriteLine("v1 x v2 = {0}", v1.Cross(v2).ToString())
        Console.WriteLine("v1 . (v2 x v3) = {0}", v1.ScalarTriple(v2, v3))
        Console.WriteLine("v1 x (v2 x v3) = {0}", v1.VectorTriple(v2, v3))
        Console.ReadKey()

    End Sub
End Module