using System;

class Program
{
    static void Main()
    {
        string text = "This is a test";

        Console.WriteLine(text.Contains("test")
            ? "The sequence was found."
            : "The sequence was not found.");
    }
}
