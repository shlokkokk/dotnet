using System;
class Program { delegate void MyDelegate(); static void Message(){ Console.WriteLine("Hello from delegate"); } static void Main(){ MyDelegate d=Message; d(); Console.ReadKey(); } }

/* THEORY / VIVA NOTES
1. A delegate is a type-safe reference to a method.
2. Its signature must match the method it references.
3. It is declared with the delegate keyword.
4. Calling the delegate invokes the referenced method.
5. Delegates are useful for callbacks and are commonly used in event handling.
*/
