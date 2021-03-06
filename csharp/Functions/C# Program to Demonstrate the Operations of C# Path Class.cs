/*
 * C# Program to Demonstrate the Operations of C# Path Class
 */
using System;
using System.IO;
class Test
{
    public static void Main()
    {
        string p = @"c:\srip\sri.txt";
        string p2 = @"c:\srip\sri";
        string p3 = @"srip";
        if (Path.HasExtension(p))
            {
                Console.WriteLine("{0} has an extension.", p);
            }
        if (!Path.HasExtension(p2))
            {
                Console.WriteLine("{0} has no extension.", p2);
            }
        if (!Path.IsPathRooted(p3))
            {
                Console.WriteLine("The string {0} contains no root information.", p3);
            }
        Console.WriteLine("Location for Temporary Files : {0}", Path.GetTempPath());
        Console.WriteLine("Full path of {0} is {1}.", p3, Path.GetFullPath(p3));
        Console.WriteLine("File available for Use : {0} ", Path.GetTempFileName());
        Console.Read();
    }
}

/*
c:\srip\sri.txt has an extension.
c:\srip\sri has no extension.
The string srip contains no root information.
Location For Temporary Files : C:\Users\Win7\appdata\local\temp\
Full Path of Temp : D:\sri\ConsoleApplication22\ConsoleApplication22\bin\Debug\srip.
File Available for Use : C:\Users\Win7\appdata\local\temp\trmpEB1B.tmp