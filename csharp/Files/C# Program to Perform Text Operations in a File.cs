/*
 * C# Program to Perform Text Operations in a File
 */
using System;
using System.IO;
class Program
{
    static void Main()
    {
        FileInfo finfo = new FileInfo("C:\\sri\\srip.txt");
        using (StreamWriter writer = finfo.AppendText())
        {
            writer.WriteLine("New File with various Text operations");
        }
        finfo = new FileInfo("C:\\sri\\srip.txt");
        using (StreamWriter writer = finfo.CreateText())
        {
            writer.WriteLine("New File with various Text operations");
        }
        using (StreamReader reader = finfo.OpenText())
        {
            Console.WriteLine(reader.ReadToEnd());
        }
        Console.Read();
    }
}

/*
New File with various Text operations