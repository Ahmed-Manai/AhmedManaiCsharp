/*
 *  C# Program to Get Content from a File and Read the Content 1 Byte at a Time
 */
using System;
using System.IO;
public sealed class Program
{
    public static void Main()
    {
        using (Stream s = new FileStream(@"c:\sri\srip.txt", FileMode.Open))
        {
            int read;
            while ((read = s.ReadByte()) != -1)
                {
                    Console.Write("{0} ", read);
                }
            Console.ReadLine();
        }
    }
}

/*
71 79 79 68 77 79 82 78 73 78 71