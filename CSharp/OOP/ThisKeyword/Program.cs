using System;

class Student
{
    int id;
    string name;

    public Student(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public void Display() => Console.WriteLine($"{id} {name}");
}

class Program
{
    static void Main()
    {
        new Student(1, "Shlok").Display();
    }
}
