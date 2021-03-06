/*
 * C# Program to Illustrate Predicate
 */
using System;

class Program
{
    static void Main()
    {
        Predicate<int> predicate = checkval => checkval == 6;
        Console.WriteLine(predicate.Invoke(4));
        Console.WriteLine(predicate.Invoke(5));
        Console.WriteLine(predicate.Invoke(6));
        Console.Read();
    }
}