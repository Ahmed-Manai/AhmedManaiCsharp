/*
 * C# Program to Trim the Given String
 */
using System;
namespace trim
{
class Program
{
    static void Main(string[] args)
    {
        string myString = "    CSHARP      ";
        System.Console.WriteLine("The String Before Trimming : (" + myString + ")");
        System.Console.WriteLine("The String After Trimming : (" + myString.Trim() + ")");
        Console.Read();
    }
}
}

/*
The String Before Trimming : (     CSHARP    )
The String After Trimming : (CSHARP)