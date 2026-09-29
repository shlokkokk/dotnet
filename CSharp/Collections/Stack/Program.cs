using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Top: " + stack.Pop());
        foreach (int x in stack) Console.WriteLine(x);
    }
}
