using System;

class Student
{
    public string Name;
    public void Display() => Console.WriteLine("Name: " + Name);
}

class Program
{
    static void Main()
    {
        Student s = new Student { Name = "Shlok" };
        s.Display();
    }
}
