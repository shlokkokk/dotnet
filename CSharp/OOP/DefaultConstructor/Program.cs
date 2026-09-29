using System;

class Student
{
    public Student()
    {
        Console.WriteLine("Default constructor called");
    }
}

class Program
{
    static void Main()
    {
        _ = new Student();
    }
}
