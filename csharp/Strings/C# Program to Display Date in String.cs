/*
 * C# Program to Display Date in String
 */
using System;
namespace DateAndTime
{
class Program
{
    static int Main()
    {
        DateTime date = new DateTime(2013,6, 23);
        string strDate = date.ToString("M");
        Console.WriteLine("Date and Time  :  {0}", date);
        Console.WriteLine("Month and Date :  {0}", strDate);
        Console.Read();
        return 0;
    }
}
}

/*
Date and Time  : 6/23/2013 12:00:00 AM
Month and Date : June 23