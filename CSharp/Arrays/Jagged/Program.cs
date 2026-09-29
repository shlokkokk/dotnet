using System;

class Program
{
    static void Main()
    {
        int[][] a =
        {
            new[] { 11, 22, 33 },
            new[] { 44, 55 },
            new[] { 66, 77, 88, 99 }
        };

        foreach (int[] row in a)
            Console.WriteLine(string.Join(" ", row));
    }
}
