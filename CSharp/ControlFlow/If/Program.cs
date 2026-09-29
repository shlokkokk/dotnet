using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
            Console.WriteLine("Positive");
    }
}
