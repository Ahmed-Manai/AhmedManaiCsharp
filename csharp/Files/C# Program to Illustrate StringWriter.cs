/*
 * C# Program to Illustrate StringWriter
 */
using System;
using System.IO;
using System.Text;
public class stringwrt
{
    StringBuilder sb = new StringBuilder();
    public stringwrt()
    {
        Writer();
    }
    public static void Main()
    {
        stringwrt srw = new stringwrt();
    }
    private void Writer()
    {
        StringWriter sw = new StringWriter(sb);
        Console.WriteLine("STUDENT DETAILS : ");
        Console.Write("Name :");
        string name = Console.ReadLine();
        sw.WriteLine("Name :" + name);
        Console.Write("Department :");
        string Department = Console.ReadLine();
        sw.WriteLine("Department :" + Department);
        Console.Write("College Name :");
        string CollegeName = Console.ReadLine();
        sw.WriteLine("College Name :" + CollegeName);
        Console.WriteLine("Information Saved!");
        Console.WriteLine();
        sw.Flush();
        sw.Close();
        Console.ReadLine();
    }
}

/*
STUDENT DETAILS :
Name : BOB
Department : IT
College Name : NIIT
Information Saved!