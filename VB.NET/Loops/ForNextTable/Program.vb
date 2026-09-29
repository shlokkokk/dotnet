Imports System

Module Program
    Sub Main()
        Console.Write("Enter number: ")
        Dim n = Convert.ToInt32(Console.ReadLine())

        For i = 1 To 10
            Console.WriteLine($"{n} x {i} = {n * i}")
        Next
    End Sub
End Module
