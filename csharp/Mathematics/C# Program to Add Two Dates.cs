/*
 * C# Program to Add Two Dates
 */
using System;
namespace DateAndTime
{
class Program
{
    static int Main()
    {
        DateTime SDate = new DateTime(2010, 10, 7);
        Console.WriteLine("Starting Date : {0}", SDate);
        DateTime EDate = startDate.AddDays(10);
        Console.WriteLine("Ending Date   : {0}\n", EDate);
        Console.ReadLine();
        return 0;
    }
}
}

/*

Starting Date : 10/7/2010  12:00:00 AM
Ending Date   : 10/17/2010 12:00:00 AM