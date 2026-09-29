using System;
class Animal { public virtual void Sound(){ Console.WriteLine("Animal sound"); } }
class Dog:Animal { public override void Sound(){ Console.WriteLine("Dog barks"); } }
class Program { static void Main(){ Animal a=new Dog(); a.Sound(); Console.ReadKey(); } }

/* THEORY / VIVA NOTES
1. Overriding lets a derived class provide a new implementation of a base-class method.
2. The base method is commonly virtual and the derived method uses override.
3. The method signature must remain compatible.
4. It provides runtime polymorphism.
5. A base reference can refer to a derived object; the overridden method is chosen at runtime.
*/
