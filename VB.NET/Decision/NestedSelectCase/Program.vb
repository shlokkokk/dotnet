Imports System

Module Program
    Sub Main()
        Console.Write("Enter course (1=IT, 2=CE): ")
        Dim course = Convert.ToInt32(Console.ReadLine())
        Console.Write("Enter year (1/2): ")
        Dim year = Convert.ToInt32(Console.ReadLine())

        Select Case course
            Case 1
                Select Case year
                    Case 1 : Console.WriteLine("IT First Year")
                    Case 2 : Console.WriteLine("IT Second Year")
                    Case Else : Console.WriteLine("Invalid year")
                End Select
            Case 2
                Select Case year
                    Case 1 : Console.WriteLine("CE First Year")
                    Case 2 : Console.WriteLine("CE Second Year")
                    Case Else : Console.WriteLine("Invalid year")
                End Select
            Case Else
                Console.WriteLine("Invalid course")
        End Select
    End Sub
End Module
