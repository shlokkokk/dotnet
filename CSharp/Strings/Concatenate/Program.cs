using System;

class Program
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";

        Console.WriteLine(first + " " + second);
        Console.WriteLine(string.Concat(first, " ", second));
    }
}
