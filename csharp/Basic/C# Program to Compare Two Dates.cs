/*
 * C# Program to Campare Two Dates
 */
using System;
namespace DateAndTime
{
class Program
{
    static int Main()
    {
        DateTime sd = new DateTime(2010, 10, 12);
        Console.WriteLine("Starting Date : {0}", sd);
        DateTime ed = sd.AddDays(10);
        Console.WriteLine("Ending Date   : {0}", ed);
        if (sd < ed)
            Console.WriteLine("{0} Occurs Before {1}", sd, ed);
        Console.Read();
        return 0;
    }
}
}

/*
Starting Date : 10/11/2010  12:00:00 AM
Ending Date   : 10/21/2010  12:00:00 AM
10/11/2010 12:00:00 Am Occurs Before 10/21/2010 12:00:00 AM