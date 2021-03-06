/*
 * C# Program to Assign Name to Thread by using Name Property
 */
using System;
using System.Threading;
class Name
{
    static void Main()
    {
        if (Thread.CurrentThread.Name == null)
            {
                Thread.CurrentThread.Name = "Main";
                Console.Write("Thread has been Named ");
            }
        else
            {
                Console.WriteLine("Unable to name a previously " +
                                  "named thread.");
            }
        Console.ReadLine();
    }
}
/*

Thread has been Named