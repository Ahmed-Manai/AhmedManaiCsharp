/*
 * C# Program to List the Files in a Directory
 */
using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] array1 = Directory.GetFiles(@"D:\");
                                             Console.WriteLine("Files in the Directory");
                                             foreach (string name in array1)
        {
            Console.WriteLine(name);
            }
        Console.Read();
    }
}

/*
Files in the Directory
D:\demo1.cs
D:\demo1.exe
D:\msdia80.dll
D:\demo1.txt