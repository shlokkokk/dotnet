using System;

class Demo
{
    ~Demo()
    {
        Console.WriteLine("Finalizer called");
    }
}

class Program
{
    static void Main()
    {
        var d = new Demo();
        d = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
