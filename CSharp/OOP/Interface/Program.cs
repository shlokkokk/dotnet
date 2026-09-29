using System;

interface IDrawable
{
    void Draw();
}

class Circle : IDrawable
{
    public void Draw() => Console.WriteLine("Drawing circle");
}

class Program
{
    static void Main()
    {
        IDrawable d = new Circle();
        d.Draw();
    }
}
