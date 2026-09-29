using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Hello    World   from   C#";
        string result = Regex.Replace(text, @"\s+", " ").Trim();

        Console.WriteLine(result);
    }
}
