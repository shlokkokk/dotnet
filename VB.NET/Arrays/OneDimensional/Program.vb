Imports System

Module Program
    Sub Main()
        Dim a(5) As Integer

        For i = 0 To a.Length - 1
            Console.Write($"a({i}) = ")
            a(i) = Convert.ToInt32(Console.ReadLine())
        Next

        Console.WriteLine("Array: " & String.Join(" ", a))
    End Sub
End Module
