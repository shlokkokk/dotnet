Imports System

Module Program
    Sub Main()
        Console.Write("Length: ")
        Dim l As Double = Convert.ToDouble(Console.ReadLine())

        Console.Write("Width: ")
        Dim w As Double = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine($"Area = {l * w}")
        Console.WriteLine($"Perimeter = {2 * (l + w)}")
    End Sub
End Module
