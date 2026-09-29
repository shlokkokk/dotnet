using System;

class Program
{
    static void Main()
    {
        int[,] a = { { 11, 22 }, { 33, 44 } };

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
                Console.Write(a[i, j] + " ");
            Console.WriteLine();
        }

        Console.WriteLine($"Rank = {a.Rank}");
    }
}
