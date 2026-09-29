using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "A Thousand Splendid Suns";
        foreach (Match m in Regex.Matches(text, @"\bS\w*"))
            Console.WriteLine(m.Value);
    }
}
