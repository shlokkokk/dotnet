Imports System

Module Program
    Sub Main()
        Dim p As Boolean = True, q As Boolean = False
        Console.WriteLine($"True And False = {p And q}")
        Console.WriteLine($"True Or False = {p Or q}")
        Console.WriteLine($"True Xor False = {p Xor q}")

        Dim a As Integer = 5, b As Integer = 3
        Console.WriteLine($"5 And 3 = {a And b}")
        Console.WriteLine($"5 Or 3 = {a Or b}")
        Console.WriteLine($"5 Xor 3 = {a Xor b}")
    End Sub
End Module
