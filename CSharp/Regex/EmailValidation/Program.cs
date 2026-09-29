using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Email: ");
        string email = Console.ReadLine();

        bool valid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        Console.WriteLine(valid ? "Valid email" : "Invalid email");
    }
}
