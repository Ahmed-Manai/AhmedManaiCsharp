/*
 * C# Program to Create a Directory
 */
using System;
using System.IO;
class program
{
    public static void Main()
    {
        Directory.CreateDirectory("C:\\NewDirectory");
        Console.WriteLine("NewDirectory is Created in C Directory");
        Console.ReadLine();
    }
}

/*
NewDirectory is Created in C Directory