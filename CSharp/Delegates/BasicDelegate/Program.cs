using System;

delegate int Operation(int a, int b);

class Program
{
    static int Add(int a, int b) => a + b;
    static int Multiply(int a, int b) => a * b;

    static void Main()
    {
        Operation op = Add;
        Console.WriteLine("Add = " + op(10, 5));

        op = Multiply;
        Console.WriteLine("Multiply = " + op(10, 5));
    }
}
