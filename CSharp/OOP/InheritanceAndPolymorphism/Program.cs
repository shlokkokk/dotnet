using System;

class Animal
{
    public virtual void Sound() => Console.WriteLine("Animal sound");
}

class Dog : Animal
{
    public override void Sound() => Console.WriteLine("Dog barks");
}

class Program
{
    static void Main()
    {
        // Exp 10: Implementation of inheritance and polymorphism.
        Animal a = new Dog();
        a.Sound();
    }
}
