Imports System

Module Program
    Sub Main()
        Console.Write("Enter name: ")
        Dim name = Console.ReadLine()

        Console.Write("Enter age: ")
        Dim age As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine($"Name = {name}")
        Console.WriteLine($"Age = {age}")
    End Sub
End Module
