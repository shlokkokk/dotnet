Imports System

Module Program
    Sub Main()
        Console.Write("First number: ")
        Dim a = Convert.ToInt32(Console.ReadLine())
        Console.Write("Second number: ")
        Dim b = Convert.ToInt32(Console.ReadLine())

        If a > b Then
            Console.WriteLine($"{a} is greater")
        ElseIf b > a Then
            Console.WriteLine($"{b} is greater")
        Else
            Console.WriteLine("Both are equal")
        End If
    End Sub
End Module
