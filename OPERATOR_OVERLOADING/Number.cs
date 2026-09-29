using System;
class Number { public int Value; public Number(int v) => Value=v; public static Number operator +(Number a, Number b) => new Number(a.Value+b.Value); public override string ToString()=>Value.ToString(); }
class Program { static void Main(){ Number a=new Number(10), b=new Number(20); Console.WriteLine("Sum = "+(a+b)); Console.ReadKey(); } }

/* THEORY / VIVA NOTES
1. Operator overloading gives a user-defined meaning to an operator for a class/struct.
2. It is a form of compile-time polymorphism.
3. The operator keyword is used to declare an overloaded operator.
4. Operator methods are normally static and use a compatible parameter/return type.
5. Here + combines the Value of two Number objects and returns a new Number.
6. It makes natural operations on user-defined types easier to read.
*/
