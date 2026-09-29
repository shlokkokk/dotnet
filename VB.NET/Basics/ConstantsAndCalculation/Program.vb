Imports System

Module Program
    Sub Main()
        Console.Write("Enter radius: ")
        Dim r As Double = Convert.ToDouble(Console.ReadLine())
        Dim area = Math.PI * r * r

        Console.WriteLine($"Area = {area:F2}")
    End Sub
End Module
