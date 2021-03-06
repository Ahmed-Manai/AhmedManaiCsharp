/*
 * C# Program to Use Delegate to Call 2 Methods within which First method Prints to Console and Second Method Prints to File
 */
using System;
using System.IO;
namespace Program
{
class PrintString
{
    static FileStream fs;
    static StreamWriter sw;
    public delegate void printString(string s);
    public static void Screen(string str)
    {
        Console.WriteLine("The String is: {0}", str);
    }
    public static void File(string s)
    {
        fs = new FileStream("c:\\sri\\Message.txt",
                            FileMode.Append, FileAccess.Write);
        sw = new StreamWriter(fs);
        sw.WriteLine(s);
        sw.Flush();
        sw.Close();
        fs.Close();
    }
    public static void sendString(printString ps)
    {
        ps("C# Program to Use Delegate to Call 2 Methods within which First method Prints to Console and Second Method Prints to File");
    }
    static void Main(string[] args)
    {
        printString ps1 = new printString(Screen);
        printString ps2 = new printString(File);
        sendString(ps1);
        sendString(ps2);
        Console.ReadKey();
    }
}
}
/*

The String is : C# Program to Use Delegate to Call 2 Methods within which First method Prints to Console and Second Method Prints to File