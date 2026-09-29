using System;

class Program
{
    static void Main()
    {
        Console.Write("Marks: ");
        int m = Convert.ToInt32(Console.ReadLine());

        if (m >= 90) Console.WriteLine("A");
        else if (m >= 75) Console.WriteLine("B");
        else if (m >= 50) Console.WriteLine("C");
        else Console.WriteLine("Fail");
    }
}
