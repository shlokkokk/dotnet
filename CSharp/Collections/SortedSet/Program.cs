using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var set = new SortedSet<string> { "Rahul", "Aman", "Yukti", "Sohel", "Jay", "Aman" };

        Console.WriteLine("Sorted:");
        foreach (string x in set) Console.WriteLine(x);

        Console.Write("Delete name: ");
        set.Remove(Console.ReadLine());

        Console.WriteLine("After deletion:");
        foreach (string x in set) Console.WriteLine(x);
    }
}
