/*
 * C# Program to Check the Existence of a File
 */
using System;
using System.IO;
class Program
{
    static void Main()
    {
        FileInfo info = new FileInfo("C:\\sri\\srip.txt");
        bool exists = info.Exists;
        if (exists == true)
            {
                Console.WriteLine("The File Exists");
            }
        else
            {
                Console.WriteLine("No Such File Found");
            }
        Console.Read();
    }
}

/*
File Exists