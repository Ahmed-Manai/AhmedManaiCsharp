/*
 * C# Program to Randomly Generate Strings
 */
using System;
using System.IO;
static class Random
{
    public static string GetRandomString()
    {
        string path = Path.GetRandomFileName();
        path = path.Replace(".", "");
        return path;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine(Random.GetRandomString());
        Console.WriteLine(Random.GetRandomString());
        Console.WriteLine(Random.GetRandomString());
        Console.Read();
    }
}
/*
g4jgtjvbs7hbf
jtwoj782hggjsi
3jbws63k