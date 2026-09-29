using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter day number: ");
        int d = Convert.ToInt32(Console.ReadLine());

        switch (d)
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            default: Console.WriteLine("Other/Invalid"); break;
        }
    }
}
