/*
 * C# Program to Read Data from Stream and Cast Data to Chars
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
                    Console.Write("{0} ", (char)read);
                }
            Console.ReadLine();
        }
    }
}

/*
G O O D M O R N I N G