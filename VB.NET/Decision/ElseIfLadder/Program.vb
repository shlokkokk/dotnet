Imports System

Module Program
    Sub Main()
        Console.Write("Enter marks: ")
        Dim m = Convert.ToInt32(Console.ReadLine())

        If m >= 90 Then
            Console.WriteLine("Grade A")
        ElseIf m >= 75 Then
            Console.WriteLine("Grade B")
        ElseIf m >= 50 Then
            Console.WriteLine("Grade C")
        Else
            Console.WriteLine("Fail")
        End If
    End Sub
End Module
