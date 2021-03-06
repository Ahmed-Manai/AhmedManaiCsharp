/*
 * C# Program to Create Anonymous Method
 */
using System;
delegate void Print(string s);
class TestClass
{
    static void Main()
    {
        Print obj = delegate(string j)
        {
            System.Console.WriteLine(j);
        };
        obj("Delegate Using the Anonymous Method");
        obj = new Print(TestClass.named);
        obj("Delegate Using the Named Method");
        Console.Read();
    }
    static void named(string k)
    {
        System.Console.WriteLine(k);
    }

}

/*

Delegate Using the Anonymous Method
Delegate Using the Named Method