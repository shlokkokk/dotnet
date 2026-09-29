Imports System

Module Program
    Sub Main()
        Dim a(,) As Integer = {{1, 2, 3}, {4, 5, 6}}

        For i = 0 To a.GetLength(0) - 1
            For j = 0 To a.GetLength(1) - 1
                Console.Write(a(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
