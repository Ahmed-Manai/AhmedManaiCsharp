/*
 *  C# Program to Demonstrate Lock in Thread
 */

using System;
using System.Threading;

class Program
{
    static readonly object _object = new object();

    static void TEST()
    {
        lock (_object)
        {
            Thread.Sleep(100);
            Console.WriteLine(Environment.TickCount);
        }
    }
    static void Main()
    {
        for (int i = 0; i < 10; i++)
            {
                ThreadStart start = new ThreadStart(TEST);
                new Thread(start).Start();
            }
    }
}
/*

900500
900593
900687
900796
900890
900999
901092
901186
901295
901389