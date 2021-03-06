/*
 * C# Program to Search an Element in an Array
 */
using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] array1 = { "cat", "dogs", "donkey", "camel" };
        string v1 = Array.Find(array1,
                               element => element.StartsWith("cam", StringComparison.Ordinal));
        string v2 = Array.Find(array1,
                               element => element.Length == 3);
        Console.WriteLine("The Elemnt that Starts with 'Cam' is : " +v1);
        Console.WriteLine("3 Letter word in the Array is : " +v2);
        Console.ReadLine();
    }
}

/*
The Element that Starts With 'Cam' is : Camel
3 Letter Word in the Array is : cat