/*
 * C# Program to Get File Time using File Class
 */
using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileInfo info = new FileInfo("C:\\srip.txt");
        DateTime time = info.CreationTime;
        Console.WriteLine("File was Created at : ");
        Console.Write(time);
        Console.Read();
    }
}

/*
File was Created at :
9/30/2013 12:15:44 PM