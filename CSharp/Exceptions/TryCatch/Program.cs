using System;

class Program
{
    static void Main()
    {
        try
        {
            int x = 10 / 0;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}
