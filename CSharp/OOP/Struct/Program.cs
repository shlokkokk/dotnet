using System;

struct Book
{
    public string Title;
    public int Id;

    public Book(string title, int id)
    {
        Title = title;
        Id = id;
    }

    public void Display() => Console.WriteLine($"{Id} - {Title}");
}

class Program
{
    static void Main()
    {
        new Book("C Programming", 101).Display();
        new Book("Python", 102).Display();
    }
}
