/*
 *  C# Program to Demonstrate Environment Type
using System;
class Program
{
    static void Main()
    {
        try
        {
            Environment.Exit(0);
        }
        finally
        {
            Console.WriteLine("Statement that is Never Reached");
        }
        Console.Read();
    }
}

/*
// No Output is obtained
// Calls the Environment.Exit method and returns a zero status code.
// The finally statement is never reached.