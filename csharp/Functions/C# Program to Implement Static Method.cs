/*
 * C# Program to Implement Static Method
 */
using System;
class Program
{
    static void stamethod()
    {
        Console.WriteLine("Static Method");
    }
    void MethodB()
    {
        Console.WriteLine("Instance Method");
    }
    static char stamethod2()
    {
        Console.WriteLine("Static Method");
        return 'C';
    }
    static void Main()
    {
        Program.stamethod();
        Console.WriteLine(Program.stamethod2());
        Program programInstance = new Program();
        programInstance.MethodB();
        Console.Read();
    }
}

/*

Static Method
Static Method
C
Instance Method