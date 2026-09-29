using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
    }
}
