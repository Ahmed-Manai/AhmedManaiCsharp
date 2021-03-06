/*
 * C# Program to Use StreamReader to Read Entire Line
 */
using System;
using System.IO;
using System.IO.Compression;
using System.Text;
public sealed class Program
{
    public static void Main()
    {
        Stream s = new FileStream(@"c:\sri\srip.txt", FileMode.Open);
        using (StreamReader sr = new StreamReader(s, Encoding.UTF8))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            Console.ReadLine();
        }
    }
}

/*
StreamWriter writes text files. It enables easy and efficient text output. It is best placed in a using-statement to ensure it is removed from memory when no longer needed. It provides several constructors and many methods.