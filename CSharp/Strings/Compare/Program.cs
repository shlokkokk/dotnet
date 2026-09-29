using System;

class Program
{
    static void Main()
    {
        string a = "This is test";
        string b = "This is text";

        Console.WriteLine(string.Equals(a, b)
            ? "Strings are equal."
            : "Strings are not equal.");
    }
}
