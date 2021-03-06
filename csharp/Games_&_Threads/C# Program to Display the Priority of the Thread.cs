/*
 *  C# Program to Display the Priority of the Thread
 */
using System;
using System.Threading;

namespace threading
{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**********Current Thread Informations***************n");
        Thread t = Thread.CurrentThread;
        t.Name = "Primary_Thread";
        Console.WriteLine("Thread Name: {0}", t.Name);
        Console.WriteLine("Thread Status: {0}", t.IsAlive);
        Console.WriteLine("Priority: {0}", t.Priority);
        Console.ReadKey();
    }

}
}
/*

Thread Name: PrimaryThread
Thread Status: True
Priority: Normal