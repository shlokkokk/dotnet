Imports System

Module Program
    Sub Main()
        Dim result As Integer = Calculate(10, 20)
        Console.WriteLine($"Result = {result}")
    End Sub

    Function Calculate(a As Integer, b As Integer) As Integer
        Dim sum As Integer = a + b
        Return sum
    End Function
End Module
