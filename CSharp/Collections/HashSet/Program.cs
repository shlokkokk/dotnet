using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var set = new HashSet<string> { "Aman", "Jay", "Aman", "Riya" };

        foreach (string x in set) Console.WriteLine(x);
    }
}
