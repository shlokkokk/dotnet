using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var names = new List<string> { "Shlok", "Aman", "Jay" };
        names.Add("Riya");

        foreach (string name in names)
            Console.WriteLine(name);
    }
}
