/*
 * C# Program to Print the Sum of all the Multiples of 3 and 5
 */
using System;
using System.IO;
class Program
{
    static void Main()
    {
        File.Copy("sri.txt", "srip.txt");
        Console.WriteLine(File.ReadAllText("sri.txt"));
        Console.WriteLine(File.ReadAllText("srip.txt"));
        Console.Read();
    }
}

/*
Contents of File S
Contents of File S