Imports System.Collections

Module Program
    Sub Main()
        Dim list As New ArrayList()
        list.AddRange(New Object() {50, 55, 10, 70, 10, 40, 13})

        Console.WriteLine("Items:")
        For Each x In list : Console.Write(x & " ") : Next

        Console.WriteLine(vbCrLf & $"Count = {list.Count}")
        list.Sort()
        Console.WriteLine("Sorted: " & String.Join(" ", list.ToArray()))

        list.Remove(13)
        list.RemoveAt(0)
        Console.WriteLine("After Remove/RemoveAt: " & String.Join(" ", list.ToArray()))
        Console.WriteLine($"Contains 10 = {list.Contains(10)}")
    End Sub
End Module
