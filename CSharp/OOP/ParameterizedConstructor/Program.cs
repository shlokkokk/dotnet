using System;

class Student
{
    public Student(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program
{
    static void Main()
    {
        _ = new Student("Shlok", 18);
    }
}
