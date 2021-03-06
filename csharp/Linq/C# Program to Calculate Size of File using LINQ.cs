/*
 * C# Program to Calculate Size of File using LINQ
 */
using System;
using System.Linq;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string[] dirfiles = Directory.GetFiles("c:\\sri\\");
        var avg = dirfiles.Select(file =>new FileInfo(file).Length).Average();
        avg = Math.Round(avg / 10, 1);
        Console.WriteLine("The Average file size is {0} MB",avg);
        Console.ReadLine();
    }
}

/*
The Average file size is 8.8 MB