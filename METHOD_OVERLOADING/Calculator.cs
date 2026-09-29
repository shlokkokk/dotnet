using System;
class Calculator { public int Add(int a,int b)=>a+b; public int Add(int a,int b,int c)=>a+b+c; public double Add(double a,double b)=>a+b; }
class Program { static void Main(){ var c=new Calculator(); Console.WriteLine(c.Add(10,20)); Console.WriteLine(c.Add(10,20,30)); Console.WriteLine(c.Add(2.5,3.5)); Console.ReadKey(); } }

/* THEORY / VIVA NOTES
1. Method overloading means using the same method name with different parameter lists.
2. The difference can be number, type or order of parameters.
3. Return type alone cannot create an overload.
4. The compiler selects the matching method from the supplied arguments.
5. It is compile-time polymorphism and improves readability.
*/
