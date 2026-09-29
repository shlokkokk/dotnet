Imports System

Module Program
    Sub Main()
        Dim total As Integer = 0

        For i = 1 To 6
            Console.Write($"Marks {i}: ")
            total += Convert.ToInt32(Console.ReadLine())
        Next

        Console.WriteLine($"Total = {total}")
    End Sub
End Module
