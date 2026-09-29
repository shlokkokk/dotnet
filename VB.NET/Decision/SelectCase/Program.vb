Imports System

Module Program
    Sub Main()
        Console.Write("Enter day number (1-7): ")
        Dim d = Convert.ToInt32(Console.ReadLine())

        Select Case d
            Case 1 : Console.WriteLine("Monday")
            Case 2 : Console.WriteLine("Tuesday")
            Case 3 : Console.WriteLine("Wednesday")
            Case 4 : Console.WriteLine("Thursday")
            Case 5 : Console.WriteLine("Friday")
            Case 6 : Console.WriteLine("Saturday")
            Case 7 : Console.WriteLine("Sunday")
            Case Else : Console.WriteLine("Invalid day")
        End Select
    End Sub
End Module
