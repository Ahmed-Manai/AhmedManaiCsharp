/*
 * C# Program to Demonstrate Use of Clone
 */
using System;
class Program
{
    static void Main()
    {
        string[] names = { "San", "Csharp", "Linux" };
        string[] clonenames = names.Clone() as string[];
        Console.WriteLine(string.Join(",", names));
        Console.WriteLine(string.Join(",", clonenames));
        Console.WriteLine();
        clonenames[0] = "SanFoundry";
        Console.WriteLine(string.Join(",", names));
        Console.WriteLine(string.Join(",", clonenames));
        Console.Read();
    }
}