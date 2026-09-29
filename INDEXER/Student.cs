using System;
class Student { private string[] names=new string[3]; public string this[int index] { get{return names[index];} set{names[index]=value;} } }
class Program { static void Main(){ var s=new Student(); s[0]="Amit"; s[1]="Riya"; s[2]="Raj"; Console.WriteLine(s[1]); Console.ReadKey(); } }

/* THEORY / VIVA NOTES
1. An indexer allows an object to be accessed using array-like syntax.
2. It uses the this keyword with an index parameter in square brackets.
3. get returns a value and set assigns a value.
4. Indexers are useful when a class internally manages a collection.
5. Here s[0], s[1] and s[2] access the internal names array through the object.
*/
