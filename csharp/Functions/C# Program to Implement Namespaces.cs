/*
 * C# Program to Implement Namespaces
 */
using System;
namespace Sanfoundry.Csharp.Codes
{
class TestClass
{
    public TestClass()
    {
        Console.WriteLine("Class to Demonstrate Namespace");
    }
}
}
class MyClient
{
    public static void Main()
    {
        Sanfoundry.Csharp.Codes.TestClass mc = new Sanfoundry.Csharp.Codes.TestClass();
        Console.ReadLine();
    }
}

/*
Class to Demonstrate Namespace