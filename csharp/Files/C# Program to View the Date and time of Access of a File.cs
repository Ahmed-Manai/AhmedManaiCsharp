/*
 * C# Program to View the Date and time of Access of a File
 */
using System;
using System.IO;
class Program
{
    static void Main()
    {
        FileInfo info = new FileInfo("C:\\sri\\srip.txt");
        DateTime time = info.CreationTime;
        Console.WriteLine("File Creation Time     : {0}", time);
        time = info.LastAccessTime;
        Console.WriteLine("File Last Access Time  : {0}", time);
        time = info.LastWriteTime;
        Console.WriteLine("File Last Write Time   : {0} ", time);
        Console.Read();
    }
}
/*
File Creation Time   : 8/11/2013 7:17:20 PM
File Access Time     : 8/15/2013 1:08:45 PM
File Last Write Time : 8/15/2013 1:37:36 PM