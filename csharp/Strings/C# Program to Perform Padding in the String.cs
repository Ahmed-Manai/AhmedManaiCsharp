/*
 * C# Program to Perform Padding in the String
 */
using System;
namespace padd
{
class Program
{
    static void Main(string[] args)
    {
        string myString = "CSHARP";
        string newString;
        System.Console.WriteLine("String Before Padding : ");
        System.Console.WriteLine(myString);
        System.Console.WriteLine("String After Padding : ");
        newString = myString.PadLeft(10, ' ');
        newString = newString.PadRight(20, '*');
        System.Console.Write("[" + newString + "]");
        Console.Read();
    }
}
}

/*
String Before Padding :
CSHARP
String After Padding :
[         CSHARP**********]