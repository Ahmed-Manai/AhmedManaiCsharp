/*
 * C# Program to Search Directories and List Files
 */
using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] Dirfile = Directory.GetFiles("C:\\sri\\","*.*",SearchOption.AllDirectories);
        foreach (string file in Dirfile)
            {
                Console.WriteLine(file);
            }
        Console.Read();
    }
}

/*
The List of Files in the Directory are :
C:\sri\message.txt
C:\sri\srip.txt
C:\sri\test.txt